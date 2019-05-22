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
    class AdministratorBUS
    {
        public DataTable readAll()
        {
            return AdministratorDAO.readAll();
        }

        public void insert(AdministratorDTO admin)
        {
            AdministratorDAO.insert(admin);
        }

        public String getPosition(int pos)
        {
            return AdministratorDAO.getPosition(pos);
        }
    }
}
