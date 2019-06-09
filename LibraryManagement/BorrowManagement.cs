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
    public partial class BorrowManagement : Form
    {
        BorrowBUS borrowBUS = new BorrowBUS();

        public string librarianid;

        public BorrowManagement()
        {
            InitializeComponent();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            lblibrarian.Text = librarianid;
            gvBorrows.DataSource = borrowBUS.readAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addFrm = new AddBorrowForm();
            addFrm.AddBorrow += AddFrm_AddBorrow;
            this.Hide();
            addFrm.ShowDialog();
            this.Show();
        }

        private void AddFrm_AddBorrow(BorrowDTO borrow)
        {
            borrowBUS.insert(borrow);
            gvBorrows.DataSource = borrowBUS.readAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvBorrows.SelectedRows.Count > 0)
            {
                BorrowDTO br = new BorrowDTO();
                br.BorrowID = (string)gvBorrows.SelectedRows[0].Cells["maphieumuon"].Value;
                br.ReaderID = (string)gvBorrows.SelectedRows[0].Cells["madocgia"].Value;
                br.BookID = (string)gvBorrows.SelectedRows[0].Cells["masach"].Value;
                br.BorrowedDate = (DateTime)gvBorrows.SelectedRows[0].Cells["ngaymuon"].Value;
                br.ReturnDate = (DateTime)gvBorrows.SelectedRows[0].Cells["hantra"].Value;

                var addFrm = new AddBorrowForm();
                addFrm.update = true;
                addFrm.borrow = br;
                addFrm.AddBorrow += AddFrm_AddBorrow;
                this.Hide();
                addFrm.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Select a row to update, pls!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvBorrows.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure to delete this record?", "DELETE", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    borrowBUS.delete((string)gvBorrows.SelectedRows[0].Cells["maphieumuon"].Value);
                    gvBorrows.DataSource = borrowBUS.readAll();
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete, pls!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var adrForm = new LibraryManagement();
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var adrForm = new StatisticForm();
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
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
