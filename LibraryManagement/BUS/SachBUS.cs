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
    }
}
