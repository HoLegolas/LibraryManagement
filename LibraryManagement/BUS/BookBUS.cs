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
    class BookBUS
    {
        public DataTable readAll()
        {
            return BookDAO.readAll();
        }

   
        public DataTable findWithName(String id)
        {
            return BookDAO.findWithID(id);

        }

        public int insert(BookDTO book)
        {
            return BookDAO.insert(book);
        }

        public int delete(string bookid)
        {
            return BookDAO.delete(bookid);
        }

        public int update(BookDTO book)
        {
            return BookDAO.update(book);
        }
    }
}
