using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
    public class BaoCaoXuatKhoDAO
    {
        public string MaPhieuXuat { get; set; }
        public DateTime NgayXuat { get; set; }
        public string GhiChu { get; set; }

        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }

       public BaoCaoXuatKhoDAO()
        {
        }
       public BaoCaoXuatKhoDAO(string MaPX, DateTime ngayxuat, string ghichu, string mahh, string tenhh, string dvt, string sl, string dongia, string thanhtien)
       {
           MaPhieuXuat = MaPX;
           NgayXuat = ngayxuat;
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
