using LibraryManagement.BUS;
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
    public partial class LibraryManagement : Form
    {
        public delegate void AdminId(String id);
        public event AdminId GetAdminId  = null;

        public LibraryManagement()
        {
            InitializeComponent();
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Enter username please!");
            }

            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Enter password please!");
            }
            else
            {
                if (readerLogin.Checked)
                {
                    MessageBox.Show("Hello Reader ^.^");
                    var reader = new Reader(txtusername.Text);
                    this.Hide();
                    reader.ShowDialog();
                    this.Close();
                }
                else
                {
                    AdministratorBUS adminBUS = new AdministratorBUS();
                    var adminInfoDataTable = adminBUS.readAll();

                    foreach (DataRow row in adminInfoDataTable.Rows)
                    { 
                        if (row["username"].ToString() == txtusername.Text &&
                            row["password"].ToString() == txtpassword.Text)
                        {
                            AdministratorDTO admin = new AdministratorDTO();
                            admin.MaNV = row["manv"].ToString();
                            admin.HoTen = row["hoten"].ToString();
                            admin.DiaChi = row["diachi"].ToString();
                            admin.SDT = row["sdt"].ToString();
                            admin.DOB = Convert.ToDateTime(row["dob"].ToString());
                            admin.CMND = row["cmnd"].ToString();
                            admin.Email = row["email"].ToString();
                            admin.NLT = Convert.ToDateTime(row["ngaylapthe"].ToString());
                            admin.NVLapThe = row["nvlapthe"].ToString();
                            admin.BangCap = row["bangcap"].ToString();
                            admin.ChucVu = Int32.Parse(row["chucvu"].ToString());
                            admin.UserName = row["username"].ToString();
                            admin.Password = row["password"].ToString();

                            MessageBox.Show("Hello Admin ^.^");

                            if (GetAdminId != null)
                            {
                                GetAdminId(admin.MaNV);
                            }

                            var managerdb = new ManagerDashboard();
                            managerdb.manv = admin.MaNV;
                            managerdb.pos = admin.ChucVu;
                            this.Hide();
                            managerdb.ShowDialog();
                            this.Close();
                        }
                    }
                    MessageBox.Show("[!] Wrong username or password typed in. Try again");
                } 
            }
            
        }
    }
}
