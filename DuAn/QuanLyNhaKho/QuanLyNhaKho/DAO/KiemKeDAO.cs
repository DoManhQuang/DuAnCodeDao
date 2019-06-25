using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
    public class  KiemKeDAO
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string Kho { get; set; }
        public string DVT { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string NgayHetHan { get; set; }

       public KiemKeDAO()
        {
        }
       public KiemKeDAO(string mahh, string tenhh, string dongia, string sl, string dvt, string kho, string thanhtien)
       {
           MaHH = mahh;
           TenHH = tenhh;
           DVT = dvt;
           SoLuong = sl;
           DonGia = dongia;
           ThanhTien = thanhtien;
           Kho = kho;
       }

       public KiemKeDAO(string mahh, string tenhh, string dongia, string sl, string dvt, string kho, string thanhtien, string ngayhethan)
        {
            MaHH = mahh;
            TenHH = tenhh;
            DVT = dvt;
            SoLuong = sl;
            DonGia = dongia;
            ThanhTien = thanhtien;
            Kho = kho;
            NgayHetHan = ngayhethan;
        }
    }
}
