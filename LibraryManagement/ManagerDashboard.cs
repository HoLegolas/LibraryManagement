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
    public partial class ManagerDashboard : Form
    {
        AdministratorBUS adminBUS = new AdministratorBUS();
        public String manv = "";
        public int pos;

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            apos.Text = adminBUS.getPosition(pos);
            aname.Text = manv;

            staffGridView.DataSource = adminBUS.readAll();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addAdminForm = new AddAdministratorForm();
            addAdminForm.NVLapThe = manv;
            addAdminForm.AddAdmin += AddAdministratorForm_AddAdmin;
            addAdminForm.ShowDialog();
        }

        private void AddAdministratorForm_AddAdmin(AdministratorDTO admin)
        {
            adminBUS.insert(admin);
            staffGridView.DataSource = adminBUS.readAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (staffGridView.SelectedRows.Count > 0)
            {
                AdministratorDTO admin = new AdministratorDTO();
                admin.MaNV = (string)staffGridView.SelectedRows[0].Cells["manv"].Value;
                admin.HoTen = (string)staffGridView.SelectedRows[0].Cells["hoten"].Value;
                admin.DiaChi = (string)staffGridView.SelectedRows[0].Cells["diachi"].Value;
                admin.DOB = (DateTime)staffGridView.SelectedRows[0].Cells["dob"].Value;
                admin.SDT = (string)staffGridView.SelectedRows[0].Cells["sdt"].Value;
                admin.CMND = (string)staffGridView.SelectedRows[0].Cells["cmnd"].Value;
                admin.Email = (string)staffGridView.SelectedRows[0].Cells["email"].Value;
                admin.NLT = (DateTime)staffGridView.SelectedRows[0].Cells["ngaylapthe"].Value;
                admin.NVLapThe = (string)staffGridView.SelectedRows[0].Cells["nvlapthe"].Value;
                admin.BangCap = (string)staffGridView.SelectedRows[0].Cells["bangcap"].Value;
                admin.ChucVu = (int)staffGridView.SelectedRows[0].Cells["chucvu"].Value;
                admin.UserName = (string)staffGridView.SelectedRows[0].Cells["username"].Value;
                admin.Password = (string)staffGridView.SelectedRows[0].Cells["password"].Value;

                var updateFrm = new AddAdministratorForm();
                updateFrm.NVLapThe = manv;
                updateFrm.update = true;
                updateFrm.admin = admin;
                updateFrm.UpdateAdmin += UpdateFrm_UpdateAdmin;
                
                updateFrm.ShowDialog();
            } else
            {
                MessageBox.Show("[!] Select a row to update\n" +
                                "[*] No rows has been selected yet or," +
                                "[*] you selected a cell only");
            }
        }

        private void UpdateFrm_UpdateAdmin(AdministratorDTO admin)
        {
            adminBUS.update(admin);
            staffGridView.DataSource = adminBUS.readAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this entry?", "DELETE", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (staffGridView.SelectedRows.Count > 0)
                {
                    string manv = (string)staffGridView.SelectedRows[0].Cells["manv"].Value;
                    adminBUS.delete(manv);
                    staffGridView.DataSource = adminBUS.readAll();
                }
            }
        }
    }
}
