using QuanLyCoffee.DTO;
using System;
using QuanLyCoffee.DAO;
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
    public partial class frmTrangChu : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            btnTaiKhoan.Enabled = type == 1;
        }

        public frmTrangChu(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

        }

        private Form currentFormChild;


        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyBan());

        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanHang());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
 
                OpenChildForm(new frmTaiKhoan());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNguyenLieu());
        }
    }
}
