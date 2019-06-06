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
    class ReturnBUS
    {
        public DataTable readAll()
        {
            return ReturnDAO.readAll();
        }

        public DataTable findWithReturnID(String returnid)
        {
            return ReturnDAO.findWithBookID(returnid);
        }

        public DataTable findWithReaderID(String readerid)
        {
            return ReturnDAO.findWithReaderID(readerid);
        }

        public DataTable findWithBookID(String bookid)
        {
            return ReturnDAO.findWithBookID(bookid);
        }

        public int insert(ReturnDTO returns)
        {
            return ReturnDAO.insert(returns);
        }

        public int delete(string returnid)
        {
            return ReturnDAO.delete(returnid);
        }

        public int update(ReturnDTO borrow)
        {
            return ReturnDAO.update(borrow);
        }
    }
}
