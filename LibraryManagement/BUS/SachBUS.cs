using QLThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BUS
{
    public class SachBUS
    {
        public DataTable readAll()
        {
            return SachDAO.readAll();
        }

        public DataTable readWithCatID(int CatID)
        {
            return SachDAO.readWithCatID(CatID);
        }

        public DataTable findWithName(String Name)
        {
            return SachDAO.findWithName(Name);

        }
    }
}
