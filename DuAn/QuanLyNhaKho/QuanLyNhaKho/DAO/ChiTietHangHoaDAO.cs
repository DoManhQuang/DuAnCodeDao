using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class ChiTietHangHoaDAO
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }

       public ChiTietHangHoaDAO()
        {
        }


       public ChiTietHangHoaDAO(string mahh, string tenhh, string dvt, string sln, string dongia, string thanhtien)
        {
            MaHH = mahh;
            TenHH = tenhh;
            DVT = dvt;
            SoLuong = sln;
            DonGia = dongia;
            ThanhTien = thanhtien;
        }

    }
}
