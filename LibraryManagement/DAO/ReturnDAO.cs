using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class ReturnDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from PHIEUTRA";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithReturnID(String returnid)
        {
            string sql = String.Format("select * from phieutra where maphieutra = '{0}'", returnid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithReaderID(String readerid)
        {
            string sql = String.Format("select * from phieutra where madocgia = '{0}'", readerid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithBookID(String bookid)
        {
            string sql = String.Format("select * from phieutra where masach = '{0}'", bookid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static int insert(ReturnDTO returns)
        {
            string sql = string.Format("insert into phieutra values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')",
                returns.Returnid, returns.Readerid, returns.Bookid, returns.RtnDate, returns.Forfeit);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int delete(string returnid)
        {
            string sql = string.Format("delete from phieutra where maphieutra = '{0}'", returnid);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int update(ReturnDTO returns)
        {
            string sql = string.Format("update phieutra set madocgia = '{0}', masach = '{1}', ngaymuon = '{2}', tienphat = '{3}' where maphieumuon = '{4}'",
                returns.Readerid, returns.Bookid, returns.RtnDate, returns.Forfeit, returns.Returnid);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }
    }
}
