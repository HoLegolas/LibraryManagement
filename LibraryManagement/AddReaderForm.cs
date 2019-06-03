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
    public partial class AddReaderForm : Form
    {
        public delegate void Reader(ReaderDTO reader);
        public event Reader AddReader = null;
        public event Reader UpdateReader = null;

        public bool update = false;
        public ReaderDTO reader;

        public string librabrianid = "";

        public AddReaderForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReaderDTO reader = GetReaderInfo();

            if (AddReader != null)
            {
                AddReader(reader);
            }
            if (UpdateReader != null)
            {
                UpdateReader(reader);
            }

            this.Close();
        }

        private ReaderDTO GetReaderInfo()
        {
            ReaderDTO reader = new ReaderDTO();
            reader.MaNV = txtReaderID.Text;
            reader.HoTen = txtName.Text;
            reader.DiaChi = txtAdrr.Text;
            reader.SDT = txtPhone.Text;
            reader.DOB = pkrDOB.Value;
            reader.Email = txtEmail.Text;
            reader.CMND = txtPassport.Text;
            reader.NLT = DateTime.Now;
            reader.NVLapThe = librabrianid;
            reader.UserName = txtUsername.Text;
            reader.Password = txtPassword.Text;
            return reader;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddReaderForm_Load(object sender, EventArgs e)
        {
            if (update)
            {
                btnAdd.Text = "UPDATE";

                txtReaderID.Text = reader.MaNV;
                txtName.Text = reader.HoTen;
                txtAdrr.Text = reader.DiaChi;
                pkrDOB.Value = reader.DOB;
                txtEmail.Text = reader.Email;
                txtPhone.Text = reader.SDT;
                txtPassport.Text = reader.CMND;
                txtUsername.Text = reader.UserName;
                txtPassword.Text = reader.Password;
            }
        }
    }
}
