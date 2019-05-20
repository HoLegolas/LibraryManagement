using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class AdministratorDTO
    {
        private String manv;
        private String hoten;
        private String diachi;
        private String sdt;
        private DateTime dob;
        private String cmnd;
        private String email;
        private DateTime ngaylapthe;
        private String nvlapthe;
        private String bangcap;
        private int chucvu;
        private String username;
        private String password;

        public String MaNV { get => manv; set => manv = value; }
        public String HoTen { get => hoten; set => hoten = value; }
        public String DiaChi { get => diachi; set => diachi = value; }
        public String SDT { get => sdt; set => sdt = value; }
        public DateTime DOB { get => dob; set => dob = value; }
        public String CMND { get => cmnd; set => cmnd = value; }
        public String Email { get => email; set => email = value; }
        public DateTime NLT { get => ngaylapthe; set => ngaylapthe = value; }
        public String NVLapThe { get => nvlapthe; set => nvlapthe = value; }
        public String BangCap { get => bangcap; set => bangcap = value; }
        public int ChucVu { get => chucvu; set => chucvu = value; }
        public String UserName { get => username; set => username = value; }
        public String Password { get => password; set => password = value; }
    }
}
