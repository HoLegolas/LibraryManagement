using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class ReaderDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from docgia";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static void insert(ReaderDTO reader)
        {
            string sql = string.Format("insert into docgia values ('{0}', N'{1}', N'{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}', N'{9}', '{10}')",
                reader.MaNV, reader.HoTen, reader.DiaChi, reader.SDT, reader.DOB, reader.CMND, reader.Email, reader.NLT, reader.NVLapThe, reader.UserName, reader.Password);
            var result = ProcessData.ExcuteNonQuery(sql);

        }


        public static void update(ReaderDTO reader)
        {
            string sql = string.Format("update docgia set hoten=N'{1}', diachi=N'{2}',sdt='{3}', cmnd='{5}', dob='{4}', email='{6}', ngaylapthe='{7}', nvlapthe='{8}', username='{9}', password='{10}' where madocgia='{0}'",
                reader.MaNV, reader.HoTen, reader.DiaChi, reader.SDT, reader.DOB, reader.CMND, reader.Email, reader.NLT, reader.NVLapThe, reader.UserName, reader.Password);
            var result = ProcessData.ExcuteNonQuery(sql);
        }

        public static void delete(string madocgia)
        {
            string sql = string.Format("delete from docgia where madocgia ='{0}' ", madocgia);
            var result = ProcessData.ExcuteNonQuery(sql);
        }
    }
}
