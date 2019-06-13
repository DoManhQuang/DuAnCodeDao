using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaKho
{
    class BLLayer02
    {
        DALayer01 Layer01 = new DALayer01();
        public void CloseConnection()
        {
            SqlConnection connection = Layer01.GetSqlConnection();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public bool DangNhap(string taikhoan, string matkhau)
        {
            string cmdText = "select count(*) from Nhanvien where Taikhoan = '" + taikhoan + "' and Matkhau = '" + matkhau + "'";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read() && int.Parse(dataReader[0].ToString()) == 1)
            {
                CloseConnection();
                return true;
            }
            CloseConnection();
            return false;
        }
        public string GetMaNV(string taikhoan, string matkhau)
        {
            string cmdText = "select MaNV from Nhanvien where Taikhoan = '" + taikhoan + "' and Matkhau = '" + matkhau + "'";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                CloseConnection();
                return dataReader[0].ToString();
            }
            return null;
        }
        public int ChucNangNguoiDung(string taikhoan, string matkhau)
        {
            string cmdText = "select Phanquyen from Nhanvien where Taikhoan = '" + taikhoan + "' and Matkhau = '" + matkhau + "'";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return int.Parse(dataReader[0].ToString());// index = 0 chỉ thứ tự được select ra ở đây thứ tự 0 là count(ma)
            }
            return 0;
        }
        public DataTable LayThongTinNhanvien()
        {
            string cmdText = "select MaNV, TenNV, Chucvu, Gioitinh, Ngaysinh, Sdt, Diachi, Email, Phanquyen from Nhanvien where Phanquyen != 1";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public void ThemBangNhanvien(string MaNV, string TenNV, string Chucvu, int Gioitinh, string Ngaysinh, string Sdt, string Diachi, string Email, string Phanquyen, string matkhau)
        {
            string cmdText = "insert into Nhanvien values ('" + MaNV + "','" + MaNV + "','" + matkhau + "',N'" + TenNV + "','" + Chucvu + "','" + Ngaysinh + "','" + Gioitinh + "',N'" + Diachi + "','" + Sdt + "','" + Email + "','" + Phanquyen + "')";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void XoaBangNhanvien(string manv)
        {
            string cmdText = "delete from Nhanvien where MaNV = '" + manv + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void SuaBangNhanvien(string MaNV, string TenNV, string Chucvu, int Gioitinh, string Ngaysinh, string Sdt, string Diachi, string Email, string Phanquyen)
        {
            string cmdText = "Update Nhanvien set TenNV = N'" + TenNV + "' ,Chucvu = N'" + Chucvu + "' , " +
                "Gioitinh = '" + Gioitinh + "' , Ngaysinh = '" + Ngaysinh + "', Sdt = '" + Sdt + "', Diachi = '" + Diachi + "', Email = '" + Email + "', Phanquyen = '" + Phanquyen + "' where MaNV = '" + MaNV + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public DataTable TimKiemBangNhanvien(string tennv)
        {
            string cmdText = "select * from Nhanvien where TenNV like N'" + tennv + "%'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable TimKiemBangHangHoa(string tenhh, string tennk, string tendm)
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
               "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
               "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
               "where TenHH like N'" + tenhh + "%' and TenNK = N'" + tennk + "' and TenDM = N'" + tendm + "'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataSet LayThongTinHangHoa()
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
                "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
                "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM; " +
                "select TenNK from Nhakho; select TenDM from Danhmuc";
            DataSet dataSet = Layer01.GetDataSet(cmdText);
            return dataSet;
        }
        public DataTable HangHoaSapHetHan()
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
               "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
               "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
               "where DATEDIFF(year, GETDATE(), Hansudung) = 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) = 0 and DATEDIFF(day, GETDATE(), Hansudung) > 0";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable HangHoaDaHetHan()
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
               "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
               "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
               "where DATEDIFF(year, GETDATE(), Hansudung) = 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) = 0 and DATEDIFF(day, GETDATE(), Hansudung) <= 0";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public void CapNhapTaiKhoan(string MaNV, string taikhoan, string matkhau)
        {
            string cmdText = "Update Nhanvien set Taikhoan = '" + taikhoan + "' ,Matkhau = '" + matkhau + "' where MaNV = '" + MaNV + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        //public string XuLyMaNC(string manc)
        //{
        //    manc = manc.Remove(0, 2);
        //    int mancNew = int.Parse(manc) + 1;
        //    manc = "NC00" + mancNew;
        //    return manc;
        //}
        // Xử lý mã tự sinh
        public int GetMaDM()
        {
            string cmdText = "select top(1) MaDM from Danhmuc order by MaDM desc";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if(dataReader.Read())
            {
                string CodeID = dataReader[0].ToString();
                int numberID = int.Parse(CodeID.Remove(0, 3));
                return numberID + 1;
            }
            return 0;
        }
        public int GetMaKH()
        {
            string cmdText = "select top(1) MaKH from Khachhang order by MaKH desc";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                string CodeID = dataReader[0].ToString();
                int numberID = int.Parse(CodeID.Remove(0, 3));
                return numberID + 1;
            }
            return 0;
        }
        public int GetMaNCC()
        {
            string cmdText = "select top(1) MaNCC from Nhacungcap order by MaNCC desc";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                string CodeID = dataReader[0].ToString();
                int numberID = int.Parse(CodeID.Remove(0, 3));
                return numberID + 1;
            }
            return 0;
        }
        public int GetMaNK()
        {
            string cmdText = "select top(1) MaNK from Nhakho order by MaNK desc";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                string CodeID = dataReader[0].ToString();
                int numberID = int.Parse(CodeID.Remove(0, 3));
                return numberID + 1;
            }
            return 0;
        }
        public int GetMaNV()
        {
            string cmdText = "select top(1) MaNV from Nhanvien order by MaNV desc";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                string CodeID = dataReader[0].ToString();
                int numberID = int.Parse(CodeID.Remove(0, 3));
                return numberID + 1;
            }
            return 0;
        }
        // Khách Hàng
        public void SuaBangKhachHang(string makh, string tenkh, string diachi, string sdt, string email)
        {
            string cmdText = "update Khachhang set TenKH = N'" + tenkh + "', Diachi = N'" + diachi
                + "', Sdt = '" + sdt + "', Email = '" + email + "' where MaKH = '" + makh + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void XoaBangKhachHang(string makh)
        {
            string cmdText = "Delete from Khachhang where MaKH = '" + makh + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public DataTable LayThongTinKhachHang()
        {
            string cmdText = "select * from Khachhang ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable TimKiemTinKhachHang(string tenkh)
        {
            string cmdText = "select * from Khachhang where TenKH like N'" + tenkh + "%'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        // Nhà Cung Cấp
        public void ThemBangNhaCungCap(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string cmdText = "insert into Nhacungcap values('" + mancc + "',N'" + tenncc 
                + "',N'" + diachi + "','" + sdt + "','" + email + "')";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void SuaBangNhaCungCap(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string cmdText = "update Nhacungcap set TenNCC = N'" + tenncc + "', Diachi = N'" + diachi
                + "', Sdt = '" + sdt + "', Email = '" + email + "' where MaNCC = '" + mancc + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void XoaBangNhaCungCap(string mancc)
        {
            string cmdText = "Delete from Nhacungcap where MaNCC = '" + mancc + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public DataTable TimkiemthongTinNhaCungCap(string tenncc)
        {
            string cmdText = "select * from Nhacungcap where TenNCC like N'"+ tenncc + "%' ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable LayThongTinNhaCungCap()
        {
            string cmdText = "select * from Nhacungcap ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        // Kho hàng
        public void ThemBangNhaKho(string mank, string tennk, string diachi)
        {
            string cmdText = "insert into Nhakho values('" + mank + "','" + tennk
                + "',N'" + diachi + "')";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void SuaBangNhaKho(string mank, string tennk, string diachi)
        {
            string cmdText = "update Nhakho set TenNK = '" + tennk + "', Diachi = N'" + diachi
                + "' where MaNK = '" + mank + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void XoaBangNhaKho(string mank)
        {
            string cmdText = "Delete from Nhakho where MaNK = '" + mank + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public DataTable TimkiemthongTinNhaKho(string tennk)
        {
            string cmdText = "select * from Nhakho where TenNK like N'" + tennk + "%' ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable LayThongTinNhaKho()
        {
            string cmdText = "select * from Nhakho ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        // Nhóm hàng-danhmuc
        public void ThemBangDanhMuc(string madm, string tendm)
        {
            string cmdText = "insert into Danhmuc values('" + madm + "',N'" + tendm
                + "')";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void SuaBangDanhmuc(string madm, string tendm)
        {
            string cmdText = "update Danhmuc set TenDM = N'" + tendm + "'where MaDM = '" + madm + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public void XoaBangDanhmuc(string madm)
        {
            string cmdText = "Delete from Danhmuc where MaDM = '" + madm + "'";
            Layer01.ExecuteNonQuery(cmdText);
        }
        public DataTable TimkiemthongTinDanhMuc(string tendm)
        {
            string cmdText = "select * from Danhmuc where TenDM like N'" + tendm + "%' ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable LayThongTinDanhmuc()
        {
            string cmdText = "select * from Danhmuc ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

    }
}
