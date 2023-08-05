
insert into XeDap values 
('Xe001',N'Xe đạp thể thao Fornix FX24 2022',N'Cỡ vành 24 inches vùng với khung xe kiểu dáng thể thao gọn gàng thích hợp cho các bạn từ 1M4-1M65, Hoặc từ 10 tuổi',10,40000,N'Tốt','Xe001.png'),

('Xe002',N'Xe đạp thể thao Asama Flow 6 24" FL2401',N'Khung Flow 6 được làm từ thép chịu lực cho tải trọng lên tới 120kg',10,50000,N'Tốt','Xe002.png'),

('Xe003',N'Xe đạp thể thao Hiland Warrior 24 Inch',N' Xe vượt qua những đoạn đường kém bằng phẳng một cách êm ái',10,50000,N'Tốt','Xe003.png'),
('Xe004',N'Xe đạp thể thao TrinX M114 2022','',10,50000,N'Tốt','Xe004.png'),
('Xe005',N'Xe đạp thể thao Fornix M8','',10,50000,N'Tốt','Xe005.png'),
('Xe006',N'Xe đạp thể thao LIFE Mardox 27.5','',10,50000,N'Tốt','Xe006.png')

insert into NhanVien values
('NV001',N'Nguyễn Văn A',5000000,N'Nhân viên'),
('NV002',N'Đỗ Thị B',5000000,N'Nhân viên'),
('NV003',N'Vũ Xuân D',5000000,N'Nhân viên'),
('NV004',N'Trân Tiễn A',15000000,N'Quản lý')

insert into KhachHang values
('KH0001',N'Nguyễn Tuấn C ',N'Mai Dịch - Cầu Giấy - Hà Nội','0356961220','02245652'),
('KH0002',N'Trần Thu H',N'Dương Nội - Hà Đông - Hà Nội','0376879619','02378236'),
('KH0003',N'Lê Xuân Đ ',N'Giảng Võ - Ba Đình - Hà Nội','0368792217','02122445'),
('KH0004',N'Dương Thị  L',N'Dịch Vọng Hậu - Cầu Giấy- Hà Nội','0347991622','02981265'),
('KH0005',N'Đỗ Thị P ',N'Dịch Vọng - Cầu Giấy - Hà Nội','0389752123','02871625'),
('KH0006',N'Nguyễn Huyền T ',N'Láng Hạ - Đống Đa - Hà Nội','0359812367','02352751')
insert into DatXe values
('KH0001','Xe002',1,N'Không','2022-10-30 10:00:00','2022-10-29 9:00:00'),
('KH0001','Xe001',1,N'Không','2022-10-28 10:00:00','2022-10-28 8:00:00'),
('KH0004','Xe004',1,N'Không','2022-10-28 13:30:00','2022-10-28 7:30:00'),
('KH0005','Xe003',1,N'Không','2022-10-25 15:00:00','2022-10-29 8:00:00'),
('KH0006','Xe004',1,N'Không','2022-11-01 10:00:00','2022-10-29 8:30:00'),
('KH0002','Xe005',1,N'Không','2022-10-30 10:00:00','2022-10-28 7:00:00')

insert into DonThanhToan (MaDonThanhToan,SoNgaySD,SoGioSD,TrangThai) values
('DonThanhToan0001',1,0,N'Bình Thường'),
('DonThanhToan0002',0,1,N'Bình Thường'),
('DonThanhToan0003',0,2,N'Bình Thường'),
('DonThanhToan0004',0,4,N'Bình Thường'),
('DonThanhToan0005',2,0,N'Bình Thường'),
('DonThanhToan0006',2,1,N'Bình Thường')

insert into DonThue values
('DonThue0001','','KH0001','NV001','DonThanhToan0002'),
('DonThue0002','','KH0001','NV002','DonThanhToan0001'),
('DonThue0003','','KH0005','NV002','DonThanhToan0004'),
('DonThue0004','','KH0006','NV001','DonThanhToan0003'),
('DonThue0005','','KH0002','NV003','DonThanhToan0005'),
('DonThue0006','','KH0003','NV002','DonThanhToan0006')


insert into ChiTietDonThue values
('DonThue0001','Xe002',1,''),
('DonThue0002','Xe001',1,''),
('DonThue0003','Xe003',1,''),
('DonThue0004','Xe004',1,''),
('DonThue0005','Xe005',1,''),
('DonThue0006','Xe001',1,'')




