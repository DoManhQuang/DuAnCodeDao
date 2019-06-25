using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class PhieuXuatDAO
    {
       public string SoPhieuXuat { get; set; }
        public string TenNhanVienXuat { get; set; }
        public string XuatTaiKho { get; set; }
        public string NgayXuat { get; set; }
        public string NguoiNhanHang { get; set; }
        public string GhiChu { get; set; }

        public PhieuXuatDAO() { }

        public PhieuXuatDAO(string soPhieuXuat, string tenkhoXuat, string tenNVxuat, string ngayXuat, string nguoinhan, string ghichu)
        {
            SoPhieuXuat = soPhieuXuat;
            TenNhanVienXuat = tenNVxuat;
            XuatTaiKho = tenkhoXuat;
            NgayXuat = ngayXuat;
            NguoiNhanHang = nguoinhan;
            GhiChu = ghichu;

        }
    }
}
