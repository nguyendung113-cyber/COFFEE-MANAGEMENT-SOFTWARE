using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien");
        }


        public bool InsertNhanVien(string manv, string tennv, string diachi, string sdt, string ngaysinh ,string CCCD)
        {
            string query = string.Format("INSERT dbo.NhanVien ( MaNV, TenNV, DiaChi, SDT, NgaySinh,CCCD)VALUES  ( N'{0}', N'{1}', N'{2}' ,N'{3}',N'{4}', N'{5}')", manv,tennv,diachi,sdt,ngaysinh,CCCD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNhanVien(string manv, string tennv, string diachi, string sdt, string ngaysinh,string CCCD)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET TenNV = N'{1}', DiaChi = N'{2}' , SDT  = N'{3}' , NgaySinh = N'{4}', CCCD = N'{5}' WHERE MaNV = N'{0}'", manv, tennv, diachi, sdt, ngaysinh, CCCD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNanhVien(string manv)
        {
            string query = string.Format("Delete NhanVien where MaNV = N'{0}'", manv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }



    }
}
