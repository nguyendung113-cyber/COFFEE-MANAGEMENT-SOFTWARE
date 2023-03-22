using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DAO
{
    class LoaiNLDAO
    {
        private static LoaiNLDAO instance;

        public static LoaiNLDAO Instance
        {
            get { if (instance == null) instance = new LoaiNLDAO(); return LoaiNLDAO.instance; }
            private set { LoaiNLDAO.instance = value; }
        }

        private LoaiNLDAO() { }

        public List<LoaiNL> GetListLoaiNguyenLieu()
        {
            List<LoaiNL> list = new List<LoaiNL>();

            string query = "select * from LoaiNL";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiNL loainl = new LoaiNL(item);
                list.Add(loainl);
            }

            return list;
        }

        public DataTable getListLoaiNL()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from dbo.LoaiNL");
        }

        public bool InsertLoaiNguyeLieu(int malnl, string tenlnl,string sdt, string diachi, string tenncc)
        {
            string query = string.Format("INSERT dbo.LoaiNL ( MaLoaiNL , TenLoaiNl, SDTNCC,  DiaChiNCC, TenNCC)VALUES  ( {0}, N'{1}', N'{2}' , N'{3}', N'{4}')", malnl, tenlnl, sdt,diachi, tenncc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLoaiNguyeLieu(int malnl, string tenlnl, string sdt, string diachi, string tenncc)
        {
            string query = string.Format("UPDATE dbo.LoaiNL SET TenLoaiNl = N'{1}', SDTNCC = N'{2}' , DiaChiNCC = N'{3}', TenNCC = N'{4}' WHERE MaLoaiNL = {0}", malnl, tenlnl, sdt, diachi, tenncc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteLoaiNguyenLieu(int malnl)
        {
            string query = string.Format("Delete LoaiNL where MaLoaiNL = {0}", malnl);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }




    }
}
