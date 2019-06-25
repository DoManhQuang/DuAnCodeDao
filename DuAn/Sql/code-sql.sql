USE master
GO

CREATE DATABASE QLkhohang
GO

USE QLkhohang
GO

CREATE TABLE Nhanvien
    (
      MaNV VARCHAR(10) PRIMARY KEY ,
      Taikhoan VARCHAR(30) NOT NULL ,
      Matkhau VARCHAR(30) NOT NULL ,
      TenNV NVARCHAR(50) NOT NULL ,
      Chucvu NVARCHAR(50) NOT NULL ,
      Ngaysinh DATE NOT NULL ,
      Gioitinh BIT NOT NULL ,
      Diachi NVARCHAR(100) NOT NULL ,
      Sdt VARCHAR(15) NOT NULL ,
      Email VARCHAR(30) NOT NULL ,
      Phanquyen INT, -- bỏ not null
    )
CREATE TABLE Danhmuc
    (
      MaDM VARCHAR(10) PRIMARY KEY ,
      TenDM NVARCHAR(30) NOT NULL,
    )
GO
CREATE TABLE Nhacungcap
    (
      MaNCC VARCHAR(10) PRIMARY KEY ,
      TenNCC NVARCHAR(50) NOT NULL ,
      Diachi NVARCHAR(100) NOT NULL ,
      Sdt VARCHAR(15) NOT NULL ,
      Email VARCHAR(30) NOT NULL,
    )
GO
CREATE TABLE Nhakho
    (
      MaNK VARCHAR(10) PRIMARY KEY ,
      TenNK NVARCHAR(30) NOT NULL ,
      Diachi NVARCHAR(100) NOT NULL,
    )
GO
CREATE TABLE Phieuxuat
    (
      MaPX VARCHAR(10) PRIMARY KEY ,
      MaNK VARCHAR(10) NOT NULL ,
      MaNV VARCHAR(10) NOT NULL ,
      Ngayxuat DATE NOT NULL ,
      Nguoinhanhang NVARCHAR(30) ,
      Ghichu NVARCHAR(100) ,
      Tongtien MONEY ,
      CONSTRAINT FK1_Phieuxuat FOREIGN KEY ( MaNK ) REFERENCES Nhakho ( MaNK ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK2_Phieuxuat FOREIGN KEY ( MaNV ) REFERENCES Nhanvien ( MaNV ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO

CREATE TABLE Hanghoa
    (
      MaHH VARCHAR(10) PRIMARY KEY ,
      TenHH NVARCHAR(50) NOT NULL ,
      Dvt NVARCHAR(50) NOT NULL ,
      Hansudung DATE NOT NULL ,
      Giavon VARCHAR(20) NOT NULL ,
      Soluong VARCHAR(20) NOT NULL ,
      MaDM VARCHAR(10) NOT NULL ,
      Mota NVARCHAR(100) NOT NULL ,
      MaNCC VARCHAR(10) NOT NULL ,
      CONSTRAINT FK1_Hanghoa FOREIGN KEY ( MaDM ) REFERENCES Danhmuc ( MaDM ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK1_Phieunhap FOREIGN KEY ( MaNCC ) REFERENCES Nhacungcap ( MaNCC ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO
CREATE TABLE CTPhieuxuat
    (
      MaPX VARCHAR(10) NOT NULL ,
      MaHH VARCHAR(10) NOT NULL ,
      Soluong VARCHAR(20) NOT NULL ,
      Giavon VARCHAR(20) NOT NULL ,
      CONSTRAINT PK1_CTPX PRIMARY KEY ( MaPX, MaHH ) ,
      CONSTRAINT FK1_CTPX FOREIGN KEY ( MaPX ) REFERENCES Phieuxuat ( MaPX ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK2_CTPX FOREIGN KEY ( MaHH ) REFERENCES Hanghoa ( MaHH ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO
CREATE TABLE Phieunhap
    (
      MaPN VARCHAR(10) PRIMARY KEY ,
      MaNV VARCHAR(10) NOT NULL ,
      MaNK VARCHAR(10) NOT NULL ,
      Ngaynhap DATE NOT NULL ,
      Nguoigiaohang NVARCHAR(30) ,
      Ghichu NVARCHAR(100) ,
      Tongtien MONEY ,
      CONSTRAINT FK2_Phieunhap FOREIGN KEY ( MaNV ) REFERENCES Nhanvien ( MaNV ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK3_Phieunhap FOREIGN KEY ( MaNK ) REFERENCES Nhakho ( MaNK ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO
CREATE TABLE CTPhieunhap
    (
      MaPN VARCHAR(10) NOT NULL ,
      MaHH VARCHAR(10) NOT NULL ,
      Soluong VARCHAR(20) NOT NULL ,
      Giavon VARCHAR(20) NOT NULL ,
      CONSTRAINT PK1_CTPhieunhap PRIMARY KEY ( MaPN, MaHH ) ,
      CONSTRAINT FK1_CTPhieunhap FOREIGN KEY ( MaPN ) REFERENCES Phieunhap ( MaPN ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK2_CTPhieunhap FOREIGN KEY ( MaHH ) REFERENCES Hanghoa ( MaHH ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO

CREATE TABLE Khachhang
    (
      MaKH VARCHAR(10) PRIMARY KEY ,
      TenKH NVARCHAR(50) NOT NULL ,
      Diachi NVARCHAR(100) NOT NULL ,
      Sdt VARCHAR(15) NOT NULL ,
      Email VARCHAR(30) NOT NULL,
    )
GO

CREATE TABLE Phieumua
    (
      MaPM VARCHAR(10) PRIMARY KEY ,
      MaKH VARCHAR(10) NOT NULL ,
      MaNV VARCHAR(10) NOT NULL ,
      Ngaymua DATE NOT NULL ,
      Thanhtoan VARCHAR(20) NOT NULL ,
      Ghichu NVARCHAR(100) ,
      CONSTRAINT FK1_Phieumua FOREIGN KEY ( MaKH ) REFERENCES Khachhang ( MaKH ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK2_Phieumua FOREIGN KEY ( MaNV ) REFERENCES Nhanvien ( MaNV ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO
CREATE TABLE CTPhieumua
    (
      MaPM VARCHAR(10) NOT NULL ,
      MaHH VARCHAR(10) NOT NULL ,
      Soluong VARCHAR(20) NOT NULL ,
      Giavon VARCHAR(20) NOT NULL ,
      CONSTRAINT PK1_CTPhieumua PRIMARY KEY ( MaPM, MaHH ) ,
      CONSTRAINT FK1_CTPhieumua FOREIGN KEY ( MaPM ) REFERENCES Phieumua ( MaPM ) ON UPDATE CASCADE
        ON DELETE CASCADE ,
      CONSTRAINT FK2_CTPhieumua FOREIGN KEY ( MaHH ) REFERENCES Hanghoa ( MaHH ) ON UPDATE CASCADE
        ON DELETE CASCADE,
    )
GO
CREATE TABLE TonDauKy
    (
      MaNK VARCHAR(10) NOT NULL ,
      MaHH VARCHAR(10) NOT NULL ,
      Soluong VARCHAR(20) NOT NULL ,
      GiaVP VARCHAR(20) NOT NULL ,
      CONSTRAINT fk_TonDauKy PRIMARY KEY ( MaNK, MaHH ) ,
      CONSTRAINT fk_TonDauKy_Kho FOREIGN KEY ( MaNK ) REFERENCES dbo.Nhakho ( MaNK ) ,
      CONSTRAINT fk_TonDauKy_HangHoa FOREIGN KEY ( MaHH ) REFERENCES dbo.Hanghoa ( MaHH ),
    )
GO

-- drop table CTPhieumua, Phieumua, CTPhieunhap, Phieunhap, CTPhieuxuat, Hanghoa, Phieuxuat, Nhakho, Nhacungcap, Danhmuc, Nhanvien, Khachhang
INSERT  INTO Nhanvien
VALUES  ( 'NV00000001', 'thunguyenQL', '12345', N'Nguyễn Thị Thu', N'Quản lý',
          '1998/12/22', 1, N'Hòa Bình', '0999999999',
          'domanhquang.rnd@gmail.com', 1 )
INSERT  INTO Nhanvien
VALUES  ( 'NV00000002', 'thunguyen', '12345', N'Nguyễn Thị Thu', N'Bộ phận kho',
          '1998/12/22', 1, N'Hòa Bình', '0999999999',
          'domanhquang.rnd@gmail.com', 2 )
 -- kho
INSERT  INTO Nhanvien
VALUES  ( 'NV00000003', 'thunguyenbanhang', '12345', N'Nguyễn Thị Thu',
          N'Bộ phận bán hàng', '1998/12/22', 1, N'Hòa Bình', '0999999999',
          'domanhquang.rnd@gmail.com', 3 )
 -- bán hàng

INSERT  INTO Nhakho
VALUES  ( 'NK0001', N'Nhà kho Long Biên', N'Hà Nội' )
INSERT  INTO Nhakho
VALUES  ( 'NK0002', N'Nhà kho Gia Lâm', N'Hà Nội' )

INSERT  INTO Nhacungcap
VALUES  ( 'NCC00001', N'Xi măng Phúc Sơn', N'Hà Nam', '0123456789',
          'domanhquang.rnd@gmail.com' )
INSERT  INTO Nhacungcap
VALUES  ( 'NCC00002', N'Xi măng xuân thành', N'Hà Nội', '9876543210',
          'domanhquang.rnd@gmail.com' )



INSERT  INTO Danhmuc
VALUES  ( 'DM00001', N'Xi măng' )
INSERT  INTO Danhmuc
VALUES  ( 'DM00002', N'Cát' )

INSERT  INTO Hanghoa
VALUES  ( 'HH00001', N'Xi măng PS p30', N'Tấn', '2019/10/10', '10000', '260',
          'DM00001', N'Hàng tốt', 'NCC00001' )
INSERT  INTO Hanghoa
VALUES  ( 'HH00002', N'Cát vàng', N'm3', '2019/10/10', '10000', '300',
          'DM00002', N'Hàng tốt', 'NCC00002' )
INSERT  INTO Hanghoa
VALUES  ( 'HH00003', N'Xi măng hoàng thạch', N'Tấn', '2019/06/15', '10000',
          '230', 'DM00001', N'Hàng tốt', 'NCC00002' )


INSERT  INTO Phieunhap
VALUES  ( 'PN00001', 'NV00000002', 'NK0001', '2019/06/09', N'Nguyễn văn A',
          N'Đã giao', 6000000 )
INSERT  INTO Phieunhap
VALUES  ( 'PN00002', 'NV00000002', 'NK0002', '2019/06/09', N'Nguyễn văn B',
          N'Đã giao', 3000000 )

INSERT  INTO CTPhieunhap
VALUES  ( 'PN00001', 'HH00001', '300', '10000' )
INSERT  INTO CTPhieunhap
VALUES  ( 'PN00001', 'HH00002', '300', '10000' )
INSERT  INTO CTPhieunhap
VALUES  ( 'PN00002', 'HH00003', '300', '10000' )



INSERT  INTO dbo.Phieuxuat
        ( MaPX ,
          MaNK ,
          MaNV ,
          Ngayxuat ,
          Nguoinhanhang ,
          Ghichu ,
          Tongtien
        )
VALUES  ( 'PX00001' , -- MaPX - varchar(10)
          'NK0001' , -- MaNK - varchar(10)
          'NV00000003' , -- MaNV - varchar(10)
          GETDATE() , -- Ngayxuat - date
          N'Trọng sơn' , -- Nguoinhanhang - nvarchar(30)
          N'Đã nhận' , -- Ghichu - nvarchar(100)
          35000000  -- Tongtien - money
        )


INSERT  INTO dbo.CTPhieuxuat
        ( MaPX ,
          MaHH ,
          Soluong ,
          Giavon
        )
VALUES  ( 'PX00001' , -- MaPX - varchar(10)
          'HH00001' , -- MaHH - varchar(10)
          '20' , -- Soluong - varchar(20)
          '500000'  -- Giavon - varchar(20)
		 )

INSERT  INTO dbo.CTPhieuxuat
        ( MaPX ,
          MaHH ,
          Soluong ,
          Giavon
        )
VALUES  ( 'PX00001' , -- MaPX - varchar(10)
          'HH00003' , -- MaHH - varchar(10)
          '50' , -- Soluong - varchar(20)
          '500000'  -- Giavon - varchar(20)
        )

INSERT  INTO dbo.TonDauKy
        ( MaNK, MaHH, Soluong, GiaVP )
VALUES  ( 'NK0001', -- MaNK - varchar(10)
          'HH00001', -- MaHH - varchar(10)
          '300', -- Soluong - varchar(20)
          '10000'  -- GiaVP - varchar(20)
          )
INSERT  INTO dbo.TonDauKy
        ( MaNK, MaHH, Soluong, GiaVP )
VALUES  ( 'NK0001', -- MaNK - varchar(10)
          'HH00002', -- MaHH - varchar(10)
          '300', -- Soluong - varchar(20)
          '10000'  -- GiaVP - varchar(20)
          )
INSERT  INTO dbo.TonDauKy
        ( MaNK, MaHH, Soluong, GiaVP )
VALUES  ( 'NK0002', -- MaNK - varchar(10)
          'HH00003', -- MaHH - varchar(10)
          '300', -- Soluong - varchar(20)
          '10000'  -- GiaVP - varchar(20)
          )

INSERT  INTO dbo.Khachhang
        ( MaKH ,
          TenKH ,
          Diachi ,
          Sdt ,
          Email
        )
VALUES  ( 'KH00001' , -- MaKH - varchar(10)
          N'trọng sơn' , -- TenKH - nvarchar(50)
          N'hà nội' , -- Diachi - nvarchar(100)
          '01293847' , -- Sdt - varchar(15)
          'aghs@gmail.com'  -- Email - varchar(30)
        )

INSERT  INTO dbo.Phieumua
        ( MaPM ,
          MaKH ,
          MaNV ,
          Ngaymua ,
          Thanhtoan ,
          Ghichu
        )
VALUES  ( 'PM00001' , -- MaPM - varchar(10)
          'KH00001' , -- MaKH - varchar(10)
          'NV00000003' , -- MaNV - varchar(10)
          GETDATE() , -- Ngaymua - date
          '10000000' , -- Thanhtoan - varchar(20)
          N'Đã thanh toán'  -- Ghichu - nvarchar(100)
        )
INSERT  INTO dbo.CTPhieumua
        ( MaPM ,
          MaHH ,
          Soluong ,
          Giavon
        )
VALUES  ( 'PM00001' , -- MaPM - varchar(10)
          'HH00001' , -- MaHH - varchar(10)
          '20' , -- Soluong - varchar(20)
          '250000'  -- Giavon - varchar(20)
        )
INSERT  INTO dbo.CTPhieumua
        ( MaPM ,
          MaHH ,
          Soluong ,
          Giavon
        )
VALUES  ( 'PM00001' , -- MaPM - varchar(10)
          'HH00003' , -- MaHH - varchar(10)
          '20' , -- Soluong - varchar(20)
          '250000'  -- Giavon - varchar(20)
        )
SELECT  *
FROM    Nhakho
        INNER JOIN Phieunhap ON Nhakho.MaNK = Phieunhap.MaNK
        INNER JOIN CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN
        INNER JOIN Hanghoa ON CTPhieunhap.MaHH = Hanghoa.MaHH
        INNER JOIN Danhmuc ON Danhmuc.MaDM = Hanghoa.MaDM
WHERE   DATEDIFF(YEAR, GETDATE(), Hansudung) = 0
        AND DATEDIFF(MONTH, GETDATE(), Hansudung) = 0
        AND DATEDIFF(DAY, GETDATE(), Hansudung) <= 0

-- SELECT DATEDIFF(day, Hansudung, GETDATE()) AS DateDiff;

-- select * from Nhakho, Nhacungcap, Phieunhap, Danhmuc, Hanghoa, CTPhieunhap

--ALTER TABLE Hanghoa
  --ALTER COLUMN Mota NVARCHAR(100)



  -- Xử lý phiếu xuất

	-- lấy danh sách phiếu xuất
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.Phieuxuat.MaPX ) STT ,
        dbo.Phieuxuat.MaPX AS N'Số phiếu xuất' ,
        dbo.Nhakho.TenNK AS N'Kho' ,
        dbo.Nhanvien.TenNV AS N'Nhân viên' ,
        dbo.Phieuxuat.Ngayxuat AS N'Ngày xuất' ,
        dbo.Phieuxuat.Nguoinhanhang ,
        dbo.Phieuxuat.Ghichu ,
        dbo.Phieuxuat.Tongtien
FROM    dbo.Phieuxuat
        INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieuxuat.MaNV
        INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieuxuat.MaNK


   -- lấy thông tin chi tiết của 1 phiếu xuất
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.CTPhieuxuat.MaHH ) STT ,
        dbo.CTPhieuxuat.MaHH ,
        dbo.Hanghoa.TenHH ,
        dbo.CTPhieuxuat.Soluong ,
        dbo.Hanghoa.Dvt ,
        dbo.CTPhieuxuat.Giavon
FROM    dbo.CTPhieuxuat
        INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH
WHERE   dbo.CTPhieuxuat.MaPX = 'PX00001'

	-- Tìm kiếm phiếu xuất theo mã
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.Phieuxuat.MaPX ) STT ,
        dbo.Phieuxuat.MaPX AS N'Số phiếu xuất' ,
        dbo.Nhakho.TenNK AS N'Kho' ,
        dbo.Nhanvien.TenNV AS N'Nhân viên' ,
        dbo.Phieuxuat.Ngayxuat AS N'Ngày xuất' ,
        dbo.Phieuxuat.Nguoinhanhang ,
        dbo.Phieuxuat.Ghichu ,
        dbo.Phieuxuat.Tongtien
FROM    dbo.Phieuxuat
        INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieuxuat.MaNV
        INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieuxuat.MaNK
WHERE   dbo.Phieuxuat.MaPX LIKE N'%01%'

SELECT  MaPX
FROM    dbo.Phieuxuat
SELECT  *
FROM    dbo.CTPhieuxuat
SELECT  *
FROM    dbo.Hanghoa


SELECT TOP 1
        MaPX
FROM    dbo.Phieuxuat
ORDER BY MaPX DESC 



-- Phần xử lý phiếu nhập hàng
		-- Lấy danh sách phiếu nhập
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.Phieunhap.MaPN ) STT ,
        dbo.Phieunhap.MaPN AS N'Số phiếu nhập' ,
        dbo.Nhakho.TenNK AS N'Kho' ,
        dbo.Nhanvien.TenNV AS N'Nhân viên' ,
        dbo.Phieunhap.Ngaynhap AS N'Ngày nhập' ,
        dbo.Phieunhap.Nguoigiaohang ,
        dbo.Phieunhap.Ghichu ,
        dbo.Phieunhap.Tongtien
FROM    dbo.Phieunhap
        INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieunhap.MaNV
        INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieunhap.MaNK


		-- Lấy thông tin chi tiết phiếu nhập của 1 phiếu nhập
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.CTPhieunhap.MaHH ) STT ,
        dbo.CTPhieunhap.MaHH ,
        dbo.Hanghoa.TenHH ,
        dbo.CTPhieunhap.Soluong ,
        dbo.Hanghoa.Dvt ,
        dbo.CTPhieunhap.Giavon
FROM    dbo.CTPhieunhap
        INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH
WHERE   dbo.CTPhieunhap.MaPN = 'PN00001'


		-- Tìm kiếm phiếu nhập
SELECT  ROW_NUMBER() OVER ( ORDER BY dbo.Phieunhap.MaPN ) STT ,
        dbo.Phieunhap.MaPN AS N'Số phiếu nhập' ,
        dbo.Nhakho.TenNK AS N'Kho' ,
        dbo.Nhanvien.TenNV AS N'Nhân viên' ,
        dbo.Phieunhap.Ngaynhap AS N'Ngày nhập' ,
        dbo.Phieunhap.Nguoigiaohang ,
        dbo.Phieunhap.Ghichu ,
        dbo.Phieunhap.Tongtien
FROM    dbo.Phieunhap
        INNER JOIN dbo.Nhanvien ON Nhanvien.MaNV = Phieunhap.MaNV
        INNER JOIN dbo.Nhakho ON Nhakho.MaNK = Phieunhap.MaNK
WHERE   dbo.Phieunhap.MaPN LIKE N'%01%'

		-- Lấy Đơn vị tính của hàng hóa theo mã
SELECT  *
FROM    dbo.Hanghoa
WHERE   MaHH = 'HH00001'

SELECT TOP 1
        *
FROM    dbo.Phieunhap
ORDER BY MaPN DESC


--SELECT  MaHH ,
--        TenHH ,
--        Dvt ,
--        Soluong ,
--        Giavon ,
--        Mota AS 'Thanhtien'
--FROM    dbo.Hanghoa
--WHERE   MaHH = '1'
		
--UPDATE  dbo.Hanghoa
--SET     Soluong = Soluong + 3
--WHERE   MaHH = 'HH00001'


--SELECT  *
--FROM    dbo.Khachhang



SELECT  *
FROM    dbo.Phieumua
SELECT  *
FROM    dbo.Hanghoa
SELECT  *
FROM    dbo.CTPhieumua
SELECT  *
FROM    dbo.Khachhang


SELECT  *
FROM    dbo.Phieuxuat
SELECT  *
FROM    dbo.Hanghoa
SELECT  *
FROM    dbo.Nhakho
INSERT  INTO dbo.Nhakho
        ( MaNK, TenNK, Diachi )
VALUES  ( 'NK0000', -- MaNK - varchar(10)
          N'Tất cả nhà kho', -- TenNK - nvarchar(30)
          N' '  -- Diachi - nvarchar(100)
          )

SELECT  TenNCC
FROM    dbo.Nhacungcap
WHERE   MaNCC = 'NCC00000'

SELECT  *
FROM    dbo.Nhacungcap
WHERE   MaNCC != 'NCC00000'
INSERT  INTO dbo.Nhacungcap
        ( MaNCC ,
          TenNCC ,
          Diachi ,
          Sdt ,
          Email
        )
VALUES  ( 'NCC00000' , -- MaNCC - varchar(10)
          N'Tất cả nhà cung cấp' , -- TenNCC - nvarchar(50)
          N' ' , -- Diachi - nvarchar(100)
          ' ' , -- Sdt - varchar(15)
          ' '  -- Email - varchar(30)
							
        )

SELECT  *
FROM    dbo.Nhakho
WHERE   dbo.Nhakho.MaNK != 'NK0000'
SELECT  *
FROM    dbo.Phieuxuat
        INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX
        INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH 

-- Báo cáo phiếu xuất theo tháng, kho, nhà cung cấp
SELECT  dbo.Phieuxuat.MaPX ,
        dbo.Phieuxuat.Ngayxuat ,
        dbo.Phieuxuat.Ghichu ,
        dbo.CTPhieuxuat.MaHH ,
        dbo.Hanghoa.TenHH ,
        dbo.Hanghoa.Dvt ,
        dbo.CTPhieuxuat.Soluong ,
        dbo.CTPhieuxuat.Giavon ,
        ( CAST(dbo.CTPhieuxuat.Soluong AS FLOAT)
          * CAST(dbo.CTPhieuxuat.Giavon AS FLOAT) ) AS 'ThanhTien'
FROM    dbo.Phieuxuat
        INNER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaPX = Phieuxuat.MaPX
        INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieuxuat.MaHH
WHERE   dbo.Phieuxuat.MaNK = 'NK0001'
        AND dbo.Hanghoa.MaNCC = 'NCC00001'
        AND dbo.Phieuxuat.Ngayxuat BETWEEN '2019-06-01'
                                   AND     '2019-06-30'



SELECT  *
FROM    dbo.Phieunhap
SELECT  *
FROM    dbo.CTPhieunhap



-- Báo cáo phiếu nhập theo tháng, nhà kho, nhà cung cấp
SELECT  dbo.Phieunhap.MaPN ,
        dbo.Phieunhap.Ngaynhap ,
        dbo.Phieunhap.Ghichu ,
        dbo.CTPhieunhap.MaHH ,
        dbo.Hanghoa.TenHH ,
        dbo.Hanghoa.Dvt ,
        dbo.CTPhieunhap.Soluong ,
        dbo.CTPhieunhap.Giavon ,
        ( CAST(dbo.CTPhieunhap.Soluong AS FLOAT)
          * CAST(dbo.CTPhieunhap.Giavon AS FLOAT) ) AS 'ThanhTien'
FROM    dbo.Phieunhap
        INNER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaPN = Phieunhap.MaPN
        INNER JOIN dbo.Hanghoa ON Hanghoa.MaHH = CTPhieunhap.MaHH
WHERE   dbo.Phieunhap.Ngaynhap BETWEEN '2019-06-2'
                               AND     '2019-07-12'



-- Báo cáo tồn kho

SELECT  dbo.Hanghoa.MaHH, dbo.Hanghoa.TenHH, dbo.Hanghoa.Dvt, dbo.Hanghoa.Soluong AS 'toncuoiky', ( CAST(dbo.Hanghoa.Soluong AS FLOAT) * CAST(dbo.Hanghoa.Giavon AS FLOAT) )  AS 'thanhtiencuoiky', dbo.TonDauKy.Soluong AS 'tondauky',( CAST(dbo.TonDauKy.Soluong AS FLOAT) * CAST(dbo.TonDauKy.GiaVP AS FLOAT) ) AS 'giatritondauky' , dbo.CTPhieunhap.Soluong AS 'slnhap', ( CAST(dbo.CTPhieunhap.Soluong AS FLOAT) * CAST(dbo.CTPhieunhap.Giavon AS FLOAT) ) AS 'thanhtiengianhap'
, dbo.CTPhieuxuat.Soluong AS 'slxuat', ( CAST(dbo.CTPhieuxuat.Soluong AS FLOAT) * CAST(dbo.CTPhieuxuat.Giavon AS FLOAT) )  AS'thanhtiengiaxuat', dbo.CTPhieumua.Soluong AS 'slmua', ( CAST(dbo.CTPhieumua.Soluong AS FLOAT) * CAST(dbo.CTPhieumua.Giavon AS FLOAT) )  AS 'thanhtiengiamua'
, dbo.Phieunhap.MaNK, dbo.Phieuxuat.MaNK
FROM    dbo.Hanghoa FULL OUTER JOIN dbo.TonDauKy ON TonDauKy.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.CTPhieumua ON CTPhieumua.MaHH = Hanghoa.MaHH FULL
 OUTER JOIN dbo.CTPhieunhap ON CTPhieunhap.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.CTPhieuxuat ON CTPhieuxuat.MaHH = Hanghoa.MaHH FULL OUTER JOIN dbo.Phieuxuat ON Phieuxuat.MaPX = CTPhieuxuat.MaPX
 FULL OUTER JOIN dbo.Phieunhap ON Phieunhap.MaPN = CTPhieunhap.MaPN FULL OUTER JOIN dbo.Phieumua ON Phieumua.MaPM = CTPhieumua.MaPM
 WHERE (MONTH(dbo.Phieunhap.Ngaynhap) = 6 AND YEAR(dbo.Phieunhap.Ngaynhap) = 2019)  Or (MONTH(dbo.Phieuxuat.Ngayxuat) = 6 AND YEAR(dbo.Phieuxuat.Ngayxuat) = 2019) or  (MONTH(dbo.Phieumua.Ngaymua) = 6 AND YEAR(dbo.Phieumua.Ngaymua) = 2019) 



select * from CTPhieumua
select * from CTPhieunhap
select * from CTPhieuxuat
select * from Danhmuc
select * from Hanghoa
select * from Khachhang
select * from Nhacungcap
select * from Nhakho
select * from Nhanvien
select * from Phieumua
select * from Phieunhap
select * from Phieuxuat
select * from TonDauKy




insert into dbo.HangHoa values('HH00004',N'Xi măng HB',N'Tấn','29/06/2019 16:23:29','0','0','DM00001', N'OK','NCC00001')