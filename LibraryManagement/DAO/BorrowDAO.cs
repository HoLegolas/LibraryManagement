using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class BorrowDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from PHIEUMUON";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithBorrowID(String borrowid)
        {
            string sql = String.Format("select * from phieumuon where maphieumuon = '{0}'", borrowid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithReaderID(String readerid)
        {
            string sql = String.Format("select * from phieumuon where madocgia = '{0}'", readerid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithBookID(String bookid)
        {
            string sql = String.Format("select * from phieumuon where masach = '{0}'", bookid);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static int insert(BorrowDTO borrow)
        {
            string sql = string.Format("insert into phieumuon values" +
                "('{0}', '{1}', '{2}', '{3}', '{4}')",
                borrow.BorrowID, borrow.ReaderID, borrow.BookID, borrow.BorrowedDate, borrow.ReturnDate);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int delete(string borrowid)
        {
            string sql = string.Format("delete from phieumuon where maphieumuon = '{0}'", borrowid);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int update(BorrowDTO borrow)
        {
            string sql = string.Format("update phieumuon set madocgia = '{0}', masach = '{1}', ngaymuon = '{2}', hantra = '{3}' where maphieumuon = '{4}'",
                borrow.ReaderID, borrow.BookID, borrow.BorrowedDate, borrow.ReturnDate, borrow.BorrowID);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }
    }
}
