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

        public static DataTable readWithCatID(int CatID)
        {
            string sql = String.Format("select * from SACH where LOAI={0}",CatID);
            var result = ProcessData.ExcuteQuery(sql);

            return result;

        }

        public static DataTable findWithName(String Name)
        {
            string sql = String.Format("select * from SACH where TENSACH LIKE N'%{0}%'", Name);
            var result = ProcessData.ExcuteQuery(sql);

            return result;

        }
    }
}
