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
        public String manv = "";
        public int pos;

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            AdministratorBUS adminBUS = new AdministratorBUS();
            apos.Text = adminBUS.getPosition(pos);
            aname.Text = manv;

            staffGridView.DataSource = adminBUS.readAll();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addAdminForm = new AddAdministratorForm();
            addAdminForm.NVLapThe = manv;
            addAdminForm.Add += AddAdministratorForm_AddAdmin;
            addAdminForm.ShowDialog();
        }

        private void AddAdministratorForm_AddAdmin(AdministratorDTO admin)
        {
            AdministratorBUS adminBUS = new AdministratorBUS();
            adminBUS.insert(admin);
            staffGridView.DataSource = adminBUS.readAll();
        }
    }
}
