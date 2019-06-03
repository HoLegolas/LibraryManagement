using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class BorrowDTO
    {
        private string _borrowid;
        private string _readerid;
        private string _bookid;
        private DateTime _brwDate;
        private DateTime _rtnDate;

        public string BorrowID { get => _borrowid; set => _borrowid = value; }
        public string ReaderID { get => _readerid; set => _readerid = value; }
        public string BookID { get => _bookid; set => _bookid = value; }
        public DateTime BorrowedDate { get => _brwDate; set => _brwDate = value; }
        public DateTime ReturnDate { get => _rtnDate; set => _rtnDate = value; }
    }
}
