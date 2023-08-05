--create database QLThueXeDap

create table XeDap(
MaXe nvarchar(255) primary key not null,
TenXe nvarchar(255) not null,
ThongTinXe nvarchar(255),
SoLuong int,
GiaThue money,
NameImage nvarchar(255),
TrangThai nvarchar(255),

)
create table KhachHang(
MaKH nvarchar(255) primary key not null,
TenKH nvarchar(255) not null,
DiaChi nvarchar(255)not null,
SDT nvarchar(20),
SoCCCD nvarchar(255) not null,

)
create table NhanVien(
MaNV nvarchar(255) primary key not null,
TenNV nvarchar(255) not null,
Luong money,
ChucVu nvarchar(255),
)
create table TaiKhoan(
IdTaiKhoan nvarchar(255) primary key not null,
TenDangNhap nvarchar(255) not null,
MatKhau nvarchar(255) not null,
MaKH nvarchar(255),
MaNV nvarchar(255),
CONSTRAINT fk_KhachHang
  FOREIGN KEY (MaKH)
  REFERENCES KhachHang  (MaKH),
CONSTRAINT fk_NhanVien
  FOREIGN KEY (MaNV)
  REFERENCES NhanVien  (MaNV),
)
create table DatXe(
MaKH nvarchar(255) not null,
MaXe nvarchar(255),
SoLuongDat int,
YeuCau nvarchar(255),
NgayHenLay datetime,
NgayDatXe datetime,
CONSTRAINT fk_KhachHang_DatXe
  FOREIGN KEY (MaKH)
  REFERENCES KhachHang  (MaKH),
 CONSTRAINT fk_XeDap_DatXe
  FOREIGN KEY (MaXe)
  REFERENCES XeDap(MaXe),
)
create table DonThanhToan(
MaDonThanhToan nvarchar(255) primary key not null,
SoNgaySD int,
SoGioSD int,
NgayKetThuc datetime,
TrangThai nvarchar(255),
TongTien money

)	
create table DonThue(
MaThue nvarchar(255) primary key not null,
TrangThai nvarchar(255),
MaKH nvarchar(255),
CONSTRAINT fk_DonThue_KhachHang
  FOREIGN KEY (MaKH)
  REFERENCES KhachHang(MaKH),
MaNV nvarchar(255),
CONSTRAINT fk_DonThue_NhanVien
  FOREIGN KEY (MaNV)
  REFERENCES NhanVien(MaNV),

MaDonThanhToan nvarchar(255),
 CONSTRAINT fk_DonThue_DonThanhToan
  FOREIGN KEY (MaDonThanhToan)
  REFERENCES DonThanhToan(MaDonThanhToan)
)
create table ChiTietDonThue(
MaThue nvarchar(255),
MaXe nvarchar(255),
SoLuongThue int,
GhiChu nvarchar(255)
CONSTRAINT fk_DonThue_ChiTiet
  FOREIGN KEY (MaThue)
  REFERENCES  DonThue (MaThue),
 CONSTRAINT fk_XeDap_ChiTiet
  FOREIGN KEY (MaXe)
  REFERENCES XeDap(MaXe),
)






