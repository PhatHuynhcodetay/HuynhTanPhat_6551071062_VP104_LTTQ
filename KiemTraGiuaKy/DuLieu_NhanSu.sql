CREATE DATABASE DuLieu_NhanSu;
USE DuLieu_NhanSu;

CREATE TABLE NhanVien(
    MaNhanVien NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenNhanVien NTEXT NOT NULL,
    LuongCoBan NVARCHAR(12) NOT NULL
);

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, LuongCoBan)VALUES 
    (N'NV001', N'Nguyễn Văn A', N'8,000,000'),
    (N'NV002', N'Trần Thị B', N'7,500,000'),
    (N'NV003', N'Lê Văn C', N'9,000,000'),
    (N'NV004', N'Phạm Thị D', N'6,800,000'),
    (N'NV005', N'Hoàng Văn E', N'8,200,000');

SELECT * FROM NhanVien; --test db

