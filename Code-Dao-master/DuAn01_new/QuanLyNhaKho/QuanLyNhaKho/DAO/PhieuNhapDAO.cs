using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class PhieuNhapDAO
    {
        public string SoPhieuNhap { get; set; }
        public string TenNhanVienNhap { get; set; }
        public string NhapTaiKho { get; set; }
        public string NgayNhap { get; set; }
        public string NguoiGiaoHang { get; set; }
        public string GhiChu { get; set; }

        public PhieuNhapDAO() { }

        public PhieuNhapDAO(string soPhieuNhap, string tenkhoNhap, string tenNVNhap, string ngayNhap, string nguoiGiao, string ghichu)
        {
            SoPhieuNhap = soPhieuNhap;
            TenNhanVienNhap = tenNVNhap;
            NhapTaiKho = tenkhoNhap;
            NgayNhap = ngayNhap;
            NguoiGiaoHang = nguoiGiao;
            GhiChu = ghichu;

        }

    }
}
