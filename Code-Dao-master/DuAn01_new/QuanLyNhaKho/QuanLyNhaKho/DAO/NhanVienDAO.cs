using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
   public class NhanVienDAO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string PhanQuyen { get; set; }

        public NhanVienDAO()
        {
        }

        public NhanVienDAO(string manv, string tennv, string phanquyen)
        {
            MaNV = manv;
            TenNV = tennv;
            PhanQuyen = phanquyen;
        }

    }
}
