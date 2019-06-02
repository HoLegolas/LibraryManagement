using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class BookDTO
    {
        private string _bookid;
        private string _title;
        private string _author;
        private string _published;
        private string _publisher;
        private DateTime _receipt;
        private float _price;
        private string _stockkeeperid;
        private int _type;

        public string BookID { get => _bookid; set => _bookid = value; }
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public string PublishedYear { get => _published; set => _published = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime Receipt { get => _receipt; set => _receipt = value; }
        public float Price { get => _price; set => _price = value; }
        public string StockkeeperID { get => _stockkeeperid; set => _stockkeeperid = value; }
        public int Type { get => _type; set => _type = value; }
    }
}
