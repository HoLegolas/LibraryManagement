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
        SachBUS sachBus = new SachBUS();
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
            

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            sachView.Columns.Add(imageColumn);
            sachView.DataSource = sachBus.readAll();

       
            readerName.Text = Name;

        }

        private void loadSachCategory(int CatID)
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            sachView.Columns.Add(imageColumn);

            sachView.DataSource = sachBus.readWithCatID(CatID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadSachCategory(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadSachCategory(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadSachCategory(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadSachCategory(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Image";
            sachView.Columns.Add(imageColumn);

            sachView.DataSource = sachBus.findWithName(txtFind.Text);
        }
    }
}
