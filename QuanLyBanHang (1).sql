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
----------------------------------------Stored Procedure-------------------------------------
--Them mat hang
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
 
--Them doi tac
Go
CREATE proc prc_InsertDoiTac(@TenDoiTac nvarchar(50),@MaLoaiDoiTac nvarchar(10), @SDT varchar(11), @DiaChi nvarchar(50), @SoTienNo money)
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM DOITAC) + 1
    BEGIN
        INSERT INTO dbo.DOITAC(MaDoiTac,TenDoiTac, MaLoaiDoiTac,SDT, DiaChi, SoTienNo)
        VALUES ('DT'+CAST(@COUNT AS VARCHAR(10)),@TenDoiTac,@MaLoaiDoiTac, @SDT, @DiaChi, @SoTienNo)
    END
END
--Tra cuu doi tac
Go
create proc prc_SearchDoiTac
@TenDoiTac nvarchar(50) = '', 
@TenLoai nvarchar(50)= '', 
@SDT varchar(11)='', 
@DiaChi nvarchar(50)= ''
AS
BEGIN
	select distinct MaDoiTac[Mã đối tác], TenDoiTac[Tên đối tác], d.MaLoaiDoiTac[Mã loại đối tác], SDT,DiaChi[Địa chỉ], SoTienNo[Số tiền nợ], TenLoai[Tên loại] 
	from DOITAC d,LOAIDOITAC ldt 
	where  ((@TenDoiTac like (N'%' + d.TenDoiTac + N'%') or @TenDoiTac = '') AND (@TenLoai like N'%' + ldt.TenLoai + N'%' or @TenLoai = '') AND (@SDT in ('', d.SDT)) AND (@DiaChi like (N'%' + d.DiaChi + N'%') or @DiaChi = '')) AND (d.MaLoaiDoiTac = ldt.MaLoaiDoiTac)
END
--Cap nhat thong tin doi tac
Go
create proc prc_UpdateDoiTac
@TenDoiTac		nvarchar(50),
@MaLoaiDoiTac	nvarchar(10),
@SDT			varchar(11),
@DiaChi			nvarchar(50),
@MaDoiTac		nvarchar(10)
AS
BEGIN
	UPDATE DOITAC
	SET 
		TenDoiTac = @TenDoiTac,
		MaLoaiDoiTac = @MaLoaiDoiTac,
		SDT = @SDT,
		DiaChi = @DiaChi
	WHERE
		MaDoiTac = @MaDoiTac
END
--EXEC prc_UpdateDoiTac N'SLam', N'LDT02', '111', N'TPHCM', N'DT3'
--select * from DOITAC
--prc_SearchDoiTac 'Nguyễn Văn BANh', '', '', ''
--prc_SearchDoiTac '','','',''
--exec prc_SearchDoiTac N'Nguyễn', '','',''
--delete from DOITAC where MaDoiTac='DT6'
--prc_InsertDoiTac N'Nguyễn Văn', 'NCC', 0909009, N'Tiền Giang',0

-- prc_InsertMatHang N'Nguyễn Văn', N'Nam'
 
-- SELECT * FROM NhanVien

--prc_InsertMatHang N'Chip Intel', 15, 'DVT01'
--exec prc_InsertMatHang N'T', 3, 'DVT01'
--select* from MATHANG
--select MaDVT from DVT where TenDVT = N'Cái'
--select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT
--select distinct MaMatHang[Mã mặt hàng], TenMatHang[Tên mặt hàng], SoLuongTon[Số lượng tồn], TenDVT[Tên đơn vị tính], m.MaDVT [Mã đơn vị tính] from MATHANG m,DVT d where m.MaDVT = d.MaDVT and TenMatHang = 'Chip'
--DELETE FROM MATHANG WHERE TenMatHang = 'Chip'
--update LOAIDOITAC set MaLoaiDoiTac = 'LDT01' where TenLoai = N'Khách hàng'
--update LOAIDOITAC set MaLoaiDoiTac = 'LDT02' where TenLoai = N'Nhà cung cấp'
--update DOITAC set MaLoaiDoiTac = 'LDT02' where MaDoiTac = N'DT1'
--select distinct MaDoiTac[Mã đối tác], TenDoiTac[Tên đối tác], d.MaLoaiDoiTac[Mã loại đối tác], SDT,DiaChi[Địa chỉ], SoTienNo[Số tiền nợ], TenLoai[Tên loại] from DOITAC d,LOAIDOITAC ldt where d.MaLoaiDoiTac = ldt.MaLoaiDoiTac