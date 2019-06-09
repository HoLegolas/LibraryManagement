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
    public partial class ReaderManagement : Form
    {
        ReaderBUS readerBUS = new ReaderBUS();
        public string librarianid;

        public ReaderManagement()
        {
            InitializeComponent();
        }

        private void ReaderManagement_Load(object sender, EventArgs e)
        {
            lbLibrarian.Text = librarianid;
            gvReaders.DataSource = readerBUS.readAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var readerForm = new AddReaderForm();
            readerForm.librabrianid = librarianid;
            readerForm.AddReader += ReaderForm_AddReader;
            readerForm.ShowDialog();
        }

        private void ReaderForm_AddReader(DTO.ReaderDTO reader)
        {
            readerBUS.insert(reader);
            gvReaders.DataSource = readerBUS.readAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvReaders.SelectedRows.Count > 0)
            {
                ReaderDTO reader = new ReaderDTO();
                reader.MaNV = (string)gvReaders.SelectedRows[0].Cells["madocgia"].Value;
                reader.HoTen = (string)gvReaders.SelectedRows[0].Cells["hoten"].Value;
                reader.DiaChi = (string)gvReaders.SelectedRows[0].Cells["diachi"].Value;
                reader.DOB = (DateTime)gvReaders.SelectedRows[0].Cells["dob"].Value;
                reader.SDT = (string)gvReaders.SelectedRows[0].Cells["sdt"].Value;
                reader.CMND = (string)gvReaders.SelectedRows[0].Cells["cmnd"].Value;
                reader.Email = (string)gvReaders.SelectedRows[0].Cells["email"].Value;
                reader.NLT = (DateTime)gvReaders.SelectedRows[0].Cells["ngaylapthe"].Value;
                reader.NVLapThe = (string)gvReaders.SelectedRows[0].Cells["nvlapthe"].Value;

                reader.UserName = (string)gvReaders.SelectedRows[0].Cells["username"].Value;
                reader.Password = (string)gvReaders.SelectedRows[0].Cells["password"].Value;

                var updateFrm = new AddReaderForm();
                updateFrm.librabrianid = librarianid;
                updateFrm.update = true;
                updateFrm.reader = reader;
                updateFrm.UpdateReader += UpdateFrm_UpdateReader;

                updateFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("[!] Select a row to update\n" +
                                "[*] No rows has been selected yet or," +
                                "[*] you selected a cell only");
            }
        }

        private void UpdateFrm_UpdateReader(ReaderDTO reader)
        {
            readerBUS.update(reader);
            gvReaders.DataSource = readerBUS.readAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this entry?", "DELETE", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (gvReaders.SelectedRows.Count > 0)
                {
                    string madocgia = (string)gvReaders.SelectedRows[0].Cells["madocgia"].Value;
                    readerBUS.delete(madocgia);
                    gvReaders.DataSource = readerBUS.readAll();
                }
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            var borrowFrm = new BorrowManagement();
            borrowFrm.librarianid = librarianid;
            this.Hide();
            borrowFrm.ShowDialog();
            this.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var returnFrm = new ReturnManagement();
            returnFrm.librarianid = librarianid;
            this.Hide();
            returnFrm.ShowDialog();
            this.Show();
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
            var adrForm = new Reader("unknow");
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            var adrForm = new Reader(librarianid);
            this.Hide();
            adrForm.ShowDialog();
            this.Close();
        }
    }
}
