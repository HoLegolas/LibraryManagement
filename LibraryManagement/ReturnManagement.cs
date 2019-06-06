using LibraryManagement.BUS;
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
    public partial class ReturnManagement : Form
    {
        ReturnBUS returnBUS = new ReturnBUS();
        public string librarianid;
        public ReturnManagement()
        {
            InitializeComponent();
        }

        private void ReturnManagement_Load(object sender, EventArgs e)
        {
            lblibrarian.Text = librarianid;
            gvReturns.DataSource = returnBUS.readAll();
        }
    }
}
