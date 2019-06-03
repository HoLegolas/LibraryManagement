using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BUS
{
    class BorrowBUS
    {
        public DataTable readAll()
        {
            return BorrowDAO.readAll();
        }

        public DataTable findWithBorrowID(String borrowid)
        {
            return BorrowDAO.findWithBookID(borrowid);
        }

        public  DataTable findWithReaderID(String readerid)
        {
            return BorrowDAO.findWithReaderID(readerid);
        }

        public  DataTable findWithBookID(String bookid)
        {
            return BorrowDAO.findWithBookID(bookid);
        }

        public  int insert(BorrowDTO borrow)
        {
            return BorrowDAO.insert(borrow);
        }

        public  int delete(string borrowid)
        {
            return BorrowDAO.delete(borrowid);
        }

        public  int update(BorrowDTO borrow)
        {
            return BorrowDAO.update(borrow);
        }
    }
}
