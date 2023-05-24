CREATE DATABASE SQL_QLCafe
GO

USE SQL_QLCafe
GO

CREATE TABLE NHANVIEN
(
	MaNV varchar(20) PRIMARY KEY,
	MatKhau nvarchar(50) NOT NULL,
	HoTen nvarchar(50),
	ChucVu nvarchar(50),
)
GO

INSERT INTO NHANVIEN(MaNV,MatKhau,HoTen,ChucVu) VALUES
('4701104094','4701104094',N'Đặng Quốc Hưng',N'Quản lý'),
('4701104109','4701104109',N'Trần Nguyên Khang',N'Thu ngân'),
('4701104150','4701104150',N'Đặng Minh Nhật',N'Pha chế'),
('4701104238','4701104238',N'Nguyễn Hoàng Quốc Việt',N'Phục Vụ')
GO

CREATE TABLE KHOHANG
(
	TenSP nvarchar(100),
	SoLuong int,
)
GO

INSERT INTO KHOHANG(TenSP, SoLuong) VALUES
(N'sữa',100),
(N'cafe gói',100),
(N'trà đào gói',100),
(N'trà vải gói',100),
(N'trà chanh gói',100),
(N'trà tắc gói',100),
(N'cà rốt',100),
(N'xoài',100),
(N'bơ',100),
(N'dâu',100),
(N'bánh bông lan',100),
(N'bánh flan',100),
(N'bánh donut',100),
(N'kem vani',100),
(N'kem socola',100)
GO


update KHOHANG set SoLuong=97 where TenSP=N'cà rốt'