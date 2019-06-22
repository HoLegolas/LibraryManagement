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
        public bool isSignin = false;
        public String Name = "";
        public int id;
        public Reader(string name)
        {
            InitializeComponent();
            Name = name;
            loadSach();
            if (isSignin == true)
            {
                button6.Text = "Sign out";
            }
        }

        public Reader(string name, bool isSignIn)
        {
            InitializeComponent();
            Name = name;
            loadSach();
            if (isSignIn == true)
            {
                button6.Text = "Sign out";
            }
        }

        private void loadSach()
        {

            sachView.DataSource = sachBus.readAll();

       
            readerName.Text = Name;

        }

        private void loadSachCategory(int CatID)
        {

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

            sachView.DataSource = sachBus.findWithName(txtFind.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var adrForm = new StatisticForm();
            this.Hide();
            adrForm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var adrForm = new LibraryManagement();
            this.Hide();
            adrForm.ShowDialog();
            this.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            sachView.DataSource = sachBus.readAll();
        }
    }
}
