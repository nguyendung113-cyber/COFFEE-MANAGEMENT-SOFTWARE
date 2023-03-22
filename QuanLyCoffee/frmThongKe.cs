using QuanLyCoffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffee
{
    public partial class frmThongKe : Form
    {

        BindingSource BillList = new BindingSource();

        public frmThongKe()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadBill();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            chartThongKe.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
            chartThongKe.Series["Tổng doanh thu"].Points.Clear();
            chartThongKe.Series["Tổng doanh thu"].XValueMember = "Ngày";
            chartThongKe.Series["Tổng doanh thu"].YValueMembers = "Tổng doanh thu";
        }



        void LoadBill()
        {
            BillList.DataSource = BillDAO.Instance.GetListBill();
        }
    
        void LoadListBillByDateTable(DateTime checkIn, DateTime checkOut)
        {
            dgvThongKe.DataSource = BillDAO.Instance.GetBillListByDateTable(checkIn,checkOut);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadListBillByDateTable(dateTimePicker1.Value,dateTimePicker2.Value);
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
