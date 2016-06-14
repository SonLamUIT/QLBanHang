use QuanLyBanHang

go
create proc LayDSDonDatHangNCC
as 
begin
select *
from DONDATHANG_NCC ncc, CT_DDH_NCC ctncc
where ncc.SoDDH_NCC=ctncc.SoDDH_NCC
end

--exec LayDSDonDatHangNCC

--proc LayDanhSachPhieuNhapHang
USE [QuanLyBanHang]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LayDanhSachPhieuNhapHang]
as
begin
select SoPNH [Số Phiếu Nhập Hàng], SoDDH_NCC [Số Đơn Đặt Hàng Nhà Cung Cấp], NgayNhap [Ngày Nhập], TongTien [Tổng Tiền], ThanhToan [Thanh Toán], ConLai [Còn Lại] 
from PHIEUNHAPHANG
ORDER BY SoPNH ASC
end

exec LayDanhSachPhieuNhapHang 

--proc LayDanhSachChiTietPhieuNhapHang
go 
create proc LayDanhSachChiTietPhieuNhapHang
as
begin
select *
from CT_PNH
ORDER BY SoPNH ASC
end

--exec LayDanhSachChiTietPhieuNhapHang
USE [QuanLyBanHang]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[LayDanhSachChiTietPhieuNhapHang]
as
begin
select SoPNH [Số Phiếu Nhập Hàng], MaMatHang [Mã Mặt Hàng], SoLuongChuaNhap [Số Lượng Chưa Nhập], SoLuongNhap [Số Lượng Nhập], DonGiaNhap [Đơn Giá Nhập], ThanhTien [Thành Tiền]
from CT_PNH
ORDER BY SoPNH ASC
end
--exec KiemTraSoPhieuNhapHangTrongPhieuNhapHang '0'

--proc nhap du lieu vao phieu nhap hang
go 
create proc NhapPhieuNhapHang
@SoPhieuNhapHang nvarchar(10),
@SoDonDatHangNhaCungCap nvarchar(10),
@NgayNhap smalldatetime,
@TongTien money,
@ThanhToan money,
@ConLai money
as 
begin
insert into dbo.PHIEUNHAPHANG values (@SoPhieuNhapHang,@SoDonDatHangNhaCungCap,@NgayNhap,@TongTien,@ThanhToan,@ConLai)
end
 
exec NhapPhieuNhapHang 'A005','AAA006','27-05-2016',0,0,0


insert into MATHANG values('AAAA0003','iphone6s')


insert into DONDATHANG_NCC values ('AAA003','A003','24/05/2016','AAA003','AAAA0003',105,9)

--cap nhat thanh tien cua CT_PNH
Update dbo.CT_PNH
set ThanhTien = coalesce(SoLuongNhap,0) * coalesce(DonGiaNhap,0),
SoLuongNhap =coalesce(SoLuongNhap,0),
DonGiaNhap =coalesce(DonGiaNhap,0)

--cap nhat tong tien cua CT_PNH
Update dbo.CT_PNH
set ThanhTien = coalesce(SoLuongNhap,0) * coalesce(DonGiaNhap,0),
SoLuongNhap =coalesce(SoLuongNhap,0),
DonGiaNhap =coalesce(DonGiaNhap,0)

--ham sum
update dbo.PHIEUNHAPHANG
set TongTien =(
SELECT SUM(ThanhTien) [Tổng Tiền], PHIEUNHAPHANG.SoPNH [Số Phiếu Nhập Hàng]
FROM CT_PNH,PHIEUNHAPHANG
where CT_PNH.SoPNH=PHIEUNHAPHANG.SoPNH
group by PHIEUNHAPHANG.SoPNH
)
from dbo.PHIEUNHAPHANG pnh,dbo.CT_PNH ctpnh
where pnh.SoPNH=[Số Phiếu Nhập Hàng]



select SUM(ThanhTien), PHIEUNHAPHANG.SoPNH
from CT_PNH,PHIEUNHAPHANG
where CT_PNH.SoPNH=PHIEUNHAPHANG.SoPNH
group by PHIEUNHAPHANG.SoPNH


--Thêm dữ liệu bảng DVT-đơn vị tính
INSERT INTO DBO.DVT VALUES ('ca','Cây')
--delete from dbo.DVT where dbo.DVT.MaDVT=''

--Thêm dữ liệu bảng DONDATHANG_NCC
insert into dbo.DONDATHANG_NCC values ('AAA003','A003',26/05/2016)
insert into dbo.DONDATHANG_NCC values ('AAA004','A005',24/05/2016)
insert into dbo.DONDATHANG_NCC values ('AAA005','A004',1/04/2016)
insert into dbo.DONDATHANG_NCC values ('AAA006','A007',7/01/2016)
insert into dbo.DONDATHANG_NCC values ('AAA007','A006',2/03/2016)

--Thêm dự liệu bảng PHIEUNHAPHANG và CT_PNH
insert into dbo.PHIEUNHAPHANG values('A001','AAA003',27/05/2016,0,0,0)
insert into dbo.PHIEUNHAPHANG values('A002','AAA004',27/05/2016,0,0,0)
insert into dbo.PHIEUNHAPHANG values('A003','AAA005',27/05/2016,0,0,0)
insert into dbo.PHIEUNHAPHANG values('A004','AAA006',27/05/2016,0,0,0)
insert into dbo.PHIEUNHAPHANG values('A005','AAA007',27/05/2016,0,0,0)

 --Thêm dữ liệu bảng LOAIDOITAC 
--delete from dbo.DOITAC where 
insert into dbo.DOITAC values ('A001',N'Phong Vũ','NCC','0888999778',N'Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A002',N'Phát Đạt','NCC','0889899889','Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A003',N'Tân Doanh','NCC','0889999888',N'Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A004',N'Duy Phương','NCC','0889999889',N'Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A005',N'Netzen','NCC','0889999898',N'Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A006',N'Samsung','NCC','0889999788',N'Tp. Hồ Chí Minh',0)
insert into dbo.DOITAC values ('A007',N'LG','NCC','0889999884',N'Tp. Hồ Chí Minh',0)

--Thêm dữ liệu bảng MATHANG 
insert into dbo.MATHANG values ('AAAA0000','iPhone 5s',10,'C')
insert into dbo.MATHANG values ('AAAA0001','iPhone 6',2,'C')
insert into dbo.MATHANG values ('AAAA0002','iPhone 6 plus',55,'C')
insert into dbo.MATHANG values ('AAAA0003','iPhone 6s ',1,'C')
insert into dbo.MATHANG values ('AAAA0003','iPhone 6s plus',22,'C')
insert into dbo.MATHANG values ('AAAA0004','Samsung Galaxy S7',88,'C')
insert into dbo.MATHANG values ('AAAA0005','Samsung Galaxy S7 edge',39,'C')
insert into dbo.MATHANG values ('AAAA0006','Samsung Galaxy S6',75,'C')
insert into dbo.MATHANG values ('AAAA0007','Samsung Galaxy S6 edge',101,'C')
insert into dbo.MATHANG values ('AAAA0008','LG G5',8,'C')

--thêm dữ liệu bảng loại đối tác
insert into dbo.LOAIDOITAC values ('NCC','Nhà cung cấp')
insert into dbo.LOAIDOITAC values ('KH','Khách hàng')

--thêm dữ liệu bảng đối tác
insert into dbo.DOITAC values ('NCCAA01','Phong Vũ','NCC','0909235009','Tp. Hồ Chí Minh',0)

--proc NhapChiTietPhieuNhapHang 
go
create proc NhapChiTietPhieuNhapHang 
@SoPNH nvarchar(10),
@MaMatHang nvarchar(10),
@SoLuongChuaNhap int,
@SoLuongNhap int,
@DonGiaNhap money,
@ThanhTien money
as 
begin
	insert into dbo.CT_PNH values (@SoPNH,@MaMatHang,@SoLuongChuaNhap,@SoLuongNhap,@DonGiaNhap,@ThanhTien)
end

exec NhapChiTietPhieuNhapHang 'A001','AAAA0002',45,37,

--Cập nhật tổng tiền phiếu nhập hàng từ chi tiết phiếu nhập hàng
go 
create proc CapNhatTongTienPhieuNhapHang
@SoPNH nvarchar(10),
@ThanhTien money
as
begin
	UPDATE PHIEUNHAPHANG 
	SET TongTien=TongTien+@ThanhTien 
	WHERE SoPNH=@SoPNH
end

go 
create proc CapNhatConLaiPhieuNhapHang
@SoPNH nvarchar(10)
as
begin
	UPDATE PHIEUNHAPHANG 
	SET ConLai=TongTien-ThanhToan
	WHERE SoPNH=@SoPNH
end

exec CapNhatTongTienPhieuNhapHang 

--proc thêm phiếu thu/chi
create proc ThemPhieuThuChi
@SoPTC nvarchar(10),
@NgayLap smalldatetime,
@MaDoiTac nvarchar(10),
@TongNo money,
@SoTien money
as
begin
	insert into PHIEUTHUCHI values (@SoPTC,@NgayLap,@MaDoiTac,@TongNo,@SoTien)
	
	update DoiTac 
	set DoiTac.SoTienNo = @TongNo
	where DoiTac.MaDoiTac=@MaDoiTac
end

create proc BaoCaoLoiNhuanTheoMatHangTheoThoiGian
@NgayThangNam smalldatetime
as
begin
select mh.MaMatHang, SUM(hdbl.TongThanhTien)*0.1 [DoanhThu]
from MATHANG mh, DVT dvt, HOADONBANLE hdbl, CT_HDBL cthdbl, CT_PNH ctpnh
where mh.MaDVT=dvt.MaDVT and mh.MaMatHang=cthdbl.MaMatHang and hdbl.SoHD=cthdbl.SoHD and hdbl.NgayLap<=@NgayThangNam and ctpnh.MaMatHang=mh.MaMatHang
group by mh.MaMatHang
end 

CREATE TABLE BaoCaoDoanhThuTheoMatHang
(
MaMatHang nvarchar(10),
DoanhThu money
);

INSERT INTO BaoCaoDoanhThuTheoMatHang
Exec BaoCaoLoiNhuanTheoMatHangTheoThoiGian '11/01/2016'

DELETE FROM BaoCaoDoanhThuTheoMatHang

create proc LayMaDoiTacTuDonDatHangNCC
@SoDDH_NCC nvarchar(10)
as
begin
select DONDATHANG_NCC.MaDoiTac
from DONDATHANG_NCC
where DONDATHANG_NCC.SoDDH_NCC=@SoDDH_NCC
end

create proc CapNhatTongNoDoiTacTuPhieuNhapHang
@MaDoiTac nvarchar(10),
@SoTien money
as 
begin
	update DoiTac 
	set DoiTac.SoTienNo = DoiTac.SoTienNo + @SoTien
	where DoiTac.MaDoiTac=@MaDoiTac
end

--exec LayMaDoiTacTuDonDatHangNCC 'AAA002'

create proc  LaySoLuongChuaNhapCuaDDH_NCC
@SoPNH nvarchar(10),
@MaMatHang nvarchar(10)
as
begin
	select ctddh.SoLuongDaNhap-ctddh.SoLuongDat 
	from PHIEUNHAPHANG pnh, CT_PNH ctpnh, DONDATHANG_NCC ddh, CT_DDH_NCC ctddh
	where pnh.SoPNH=ctpnh.SoPNH and pnh.SoDDH_NCC=ddh.SoDDH_NCC and ddh.SoDDH_NCC=ctddh.SoDDH_NCC and pnh.SoPNH=@SoPNH and ctddh.MaMatHang=@MaMatHang
end

create proc CapNhatSoLuongNhapDDH_NCC
@SoDDH_NCC nvarchar(10),
@MaMatHang nvarchar(10),
@SoLuongNhap int
as
begin
	update CT_DDH_NCC
	set SoLuongDaNhap=SoLuongDaNhap+@SoLuongNhap
	where SoDDH_NCC=@SoDDH_NCC and MaMatHang=@MaMatHang
end

create proc PhieuNhapHang_LaySoDDHNCC
@SoPNH nvarchar(10)
as 
begin
	select pnh.SoDDH_NCC
	from PHIEUNHAPHANG pnh, CT_PNH ctpnh
	where pnh.SoPNH=ctpnh.SoPNH and ctpnh.SoPNH=@SoPNH
end

create table LichSuDuLieu
(
	ThoiGian varchar(50) primary key,
	SuKien nvarchar(200)
)

--bảng danh sách tài khoản
create table TaiKhoan
(
	TenDangNhap nvarchar(50) primary key,
	MatKhau nvarchar(50)
)

--proc kiểm tra đăng nhập hợp lệ
create proc KiemTraDangNhap
@TenDangNhap nvarchar(50),
@MatKhau nvarchar(50)
as
begin
	select * from TaiKhoan where TenDangNhap=@TenDangNhap and MatKhau=@MatKhau
end

--thêm dữ liệu vào bảng tài khoản 
insert into TaiKhoan values('admin','admin')

--exec KiemTraDangNhap 'admin','admin'

insert into LichSuDuLieu values ('admin','{1}')