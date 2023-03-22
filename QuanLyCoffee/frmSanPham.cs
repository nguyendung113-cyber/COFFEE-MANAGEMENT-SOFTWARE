using QuanLyCoffee.DAO;
using QuanLyCoffee.DTO;
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
    public partial class frmSanPham : Form
    {
        BindingSource foodList = new BindingSource();
        public frmSanPham()
        {
            InitializeComponent();
            LoadList();
        }

        void LoadList()
        {
            dtgSanPham.DataSource = foodList;

            LoadSanphamList();
            AddFoodBinding();
            LoadFoodCategoryIntoComboBox(cbbLoaiSanPham);
        }

        void LoadSanphamList()
        {
            //string query = "SELECT f.id AS 'ID', fc.name AS 'Tên loại', f.name AS 'Tên', f.price AS 'Giá' " +
            //               "FROM dbo.Food f, dbo.FoodCategory fc " +
            //               "WHERE f.idCategory = fc.id";
            //dtgSanPham.DataSource = DataProvider.Instance.ExecuteQuery(query);
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddFoodBinding()
        {
            txtTenSanPham.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtMaSanPham.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmDonGia.DataBindings.Add(new Binding("Value", dtgSanPham.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadFoodCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListFoodCategory();
            cb.DisplayMember = "Name";
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }


        

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string name = txtTenSanPham.Text;
            int categoryID = (cbbLoaiSanPham.SelectedItem as Category).ID;
            float price = (float)nmDonGia.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadSanphamList();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaSanPham.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadSanphamList();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtTimTen.Text);
        }

        private void txtMaSanPham_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dtgSanPham.SelectedCells.Count > 0)
                {
                    int id = (int)dtgSanPham.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetFoodCategoryByID(id);

                    cbbLoaiSanPham.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbLoaiSanPham.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbbLoaiSanPham.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string name = txtTenSanPham.Text;
            int categoryID = (cbbLoaiSanPham.SelectedItem as Category).ID;
            float price = (float)nmDonGia.Value;
            int id = Convert.ToInt32(txtMaSanPham.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadSanphamList();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void cbbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
