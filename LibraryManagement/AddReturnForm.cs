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
    public partial class AddReturnForm : Form
    { 

        public delegate void Return(ReturnDTO returns);
        public event Return AddReturn = null;
        public event Return UpdateReturn = null;

        public bool update = false;
        public ReturnDTO returns;
        public AddReturnForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddReturnForm_Load(object sender, EventArgs e)
        {
            borrowDate.Value = DateTime.Now;
            if (update)
            {
                txtBorrowid.Text = returns.Returnid;
                txtReaderid.Text = returns.Readerid;
                txtBookid.Text = returns.Bookid;
                borrowDate.Value = returns.RtnDate;
                borrowDate.Enabled = true;
               
                textBox1.Text = returns.Forfeit.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ReturnDTO GetReturnInfo()
        {
            ReturnDTO re = new ReturnDTO();
            re.Returnid = txtBorrowid.Text;
            re.Readerid = txtReaderid.Text;
            re.Bookid = txtBookid.Text;
            re.RtnDate = borrowDate.Value;
            re.Forfeit = float.Parse(textBox1.Text);
            return re;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReturnDTO returnInfo = GetReturnInfo();

            if (AddReturn != null)
            {
                AddReturn(returnInfo);
            }

            if (UpdateReturn != null)
            {
                UpdateReturn(returnInfo);
            }

            this.Close();
        }
    }
}
