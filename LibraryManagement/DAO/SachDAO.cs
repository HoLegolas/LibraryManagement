using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    class SachDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from SACH";
            var result = ProcessData.ExcuteQuery(sql);
            
            return result;
        }
    }
}
