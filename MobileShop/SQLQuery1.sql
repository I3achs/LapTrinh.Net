create database MobileShop
use MobileShop
go
create table SanPham
(
	idSP int primary key,
	tenSP nvarchar(50),
	gia float,
	hangSX nvarchar(50)
)
create table KhachHang
(
	idKH int primary key,
	tenKH nvarchar(100),
	diachi nvarchar(max),
	sdt varchar(15)
)
create table DonHang
(
	idDH int primary key,
	idKH int,
	idSP int,
	soluong int,
	ngaymua date
)
create table NguoiDung
(
	idND int primary key,
	tenDN varchar(50),
	MK varchar(50),
)
INSERT INTO SanPham (tenSP, gia, hangSX) VALUES
('iPhone 13', 999.99, 'Apple'),
('Galaxy S21', 799.99, 'Samsung'),
('Xiaomi Mi 11', 749.99, 'Xiaomi');

INSERT INTO KhachHang (tenKH, diachi, sdt) VALUES
('Nguyen Van A', '123 Nguyen Trai, HCM', '0123456789'),
('Tran Thi B', '456 Le Lai, HN', '0987654321');

INSERT INTO NguoiDung (tenDN, MK) VALUES
('admin', '123456'),
('user', 'password');
