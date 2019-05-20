using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BUS
{
    class AdministratorBUS
    {
        public DataTable readAll()
        {
            return AdministratorDAO.readAll();
        }
    }
}
