using LibraryManagement.DAO;
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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from SACH";
            DataTable data = new DataTable();
            data = ProcessData.ExcuteQuery(sql);

            int total = data.Rows.Count;

            int[] count = new int[4]{ 0,0,0,0 };
            string[] name = new string[4] { "Tiểu thuyết", "Khoa học", "Ngoại ngữ", "Truyện tranh" };

            for (int i=0;i<4;i++)
            {
                sql = string.Format("select * from SACH where LOAI={0}", i);
                data = ProcessData.ExcuteQuery(sql);
                count[i] = data.Rows.Count;
            }

            for (int i = 0; i < 4; i++)
            {
                
                    chartBook.Series["Series1"].Points.AddXY(name[i], count[i]);
                
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartBorrow.Series["Series1"].Points.Clear();
            string sql = "select * from PHIEUMUON";
            DataTable data = new DataTable();
            data = ProcessData.ExcuteQuery(sql);

            int total = data.Rows.Count;

            int[] count = new int[4] { 0, 0, 0, 0 };
            string[] name = new string[4] { "Tiểu thuyết", "Khoa học", "Ngoại ngữ", "Truyện tranh" };

            int month = (int)monthPick.Value;
            for (int i = 0; i < 4; i++)
            {
                sql = string.Format("select * from SACH,PHIEUMUON where SACH.MASACH = PHIEUMUON.MASACH and month(PHIEUMUON.NGAYMUON) = {0} and LOAI={1}",
                    month,i);
                data = ProcessData.ExcuteQuery(sql);
                count[i] = data.Rows.Count;
            }

            for (int i = 0; i < 4; i++)
            {

                chartBorrow.Series["Series1"].Points.AddXY(name[i], count[i]);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
