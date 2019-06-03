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
    public partial class AddBorrowForm : Form
    {
        public delegate void Borrow(BorrowDTO borrow);
        public event Borrow AddBorrow = null;
        public event Borrow UpdateBorrow = null;

        public bool update = false;
        public BorrowDTO borrow;

        public AddBorrowForm()
        {
            InitializeComponent();
        }


        private void AddBorrowForm_Load(object sender, EventArgs e)
        {
            borrowDate.Value = DateTime.Now;
            returnDate.Value = borrowDate.Value.AddDays(7);

            if (update)
            {
                txtBorrowid.Text = borrow.BorrowID;
                txtReaderid.Text = borrow.ReaderID;
                txtBookid.Text = borrow.BookID;
                borrowDate.Value = borrow.BorrowedDate;
                returnDate.Value = borrow.ReturnDate;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BorrowDTO borrowInfo = GetBorrowInfo();

            if (AddBorrow != null)
            {
                AddBorrow(borrowInfo);
            }

            if (UpdateBorrow != null)
            {
                UpdateBorrow(borrowInfo);
            }

            this.Close();
        }

        private BorrowDTO GetBorrowInfo()
        {
            BorrowDTO br = new BorrowDTO();
            br.BorrowID = txtBorrowid.Text;
            br.ReaderID = txtReaderid.Text;
            br.BookID = txtBookid.Text;
            br.BorrowedDate = borrowDate.Value;
            br.ReturnDate = returnDate.Value;
            return br;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
