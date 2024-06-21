create database QuanLyXeHoi
go
use QuanLyXeHoi
go
create table Kho(
MaKho char(10) not null primary key,
DiaChi nvarchar(50) null,
QuanLy nvarchar(50) null
);
go 

create table LoaiXe(
MaLoai int not null primary key,
TenLoai nvarchar(50)
);
go
create table XeHoi(
MaXe int primary key not null identity(1,1),
TenXe nvarchar(50) null,
Kho char(10) not null,
NgayNhapKho date null,
MaLoai int not null
);
go
create table DangNhap(
username char(20) not null primary key,
matkhau char(20) null,
PhanQuyen char(20) null
);

alter table XeHoi
add constraint fk_kho
foreign key (Kho)
references Kho(MaKho)

alter table XeHoi
add constraint fk_maloai
foreign key (MaLoai)
References LoaiXe(MaLoai)