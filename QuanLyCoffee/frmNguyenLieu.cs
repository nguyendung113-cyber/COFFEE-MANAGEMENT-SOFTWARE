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
    public partial class frmNguyenLieu : Form
    {
        BindingSource NguyenLieuList = new BindingSource();

        BindingSource LoaiNguyenLieuList = new BindingSource();

        public frmNguyenLieu()
        {
            InitializeComponent();
            Load();
            LoadLoaiNL(ccbNguyenLieu);
        }



    

        void Load()
        {
            dataGridView1.DataSource = NguyenLieuList;
            dataGridView2.DataSource = LoaiNguyenLieuList;
            AddNguyenLieuBinding();
            LoadNguyenLieu();
            AddLoaiNguyenLieuBinding();
            LoadLoaiNguyenLieu();
        }

        void AddNguyenLieuBinding()
        {

            txtMaNL.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNL", true, DataSourceUpdateMode.Never));
            txtTenNL.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenNL", true, DataSourceUpdateMode.Never));
            txtSL.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtGhiChu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
        }

        void LoadNguyenLieu()
        {
            NguyenLieuList.DataSource = NguyenLieuDAO.Instance.getListNguyenLieu();
        }

        void LoadLoaiNguyenLieu()
        {
            LoaiNguyenLieuList.DataSource = LoaiNLDAO.Instance.getListLoaiNL();
        }


        void AddLoaiNguyenLieuBinding()
        {

            txtMaLNL.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "MaLoaiNL", true, DataSourceUpdateMode.Never));
            txtTenLNL.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "TenLoaiNL", true, DataSourceUpdateMode.Never));
            txtNCC.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "TenNCC", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "SDTNCC", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dataGridView2.DataSource, "DiaChiNCC", true, DataSourceUpdateMode.Never));
           
        }


        void AddNguyenLieu(int manl, string tennl, int soluong, string ghichu, int malnl)
        {
            try
            {
                if (NguyenLieuDAO.Instance.InsertNguyeLieu(manl, tennl, soluong, ghichu,malnl))
                {

                    MessageBox.Show("Thêm nguyên liệu mới thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nguyên liệu thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadNguyenLieu();
        }


        void UpdateNguyenLieu(int manl, string tennl, int soluong, string ghichu,int malnl)
        {
            try
            {
                if (NguyenLieuDAO.Instance.UpdateNguyeLieu(manl, tennl, soluong, ghichu, malnl))
                {

                    MessageBox.Show("Cập nhật nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("Chập nhất nguyên liệu thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadNguyenLieu();
        }

      

        void DeleteNguyeLieu(int manl)
        {
            try
            {
                if (NguyenLieuDAO.Instance.DeleteNguyenLieu(manl))
                {
                    MessageBox.Show("Xóa thông tin nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thông tin nguyên liệu thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thông tin nguyên liệu thất bại");
            }

            LoadNguyenLieu();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int manl = int.Parse(txtMaNL.Text);
            string tennl = txtTenNL.Text;
            int soluong = int.Parse(txtSL.Text);
            string ghichu = txtGhiChu.Text;
            int malnl = int.Parse(ccbNguyenLieu.SelectedValue.ToString());

            AddNguyenLieu(manl, tennl, soluong, ghichu, malnl);
        }


        private void tbnSua_Click(object sender, EventArgs e)
        {
            int manl = int.Parse(txtMaNL.Text);
            string tennl = txtTenNL.Text;
            int soluong = int.Parse(txtSL.Text);
            string ghichu = txtGhiChu.Text;
            int malnl = int.Parse(ccbNguyenLieu.SelectedValue.ToString());

            UpdateNguyenLieu(manl, tennl, soluong, ghichu,malnl);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                int manl = int.Parse(txtMaNL.Text);

                DeleteNguyeLieu(manl);
        }

        //Loại Nguyên Liệu  
        void AddLoaiNguyenLieu(int malnl, string tenlnl, string sdt, string diachi, string tenncc)
        {
            try
            {
                if (LoaiNLDAO.Instance.InsertLoaiNguyeLieu(malnl, tenlnl, sdt, diachi, tenncc))
                {

                    MessageBox.Show("Thêm nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nguyên liệun thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadLoaiNguyenLieu();
        }


        void UpdateLoaiNguyenLieu(int malnl, string tenlnl, string sdt, string diachi, string tenncc)
        {
            try
            {
                if (LoaiNLDAO.Instance.UpdateLoaiNguyeLieu(malnl, tenlnl, sdt, diachi, tenncc))
                {

                    MessageBox.Show("Cập nhật loại nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật loại nguyên liệu thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn đã nhập sai thông tin, vui lòng nhập lại");
            }
            Console.Read();


            LoadLoaiNguyenLieu();
        }



        void DeleteLoaiNguyeLieu(int malnl)
        {
            try
            {
                if (LoaiNLDAO.Instance.DeleteLoaiNguyenLieu(malnl))
                {
                    MessageBox.Show("Xóa thông tin loại nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thông tin loại nguyên liệu thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thông tin nguyên liệu thất bại");
            }

            LoadLoaiNguyenLieu();
        }



 

        private void button1_Click(object sender, EventArgs e)
        {
            int malnl = int.Parse(txtMaLNL.Text);
            string tenlnl = txtTenLNL.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string tenncc = txtNCC.Text;

            AddLoaiNguyenLieu(malnl, tenlnl, sdt, diachi, tenncc);
        }

        private void btnSuaLNL_Click(object sender, EventArgs e)
        {
            int malnl = int.Parse(txtMaLNL.Text);
            string tenlnl = txtTenLNL.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string tenncc = txtNCC.Text;
           

            UpdateLoaiNguyenLieu(malnl, tenlnl, sdt, diachi, tenncc);
        }

        private void btnXoaLNL_Click(object sender, EventArgs e)
        {
            int malnl = int.Parse(txtMaLNL.Text);

            DeleteLoaiNguyeLieu(malnl);
        }

        void LoadLoaiNL(ComboBox cb)
        {
            cb.DataSource = LoaiNLDAO.Instance.getListLoaiNL();
            cb.DisplayMember = "TenLoaiNL";
            cb.ValueMember = "MaLoaiNL";

        }

        private void ccbNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }


 


}
