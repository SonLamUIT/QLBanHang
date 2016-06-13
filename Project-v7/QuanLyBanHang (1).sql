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
	TiLeGiaSi			float,
	TiLeGiaLe			float,

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

--Them vao HOADONBANLE
GO
Create proc prc_InsertHoaDonBanLe(@TenKH nvarchar(50),@NgayLap smalldatetime, @TongThanhTien money)
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM HOADONBANLE) + 1
    BEGIN
        INSERT INTO dbo.HOADONBANLE(SoHD, TenKH, NgayLap, TongThanhTien)
        VALUES ('HDBL'+CAST(@COUNT AS VARCHAR(10)),@TenKH,@NgayLap, @TongThanhTien)
    END
END

--Them vao DONDATHANG_KH
GO
Create proc prc_InsertDONDATHANG_KH(@MaDoiTac nvarchar(10),@NgayLap smalldatetime, @NgayGiaoDuKien smalldatetime)
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM DONDATHANG_KH) + 1
    BEGIN
        INSERT INTO dbo.DONDATHANG_KH(SoDDH_KH, MaDoiTac, NgayLap, NgayGiaoHangDuKien)
        VALUES ('DDHKH'+CAST(@COUNT AS VARCHAR(10)),@MaDoiTac,@NgayLap, @NgayGiaoDuKien)
    END
END
--Them vao PhieuGiaoHang
GO
Create proc prc_InsertPHIEUGIAOHANG(@SoDDH_KH nvarchar(10),@NgayGiao smalldatetime, @TongTien money, @ThanhToan money, @ConLai money)
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM PHIEUGIAOHANG) + 1
    BEGIN
        INSERT INTO dbo.PHIEUGIAOHANG(SoPGH, SoDDH_KH, NgayGiao, TongTien, ThanhToan, ConLai)
        VALUES ('PGH'+CAST(@COUNT AS VARCHAR(10)),@SoDDH_KH, @NgayGiao, @TongTien, @ThanhToan, @ConLai)
    END
END
--Them Bao Cao Cong No
GO
Create proc prc_InsertBAOCAOCONGNO(@Thang int, @Nam int, @MaLoaiDoiTac nvarchar(10))
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM BAOCAOCONGNO) + 1
    BEGIN
        INSERT INTO dbo.BAOCAOCONGNO(MaBCCN, Thang, Nam, MaLoaiDoiTac)
        VALUES ('BCCN'+CAST(@COUNT AS VARCHAR(10)),@Thang, @Nam, @MaLoaiDoiTac)
    END
END

--Them DONDATHANG_NCC
Go
CREATE proc prc_InsertDonDatHang_NCC(@MaDoiTac nvarchar(10),@NgayLap smalldatetime)
AS
BEGIN
    DECLARE @COUNT AS INT
    SELECT @COUNT = (SELECT COUNT(*) FROM DONDATHANG_NCC) + 1
    BEGIN
        INSERT INTO dbo.DONDATHANG_NCC(SoDDH_NCC,MaDoiTac, Ngaylap)
        VALUES ('SoDDH'+CAST(@COUNT AS VARCHAR(10)),@MaDoiTac,@NgayLap)
    END
END

---drop proc prc_InsertDonDatHang_NCC
--prc_InsertDonDatHang_NCC N'DT04', '27/05/2016'
--prc_InsertDonDatHang_NCC N'DT02', '27/05/2016'

---prc_InsertDonDatHang_NCC N'DT01','1/1/2000'
--Them CT_DONDATHANG_NCC
Go
CREATE proc prc_InsertCT_DDH_NCC(@SoDDH_NCC nvarchar(10), @MaMatHang nvarchar(10),@SoLuongDat int, @SoLuongDaNhap int)
AS
BEGIN
    INSERT INTO dbo.CT_DDH_NCC(SoDDH_NCC,MaMatHang, SoLuongDat,SoLuongDaNhap)
    VALUES (@SoDDH_NCC,@MaMatHang, @SoLuongDat,@SoLuongDaNhap)
END
--Cap Nhat Tham So
GO
Create Proc prc_UpdateThamSo
@TiLeGiaSi				float,
@TiLeGiaLe				float
AS
BEGIN
	UPDATE THAMSO
	SET TiLeGiaLe = @TiLeGiaLe, TiLeGiaSi = @TiLeGiaSi
END

delete CT_PHIEUGIAOHANG
delete PHIEUGIAOHANG
delete CT_DDH_KH
delete DONDATHANG_KH
delete CT_BAOCAOCONGNO
delete BAOCAOCONGNO
delete DOITAC where MaLoaiDoiTac  = 'LDT01'
delete CT_DDH_NCC
delete DONDATHANG_NCC

prc_UpdateThamSo 0, 0
Update THAMSO set TiLeGiaLe = 0.1
--drop table THAMSO
--select m.TenMatHang [Mặt hàng], c.SoLuongDat[Số lượng đặt], c.SoLuongDaNhap[Số lượng nhập] from DONDATHANG_NCC d, CT_DDH_NCC c, DOITAC dt, MATHANG m where dt.MaDoiTac = d.MaDoiTac and d.SoDDH_NCC = c.SoDDH_NCC and m.MaMatHang = c.MaMatHang and TenDoiTac = N'Nguyễn Văn' and c.SoDDH_NCC = 'SoDDH1'
--select * from DOITAC dt, DONDATHANG_NCC dd where dt.MaDoiTac = dd.MaDoiTac and TenDoiTac = N'Nguyễn Văn'
--select d.MaDoiTac[Mã đối tác], d.TenDoiTac [Tên đối tác], l.TenLoai [Loại đối tác], SDT, DiaChi [Địa chỉ], Thang [Tháng], Nam [Năm], NoDauKy [Nợ đầu kỳ], PhatSinh [Phát Sinh], NoCuoiKy [Nợ cuối kỳ] 
--from DOITAC d, LOAIDOITAC l, BAOCAOCONGNO b, CT_BAOCAOCONGNO c where d.MaLoaiDoiTac = l.MaLoaiDoiTac and d.MaDoiTac = c.MaDoiTac and c.MaBCCN = b.MaBCCN and TenDoiTac = N'Sơn Lâm'
--select c.MaBCCN from DOITAC d, CT_BAOCAOCONGNO c where c.MaDoiTac = d.MaDoiTac and d.MaDoiTac = 'DT2'
--update BAOCAOCONGNO set Thang = 6, Nam = 2015 where MaBCCN = 
--update CT_BAOCAOCONGNO set NoDauKy = 5000, NoCuoiKy = 1000, PhatSinh = NoDauKy + NoCuoiKy where MaDoiTac = 'DT6'

--select sum(TongTien)[Tong Tien] from PHIEUGIAOHANG p, DONDATHANG_KH d where p.SoDDH_KH = d.SODDH_KH and MaDoiTac = 'DT6' and MONTH(p.NgayGiao) = 6 and YEAR(p.NgayGiao) = 2016
--select sum(ConLai)[Con Lai] from PHIEUGIAOHANG p, DONDATHANG_KH d where p.SoDDH_KH = d.SODDH_KH and MaDoiTac = 'DT6' and MONTH(p.NgayGiao) = 6 and YEAR(p.NgayGiao) = 2016
--select sum(ConLai)[Con Lai] from PHIEUGIAOHANG p, DONDATHANG_KH d where p.SoDDH_KH = d.SODDH_KH and MaDoiTac = 'DT2'
--Select m.MaMatHang [Mã mặt hàng], TenMatHang [Tên mặt hàng], SoLuong [Số lượng], DonGia [Đơn giá], ThanhTien [Thành Tiền], NgayLap [Ngày lập] 
--from MATHANG m, HOADONBANLE h, CT_HDBL c 
--where m.MaMatHang = c.MaMatHang AND h.SoHD = c.SoHD AND TenKH LIKE N'% + Lâm + %'

--delete CT_HDBL
--delete HOADONBANLE

--select sum(ConLai)[Con lai] from PHIEUGIAOHANG where SoDDH_KH = 'DDHKH1' and MONTH(NgayGiao) = 6 and YEAR(NgayGiao) = 2016
--select sum(ConLai)[Con lai] from PHIEUGIAOHANG where SoDDH_KH = 'DDHKH2'
--update DOITAC set SoTienNo = 0
--select sum(c.SoLuongDaGiao)[Số lượng đã giao] from CT_PHIEUGIAOHANG c, PHIEUGIAOHANG p where c.MaMatHang = 'MH4' AND c.SoPGH = p.SoPGH AND p.SoDDH_KH = 'DDHKH1'
--select SoLuongDat from CT_DDH_KH c, DONDATHANG_KH d where c.SoDDH_KH = d.SoDDH_KH and c.MaMatHang = 'MH4'
--update CT_DDH_KH
--set SoLuongDaGiao = 100
--where (SoDDH_KH = 'DDHKH2' and MaMatHang = 'MH01')
--update PHIEUGIAOHANG 
--set TongTien = 100
--where (SoDDH_KH = 'DDHKH2' and SoPGH in (select top 1 SoPGH from PHIEUGIAOHANG order by SoPGH DESC))
--delete PHIEUGIAOHANG
--select m.TenMatHang [Mặt hàng], m.MaMatHang [Mã mặt hàng] from CT_DDH_KH c, MATHANG m  where m.MaMatHang = c.MaMatHang AND c.SoDDH_KH = 'DDHKH3'
--Select MaMatHang from CT_DDH_KH where SoDDH_KH = N'DDHKH3'
--select m.TenMatHang [Mặt hàng], TenDVT [Đơn vị tính], c.SoLuongDat [Số lượng đặt], c.SoLuongDaGiao [Số lượng đã giao], d.NgayLap [Ngày lập], d.NgayGiaoHangDuKien [Ngày giao (dự kiến)] from DONDATHANG_KH d, CT_DDH_KH c, MATHANG m, DVT dvt, DOITAC dt where m.MaMatHang = c.MaMatHang AND c.SoDDH_KH = d.SoDDH_KH AND dvt.MaDVT = m.MaDVT AND dt.MaDoiTac = d.MaDoiTac AND TenDoiTac = N'Lam' AND d.SoDDH_KH = N'DDHKH3'
--select MaDoiTac from DOITAC where TenDoiTac = N'Lam'
--select SoDDH_KH from DONDATHANG_KH where MaDoiTac = 'DT3'
--delete from DONDATHANG_KH where MaDoiTac = 'DT2'
--SELECT * FROM DOITAC D, LOAIDOITAC L WHERE D.MaLoaiDoiTac = L.MaLoaiDoiTac AND TenLoai = N'Khách hàng' AND (d.MaDoiTac not in (select MaDoiTac from DONDATHANG_KH)) 
--select MaDoiTac from LOAIDOITAC l, DOITAC d where l.MaLoaiDoiTac = d.MaLoaiDoiTac AND l.TenLoai = N'Khách hàng' AND TenDoiTac = N'Lam'
--prc_InsertDONDATHANG_KH 'DT3', '31/5/2016', '1/6/2016'
--SET DATEFORMAT DMY
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
--select * from MATHANG ORDER BY TenMatHang ASC
--select top 1 SoHD from HOADONBANLE order by SoHD DESC
--INSERT INTO CT_HDBL VALUES ('HDBL2', 'MH2', 2, 4, 8);
--SELECT SUM(ThanhTien) [Tong Thanh Tien] FROM CT_HDBL where SoHD = 'HDBL5'
--Select c.MaMatHang [Mã mặt hàng], TenMatHang [Tên mặt hàng], SoLuong [Số lượng], DonGia [Đơn giá], ThanhTien [Thành Tiền], NgayLap [Ngày lập] from MATHANG m, HOADONBANLE h, CT_HDBL c where m.MaMatHang = c.MaMatHang AND h.SoHD = c.SoHD AND TenKH = N'Hoang'
--SELECT * FROM DOITAC D, LOAIDOITAC L WHERE D.MaLoaiDoiTac = L.MaLoaiDoiTac AND TenLoai = N'Khách hàng'

SELECT * FROM DOITAC D, DONDATHANG_KH ddh WHERE D.MaDoiTac = ddh.MaDoiTac