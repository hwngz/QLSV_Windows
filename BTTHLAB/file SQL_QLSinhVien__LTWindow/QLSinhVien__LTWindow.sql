create database QLSinhVien
go
use QLSinhVien

create table Khoa
(
	MaKhoa varchar(10) CONSTRAINT K_MK_PK PRIMARY KEY,
	TenKhoa NVARCHAR(100) CONSTRAINT K_TK_U UNIQUE
)
create table Lop
(
	MaLop VARCHAR(10) CONSTRAINT L_ML_PK PRIMARY KEY,
	TenLop NVARCHAR(100) CONSTRAINT L_TL_NN NOT NULL,
	MaKhoa VARCHAR(10) CONSTRAINT L_MK_FK FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
)
create table SinhVien
(
	MaSinhVien VARCHAR(10) CONSTRAINT SV_MSV_PK PRIMARY KEY,
	HoTen NVARCHAR(100) CONSTRAINT SV_HOTEN_NN NOT NULL,
	NgaySinh DATE CONSTRAINT SV_NS_NN NOT NULL,
	MaLop VARCHAR(10) CONSTRAINT SV_ML_FK FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
)
create table MonHoc
(
	MaMonHoc VARCHAR(10) CONSTRAINT MH_MAMH_PK PRIMARY KEY,
	TenMonHoc NVARCHAR(100) CONSTRAINT MH_TENMH_NN NOT NULL,
)
create table Diem
(
	MaSinhVien VARCHAR(10) CONSTRAINT D_MASV_FK FOREIGN KEY (MaSinhVien) references  SinhVien(MaSinhVien),
	MaMonHoc varchar(10) constraint D_MaMonHoc_FK FOREIGN KEY (MaMonHoc) references MonHoc (MaMonHoc),
	Diem float constraint D_DIEM_NN NOT NULL
)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES
('MK001', N'Công Nghệ Thông Tin'),
('MK002', N'Sinh học'),
('MK003', N'Hóa học'),
('MK004', N'Vật Lý học'),
('MK005', N'Địa Lý')

insert into Lop(MaLop,TenLop, MaKhoa) values
('ML001', N'Sư Phạm Tin', 'MK001'),
('ML002', N'Công Nghệ Thông Tin', 'MK001'),
('ML003', N'Sư phạm Sinh học', 'MK002'),
('ML004', N'Sư phạm KHTN', 'MK003'),
('ML005', N'Sư phạm Địa Lý', 'MK005')


insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) values
('SV001', N'Tăng Ngọc Phụng', '2002-6-12', 'ML001'),
('SV002',N'Tăng Kim Hồng', '1964-2-14', 'ML002'),
('SV003', N'Tăng Khải Quang', '1992-5-9', 'ML003'),
('SV004', N'Tăng Khãi Chung', '1997-8-3','ML005'),
('SV005', N'Diệp Quân Hỷ', '1968-1-19', 'ML004')
INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES
('MH001', N'Lập trình cơ bản'),
('MH002', N'Lập trình Windows'),
('MH003', N'Lập trình hướng đối tượng'),
('MH004', N'Lập trình nâng cao'),
('MH005', N'Cơ sở dữ liệu')
insert into DIEM(MaSinhVien, MaMonHoc,Diem) VALUES
('SV001', 'MH001', 8.9),
('SV001', 'MH002', 9.0),
('SV002', 'MH001', 7.8),
('SV003', 'MH005', 8.0),
('SV004', 'MH003', 7.8),
('SV005','MH004', 3.6)

select * from Khoa order by MaKhoa
SELECT * FROM MonHoc
select * from SinhVien
delete from SinhVien where MaSinhVien = 'SV001'
SELECT *  FROM Diem

select  NgaySinh, CONVERT(varchar(12), NgaySinh,103)  from SinhVien

select * from Lop