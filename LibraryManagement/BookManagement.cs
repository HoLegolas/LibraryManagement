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
    public partial class BookManagement : Form
    {
        BookBUS bookbus = new BookBUS();
        public string stockkeeperid;

        public BookManagement()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvBooks.SelectedRows.Count > 0)
            {
                string bookid = (string)gvBooks.SelectedRows[0].Cells["masach"].Value;
                var result = MessageBox.Show("Are you sure to delete this record?", "DELETE", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {
                    bookbus.delete(bookid);
                }
            } else
            {
                MessageBox.Show("No rows has been selected yet or,\nYou selected a cell.");
            }
        }

        private void gvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            if (stockkeeperid != "")
            {
                txtSKID.Text = stockkeeperid;
            } else
            {
                txtSKID.Text = "Not Available";
            }

            gvBooks.DataSource = bookbus.readAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addFrm = new AddBookForm();
            addFrm.AddBook += AddFrm_AddBook;
            addFrm.stockkeeperid = stockkeeperid;
            this.Hide();
            addFrm.ShowDialog();
            this.Show();
        }

        private void AddFrm_AddBook(BookDTO book)
        {
            bookbus.insert(book);
            gvBooks.DataSource = bookbus.readAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvBooks.SelectedRows.Count > 0)
            {
                BookDTO book = new BookDTO();
                book.BookID = (string)gvBooks.SelectedRows[0].Cells["masach"].Value;
                book.Title = (string)gvBooks.SelectedRows[0].Cells["tensach"].Value;
                book.Author = (string)gvBooks.SelectedRows[0].Cells["tacgia"].Value;
                book.PublishedYear = (string)(gvBooks.SelectedRows[0].Cells["nsx"].Value + "");
                book.Publisher = (string)gvBooks.SelectedRows[0].Cells["nxb"].Value;
                book.Receipt = (DateTime)gvBooks.SelectedRows[0].Cells["ngaynhap"].Value;
                book.Price = float.Parse(gvBooks.SelectedRows[0].Cells["gia"].Value + "");
                book.StockkeeperID = (string)gvBooks.SelectedRows[0].Cells["nvtiepnhan"].Value;
                book.Type = (int)gvBooks.SelectedRows[0].Cells["loai"].Value;

                var updateForm = new AddBookForm();
                updateForm.update = true;
                updateForm.stockkeeperid = stockkeeperid;
                updateForm.book = book;
                updateForm.UpdateBook += UpdateForm_UpdateBook;
                
                updateForm.ShowDialog();
            }
        }

        private void UpdateForm_UpdateBook(BookDTO book)
        {
            bookbus.update(book);
            gvBooks.DataSource = bookbus.readAll();
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
    }
}
