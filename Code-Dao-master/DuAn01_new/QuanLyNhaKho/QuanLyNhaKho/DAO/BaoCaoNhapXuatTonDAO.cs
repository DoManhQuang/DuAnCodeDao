using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class BaoCaoNhapXuatTonDAO
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DVT { get; set; }
        public string SLTonDK { get; set; }
        public string ThanhTienTonDK { get; set; }
        public string SLNhap { get; set; }
        public string ThanhTienNhap { get; set; }
        public string SLXuat { get; set; }
        public string ThanhTienXuat { get; set; }
        public string SLTonCuoiKy { get; set; }
        public string ThanhTienCuoiKy { get; set; }

       public BaoCaoNhapXuatTonDAO()
        {
        }

       public BaoCaoNhapXuatTonDAO(string mahh, string tenhh, string dvt, string sltonCuoiKy, string ttCuoiky, string slTonDK, string TTTDK, string slnhap, string ttnhap, string slxuat, string ttxuat)
       {
           MaHH = mahh;
           TenHH = tenhh;
           DVT = dvt;
           
           SLTonDK = slTonDK;
           ThanhTienTonDK = TTTDK;
           
           SLNhap = slnhap;
           ThanhTienNhap = ttnhap;

           SLXuat = slxuat;
           ThanhTienXuat = ttxuat;

           SLTonCuoiKy = sltonCuoiKy;
           ThanhTienCuoiKy = ttCuoiky;
       }
    }
}
