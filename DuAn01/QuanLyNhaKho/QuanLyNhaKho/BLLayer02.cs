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
            string cmdText = "Update Nhanvien set TenNV = N'" + TenNV + "' ,Chucvu = '" + Chucvu + "' , " +
                "Gioitinh = " + Gioitinh + "' , Ngaysinh = '" + Ngaysinh + "', Sdt = '" + Sdt + "', Diachi = '" + Diachi + "', Email = '" + Email + "', Phanquyen = '" + Phanquyen + "' where MaNV = '" + MaNV + "'";
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
        //public int DemMaNV()
        //{
        //    string cmdText = "select count(MaNV) from NhanVien"; //where CustomersName = N'" + tenkh + "'";
        //    SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
        //    if (dataReader.Read())
        //    {
        //        return Int32.Parse(dataReader[0].ToString());
        //    }
        //    return 0;
        //}
        //public string XuLyMaNC(string manc)
        //{
        //    manc = manc.Remove(0, 2);
        //    int mancNew = int.Parse(manc) + 1;
        //    manc = "NC00" + mancNew;
        //    return manc;
        //}
        //public string GetMaNCNew()
        //{
        //    string cmdText = "select dbo.DemsoluongMaNC()";
        //    SqlDataReader dataReader = Layer01.GetExecuteReader(cmdText);
        //    if (dataReader.Read())
        //    {
        //        return XuLyMaNC(dataReader[0].ToString());
        //    }
        //    return null;
        //}
    }
}
