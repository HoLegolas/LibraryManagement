using QLThuVien.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class LibraryManagement : Form
    {
        public LibraryManagement()
        {
           
            InitializeComponent();
            SachBUS sachBUS = new SachBUS();
            sachDGV.DataSource = sachBUS.readAll();
        }

        private void sachDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
