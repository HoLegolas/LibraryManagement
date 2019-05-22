using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddAdministratorForm : Form
    {
        public delegate void AddAdmin(AdministratorDTO admin);
        public event AddAdmin Add = null;

        public String NVLapThe = "";
         

        public AddAdministratorForm()
        {
            InitializeComponent();
        }

        private void AddAdministratorForm_Load(object sender, EventArgs e)
        {

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdministratorDTO admin = GetAdminInfo();

            if (Add != null)
            {
                Add(admin);
            }

            this.Close();
        }

        private AdministratorDTO GetAdminInfo()
        {
            var utf8 = Encoding.UTF8;
            byte[] bmanv = utf8.GetBytes(NVLapThe);

            AdministratorDTO admin = new AdministratorDTO();
            admin.MaNV = idtxt.Text;
            admin.HoTen = nametxt.Text;
            admin.DiaChi = addresstxt.Text;
            admin.SDT = phonetxt.Text;
            admin.DOB = dobPicker.Value;
            admin.Email = emailtxt.Text;
            admin.CMND = passporttxt.Text;
            admin.NLT = DateTime.Now;
            admin.NVLapThe = utf8.GetString(bmanv);
            admin.BangCap = certificatetxt.Text;
            admin.ChucVu = (int)positionNumber.Value;
            admin.UserName = usernametxt.Text;
            admin.Password = passswordtxt.Text;
            return admin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
