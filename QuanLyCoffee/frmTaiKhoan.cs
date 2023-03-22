using QuanLyCoffee.DAO;
using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffee
{
    public partial class frmTaiKhoan : Form
    {


        public string key = "";
       
        BindingSource accountList = new BindingSource();

        BindingSource NhanVienList = new BindingSource();

        BindingSource ListTable = new BindingSource();

        private Account loginAccount;

        public frmTaiKhoan()
        {
            InitializeComponent();
            Load();
            LoadTable(ccbStatus);
        }


        void Load()
        {
            dgvTaiKhoan.DataSource = accountList;
            dgvNV.DataSource = NhanVienList;
            dgvBan.DataSource = ListTable;
            LoadAccount();
            AddAccountBinding();
            AddNhanVienBinding();
            LoadNhanVien();
            AddBanBinding();
            LoadBan();
            
        }

        void AddAccountBinding()
        {
            
            txtTaiKhoan.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtMatkhau.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "PassWord", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dgvTaiKhoan.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }


        void AddBanBinding()
        {
            txtMaBan.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtTenBan.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "name", true, DataSourceUpdateMode.Never));
            ccbStatus.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }


        void LoadBan()
        {
            ListTable.DataSource = TableDAO.Instance.getListTable();
        }



        void AddNhanVienBinding()
        {
            
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenNV.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, today.Day);
            txtCCCD.DataBindings.Add(new Binding("Text", dgvNV.DataSource, "CCCD", true, DataSourceUpdateMode.Never));
            

        }

        void LoadNhanVien()
        {
            NhanVienList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }


      //Account

        void AddAccount(string userName, string displayName, string password,int type)
        {
            try { 
            if (AccountDAO.Instance.InsertAccount(userName, displayName, password ,type))
            {
                
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            }catch(SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadAccount();
        }


        void EditAccount(string userName, string displayName, string password ,int type)
        {
            try { 
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, password ,type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            }catch(SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
        Console.Read();


            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            try { 
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }}catch(SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadAccount();
        }

          private void btnLuu_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string displayName = txtTen.Text;
            string password = txtMatkhau.Text;
            int type = (int)numericUpDown1.Value;

            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(password);///mk là biến truyền vào
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }

            EditAccount(userName, displayName, str, type);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string displayName = txtTen.Text;
            string password = txtMatkhau.Text;
            int type = (int)numericUpDown1.Value;

            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(password);///mk là biến truyền vào
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }



            AddAccount(userName, displayName, str ,type);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;

            DeleteAccount(userName);
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyQuanCafeDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyQuanCafeDataSet.NhanVien);

        }



        //NhanVien
        void AddNhanVien(string manv, string tennv, string diachi, string sdt,string ngaysinh, string CCCD)
        {
            try
            {

                if (NhanVienDAO.Instance.InsertNhanVien(manv,tennv,diachi,sdt,ngaysinh,CCCD))
            {

                MessageBox.Show("Thêm thông tin nhân viên thành công");
            }
            else
            {
               
            }
            }catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            Console.Read();

            LoadNhanVien();
        }


        void EditNhanVien(string manv, string tennv, string diachi, string sdt,string ngaysinh, string CCCD)
        {

            try
            {

                if (NhanVienDAO.Instance.UpdateNhanVien(manv, tennv, diachi, sdt, ngaysinh,CCCD))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công");
            }
            else
            {
                
            }
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message );
            }
            Console.Read();


            LoadNhanVien();
        }

        void DeleteNhanVien(string manv)
        {
            try { 
            if (NhanVienDAO.Instance.DeleteNanhVien(manv))
            {
                MessageBox.Show("Xóa thông tin nhân viên thành công");
            }
            else
            {
                    MessageBox.Show("Xóa thông tin nhân viên thất bại");
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("Xóa thông tin nhân viên thất bại");
            }

            LoadNhanVien();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string tennv = txtTenNV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string ngaysinh = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy/MM/dd");
            string CCCD = txtCCCD.Text;

            AddNhanVien(manv, tennv, diachi, sdt, ngaysinh, CCCD);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;

            DeleteNhanVien(manv);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string tennv = txtTenNV.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string ngaysinh = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy/MM/dd");

            string CCCD = txtCCCD.Text;



            EditNhanVien(manv, tennv, diachi, sdt, ngaysinh, CCCD);
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


  

  

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void InsertBan(string name, string status)
        {

            if (TableDAO.Instance.InsertBan(name,status))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }

            LoadBan();
        }

        void LoadTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.getTrangThai();
            cb.DisplayMember = "status";
            cb.ValueMember = "status";

        }

        void DeleteBan(string name)
        {
            try
            {
                if (TableDAO.Instance.DeleteTable(name))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
                
            
            LoadBan();
        }

        //Luong

        



        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            string name = txtTenBan.Text;
            string status = ccbStatus.SelectedValue.ToString();

            InsertBan(name, status);
        }

        private void ccbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string name = txtTenBan.Text;
            DeleteBan(name);
        }
    }
}
