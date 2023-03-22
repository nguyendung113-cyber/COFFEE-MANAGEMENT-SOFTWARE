using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DTO
{
    class LoaiNL
    {

        public LoaiNL(int malnl, string tenncc, string sdt, string diachi,string tenlnl)
        {
            this.MaLoaiNL = malnl;
            this.TenNCC = tenncc;
            this.SDTNCC = sdt;
            this.DiaChi = diachi;
            this.TenLoaiNl = tenlnl;

        }

        public LoaiNL(DataRow row)
        {
            this.MaLoaiNL = Convert.ToInt32(row["malnl"].ToString());
            this.TenNCC = row["tenncc"].ToString();
            this.SDTNCC = row["sdt"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.TenLoaiNl = row["tenlnl"].ToString();

        }

        private int malnl;

        public int MaLoaiNL
        {
            get { return malnl; }
            set { malnl = value; }
        }

        private string tenncc;

        public string TenNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }

        private string sdt;

        public string SDTNCC
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string diachi;

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string tenlnl;

        public string TenLoaiNl
        {
            get { return tenlnl; }
            set { tenlnl = value; }
        }
    }
}
