using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class ReturnManagement : Form
    {
        ReturnBUS returnBUS = new ReturnBUS();
        public string librarianid;
        public ReturnManagement()
        {
            InitializeComponent();
        }

        private void ReturnManagement_Load(object sender, EventArgs e)
        {
            lblibrarian.Text = librarianid;
            gvReturns.DataSource = returnBUS.readAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addFrm = new AddReturnForm();
            addFrm.AddReturn += AddFrm_AddReturn;
            this.Hide();
            addFrm.ShowDialog();
            this.Show();
        }
        private void AddFrm_AddReturn(ReturnDTO returns)
        {
            returnBUS.insert(returns);
            gvReturns.DataSource = returnBUS.readAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvReturns.SelectedRows.Count > 0)
            {
                ReturnDTO re = new ReturnDTO();
                re.Returnid = (string)gvReturns.SelectedRows[0].Cells["maphieutra"].Value;
                re.Readerid = (string)gvReturns.SelectedRows[0].Cells["madocgia"].Value;
                re.Bookid = (string)gvReturns.SelectedRows[0].Cells["masach"].Value;
                re.RtnDate = (DateTime)gvReturns.SelectedRows[0].Cells["ngaytra"].Value;
                re.Forfeit = float.Parse(gvReturns.SelectedRows[0].Cells["tienphat"].Value.ToString());

                var addFrm = new AddReturnForm();
                addFrm.update = true;
                addFrm.returns = re;
                addFrm.AddReturn += AddFrm_AddReturn;
                this.Hide();
                addFrm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Select a row to update, pls!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvReturns.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure to delete this record?", "DELETE", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    returnBUS.delete((string)gvReturns.SelectedRows[0].Cells["maphieutra"].Value);
                    gvReturns.DataSource = returnBUS.readAll();
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete, pls!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var adrForm = new Reader("unknow");
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var adrForm = new StatisticForm();
            this.Hide();
            adrForm.ShowDialog();
            this.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            var adrForm = new Reader(librarianid);
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
        }
    }
}
