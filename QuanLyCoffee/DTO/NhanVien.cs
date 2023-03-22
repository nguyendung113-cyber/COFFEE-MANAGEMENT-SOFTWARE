using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DTO
{
    class NhanVien
    {

        public NhanVien(string maNV, string TenNV, string sdt, DateTime? ngaysinh, string cccd = null)
        {
            this.MaNV = maNV;
            this.tenNV = TenNV;
            this.SDT = sdt;
            this.NgaySinh = ngaysinh;
            this.CCCD = cccd;
        }

        public NhanVien(DataRow row)
        {
            this.MaNV = row["MANV"].ToString();
            this.tenNV = row["tenNV"].ToString();
            this.SDT = row["SDDT"].ToString();
            this.NgaySinh = (DateTime?)row["NgaySinh"];
            this.CCCD = row["CCCD"].ToString();
        }

        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }



        private DateTime? ngaysinh;

        public DateTime? NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string cccd;

        public string CCCD
        {
            get { return cccd; }
            set { cccd = value; }
        }
    }
}
