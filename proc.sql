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