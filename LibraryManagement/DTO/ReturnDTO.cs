using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    class ReturnDTO
    {
        private string _returnid;
        private string _readerid;
        private string _bookid;
        private DateTime _rtnDate;
        private float _forfeit;

        public string Returnid { get => _returnid; set => _returnid = value; }
        public string Readerid { get => _readerid; set => _readerid = value; }
        public string Bookid { get => _bookid; set => _bookid = value; }
        public DateTime RtnDate { get => _rtnDate; set => _rtnDate = value; }
        public float Forfeit { get => _forfeit; set => _forfeit = value; }
    }
}
