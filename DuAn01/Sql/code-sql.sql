CREATE DATABASE QLkhohang
on primary ( name = 'QLkhohang_dat', filename = 'G:\Github Page\DuAnCodeDao\DuAn01\Sql\QLkhohang_dat.mdf', size = 5mb, maxsize = 20mb, filegrowth = 20%)
log on ( name = 'QLkhohang_log', filename = 'G:\Github Page\DuAnCodeDao\DuAn01\Sql\QLkhohang_log.ldf', size = 1mb, maxsize = 10mb, filegrowth = 20%)
go

USE QLKhohang
go

create table Nhanvien(
	MaNV varchar(10) primary key,
	Taikhoan varchar(30) not null,
	Matkhau varchar(30) not null,
	TenNV nvarchar(50) not null,
	Chucvu nvarchar(50) not null,
	Ngaysinh date not null,
	Gioitinh bit not null,
	Diachi nvarchar(100) not null,
	Sdt varchar(15) not null,
	Email varchar(30) not null,
	Phanquyen int not null,
)
create table Danhmuc(
	MaDM varchar(10) primary key,
	TenDM nvarchar(30) not null,
)
go
create table Nhacungcap(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50) not null,
	Diachi nvarchar(100) not null,
	Sdt varchar(15) not null,
	Email varchar(30) not null,
)
go
create table Nhakho(
	MaNK varchar(10) primary key,
	TenNK nvarchar(30) not null,
	Diachi nvarchar(100) not null,
)
go
create table Phieuxuat(
	MaPX varchar(10) primary key,
	MaNK varchar(10) not null,
	MaNV varchar(10) not null,
	Ngayxuat date not null,
	Nguoinhanhang nvarchar(30),
	Ghichu nvarchar(100),
	Tongtien MONEY,
	constraint FK1_Phieuxuat foreign key (MaNK) references Nhakho(MaNK)
	on update cascade on delete cascade,
	constraint FK2_Phieuxuat foreign key (MaNV) references Nhanvien(MaNV)
	on update cascade on delete cascade,
)
go

create table Hanghoa(
	MaHH varchar(10) primary key,
	TenHH nvarchar(50) not null,
	Dvt nvarchar(50) not null,
	Hansudung date not null,
	Giavon varchar(20) not null,
	Soluong varchar(20) not null,
	MaDM varchar(10) not null,
	Mota nvarchar(100) not null,
	MaNCC varchar(10) not null,
	constraint FK1_Hanghoa foreign key (MaDM) references Danhmuc(MaDM)
	on update cascade on delete cascade,
	constraint FK1_Phieunhap foreign key (MaNCC) references Nhacungcap(MaNCC)
	on update cascade on delete cascade,
)
go
create table CTPhieuxuat(
	MaPX varchar(10) not null,
	MaHH varchar(10) not null,
	Soluong varchar(20) not null,
	Giavon varchar(20) not null,
	constraint PK1_CTPX primary key (MaPX,MaHH),
	constraint FK1_CTPX foreign key (MaPX) references Phieuxuat(MaPX)
	on update cascade on delete cascade,
	constraint FK2_CTPX foreign key (MaHH) references Hanghoa(MaHH)
	on update cascade on delete cascade,
)
go
create table Phieunhap(
	MaPN varchar(10) primary key,
	MaNV varchar(10) not null,
	MaNK varchar(10) not null,
	Ngaynhap date not null,
	Nguoigiaohang nvarchar(30),
	Ghichu nvarchar(100),
	Tongtien MONEY,
	constraint FK2_Phieunhap foreign key (MaNV) references Nhanvien(MaNV)
	on update cascade on delete cascade,
	constraint FK3_Phieunhap foreign key (MaNK) references Nhakho(MaNK)
	on update cascade on delete cascade,
)
go
create table CTPhieunhap(
	MaPN varchar(10) not null,
	MaHH varchar(10) not null,
	Soluong varchar(20) not null,
	Giavon varchar(20) not null,
	constraint PK1_CTPhieunhap primary key (MaPN,MaHH),
	constraint FK1_CTPhieunhap foreign key (MaPN) references Phieunhap(MaPN)
	on update cascade on delete cascade,
	constraint FK2_CTPhieunhap foreign key (MaHH) references Hanghoa(MaHH)
	on update cascade on delete cascade,
)
go

create table Khachhang(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50) not null,
	Diachi nvarchar(100) not null,
	Sdt varchar(15) not null,
	Email varchar(30) not null,
)
go

create table Phieumua(
	MaPM varchar(10) primary key,
	MaKH varchar(10) not null,
	MaNV varchar(10) not null,
	Ngaymua date not null,
	Thanhtoan varchar(20) not null,
	Ghichu nvarchar(100),
	constraint FK1_Phieumua foreign key (MaKH) references Khachhang(MaKH)
	on update cascade on delete cascade,
	constraint FK2_Phieumua foreign key (MaNV) references Nhanvien(MaNV)
	on update cascade on delete cascade,
)
go
create table CTPhieumua(
	MaPM varchar(10) not null,
	MaHH varchar(10) not null,
	Soluong varchar(20) not null,
	Giavon varchar(20) not null,
	constraint PK1_CTPhieumua primary key (MaPM,MaHH),
	constraint FK1_CTPhieumua foreign key (MaPM) references Phieumua(MaPM)
	on update cascade on delete cascade,
	constraint FK2_CTPhieumua foreign key (MaHH) references Hanghoa(MaHH)
	on update cascade on delete cascade,
)
go
--drop table CTPhieumua, Phieumua, CTPhieunhap, Phieunhap, CTPhieuxuat, Hanghoa, Phieuxuat, Nhakho, Nhacungcap, Danhmuc, Nhanvien, Khachhang
insert into Nhanvien values ('NV00000001','manhquang','quang1412',N'Đỗ Mạnh Quang','CEO','1998/12/22',1,N'Hòa Bình','0999999999','domanhquang.rnd@gmail.com',1)
insert into Nhanvien values ('NV00000002','trongson','son1412',N'Chu Trọng Sơn','CTO','1998/12/22',1,N'Hòa Bình','0999999999','domanhquang.rnd@gmail.com',2) -- kho
insert into Nhanvien values ('NV00000003','nguyenthu','thu1412',N'Nguyễn Thu','CMO','1998/12/22',0,N'Hòa Bình','0999999999','domanhquang.rnd@gmail.com',3) -- bán hàng

insert into Nhakho values ('NK0001',N'Nhà kho 01',N'Hà Nội')
insert into Nhakho values ('NK0002',N'Nhà kho 02',N'Hồ Chí Minh')

insert into Nhacungcap values ('NCC00001',N'Nhà cung cấp 01',N'Hà Nội','0123456789','domanhquang.rnd@gmail.com')
insert into Nhacungcap values ('NCC00002',N'Nhà cung cấp 02',N'Hồ Chí Minh','9876543210','domanhquang.rnd@gmail.com')

insert into Phieunhap values ('PN00001','NV00000002','NK0001','2019/06/09',N'Nguyễn văn A',N'Đã giao', 3000000)
insert into Phieunhap values ('PN00002','NV00000002','NK0002','2019/06/09',N'Nguyễn văn B',N'Đã giao',3000000)

insert into Danhmuc values ('DM00001',N'Danh mục 01')
insert into Danhmuc values ('DM00002',N'Danh mục 02')

insert into Hanghoa values ('HH00001',N'Hàng hóa 01',N'Tấn','2019/10/10','10000','300','DM00001',N'Hàng tốt','NCC00001')
insert into Hanghoa values ('HH00002',N'Hàng hóa 02',N'Tấn','2019/10/10','10000','300','DM00002',N'Hàng tốt','NCC00002')
insert into Hanghoa values ('HH00003',N'Hàng hóa 03',N'Tạ','2019/06/15','10000','300','DM00001',N'Hàng tốt','NCC00002')
insert into Hanghoa values ('HH00004',N'Hàng hóa 04',N'Yến','2019/06/15','10000','300','DM00002',N'Hàng tốt','NCC00001')
insert into Hanghoa values ('HH00005',N'Hàng hóa 05',N'Yến','2019/06/09','10000','300','DM00002',N'Hàng tốt','NCC00002')
insert into Hanghoa values ('HH00006',N'Hàng hóa 06',N'Yến','2019/06/07','10000','300','DM00002',N'Hàng tốt','NCC00001')


insert into CTPhieunhap values ('PN00001','HH00001','10000','300')
insert into CTPhieunhap values ('PN00001','HH00002','10000','300')
insert into CTPhieunhap values ('PN00002','HH00003','10000','300')
insert into CTPhieunhap values ('PN00002','HH00004','10000','300')
insert into CTPhieunhap values ('PN00001','HH00005','10000','300')
insert into CTPhieunhap values ('PN00002','HH00006','10000','300')

select Hanghoa.MaHH, TenHH, Dvt, Hansudung, Hanghoa.Giavon, Hanghoa.Soluong, TenDM, TenNK, Mota 
from Nhakho inner join Phieunhap on Nhakho.MaNK = Phieunhap.MaNK 
inner join CTPhieunhap on CTPhieunhap.MaPN = Phieunhap.MaPN 
inner join Hanghoa on CTPhieunhap.MaHH = Hanghoa.MaHH 
inner join Danhmuc on Danhmuc.MaDM = Hanghoa.MaDM 
where DATEDIFF(year, GETDATE(), Hansudung) = 0 and DATEDIFF(MONTH, GETDATE(), Hansudung) = 0 and DATEDIFF(day, GETDATE(), Hansudung) <= 0

-- SELECT DATEDIFF(day, Hansudung, GETDATE()) AS DateDiff;

-- select * from Nhakho, Nhacungcap, Phieunhap, Danhmuc, Hanghoa, CTPhieunhap

--ALTER TABLE Hanghoa
  --ALTER COLUMN Mota NVARCHAR(100)

  select * from Nhanvien
  Update Nhanvien set Taikhoan = 'quangdo' ,Matkhau = '1412' where MaNV = 'NV00000001'