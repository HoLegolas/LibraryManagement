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
    class ReaderBUS
    {
        public DataTable readAll()
        {
            return ReaderDAO.readAll();
        }

        public void insert(ReaderDTO reader)
        {
            ReaderDAO.insert(reader);
        }

        public void update(ReaderDTO reader)
        {
            ReaderDAO.update(reader);
        }

        public void delete(string madocgia)
        {
            ReaderDAO.delete(madocgia);
        }
    }
}
