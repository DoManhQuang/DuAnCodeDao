using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaKho.DAO;
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

        public string GetTenNV(string taikhoan, string matkhau)
        {
            string cmdText = "select TenNV from Nhanvien where Taikhoan = '" + taikhoan + "' and Matkhau = '" + matkhau + "'";
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
            string cmdText = "select * from Nhanvien where TenNV like N'%" + tennv + "%'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable TimKiemBangHangHoa(string tenhh, string tennk, string tendm)
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
               "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
               "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
               "where TenHH like N'%" + tenhh + "%' and TenNK = N'" + tennk + "' and TenDM = N'" + tendm + "'";
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
               "where DATEDIFF(year, GETDATE(), Hansudung) <= 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) <= 0 and DATEDIFF(day, GETDATE(), Hansudung) > 0";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable HangHoaDaHetHan()
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
               "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
               "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
               "where DATEDIFF(year, GETDATE(), Hansudung) <= 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) <= 0 and DATEDIFF(day, GETDATE(), Hansudung) <= 0";
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
            if (dataReader.Read())
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
            string cmdText = "select * from Khachhang where TenKH like N'%" + tenkh + "%'";
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
            string cmdText = "select * from Nhacungcap where TenNCC like N'%" + tenncc + "%' ";
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
            string cmdText = "select * from Nhakho where TenNK like N'%" + tennk + "%' ";
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
            string cmdText = "select * from Danhmuc where TenDM like N'%" + tendm + "%' ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable LayThongTinDanhmuc()
        {
            string cmdText = "select * from Danhmuc ";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        #region Phần Xuất hàng

        public DataTable LayMaSoPhieuXuatCuoiCung()
        {
            string cmdText = "SELECT TOP 1 * FROM dbo.Phieuxuat ORDER BY MaPX DESC";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayThongTinDanhSachPhieuXuat()
        {
            string cmdText = "Select Row_number() over(order by dbo.Phieuxuat.MaPX) STT, dbo.Phieuxuat.MaPX AS N'Số phiếu xuất', dbo.Nhakho.TenNK AS N'Kho', dbo.Nhanvien.TenNV as N'Nhân viên', dbo.Phieuxuat.Ngayxuat AS N'Ngày xuất', dbo.Phieuxuat.Nguoinhanhang AS N'Người nhận', dbo.Phieuxuat.Ghichu AS N'Ghi chú', dbo.Phieuxuat.Tongtien AS N'Tổng tiền' FROM dbo.Phieuxuat INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieuxuat.MaNV INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieuxuat.MaNK";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayThongTinChiTietCuaPhieuXuat(String MaPX)
        {
            string cmdText = " Select Row_number() over(order by dbo.CTPhieuxuat.MaHH) STT, dbo.CTPhieuxuat.MaHH,dbo.Hanghoa.TenHH, dbo.CTPhieuxuat.Soluong,dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Giavon FROM dbo.CTPhieuxuat INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.CTPhieuxuat.MaPX ='" + MaPX + "'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable TimKiemPhieuXuat(String MaPX)
        {
            string cmdText = "Select Row_number() over(order by dbo.Phieuxuat.MaPX) STT, dbo.Phieuxuat.MaPX AS N'Số phiếu xuất', dbo.Nhakho.TenNK AS N'Kho', dbo.Nhanvien.TenNV as N'Nhân viên', dbo.Phieuxuat.Ngayxuat AS N'Ngày xuất', dbo.Phieuxuat.Nguoinhanhang, dbo.Phieuxuat.Ghichu, dbo.Phieuxuat.Tongtien FROM dbo.Phieuxuat INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieuxuat.MaNV INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieuxuat.MaNK where dbo.Phieuxuat.MaPX like N'%" + MaPX + "%'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }


        public void ThemPhieuNhapHangVaoBangPhieuXuat(string MaPX, string MaNK, string MaNV, DateTime Ngayxuat, string NguoiNhanHang, string GhiChu, double tongTien, List<ChiTietHangHoaDAO> DanhSachHangXuat)
        {
            // Thêm thông tin chung về phiếu nhập
            string cmdText = "INSERT  INTO dbo.Phieuxuat( MaPX, MaNK ,MaNV ,Ngayxuat ,Nguoinhanhang , Ghichu ,Tongtien) VALUES  ( '" + MaPX + "', '" + MaNK + "' , '" + MaNV + "' , '" + Ngayxuat + "' , '" + NguoiNhanHang + "' ,N'" + GhiChu + "' , " + tongTien + ")";
            Layer01.ExecuteNonQuery(cmdText);

            // Thêm Danh sách hàng nhập và cập nhật số lượng
            foreach (ChiTietHangHoaDAO item in DanhSachHangXuat)
            {
                string cmdText1 = "	INSERT INTO dbo.CTPhieuxuat (MaPX, MaHH, Soluong, Giavon ) VALUES  ( '" + MaPX + "', '" + item.MaHH + "', '" + item.SoLuong + "',  '" + item.DonGia + "' )";
                Layer01.ExecuteNonQuery(cmdText1);
                string cmdText2 = "	UPDATE dbo.Hanghoa SET Soluong = Soluong-" + int.Parse(item.SoLuong) + " WHERE MaHH = '" + item.MaHH + "'";
                Layer01.ExecuteNonQuery(cmdText2);
            }
        }

        public List<ChiTietHangHoaDAO> LayThongTinChiTietCuaPhieuXuatTheoSoPhieu(string soPhieu)
        {
            string cmdText = "Select dbo.CTPhieuxuat.MaHH,dbo.Hanghoa.TenHH,dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Soluong, dbo.CTPhieuxuat.Giavon, (CAST(CTPhieuxuat.Soluong as float) * CAST(CTPhieuxuat.Giavon as float) ) AS 'ThanhTien' FROM dbo.CTPhieuxuat INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.CTPhieuxuat.MaPX ='" + soPhieu + "'";
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<ChiTietHangHoaDAO> dataHangXuat = new List<ChiTietHangHoaDAO>();
            while (dr.Read())
            {
                ChiTietHangHoaDAO chiTietHH = new ChiTietHangHoaDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                dataHangXuat.Add(chiTietHH);
            }
            dr.Close();
            return dataHangXuat;
        }

        #endregion


        #region Phần nhập hàng

        public DataTable LayThongTinDanhSachPhieuNhap()
        {
            string cmdText = "Select Row_number() over(order by dbo.Phieunhap.MaPN) STT, dbo.Phieunhap.MaPN AS N'Số phiếu nhập', dbo.Nhakho.TenNK AS N'Kho', dbo.Nhanvien.TenNV as N'Nhân viên', dbo.Phieunhap.Ngaynhap AS N'Ngày nhập', dbo.Phieunhap.Nguoigiaohang AS N'Người giao hàng', dbo.Phieunhap.Ghichu AS N'Ghi chú', dbo.Phieunhap.Tongtien AS N'Tổng tiền' FROM dbo.Phieunhap INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieunhap.MaNV INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieunhap.MaNK";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayThongTinChiTietCuaPhieuNhap(String MaPX)
        {
            string cmdText = " Select Row_number() over(order by dbo.CTPhieunhap.MaHH) STT, dbo.CTPhieunhap.MaHH,dbo.Hanghoa.TenHH, dbo.CTPhieunhap.Soluong,dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Giavon FROM dbo.CTPhieunhap INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE dbo.CTPhieunhap.MaPN ='" + MaPX + "'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable TimKiemPhieuNhap(String MaPX)
        {
            string cmdText = "Select Row_number() over(order by dbo.Phieunhap.MaPN) STT, dbo.Phieunhap.MaPN AS N'Số phiếu nhập', dbo.Nhakho.TenNK AS N'Kho', dbo.Nhanvien.TenNV as N'Nhân viên', dbo.Phieunhap.Ngaynhap AS N'Ngày nhập', dbo.Phieunhap.Nguoigiaohang, dbo.Phieunhap.Ghichu, dbo.Phieunhap.Tongtien FROM dbo.Phieunhap INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieunhap.MaNV INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieunhap.MaNK where dbo.Phieunhap.MaPN like N'%" + MaPX + "%'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public ChiTietHangHoaDAO LayThongTinMotHangHoaNhapTheoMa(string MaHH)
        {
            string cmdText = "SELECT MaHH, TenHH, Dvt, Soluong, Giavon, Mota AS 'Thanhtien' FROM dbo.Hanghoa where MaHH='" + MaHH + "'";
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            ChiTietHangHoaDAO chiTietHH = new ChiTietHangHoaDAO();
            while (dr.Read())
            {
                chiTietHH = new ChiTietHangHoaDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            return chiTietHH;
        }

        public List<ChiTietHangHoaDAO> LayDanhSachHangHoa()
        {
            string cmdText = "SELECT MaHH, TenHH, Dvt, Soluong, Giavon, Mota AS 'Thanhtien' FROM dbo.Hanghoa";
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<ChiTietHangHoaDAO> chitiets = new List<ChiTietHangHoaDAO>();
            while (dr.Read())
            {
                ChiTietHangHoaDAO chiTietHH = new ChiTietHangHoaDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                chitiets.Add(chiTietHH);
            }
            dr.Close();
            return chitiets;
        }


        public List<ChiTietHangHoaDAO> LayThongTinChiTietCuaPhieuNhapTheoSoPhieu(string soPhieu)
        {
            string cmdText = "Select dbo.CTPhieunhap.MaHH,dbo.Hanghoa.TenHH,dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Soluong, dbo.CTPhieunhap.Giavon, (CAST(CTPhieunhap.Soluong as float) * CAST(CTPhieunhap.Giavon as float) ) AS 'ThanhTien' FROM dbo.CTPhieunhap INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE dbo.CTPhieunhap.MaPN ='" + soPhieu + "'";
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<ChiTietHangHoaDAO> dataHangMua = new List<ChiTietHangHoaDAO>();
            while (dr.Read())
            {
                ChiTietHangHoaDAO chiTietHH = new ChiTietHangHoaDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                dataHangMua.Add(chiTietHH);
            }
            dr.Close();
            return dataHangMua;
        }


        public DataTable LayMaSoPhieuNhapCuoiCung()
        {
            string cmdText = "SELECT TOP 1 * FROM dbo.Phieunhap ORDER BY MaPN DESC";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayMaSoHangHoaCuoiCung()
        {
            string cmdText = "SELECT TOP 1 * FROM dbo.Hanghoa ORDER BY MaHH DESC";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }


        public void ThemPhieuNhapHangVaoBangPhieuNhap(string MaPN, string MaNV, string MaNK, DateTime Ngaynhap, string NguoiGiaoHang, string GhiChu, double tongTien, List<ChiTietHangHoaDAO> DanhSachHangNhap)
        {
            // Thêm thông tin chung về phiếu nhập
            string cmdText = "INSERT  INTO dbo.Phieunhap( MaPN , MaNV ,MaNK ,Ngaynhap ,Nguoigiaohang , Ghichu ,Tongtien) VALUES  ( '" + MaPN + "', '" + MaNV + "' , '" + MaNK + "' , '" + Ngaynhap + "' , N'" + NguoiGiaoHang + "' ,N'" + GhiChu + "' , " + tongTien + ")";
            Layer01.ExecuteNonQuery(cmdText);

            // Thêm Danh sách hàng nhập và cập nhật số lượng
            foreach (ChiTietHangHoaDAO item in DanhSachHangNhap)
            {
                string cmdText1 = "	INSERT INTO dbo.CTPhieunhap ( MaPN, MaHH, Soluong, Giavon ) VALUES  ( '" + MaPN + "', '" + item.MaHH + "', '" + item.SoLuong + "',  '" + item.DonGia + "' )";
                Layer01.ExecuteNonQuery(cmdText1);
                string cmdText2 = "	UPDATE dbo.Hanghoa SET Soluong = Soluong+" + int.Parse(item.SoLuong) + ", Giavon = '" + int.Parse(item.DonGia) + "' WHERE MaHH = '" + item.MaHH + "'";
                Layer01.ExecuteNonQuery(cmdText2);
            }
        }
        public void ThemMoiHangHoa(string mahh, string tenhh, string dvt, string hansudung, string giavon, string soluong, string maDM, string mota, string maNCC)
        {

            string cmdText = "insert into dbo.HangHoa values('" + mahh + "',N'" + tenhh + "',N'" + dvt + "','" + hansudung + "','" + giavon + "','" + soluong + "','" + maDM + "', N'" + mota + "','" + maNCC + "')";
            Layer01.ExecuteNonQuery(cmdText);

        }

        public DataTable LayDanhSachDanhMuc()
        {
            string cmdText = "SELECT * FROM dbo.DanhMuc";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }


        #endregion

        #region Phần chung của phiếu nhập và phiếu xuất

        public DataTable LayDanhSachNhaKho()
        {
            string cmdText = "SELECT * FROM dbo.Nhakho WHERE dbo.Nhakho.MaNK != 'NK0000'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayDanhSachNhaCungCap()
        {
            string cmdText = "SELECT * FROM dbo.Nhacungcap WHERE MaNCC != 'NCC00000'";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayDanhSachNhaKhoALL()
        {
            string cmdText = "SELECT * FROM dbo.Nhakho";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public DataTable LayDanhSachNhaCungCapALL()
        {
            string cmdText = "SELECT * FROM dbo.Nhacungcap";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public string GetTenKhoTheoMaKho(string makho)
        {
            string cmdText = "select TenNK from NhaKho where MaNK = '" + makho + "'";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                CloseConnection();
                return dataReader[0].ToString();
            }
            return null;
        }

        public string GetTenNhaCungCapTheoMaNhaCungCap(string maNCC)
        {
            string cmdText = "SELECT TenNCC FROM dbo.Nhacungcap WHERE MaNCC = '" + maNCC + "'";
            SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                CloseConnection();
                return dataReader[0].ToString();
            }
            return null;
        }

        #endregion


        #region Phần hóa đơn

        public DataTable LayMaHoaDonCuoiCung()
        {
            string cmdText = "  SELECT TOP 1 * FROM dbo.Phieumua ORDER BY MaPM DESC";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }
        public DataTable LayMaKHCuoiCung()
        {
            string cmdText = "  SELECT TOP 1 * FROM dbo.Phieumua ORDER BY MaPM DESC";
            DataTable dataTable = Layer01.GetDataTable(cmdText);
            return dataTable;
        }

        public void ThanhToanVaThemHoaDonBanHang(string MaHD, string MaNV, DateTime Ngaymua, string Ghichu, double Tongtien, string TenKH, string Diachi, string sdt, string email, List<ChiTietHangHoaDAO> DanhSachHangBan)
        {
            // Thêm thông tin khách hàng
            string maKHGoc = LayMaKHCuoiCung().Rows[0][0].ToString();// lấy ô đầu tiên của bảng kết quả trả về
            string kyTuDau = maKHGoc.Substring(0, 2);
            int soCanTang = Convert.ToInt32(maKHGoc.Substring(2)) + 1;

            string maKH = "";
            if (soCanTang >= 0 && soCanTang < 10)
                maKH = kyTuDau + "0000" + soCanTang;
            if (soCanTang >= 10 && soCanTang < 100)
                maKH = kyTuDau + "000" + soCanTang;
            if (soCanTang >= 100 && soCanTang < 1000)
                maKH = kyTuDau + "00" + soCanTang;
            if (soCanTang >= 1000 && soCanTang < 10000)
                maKH = kyTuDau + "0" + soCanTang;
            if (soCanTang >= 10000 && soCanTang < 100000)
                maKH = kyTuDau + soCanTang;
            if (soCanTang >= 100000)
                maKH = "Không thể tăng hơn nữa!";

            string cmdKH = "INSERT INTO dbo.Khachhang (MaKH, TenKH, Diachi, Sdt, Email) VALUES  ('" + maKH + "',N'" + TenKH + "',N'" + Diachi + "','" + sdt + "','" + email + "')";
            Layer01.ExecuteNonQuery(cmdKH);


            // Thêm thông tin chung về phiếu mua
            string cmdText = "INSERT INTO dbo.Phieumua ( MaPM , MaKH , MaNV , Ngaymua , Thanhtoan , Ghichu  ) VALUES  ('" + MaHD + "','" + maKH + "','" + MaNV + "','" + Ngaymua + "','" + Tongtien + "',N'" + Ghichu + "')";
            Layer01.ExecuteNonQuery(cmdText);


            // Thêm Danh sách hàng mua và cập nhật số lượng trong kho
            foreach (ChiTietHangHoaDAO item in DanhSachHangBan)
            {
                string cmdText1 = "INSERT INTO dbo.CTPhieumua ( MaPM, MaHH, Soluong, Giavon ) VALUES ('" + MaHD + "','" + item.MaHH + "','" + item.SoLuong + "','" + item.DonGia + "')";
                Layer01.ExecuteNonQuery(cmdText1);
                string cmdText2 = "	UPDATE dbo.Hanghoa SET Soluong = Soluong-" + int.Parse(item.SoLuong) + " WHERE MaHH = '" + item.MaHH + "'";
                Layer01.ExecuteNonQuery(cmdText2);
            }
        }

        #endregion


        //#region Hàng hóa

        //public DataTable TimKiemBangHangHoa(string tenhh, string tennk, string tendm)
        //{
        //    string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
        //       "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
        //       "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
        //       "where TenHH like N'" + tenhh + "%' and TenNK = N'" + tennk + "' and TenDM = N'" + tendm + "'";
        //    DataTable dataTable = Layer01.GetDataTable(cmdText);
        //    return dataTable;
        //}
        //public DataSet LayThongTinHangHoa()
        //{
        //    string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
        //        "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
        //        "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM; " +
        //        "select TenNK from Nhakho; select TenDM from Danhmuc";
        //    DataSet dataSet = Layer01.GetDataSet(cmdText);
        //    return dataSet;
        //}
        //public DataTable HangHoaSapHetHan()
        //{
        //    string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
        //       "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
        //       "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
        //       "where DATEDIFF(year, GETDATE(), Hansudung) = 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) = 0 and DATEDIFF(day, GETDATE(), Hansudung) > 0";
        //    DataTable dataTable = Layer01.GetDataTable(cmdText);
        //    return dataTable;
        //}
        //public DataTable HangHoaDaHetHan()
        //{
        //    string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota " +
        //       "from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN " +
        //       "inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM " +
        //       "where DATEDIFF(year, GETDATE(), Hansudung) = 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) = 0 and DATEDIFF(day, GETDATE(), Hansudung) <= 0";
        //    DataTable dataTable = Layer01.GetDataTable(cmdText);
        //    return dataTable;
        //}

        //#endregion

        #region Phần báo cáo

        public List<BaoCaoXuatKhoDAO> LayDuLieuBaoCaoXuatKho(string MaKho, string MaNCC, DateTime TuNgay, DateTime DenNgay)
        {
            string cmdText;
            if (MaKho.Equals("NK0000") && MaNCC.Equals("NCC00000"))
            {
                cmdText = "SELECT dbo.Phieuxuat.MaPX, dbo.Phieuxuat.Ngayxuat, dbo.Phieuxuat.Ghichu, dbo.CTPhieuxuat.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Soluong, dbo.CTPhieuxuat.Giavon, (CAST(dbo.CTPhieuxuat.Soluong as float) * CAST(dbo.CTPhieuxuat.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieuxuat INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.Phieuxuat.Ngayxuat BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else if (MaKho.Equals("NK0000") && !MaNCC.Equals("NCC00000"))
            {

                cmdText = "SELECT dbo.Phieuxuat.MaPX, dbo.Phieuxuat.Ngayxuat, dbo.Phieuxuat.Ghichu, dbo.CTPhieuxuat.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Soluong, dbo.CTPhieuxuat.Giavon, (CAST(dbo.CTPhieuxuat.Soluong as float) * CAST(dbo.CTPhieuxuat.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieuxuat INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.Hanghoa.MaNCC = '" + MaNCC + "' AND dbo.Phieuxuat.Ngayxuat BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else if (!MaKho.Equals("NK0000") && MaNCC.Equals("NCC00000"))
            {
                cmdText = "SELECT dbo.Phieuxuat.MaPX, dbo.Phieuxuat.Ngayxuat, dbo.Phieuxuat.Ghichu, dbo.CTPhieuxuat.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Soluong, dbo.CTPhieuxuat.Giavon, (CAST(dbo.CTPhieuxuat.Soluong as float) * CAST(dbo.CTPhieuxuat.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieuxuat INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.Phieuxuat.MaNK = '" + MaKho + "' AND dbo.Phieuxuat.Ngayxuat BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else
            {
                cmdText = "SELECT dbo.Phieuxuat.MaPX, dbo.Phieuxuat.Ngayxuat, dbo.Phieuxuat.Ghichu, dbo.CTPhieuxuat.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieuxuat.Soluong, dbo.CTPhieuxuat.Giavon, (CAST(dbo.CTPhieuxuat.Soluong as float) * CAST(dbo.CTPhieuxuat.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieuxuat INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH WHERE dbo.Phieuxuat.MaNK = '" + MaKho + "' AND dbo.Hanghoa.MaNCC = '" + MaNCC + "' AND dbo.Phieuxuat.Ngayxuat BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<BaoCaoXuatKhoDAO> dataBaoCao = new List<BaoCaoXuatKhoDAO>();
            while (dr.Read())
            {
                BaoCaoXuatKhoDAO row = new BaoCaoXuatKhoDAO(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                dataBaoCao.Add(row);
            }
            dr.Close();
            return dataBaoCao;
        }

        public List<BaoCaoNhapKhoDAO> LayDuLieuBaoCaoNhapKho(string MaKho, string MaNCC, DateTime TuNgay, DateTime DenNgay)
        {
            string cmdText;
            if (MaKho.Equals("NK0000") && MaNCC.Equals("NCC00000"))
            {
                cmdText = "SELECT dbo.Phieunhap.MaPN, dbo.Phieunhap.Ngaynhap, dbo.Phieunhap.Ghichu, dbo.CTPhieunhap.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Soluong, dbo.CTPhieunhap.Giavon, (CAST(dbo.CTPhieunhap.Soluong as float) * CAST(dbo.CTPhieunhap.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieunhap INNER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE dbo.Phieunhap.Ngaynhap BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else if (MaKho.Equals("NK0000") && !MaNCC.Equals("NCC00000"))
            {

                cmdText = "SELECT dbo.Phieunhap.MaPN, dbo.Phieunhap.Ngaynhap, dbo.Phieunhap.Ghichu, dbo.CTPhieunhap.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Soluong, dbo.CTPhieunhap.Giavon, (CAST(dbo.CTPhieunhap.Soluong as float) * CAST(dbo.CTPhieunhap.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieunhap INNER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE  dbo.Hanghoa.MaNCC = '" + MaNCC + "' AND dbo.Phieunhap.Ngaynhap BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else if (!MaKho.Equals("NK0000") && MaNCC.Equals("NCC00000"))
            {

                cmdText = "SELECT dbo.Phieunhap.MaPN, dbo.Phieunhap.Ngaynhap, dbo.Phieunhap.Ghichu, dbo.CTPhieunhap.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Soluong, dbo.CTPhieunhap.Giavon, (CAST(dbo.CTPhieunhap.Soluong as float) * CAST(dbo.CTPhieunhap.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieunhap INNER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE dbo.Phieunhap.MaNK = '" + MaKho + "' AND dbo.Phieunhap.Ngaynhap BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            else
            {
                cmdText = "SELECT dbo.Phieunhap.MaPN, dbo.Phieunhap.Ngaynhap, dbo.Phieunhap.Ghichu, dbo.CTPhieunhap.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.CTPhieunhap.Soluong, dbo.CTPhieunhap.Giavon, (CAST(dbo.CTPhieunhap.Soluong as float) * CAST(dbo.CTPhieunhap.Giavon as float) ) AS 'ThanhTien' FROM dbo.Phieunhap INNER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH WHERE dbo.Phieunhap.MaNK = '" + MaKho + "' AND  dbo.Hanghoa.MaNCC = '" + MaNCC + "' AND dbo.Phieunhap.Ngaynhap BETWEEN '" + TuNgay + "' AND '" + DenNgay + "'";
            }
            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<BaoCaoNhapKhoDAO> dataBaoCao = new List<BaoCaoNhapKhoDAO>();
            while (dr.Read())
            {
                BaoCaoNhapKhoDAO row = new BaoCaoNhapKhoDAO(dr[0].ToString(), DateTime.Parse(dr[1].ToString()), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                dataBaoCao.Add(row);
            }
            dr.Close();
            return dataBaoCao;
        }

        public List<BaoCaoNhapXuatTonDAO> LayDuLieuBaoCaoTonKho(string MaKho, int nam, int thang)
        {
            string cmdText = "SELECT dbo.Hanghoa.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.Hanghoa.Soluong AS 'toncuoiky', ( CAST(dbo.Hanghoa.Soluong AS FLOAT) * CAST(dbo.Hanghoa.Giavon AS FLOAT) )  AS 'thanhtiencuoiky', dbo.TonDauKy.Soluong AS 'tondauky',( CAST(dbo.TonDauKy.Soluong AS FLOAT) * CAST(dbo.TonDauKy.GiaVP AS FLOAT) ) AS 'giatritondauky' , dbo.CTPhieunhap.Soluong AS 'slnhap', ( CAST(dbo.CTPhieunhap.Soluong AS FLOAT) * CAST(dbo.CTPhieunhap.Giavon AS FLOAT) ) AS 'thanhtiengianhap', dbo.CTPhieuxuat.Soluong AS 'slxuat', ( CAST(dbo.CTPhieuxuat.Soluong AS FLOAT) * CAST(dbo.CTPhieuxuat.Giavon AS FLOAT) )  AS'thanhtiengiaxuat', dbo.CTPhieumua.Soluong AS 'slmua', ( CAST(dbo.CTPhieumua.Soluong AS FLOAT) * CAST(dbo.CTPhieumua.Giavon AS FLOAT) )  AS 'thanhtiengiamua' , dbo.Phieunhap.MaNK, dbo.Phieuxuat.MaNK FROM    dbo.Hanghoa FULL OUTER JOIN dbo.TonDauKy ON TonDauKy.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.CTPhieumua ON CTPhieumua.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.Phieuxuat ON Phieuxuat.MaPX = CTPhieuxuat.MaPX FULL OUTER JOIN dbo.Phieunhap ON Phieunhap.MaPN = CTPhieunhap.MaPN FULL OUTER JOIN dbo.Phieumua ON Phieumua.MaPM = CTPhieumua.MaPM WHERE MONTH(dbo.Phieunhap.Ngaynhap) = " + thang + " AND YEAR(dbo.Phieunhap.Ngaynhap) = " + nam + "  Or MONTH(dbo.Phieuxuat.Ngayxuat) = " + thang + " AND YEAR(dbo.Phieuxuat.Ngayxuat) = " + nam + " or  MONTH(dbo.Phieumua.Ngaymua) = " + thang + " AND YEAR(dbo.Phieumua.Ngaymua) = " + nam + " ";

            SqlDataReader dr = Layer01.GetExecuteReader(cmdText);
            List<BaoCaoNhapXuatTonDAO> dataBaoCao = new List<BaoCaoNhapXuatTonDAO>();
            while (dr.Read())
            {
                //string mahh, string tenhh, string dvt, string slTonDK, string TTTDK, string sltonCuoiKy, string ttCuoiky, string slnhap, string ttnhap, string slxuat, string ttxuat
                BaoCaoNhapXuatTonDAO row = new BaoCaoNhapXuatTonDAO();
                if (MaKho.Equals("NK0000"))// tất cả nhà kho
                {
                    if (dr[7].ToString().Equals(""))// hàng này không có phiếu nhập
                    {
                        row = new BaoCaoNhapXuatTonDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "0", "0", "0", "0");
                        if (!dr[9].ToString().Equals("") && dr[11].ToString().Equals(""))// hàng có phiếu xuất và không có phiếu mua
                        {
                            row.SLXuat = dr[9].ToString();
                            row.ThanhTienXuat = dr[10].ToString();
                        }
                        else if (dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có phiếu mua và không có phiếu xuất
                        {
                            row.SLXuat = dr[11].ToString();
                            row.ThanhTienXuat = dr[12].ToString();
                        }
                        else if (!dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có cả phiếu mua và phiếu xuất.
                        {
                            row.SLXuat = (int.Parse(dr[11].ToString()) + int.Parse(dr[9].ToString())).ToString();
                            row.ThanhTienXuat = (int.Parse(dr[12].ToString()) + int.Parse(dr[10].ToString())).ToString();
                        }
                    }
                    else// hàng có phiếu nhập
                    {
                        row = new BaoCaoNhapXuatTonDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), "0", "0");
                        if (!dr[9].ToString().Equals("") && dr[11].ToString().Equals(""))// hàng có phiếu xuất và không có phiếu mua
                        {
                            row.SLXuat = dr[9].ToString();
                            row.ThanhTienXuat = dr[10].ToString();
                        }
                        else if (dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có phiếu mua và không có phiếu xuất
                        {
                            row.SLXuat = dr[11].ToString();
                            row.ThanhTienXuat = dr[12].ToString();
                        }
                        else if (!dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có cả phiếu mua và phiếu xuất.
                        {
                            row.SLXuat = (int.Parse(dr[11].ToString()) + int.Parse(dr[9].ToString())).ToString();
                            row.ThanhTienXuat = (int.Parse(dr[12].ToString()) + int.Parse(dr[10].ToString())).ToString();
                        }
                    }
                    dataBaoCao.Add(row);
                }
                else// không phải tất cả nhà kho
                {
                    if (dr[7].ToString().Equals(""))// hàng này không có phiếu nhập
                    {
                        row = new BaoCaoNhapXuatTonDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "0", "0", "0", "0");
                        if (!dr[9].ToString().Equals("") && dr[11].ToString().Equals("") )// hàng có phiếu xuất và không có phiếu mua
                        {
                            row.SLXuat = dr[9].ToString();
                            row.ThanhTienXuat = dr[10].ToString();
                        }
                        else if (dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có phiếu mua và không có phiếu xuất
                        {
                            row.SLXuat = dr[11].ToString();
                            row.ThanhTienXuat = dr[12].ToString();
                        }
                        else if (!dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có cả phiếu mua và phiếu xuất.
                        {
                            row.SLXuat = (int.Parse(dr[11].ToString()) + int.Parse(dr[9].ToString())).ToString();
                            row.ThanhTienXuat = (int.Parse(dr[12].ToString()) + int.Parse(dr[10].ToString())).ToString();
                        }
                        if (dr[14].ToString().Equals(MaKho))// mã kho xuất bằng với mã kho chọn
                        {
                            dataBaoCao.Add(row);
                        }
                    }
                    else if (dr[9].ToString().Equals(""))// hàng không có phiếu xuất
                    {
                        row = new BaoCaoNhapXuatTonDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "0", "0", "0", "0");
                        if (!dr[7].ToString().Equals(""))// có phiếu nhập
                        {
                            row.SLNhap = dr[7].ToString();
                            row.ThanhTienNhap = dr[8].ToString();
                        }
                        if (dr[13].ToString().Equals(MaKho))// mã kho nhập bằng với mã kho chọn
                        {
                            dataBaoCao.Add(row);
                        }
                    }
                    else if (!dr[7].ToString().Equals("") && !dr[9].ToString().Equals(""))// hàng có phiếu nhập và phiếu xuất
                    {
                        // khởi tạo dữ liệu
                         row = new BaoCaoNhapXuatTonDAO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), "0", "0");
                        if (!dr[9].ToString().Equals("") && dr[11].ToString().Equals(""))// hàng có phiếu xuất và không có phiếu mua
                        {
                            row.SLXuat = dr[9].ToString();
                            row.ThanhTienXuat = dr[10].ToString();
                        }
                        else if (dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có phiếu mua và không có phiếu xuất
                        {
                            row.SLXuat = dr[11].ToString();
                            row.ThanhTienXuat = dr[12].ToString();
                        }
                        else if (!dr[9].ToString().Equals("") && !dr[11].ToString().Equals(""))// hàng có cả phiếu mua và phiếu xuất.
                        {
                            row.SLXuat = (int.Parse(dr[11].ToString()) + int.Parse(dr[9].ToString())).ToString();
                            row.ThanhTienXuat = (int.Parse(dr[12].ToString()) + int.Parse(dr[10].ToString())).ToString();
                        }

                        // phiếu nhập và phiếu xuất cùng kho

                        if (dr[13].ToString().Equals(MaKho)&&dr[14].ToString().Equals(MaKho))
                        {
                            dataBaoCao.Add(row);
                        }

                        // phiếu nhập bằng kho chọn và phiếu xuất khác kho chọn
                        else if (dr[13].ToString().Equals(MaKho) && !dr[14].ToString().Equals(MaKho))
                        {
                            row.SLXuat = "0";
                            row.ThanhTienXuat = "0";
                            dataBaoCao.Add(row);
                        }

                        // phiếu nhập khác kho chọn và phiếu xuất cùng kho chọn
                        else  if (!dr[13].ToString().Equals(MaKho) && dr[14].ToString().Equals(MaKho))
                        {
                            row.SLNhap = "0";
                            row.ThanhTienNhap = "0";
                            dataBaoCao.Add(row);
                        }
                    }
                }

            }
            dr.Close();
            return dataBaoCao;
        }

        #endregion


        public DataTable LayTenNhaKho()
        {
            string cmdText = "select * from Nhakho";
            DataTable dt = Layer01.GetDataTable(cmdText);
            return dt;
        }

        public DataTable LayHangTonDauKy(string nhakho, string thoigian)
        {
            string cmdText = "select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM where Nhakho.MaNK = '" + nhakho + "' and Phieunhap.Ngaynhap <= '" + thoigian + "'";
            DataTable dt = Layer01.GetDataTable(cmdText);
            return dt;
        }
    }
}
