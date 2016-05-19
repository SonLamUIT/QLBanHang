CREATE DATABASE	QuanLyBanHang
USE QuanLyBanHang

CREATE TABLE LOAIDOITAC
(
	MaLoaiDoiTac		nvarchar(10) primary key,
	TenLoai				nvarchar(50)
)

CREATE TABLE DOITAC
(
	MaDoiTac			nvarchar(10) primary key,
	TenDoiTac			nvarchar(50),
	MaLoaiDoiTac		nvarchar(10) foreign key references LOAIDOITAC(MaLoaiDoiTac),
	SDT					varchar(11),
	DiaChi				nvarchar(50),
	SoTienNo			money
)

CREATE TABLE DONDATHANG_NCC
(
	SoDDH_NCC			nvarchar(10) primary key,
	MaDoiTac			nvarchar(10) foreign key references DOITAC(MaDoiTac),
	Ngaylap				smalldatetime
)

CREATE TABLE DVT
(
	MaDVT				nvarchar(10) primary key,
	TenDVT				nvarchar(10)
)

CREATE TABLE MATHANG
(
	MaMatHang			nvarchar(10) primary key,
	TenMatHang			nvarchar(50),
	SoLuongTon			int,
	MaDVT				nvarchar(10) foreign key references DVT(MaDVT)
)


CREATE TABLE CT_DDH_NCC
(
	SoDDH_NCC			nvarchar(10) foreign key references DONDATHANG_NCC(SoDDH_NCC),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuongDat			int,
	SoLuongDaNhap		int,
	constraint PK_CT_DDH_NCC primary key (SoDDH_NCC,MaMatHang)
)

CREATE TABLE PHIEUNHAPHANG
(
	SoPNH				nvarchar(10) primary key,
	SoDDH_NCC			nvarchar(10) foreign key references DONDATHANG_NCC(SoDDH_NCC),
	NgayNhap			smalldatetime,
	TongTien			money,
	ThanhToan			money,
	ConLai				money
)

CREATE TABLE CT_PNH
(
	SoPNH				nvarchar(10) foreign key references PHIEUNHAPHANG(SoPNH),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuongChuaNhap		int,
	SoLuongNhap			int,
	DonGiaNhap			money,
	ThanhTien			money,
	constraint PK_CT_PNH primary key (SoPNH,MaMatHang)
)

CREATE TABLE PHIEUTHUCHI
(
	SoPTC				nvarchar(10) primary key,
	NgayLap				smalldatetime,
	MaDoiTac			nvarchar(10) foreign key references DOITAC(MaDoiTac),
	TongNo				money,
	SoTien				money
)

CREATE TABLE HOADONBANLE
(
	SoHD				varchar(10) primary key,
	TenKH				nvarchar(50) ,
	NgayLap				smalldatetime,
	TongThanhTien		money
)

CREATE TABLE CT_HDBL
(
	SoHD				varchar(10) foreign key references HOADONBANLE(SoHD),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuong				int,
	DonGia				money,
	ThanhTien			money,
	constraint PK_CT_HDBL primary key (SoHD, MaMatHang)
)

CREATE TABLE DONDATHANG_KH
(
	SoDDH_KH			nvarchar(10) primary key,
	MaDoiTac			nvarchar(10) foreign key references DOITAC(MaDoiTac),
	NgayLap				smalldatetime,
	NgayGiaoHangDuKien		smalldatetime
)

CREATE TABLE CT_DDH_KH
(
	SoDDH_KH			nvarchar(10) foreign key references DONDATHANG_KH(SoDDH_KH),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuongDat			int,
	SoLuongDaGiao		int,
	constraint PK_CT_DDH_KH primary key(SoDDH_KH, MaMatHang)
)

CREATE TABLE PHIEUGIAOHANG
(
	SoPGH				nvarchar(10) primary key,
	SoDDH_KH			nvarchar(10) foreign key references DONDATHANG_KH(SoDDH_KH),
	NgayGiao			smalldatetime,
	TongTien			money,
	ThanhToan			money,
	ConLai				money
)
CREATE TABLE CT_PHIEUGIAOHANG
(
	SoPGH				nvarchar(10) foreign key references PHIEUGIAOHANG(SoPGH),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuongChuaGia		int,
	SoLuongDaGiao		int,
	DonGia				money,
	ThanhTien			money
	constraint PK_CT_PHIEUGIAOHANG primary key	(SoPGH, MaMatHang)
)

CREATE TABLE BAOCAOLOINHUAN
(
	MaBCLN				nvarchar(10) primary key,
	Ngay				int,
	Thang				int,
	Nam					int,
	TongLoiNhuan		money

)

CREATE TABLE CT_BAOCAOLOINHUAN
(
	MaBCLN				nvarchar(10) foreign key references BAOCAOLOINHUAN(MaBCLN),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	SoLuongBanLe		int,
	SoLuongBanSi		int,
	LoiNhuan			money,
	TiLe				float,
	constraint PK_CT_BAOCAOLOINHUAN primary key (MaBCLN, MaMatHang)
)

CREATE TABLE BAOCAOTON
(
	MaBCT				nvarchar(10) primary key,
	Ngay				int,
	Thang				int,
	Nam					int

)

CREATE TABLE CT_BAOCAOTON
(
	MaBCT				nvarchar(10) foreign key references BAOCAOTON(MaBCT),
	MaMatHang			nvarchar(10) foreign key references MATHANG(MaMatHang),
	TonDauKy			int,
	SoLuongNhap			int,
	SoLuongXuat			int,
	TonCuoiKy			int
	constraint PK_CT_BAOCAOTON primary key (MaBCT, MaMatHang)
)

CREATE TABLE BAOCAOCONGNO
(
	MaBCCN				nvarchar(10) primary key,
	Thang				int,
	Nam					int,
	MaLoaiDoiTac		nvarchar(10) foreign key references LOAIDOITAC(MaLoaiDoiTac)	
)

CREATE TABLE CT_BAOCAOCONGNO
(
	MaBCCN				nvarchar(10) foreign key references BAOCAOCONGNO(MaBCCN),
	MaDoiTac			nvarchar(10) foreign key references DOITAC(MaDoiTac),
	NoDauKy				money,
	PhatSinh			money,
	NoCuoiKy			money,
	constraint PK_CT_BAOCAOCONGNO primary key (MaBCCN, MaDoiTac)	
)

CREATE TABLE THAMSO
(
	MaThamSo			nvarchar(10),
	TiLeGiaSi			money,
	TiLeGiaLe			money,

)

SET DATEFORMAT DMY
--USE master
--DROP DATABASE QuanLyBanHang

Go
CREATE proc prc_InsertMatHang(@TenMatHang nvarchar(50),@SoLuongTon int, @MaDVT nvarchar(10))
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM MATHANG) + 1
    BEGIN
        INSERT INTO dbo.MATHANG(MaMatHang,TenMatHang,SoLuongTon, MaDVT)
        VALUES ('MH'+CAST(@COUNT AS VARCHAR(10)),@TenMatHang,@SoLuongTon, @MaDVT)
    END
END
 
-- prc_InsertMatHang N'Nguyễn Văn', N'Nam'
 
-- SELECT * FROM NhanVien

prc_InsertMatHang N'Chip Intel', 15, 'DVT01'
select* from MATHANG
select MaDVT from DVT where TenDVT = N'Cái'