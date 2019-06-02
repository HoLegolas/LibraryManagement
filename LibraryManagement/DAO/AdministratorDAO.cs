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
            string sql = string.Format("insert into banquanli values ('{0}', N'{1}', N'{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}', N'{9}', '{10}', '{11}', '{12}')",
                admin.MaNV, admin.HoTen, admin.DiaChi, admin.SDT, admin.DOB, admin.CMND, admin.Email, admin.NLT, admin.NVLapThe, admin.BangCap, admin.ChucVu, admin.UserName, admin.Password);
            var result = ProcessData.ExcuteNonQuery(sql);
        
        }

        public static String getPosition(int pos)
        {
            string sql = string.Format("select v.pos from vitri v where id = '{0}'", pos);
            var result = ProcessData.ExcuteScalar(sql);

            return (String)result;
        }

        public static void update(AdministratorDTO admin)
        {
            string sql = string.Format("update banquanli set hoten=N'{1}', diachi=N'{2}',sdt='{3}', cmnd='{5}', dob='{4}', email='{6}', ngaylapthe='{7}', nvlapthe='{8}', bangcap='N{9}', chucvu='{10}', username='{11}', password='{12}'where manv='{0}'",
                admin.MaNV, admin.HoTen, admin.DiaChi, admin.SDT, admin.DOB, admin.CMND, admin.Email, admin.NLT, admin.NVLapThe, admin.BangCap, admin.ChucVu, admin.UserName, admin.Password);
            var result = ProcessData.ExcuteNonQuery(sql);
        }

        public static void delete(string manv)
        {
            string sql = string.Format("delete from banquanli where manv ='{0}' ", manv);
            var result = ProcessData.ExcuteNonQuery(sql);
        }
    }
}
