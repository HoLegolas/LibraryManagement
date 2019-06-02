using LibraryManagement.DTO;
using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddBookForm : Form
    {
        public delegate void Book(BookDTO book);
        public event Book AddBook = null;
        public event Book UpdateBook = null;

        public bool update = false;
        public BookDTO book;
        public string stockkeeperid;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
           if (update)
            {
                btnAdd.Text = "UPDATE";

                txtBookID.Text = book.BookID;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                nPublished.Value = int.Parse(book.PublishedYear);
                txtPublisher.Text = book.Publisher;
                pkrReceipt.Value = book.Receipt;
                txtPrice.Text = book.Price + "" ;
                nType.Value = book.Type;
                stockkeeperid = book.StockkeeperID;
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookDTO bookInfo = GetBookInfo();

            if (AddBook != null)
            {
                AddBook(bookInfo);
            }

            if (UpdateBook != null)
            {
                UpdateBook(bookInfo);
            }

            this.Close();
        }

        private BookDTO GetBookInfo()
        {
            BookDTO cbook = new BookDTO();

            cbook.BookID = txtBookID.Text;
            cbook.Title = txtTitle.Text;
            cbook.Author = txtAuthor.Text;
            cbook.PublishedYear = "" + nPublished.Value;
            cbook.Publisher = txtPublisher.Text;
            cbook.Receipt = pkrReceipt.Value;
            cbook.Price = float.Parse(txtPrice.Text);
            cbook.Type = (int)nType.Value;
            cbook.StockkeeperID = stockkeeperid;

            return cbook;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
