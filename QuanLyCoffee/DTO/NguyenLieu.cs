using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DTO
{
    class NguyenLieu
    {
        public NguyenLieu(int manl, string tennl, int soluong, string ghichu, int malnl)
        {
            this.MaNL = manl;
            this.TenNL = tennl;
            this.SoLuong = soluong;
            this.GhiChu = ghichu;
            
        }

        public NguyenLieu(DataRow row)
        {
            this.MaNL = Convert.ToInt32(row["manl"].ToString());
            this.TenNL = row["tennl"].ToString();
            this.SoLuong = Convert.ToInt32(row["soluong"].ToString());
            this.GhiChu = row["ghichu"].ToString();
            this.MaLoaiNL = Convert.ToInt32(row["malnl"].ToString());

        }

        private int soluong;

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private int manl;

        public int MaNL
        {
            get { return manl; }
            set { manl = value; }
        }

        private int malnl;

        public int MaLoaiNL
        {
            get { return malnl; }
            set { malnl = value; }
        }

        private string tennl;

        public string TenNL
        {
            get { return tennl; }
            set { tennl = value; }
        }



        private string ghichu;

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }


    }
}
