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
        public delegate void Admin(AdministratorDTO admin);
        public event Admin AddAdmin = null;
        public event Admin UpdateAdmin = null;

        public bool update = false;
        public AdministratorDTO admin;

        public String NVLapThe = "";
         

        public AddAdministratorForm()
        {
            InitializeComponent();
           
        }

        private void AddAdministratorForm_Load(object sender, EventArgs e)
        {
            if (update)
            {
                btnAdd.Text = "UPDATE";

                idtxt.Text = admin.MaNV;
                nametxt.Text = admin.HoTen;
                addresstxt.Text = admin.DiaChi;
                dobPicker.Value = admin.DOB;
                emailtxt.Text = admin.Email;
                phonetxt.Text = admin.SDT;
                passporttxt.Text = admin.CMND;
                certificatetxt.Text = admin.BangCap;
                positionNumber.Value = admin.ChucVu;
                usernametxt.Text = admin.UserName;
                passswordtxt.Text = admin.Password;
            }
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdministratorDTO admin = GetAdminInfo();

            if (AddAdmin != null)
            {
                AddAdmin(admin);
            }
            if (UpdateAdmin != null)
            {
                UpdateAdmin(admin);
            }

            this.Close();
        }

        private AdministratorDTO GetAdminInfo()
        {
            AdministratorDTO admin = new AdministratorDTO();
            admin.MaNV = idtxt.Text;
            admin.HoTen = nametxt.Text;
            admin.DiaChi = addresstxt.Text;
            admin.SDT = phonetxt.Text;
            admin.DOB = dobPicker.Value;
            admin.Email = emailtxt.Text;
            admin.CMND = passporttxt.Text;
            admin.NLT = DateTime.Now;
            admin.NVLapThe = NVLapThe;
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

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
