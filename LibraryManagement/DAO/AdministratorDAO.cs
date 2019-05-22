using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    class AdministratorDAO
    {
        public static DataTable readAll()
        {
            string sql = "select * from banquanli";
            var result = ProcessData.ExcuteQuery(sql);

            return result;
        }

        public static void insert(AdministratorDTO admin)
        {
            string sql = string.Format("insert into banquanli values ('{0}', '{1}', '{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                admin.MaNV, admin.HoTen, admin.DiaChi, admin.SDT, admin.DOB, admin.CMND, admin.Email, admin.NLT, admin.NVLapThe, admin.BangCap, admin.ChucVu, admin.UserName, admin.Password);
            var result = ProcessData.ExcuteNonQuery(sql);
        
        }

        public static String getPosition(int pos)
        {
            string sql = string.Format("select v.pos from vitri v where id = '{0}'", pos);
            var result = ProcessData.ExcuteScalar(sql);

            return (String)result;
        }
    }
}
