using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DAO
{
    class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;

        public static NguyenLieuDAO Instance
        {
            get { if (instance == null) instance = new NguyenLieuDAO(); return instance; }
            private set { instance = value; }
        }


        public DataTable getListNguyenLieu()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from dbo.NguyenLieu " );

        }

   

        public bool InsertNguyeLieu(int manl, string tennl, int soluong,string ghichu,int malnl)
        {
            string query = string.Format("INSERT dbo.NguyenLieu ( MaNL , TenNL,  SoLuong, GhiChu , MaLoaiNL)VALUES  ( {0}, N'{1}', {2} , N'{3}' ,{4})", manl, tennl, soluong, ghichu,malnl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNguyeLieu(int manl, string tennl, int soluong, string ghichu,int malnl)
        {
            string query = string.Format("UPDATE dbo.NguyenLieu SET TenNL = N'{1}', SoLuong = {2} , GhiChu = N'{3}', MaLoaiNL = {4} WHERE MaNL = {0}", manl, tennl,soluong,ghichu,malnl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNguyenLieu(int manl)
        {
            string query = string.Format("Delete NguyenLieu where MaNL = {0}", manl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
