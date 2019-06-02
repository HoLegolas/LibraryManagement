using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class BookDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from SACH";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static DataTable findWithID(String id)
        {
            string sql = String.Format("select * from SACH where masach = '{0}'", id);
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static int insert(BookDTO book)
        {
            string sql = string.Format("insert into sach(masach, tensach, tacgia, nsx, nxb, ngaynhap, gia, nvtiepnhan, loai) values" +
                " ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}', '{7}', '{8}')",
                book.BookID, book.Title, book.Author, book.PublishedYear, book.Publisher, book.Receipt, book.Price, book.StockkeeperID, book.Type);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int delete(string bookid)
        {
            string sql = string.Format("delete from sach where masach = '{0}'", bookid);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }

        public static int update(BookDTO book)
        {
            string sql = string.Format("update sach set tensach = N'{1}',tacgia = N'{2}', nsx = '{3}', nxb = '{4}', ngaynhap = '{5}', " +
                "gia = '{6}', nvtiepnhan = '{7}', loai = '{8}' where masach = '{0}'", 
                book.BookID, book.Title, book.Author, book.PublishedYear, book.Publisher, book.Receipt, 
                book.Price, book.StockkeeperID, book.Type);
            var result = ProcessData.ExcuteNonQuery(sql);
            return result;
        }
    }
}
