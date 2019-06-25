using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class BaoCaoNhapKhoDAO
    {

       public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }

        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }

       public BaoCaoNhapKhoDAO()
        {
        }


       public BaoCaoNhapKhoDAO(string MaPN, DateTime ngaynhap, string ghichu, string mahh, string tenhh, string dvt, string sl, string dongia, string thanhtien)
       {
           MaPhieuNhap = MaPN;
           NgayNhap = ngaynhap;
           GhiChu = ghichu;

           MaHH = mahh;
           TenHH = tenhh;
           DVT = dvt;
           SoLuong = sl;
           DonGia = dongia;
           ThanhTien = thanhtien;
       }
    }
}
