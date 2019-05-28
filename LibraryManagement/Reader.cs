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

namespace LibraryManagement
{
    public partial class Reader : Form
    {
        public String Name = "";
        public int id;
        public Reader(string name)
        {
            InitializeComponent();
            Name = name;
            loadSach();
        }

        private void loadSach()
        {
            SachBUS sachBus = new SachBUS();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            sachView.Columns.Add(imageColumn);
            sachView.DataSource = sachBus.readAll();

       
            readerName.Text = Name;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
