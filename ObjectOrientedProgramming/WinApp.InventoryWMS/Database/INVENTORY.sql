GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_NgayNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE FUNCTION [dbo].[uf_Get_NgayNhap]
(
	@IdLoaiVatTu	uniqueidentifier
)
RETURNS date
AS
BEGIN
	DECLARE @NgayNhap date
	SET @NgayNhap =	  (SELECT  TOP 1 NgayTaoDate
					     FROM  (SELECT IdPhieuNhap
								  FROM dbo.KhPhieuNhapCt
								 WHERE (IdLoaiVatTu=@IdLoaiVatTu) 
							   ) as CT INNER JOIN
							   (SELECT Id,
									   NgayTaoDate
								  FROM dbo.KhPhieuNhap		
							   ) as PN ON CT.IdPhieuNhap=PN.Id
						ORDER BY
							   PN.NgayTaoDate ASC
					  )
	RETURN @NgayNhap
END

GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_NgayXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE FUNCTION [dbo].[uf_Get_NgayXuat]
(
	@IdLoaiVatTu	uniqueidentifier
)
RETURNS date
AS
BEGIN
	DECLARE @NgayNhap date
	SET @NgayNhap =	  (SELECT  TOP 1 NgayTaoDate
					     FROM  (SELECT IdPhieuXuat
								  FROM dbo.KhPhieuXuat_Ct
								 WHERE (IdLoaiVatTu=@IdLoaiVatTu) 
							   ) as CT INNER JOIN
							   (SELECT Id,
									   NgayTaoDate
								  FROM dbo.KhPhieuXuat		
							   ) as PN ON CT.IdPhieuXuat=PN.Id
						ORDER BY
							   PN.NgayTaoDate ASC
					  )
	RETURN @NgayNhap
END

GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_NhapXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE FUNCTION [dbo].[uf_Get_NhapXuat](@ListKhoHang varchar(100),@TuNgay date,@DenNgay date) 
RETURNS @Tbl TABLE (IdLoaiVatTu uniqueidentifier,Nhap int,Xuat int,Chuyen int)
AS
BEGIN
	INSERT INTO @Tbl(IdLoaiVatTu,Nhap,Xuat,Chuyen)	
	SELECT  CT.IdLoaiVatTu,
		    SUM(CT.SoLuong) as Nhap,
			CONVERT(int,0) as Xuat,
			CONVERT(int,0) as Chuyen
	   FROM	   
			(SELECT Id,
					IdKhoHang
			   FROM dbo.KhPhieuNhap 
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PN INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PN.IdKhoHang=ID.Id INNER JOIN
			(SELECT IdPhieuNhap,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuNhapCt
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as CT ON PN.Id=CT.IdPhieuNhap 
	GROUP BY					 				
			CT.IdLoaiVatTu

	UNION ALL	   
					
	SELECT  CT.IdLoaiVatTu,
			CONVERT(int,0) as Nhap,
			SUM(CT.SoLuong) as Xuat,		   
			CONVERT(int,0) as Chuyen	   
	  FROM	   
			(SELECT Id,
					IdKhoHang
			   FROM dbo.KhPhieuXuat
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay) 
			) as PX INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PX.IdKhoHang=ID.Id INNER JOIN			   
			(SELECT IdPhieuXuat,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuXuatCt
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as CT ON PX.Id=CT.IdPhieuXuat 
	GROUP BY					 				
			CT.IdLoaiVatTu
			   
	UNION ALL	   
			   
	SELECT  CT.IdLoaiVatTu,
			CONVERT(int,0) as Nhap,
			CONVERT(int,0) as Xuat,
			SUM(CT.SoLuong) as Chuyen
	  FROM	   
			(SELECT Id,
					IdKhoHang
			   FROM dbo.KhPhieuChuyen
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PC INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PC.IdKhoHang=ID.Id INNER JOIN			   
			(SELECT IdPhieuChuyen,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuChuyenCt
			  WHERE (NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as CT ON PC.Id=CT.IdPhieuChuyen 
	GROUP BY					 				
			CT.IdLoaiVatTu
	RETURN
END



GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_SoLuongNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE FUNCTION [dbo].[uf_Get_SoLuongNhap]
(
	@IdSanPham  uniqueidentifier
)
RETURNS decimal(10,2)
AS
BEGIN
	DECLARE @SoLuongNhap decimal(10,2)
	SET @SoLuongNhap   = (SELECT TOP 1 SoLuongNhap
							FROM dbo.KH_SanPham
					      WHERE Id=@IdSanPham
					    )
	IF(@SoLuongNhap IS NULL) SET @SoLuongNhap=0				
	return @SoLuongNhap
END






















GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_TableGuid]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE FUNCTION [dbo].[uf_Get_TableGuid](@Str VARCHAR(8000), @Table VARCHAR(20)) 
RETURNS @Tbl TABLE (Id uniqueidentifier)
AS
BEGIN
	SET @Str = REPLACE(@Str,' ','')
	IF(@Str IS NULL OR LEN(@Str)=0)
	BEGIN
		IF(@Table='NhomVatTu')
		BEGIN
			INSERT INTO @Tbl
			SELECT Id FROM dbo.DmNhomVatTu
		END		
	END
	ELSE
	BEGIN
		DECLARE @SubStr VARCHAR(36), @i INT
		SET @i = CHARINDEX(',', @Str, 0)
		WHILE @i > 0
		BEGIN
			SET @SubStr = LEFT(@Str,@i-1)
			INSERT INTO @Tbl
			SELECT @SubStr
	 
			SET @Str = SUBSTRING(@Str, @i+1,8000)
			SET @i = CHARINDEX(',', @Str, 0)
		END	
		INSERT INTO @Tbl
		SELECT LTRIM(RTRIM(@Str))
	END
	RETURN
END






GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_TableInt]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE FUNCTION [dbo].[uf_Get_TableInt](@Str VARCHAR(1000), @Table VARCHAR(20)) 
RETURNS @Tbl TABLE (Id int)
AS
BEGIN
	SET @Str = REPLACE(@Str,' ','')
	IF(@Str IS NULL OR LEN(@Str)=0)
	BEGIN
		IF(@Table='KhoHang')
		BEGIN
			INSERT INTO @Tbl
			SELECT Id FROM dbo.DmKhoHang		
		END
		ELSE IF(@Table='VaiTro')
		BEGIN
			INSERT INTO @Tbl
			SELECT Id FROM dbo.HtVaiTro		
		END				
	END
	ELSE
	BEGIN	
		DECLARE @SubStr VARCHAR(2), @i INT
		SET @i = CHARINDEX(',', @Str, 0)
		WHILE @i > 0
		BEGIN
			SET @SubStr = LEFT(@Str,@i-1)
			INSERT INTO @Tbl
			SELECT CONVERT(int,@SubStr)
	 
			SET @Str = SUBSTRING(@Str, @i+1,8000)
			SET @i = CHARINDEX(',', @Str, 0)
		END	
		INSERT INTO @Tbl
		SELECT CONVERT(int,LTRIM(RTRIM(@Str)))
	END
	RETURN
END







GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_TongNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE FUNCTION [dbo].[uf_Get_TongNhap]
(
	@IdSanPham  uniqueidentifier
)
RETURNS decimal(10,2)
AS
BEGIN
	DECLARE @SoLuong decimal(10,2)
	SET @SoLuong  = (SELECT SUM(SoLuong)
					   FROM dbo.KhPhieuNhapCt 
					  WHERE IdSanPham=@IdSanPham
					)
	IF(@SoLuong IS NULL) SET @SoLuong=0					 
	return @SoLuong
END






















GO
/****** Object:  UserDefinedFunction [dbo].[uf_Get_TongXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE FUNCTION [dbo].[uf_Get_TongXuat]
(
	@IdSanPhamMv  uniqueidentifier
)
RETURNS decimal(10,2)
AS
BEGIN
	DECLARE @SoLuongXuat decimal(10,2)
	SET @SoLuongXuat  = (SELECT SUM(SoLuong)
						   FROM dbo.KhPhieuXuatSp 
					      WHERE IdSanPham=@IdSanPhamMv
					    )
	DECLARE @SoLuongCk decimal(10,2)					 
	SET @SoLuongCk  = (SELECT SUM(SoLuong)
					     FROM dbo.KhPhieuChuyenSp
					    WHERE IdSanPham=@IdSanPhamMv
					  )	
	IF(@SoLuongXuat IS NULL) SET @SoLuongXuat=0					 
	IF(@SoLuongCk IS NULL) SET @SoLuongCk=0		
	return @SoLuongXuat+@SoLuongCk
END






















GO
/****** Object:  Table [dbo].[DmBoPhan]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmBoPhan](
	[Id] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_BoPhan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmChiNhanh]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmChiNhanh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[TenVietTat] [nvarchar](20) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[LienHe] [nvarchar](200) NOT NULL,
	[MaSoThue] [nvarchar](20) NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmDonViTinh]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmDonViTinh](
	[Id] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmKhoHang](
	[Id] [int] NOT NULL,
	[IdChiNhanh] [int] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[TenVietTat] [nvarchar](5) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_KhoHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmLoaiVatTu](
	[Id] [uniqueidentifier] NOT NULL,
	[IdNhomVatTu] [uniqueidentifier] NOT NULL,
	[IdDonViTinh] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[QuyCach] [nvarchar](300) NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_LoaiVatTu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmNguonKho]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmNguonKho](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdNguonNhap] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_DM_NguonKho] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmNguonNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmNguonNhap](
	[Id] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](300) NULL,
	[LienHe] [nvarchar](300) NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_NguonNhap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DmNhomVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DmNhomVatTu](
	[Id] [uniqueidentifier] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_DM_NhomVatTu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtChucNang]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtChucNang](
	[TenForm] [varchar](50) NOT NULL,
	[IdPhanHe] [int] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_HT_ChucNang] PRIMARY KEY CLUSTERED 
(
	[TenForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtNguoiDung]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtNguoiDung](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[TenTruyCap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[DangNhap] [bit] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_HT_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtNguoiDungVaiTro]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtNguoiDungVaiTro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdNguoiDung] [int] NOT NULL,
	[IdVaiTro] [int] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[MacDinh] [bit] NOT NULL,
 CONSTRAINT [PK_HT_NguoiDungVaiTro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtPhanHe]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtPhanHe](
	[Id] [int] NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_HT_PhanHe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtQuyenHan]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtQuyenHan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdVaiTro] [int] NOT NULL,
	[TenForm] [varchar](50) NOT NULL,
	[Xem] [bit] NOT NULL,
	[Them] [bit] NOT NULL,
	[Sua] [bit] NOT NULL,
	[Xoa] [bit] NOT NULL,
 CONSTRAINT [PK_HT_QuyenHan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtThietLap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtThietLap](
	[Id] [int] NOT NULL,
	[TenPhanMem] [nvarchar](100) NOT NULL,
	[NgayDuLieu] [int] NOT NULL,
	[KieuKhoa] [int] NOT NULL,
	[ThoiGianKhoa] [int] NOT NULL,
	[XoaQuaNgay] [bit] NOT NULL,
 CONSTRAINT [PK_HT_ThietLap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HtVaiTro]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HtVaiTro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[ThuTu] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_HT_VaiTro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhNhapXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhNhapXuat](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[Thang] [date] NOT NULL,
	[Nhap] [int] NOT NULL,
	[Xuat] [int] NOT NULL,
	[Chuyen] [int] NOT NULL,
 CONSTRAINT [PK_KH_NhapXuat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuChuyen]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuChuyen](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdKhoNhan] [int] NOT NULL,
	[SoPhieu] [nvarchar](20) NOT NULL,
	[IdNguoiGiao] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[TrangThaiNhan] [int] NOT NULL,
	[IdNguoiTao] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuChuyen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuChuyenCt]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuChuyenCt](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuChuyen] [uniqueidentifier] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuChuyen_Ct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuChuyenSp]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuChuyenSp](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuChuyenCt] [uniqueidentifier] NOT NULL,
	[IdSanPham] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
 CONSTRAINT [PK_KH_PhieuChuyen_Sp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuNhap](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdNguonNhap] [uniqueidentifier] NOT NULL,
	[IdPhieuChuyen] [uniqueidentifier] NULL,
	[IdKhoChuyen] [int] NULL,
	[LoaiNhap] [int] NOT NULL,
	[SoPhieu] [nvarchar](20) NOT NULL,
	[IdNguoiTao] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[UpdateTon] [bit] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuNhapCt]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuNhapCt](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuNhap] [uniqueidentifier] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[IdSanPham] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuNhap_Ct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuNhapNb]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuNhapNb](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdKhoChuyen] [int] NOT NULL,
	[IdPhieuChuyen] [uniqueidentifier] NOT NULL,
	[IdPhieuNhap] [uniqueidentifier] NULL,
	[IdNguonNhap] [uniqueidentifier] NOT NULL,
	[SoPhieu] [nvarchar](20) NOT NULL,
	[TrangThai] [int] NOT NULL,
	[IdNguoiGiao] [int] NOT NULL,
	[IdNguoiTao] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuNhapNb] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuNhapNbCt]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuNhapNbCt](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuNhapNb] [uniqueidentifier] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[IdSanPham] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuNhapNb_Ct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuXuat](
	[Id] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdBoPhan] [uniqueidentifier] NOT NULL,
	[SoPhieu] [nvarchar](20) NOT NULL,
	[IdNguoiNhan] [int] NOT NULL,
	[IdNguoiTao] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[UpdateTon] [bit] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuXuatCt]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuXuatCt](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuXuat] [uniqueidentifier] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTaoDate] [date] NOT NULL,
	[ChuThich] [nvarchar](300) NULL,
 CONSTRAINT [PK_KH_PhieuXuat_Ct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhPhieuXuatSp]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhPhieuXuatSp](
	[Id] [uniqueidentifier] NOT NULL,
	[IdPhieuXuatCt] [uniqueidentifier] NOT NULL,
	[IdSanPham] [uniqueidentifier] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_KH_PhieuXuat_Sp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhSanPham]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhSanPham](
	[Id] [uniqueidentifier] NOT NULL,
	[IdSanPham] [uniqueidentifier] NOT NULL,
	[IdKhoHang] [int] NOT NULL,
	[IdNguonNhap] [uniqueidentifier] NOT NULL,
	[IdLoaiVatTu] [uniqueidentifier] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[ChuThich] [nvarchar](100) NULL,
 CONSTRAINT [PK_KH_SanPham] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DmBoPhan] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'fe805057-fcb4-4df8-a587-5b56e9dccf31', N'Phòng KCS', 2, 1, N'')
GO
INSERT [dbo].[DmBoPhan] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'783b7a28-7744-433d-b510-6e08b721540b', N'Phòng kinh doanh', 4, 1, N'')
GO
INSERT [dbo].[DmBoPhan] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'6f84e1c5-3cd5-4cc2-abcd-73a1898345ac', N'Phân xưởng', 1, 1, N'')
GO
INSERT [dbo].[DmBoPhan] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'572dfdfe-e70f-459b-83a2-ed4905015566', N'Tổ xe', 3, 1, N'')
GO
SET IDENTITY_INSERT [dbo].[DmChiNhanh] ON 
GO
INSERT [dbo].[DmChiNhanh] ([Id], [Ten], [TenVietTat], [DiaChi], [LienHe], [MaSoThue], [ThuTu], [TrangThai], [ChuThich]) VALUES (1, N'Công ty TNHH Quốc Hùng', N'Quốc Hùng', N'200 Nguyễn Văn Linh - Thanh Khê - Đà Nẵng', N'ĐT: 0905.080.280 - Email: tuanpmsoft@gmail.com', NULL, 1, 1, N'')
GO
SET IDENTITY_INSERT [dbo].[DmChiNhanh] OFF
GO
INSERT [dbo].[DmDonViTinh] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây', 0, 1, N'')
GO
INSERT [dbo].[DmDonViTinh] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'45eb383b-a661-4def-91fb-529127d36c51', N'Bộ', 0, 1, N'')
GO
INSERT [dbo].[DmDonViTinh] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Mét', 0, 1, N'')
GO
INSERT [dbo].[DmDonViTinh] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cái', 0, 1, N'')
GO
INSERT [dbo].[DmKhoHang] ([Id], [IdChiNhanh], [Ten], [TenVietTat], [ThuTu], [TrangThai], [ChuThich]) VALUES (1, 1, N'Kho tổng', N'K1', 1, 1, N'')
GO
INSERT [dbo].[DmKhoHang] ([Id], [IdChiNhanh], [Ten], [TenVietTat], [ThuTu], [TrangThai], [ChuThich]) VALUES (2, 1, N'Chi nhánh', N'K2', 2, 1, N'')
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'592c5b75-5a34-4d44-b918-000257d3cb92', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 60', N'Dày 3mm; Đệ Nhất    ', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'17c98e46-9919-404d-b0e7-00ed822b8d44', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 140', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ba68ecc7-0601-416b-b097-03996d77093a', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 140', N'Phi 140; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'54fad264-c2cf-45c7-90a9-03b7c9adce39', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 800A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f6a4e8f9-4b8c-43b1-bc4f-060d1ae58633', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C140', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'79adb2d0-8f16-44de-a08c-063702c49597', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 60', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'29814a9f-a429-425d-be8a-09f12b8a7984', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'002a95f2-4c01-4ee5-9f72-0b0751359cc3', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 225A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'66d41a0e-fe41-4acd-aac0-0b795cf66d78', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế RXM4AB2P7', N'Hãng Schneider (14 chân, cuộn dây 230 VDC)', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'0f359808-dbc6-4529-8e72-0c1245fc6ebb', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 34', N'Phi 34; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'64a8cc1e-ee28-4bc4-9de0-0d07a1efb030', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế MY4N 24VDC', N'Hiệu omron ', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1e6e598b-77bf-4148-bbc2-0f84d4110ea1', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 60-49', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8b1c954b-6d42-42c2-8a6c-10181d6048e9', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 10A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'17068171-2460-43a6-92e6-1059258912a4', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 90-114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'df8af047-2372-4f9a-a9ce-10d54d8333f6', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 110', N'Phi 110; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'dc3e22e1-fc32-4ca9-8201-154692c54a69', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B79', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ba87f81d-c45f-425d-b800-171bf1f70673', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C120', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8f18c95e-5f63-4d51-b0bc-172f39023607', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế RXM2LB2BD', N'Hãng Schneider (8 chân, cuộn dây 24 VDC)', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'56a19585-49db-4153-a1c6-173ac6486ef1', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 34-50A', N'Hãng LG (LS);MT-63', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f2c94d8a-5781-44f3-926b-1ccca50f448f', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B94', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'885f03e1-aeb3-4796-a1b1-1f40b7ffb579', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 140', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8646653f-bfa9-42dd-ae9b-21b71f78fc0d', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B52', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'24a3484c-33e8-4013-8be8-21c50566787c', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A52', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'c328c187-1719-47ec-ae20-22b53309f10e', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế MY4N 220/240VAC', N'Hiệu omron ', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'95ce53bf-54be-4042-8898-23288921d5fc', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 76', N'Dày 4,5mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'49a495d4-0e1d-4f24-b867-237a3167a089', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 21', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'0fc28d9e-d7f5-43b7-9fc0-23dfd6cdfb50', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 27-21', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e61c39d4-c10e-4998-97e2-281c43896345', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 200', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'066afbc3-c34a-4609-a9b5-28b922d95dd9', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 114', N'Dày 5mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'49e2211b-07d7-431f-b0d7-2af39fa1e535', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C109', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4f7e8dd8-3d00-428a-b55e-2cbedf0dc88a', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 49-42', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd8ae8c5c-745d-4977-8921-2cf58e588102', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa SPC 3050', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'be674b68-a10a-437f-9a9b-2e0563b0d7b7', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A62', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd28c98de-6262-4bd3-b04a-2e5a8b27d92a', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 300A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1a4219e1-773b-428b-bc45-2eff8dee7b27', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 9-13A', N'Hãng LG (LS);MT-12', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f925483a-9f26-4a2c-85be-3172d6db2bb6', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 42', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3bb7de0c-5c18-47d8-a951-31a3116af1b6', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A49', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'63afe48f-1600-47da-92ed-31aabb4e761c', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C102', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7e3f609b-46b8-45a1-a0c5-330b37a5cd21', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7ec91094-872e-469d-9f21-338ab03b856d', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 400A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'88e179ac-b187-4fd6-8f93-34a63451423f', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le điện áp', N'Hãng Mikro; Model MX100', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'09776b7f-431f-4af6-bd9e-3602de1bf8c6', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C131', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e2adfdce-81a2-419a-8549-3b3155fafbcd', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 2,5-4A', N'Hãng LG (LS); MT-32', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'35470f87-d9ec-4153-933a-3fab9625435c', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 114', N'Phi 114; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1d2c6bea-58a7-4856-b882-49b8acd337b8', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 200', N'Dày 4,9mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'cf12b857-b724-4373-a4cb-4a903bf7eaf6', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C135', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2e9ae1b5-7018-402a-93f9-4adb29f46ae1', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 45-64A', N'Hãng LG (LS);MT-63', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd97a7347-93d8-4d6a-ba52-4cdbc4a245d4', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 500A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e0c3e405-4b08-4e79-9032-4dfaf96928d9', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 76', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2629c5a8-1bb6-49b6-b0c8-4e5b716c442a', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 21', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1bc9efea-da0f-4568-880d-4f4da0a0037d', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B59', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'6d539ac5-4f54-45b2-b5f0-4fb8192b2828', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 200A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9e780c11-2765-4ec2-9e23-5144c393832b', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 110', N'Dày 4,2mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'20521550-4efd-44bd-9df6-51732b418b04', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C127', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'24a35dc8-a679-4afc-87af-529051b57e4c', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 76', N'Phi 76; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'c2622428-a30e-4360-8968-530d47b02dc9', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 160', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ddf40048-4dcb-4633-80fc-54f02953d8e3', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 49', N'Phi  49; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'aa39500f-b952-4d90-80cd-552baf03e69b', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 27', N'Dày 3mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3eaaa07b-f748-4b6d-a4a7-59c0b2d6da81', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 34', N'Dày 3mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'b07388bf-6802-4a5b-b3b9-61208d60e87b', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 76', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7ee28f57-f840-4795-b6e2-622e85fa1a28', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 160', N'Dày 4,7mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8b5bdf8f-da5b-4606-bd64-62e9480bc3ea', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế RXM2AB1BD', N'Hãng Schneider (8 chân, cuộn dây 24 VDC)', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ef65bc2e-3ae9-4c34-bfcf-681ddd4d5830', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 160', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3e95f0b4-935e-483c-9af1-68e067060139', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 27', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'08aebd3e-dae7-4e9e-8dee-6b62104a926e', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 34', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd27ed9ae-fde8-4b64-89bd-6c9f8abc3980', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 22-32A', N'Hãng LG (LS);MT-32', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2a1d2717-2c23-4bb0-9049-6dccdb5def8b', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 27', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e63a3147-2910-495e-a484-6eda2262cbcd', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A1250', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fbacb7cb-83d2-467a-8ff9-7158bc359db0', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa D177', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9b834986-6d00-48e3-a3ba-71d2875c1b3b', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 27', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'54154238-8443-4ff2-a3e2-7331443274dc', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 50A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3cf22291-c069-43be-9635-73e2ccf0b9eb', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 160-90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f1262054-a671-4969-b364-7492b8602da6', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le bán dẫn', N'HSR-3D404Z', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'cb4605a9-82e6-469b-8a29-7533e1a70ff7', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 140-114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'641e6a62-88d6-41dd-9778-763781357f65', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B88', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'518e5a42-3fd3-4349-a11a-77114f3930f9', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C97', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd9e51526-96ae-4e06-940c-7775306eeb87', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 200-140', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'063b5057-4c86-44a5-94ce-7b1370dbb438', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 27', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'abb2d963-e0e1-405b-85c1-7b8aefe2775c', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 21', N'Dày 3mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'5542df08-ab35-4644-8226-806bbdcc707c', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa 5V - 1060', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7d203d69-75d9-496a-83eb-84487cbab461', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 200-160', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'39cf7e14-2f9f-466d-a7c1-85917911add4', N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cánh bơm bột IHD80-65-125', N'Bơm IHD80-65-125;Q=50, H=20', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'995384b3-bc8f-44d5-8de9-85a9d9827c1c', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 330A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'0cd2716f-efec-4150-8d91-87b3800d3757', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 15A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'88d5e42d-fbc0-4fa4-81f0-89cd8bce58de', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 5-8A', N'Hãng LG (LS);MT-32', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7e2b2c09-1bf9-4b1b-93ce-8a776da53af0', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B99', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'c861270c-1692-49f9-83fa-8d691e50ec4d', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 90', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'0f9128db-9b31-4da7-9fa4-9077c65dac9e', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 90-76', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2e8ebaf3-cb84-4b1f-ab95-90c415c8fd20', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 75A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'586a39ab-6ea2-4022-a2e1-9226868f9da1', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 110-90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fc1cb564-5a20-43c4-9a80-9269fb7c83b0', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 54-75A', N'Hãng LG (LS);MT-95', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fa8c69a7-8001-4135-b402-96e99af00233', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 18-25A', N'Hãng LG (LS);MT-32', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'97819447-d3c1-4403-bd39-97e0cf598606', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 160', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7173ac92-e9cd-44a6-9680-9a29b901b164', N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cánh bơm bã IHD100-80-160K', N'Bơm IHD100-80-160K; Q=100, H=33', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ef54d19a-4be0-4dc5-bad3-9c1174716fc0', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 140', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'360e9277-f5e7-4cf8-b607-9c8196bda75b', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A54', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9694c7c3-7fef-47f7-b24d-9d35d4bb30f2', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B56', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2a81297b-25ae-459d-bf7a-9d663b50aa58', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 60', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'6ea6b44b-5a41-405f-9e10-9d75b8b786eb', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén SC50x600S', N'Hãng: Airtac', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'b8a98523-7875-4345-833e-9e3b00c6e26e', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 160', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'420a795c-e039-42ad-8d88-a044cf12c430', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén SC50x75S', N'Hãng: Airtac.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd6798720-3915-4b33-834b-a485b03619fa', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 60-76', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f45e5007-3407-4743-a0d9-a485e693b8aa', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 200', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'197a2c35-d10e-4cf9-93f3-a5c3e47bb8ba', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa SC136', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ad9d067e-3c45-464d-9c00-a9b54324bcec', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 185A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'cb7a1d05-3d03-46c7-8cf0-aa5a2acc398f', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B49', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fd541d05-2377-4608-a1ea-aaa7c25c85cd', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 76', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'd2188980-005b-4500-9fca-ab7db8f32daf', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 49', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'5abcf160-234e-450e-80ba-ab9af7ff768f', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 32A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'42fe8545-b5d9-423e-a69d-af42a44e4870', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 34', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1988a4ac-9034-4ee2-aef2-b274b3f88ae7', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Tê nhựa phi 110', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'22d81861-f501-4899-9cca-b2e62962d86b', N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cánh bơm bột  IHD125-80-160', N'Bơm IHD125-80-160; Q=160, H=26', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4a90f02b-5c92-495a-9a0e-b5fa5619b57e', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 76', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ecdd42ff-2b5d-4b71-85ff-b7208e631894', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 75A', N'Hãng SX: LS; Mitsubishi;3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'13b31320-d59c-406f-ada0-b764d316b3dc', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 140', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'cd57eb98-62d5-48aa-9681-b9441ffc906a', N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cánh bơm bã IHD125-80-160K', N'Bơm IHD125-80-160K; Q=160, H=26', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'07981784-4bb5-4d80-93fd-ba991b2bea22', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat BKN C32- 3P', N'Hãng SX: LS; Mitsubishi', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'91acb4cf-17d8-42a4-bd1f-bab644530714', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 65A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8aadf39b-fd94-4612-8e04-bd8b9b39c150', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 140', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'65b5e742-4520-4244-a9ca-beb48ef2cf4c', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén 50x200', N'Hãng: Airtac', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7433cbef-7dd6-48b1-98a1-c2f0d309bdf7', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi  200', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'aa46e7b1-679c-4a55-93ba-c47c1b74c1ea', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le điện từ MK2P-I 250VAC 7A', N'Hiệu omron ', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3aad7237-5dbd-4eed-b88f-c93a404382a1', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat BKN C20- 2P', N'Hãng SX: LS; Mitsubishi', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'b9c84a74-5da3-4797-bf3d-c997ed105fae', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 34', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'20bc1cde-69f2-45c0-bbba-c9cb8cd4902b', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa A3050', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'631834d7-6d7d-4e9e-b288-cb40f1d8ecc7', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 34-27', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9edd23d2-e352-4926-be45-cb7b0173db9b', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 120-185A', N'Hãng LG (LS);MT-225', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8f188c09-cdd7-4c95-a72f-cba2420d4d6d', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 21', N'Phi  21; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'97a09f80-1197-4c58-9c75-cd7d4be6064e', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 630A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'11867285-623d-4ec9-98d7-d20cd8bd2916', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 40A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'df3a016f-0807-4970-9fab-d2e2a9b413cb', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 70-95A', N'Hãng LG (LS);MT-95', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3e35aca4-880b-4361-95a8-d3983b86c950', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 200', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'33e7e129-23ad-44f6-91c9-d3a373846575', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fa8bf436-3546-4f6d-a8f0-d45990f01482', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4414fad5-11c8-453c-a485-d509befec2a8', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 110', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'0fbb1191-b4ff-431b-8780-d5a4fc20fecf', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 76', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e256845c-93cf-403e-9f74-d6d4d605ef0b', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 85A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'37088278-c4d1-4bed-8354-d89a69915d23', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 34', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f5cd4c1d-5bf9-4b6d-b593-dac19f5f61cd', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 60', N'Dày 4mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fe7cd16d-ff51-4c16-b9a7-db503f5edcb7', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 12-18A', N'Hãng LG (LS);MT-12', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1c66ce71-f116-4f94-b35b-db606f85aaa3', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 90', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'e2931e79-30df-445c-b7b9-db734ab03930', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'45eb383b-a661-4def-91fb-529127d36c51', N'Rơ le điện từ + chân đế MK2P-I 12VDC 10A', N'Hiệu omron ', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9e3e241a-c2f9-4236-8f22-dbe48e4b0580', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén SC50x150S', N'Hãng: Airtac', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9a674dbc-52c3-41db-8fad-dc2be6cce3e6', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 90', N'Dày 5,4mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'55597aba-1ae4-4e6b-b57e-ddf687f95fb7', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 49', N'Dày 3,5mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'b850b159-8e4c-43b6-abe8-de904d726d94', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 160-240A', N'Hãng LG (LS);MT-225', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'77e05587-e5f7-464f-8bc4-df2e13cbac83', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3d468861-7c65-4fd7-9899-e1b0b28730ed', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B64', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'a767e0e4-bd22-4ba4-a184-e208e0ea2544', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén 50x800', N'Hãng: Airtac', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f6f99f11-2e16-4b28-a996-e30f22318f47', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7acddf47-451b-4f14-90c8-e311b4b57d79', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa 5VX750', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4532655a-6175-4e91-84be-e37f1af46c3f', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 114', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'1524a7f4-b8c4-4ba2-abf3-e3cc9008895c', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 49', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'82ed7733-0653-4b64-8707-e4081950e776', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 110', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'97c527c0-d432-410e-85d3-e5dd23448b0e', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa C145', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'78da6aaf-c000-4233-93f0-e6d0568aa9a8', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B82', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f736c3c0-7590-4906-a007-e824456257fc', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 160', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'a3363b36-02de-4d27-b83c-e8ea29fd90cc', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 114', N'Dày 5mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'09137f48-1be8-4174-b8ef-e91e3f282a64', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 60', N'Phi 60; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'971dcf8e-225b-453d-bf1f-e9836e0141f2', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Van nhựa phi 27', N'Phi 27; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f49da679-c572-4f8a-86f4-e9fd7395eb43', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Côn chuyển phi 42-34', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'7caf1f0a-43a5-42e7-a6b7-ebd7f7a065cb', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat 100A', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực', 1, N'')
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f3e3b1eb-81e0-49e0-8ca2-ec2200ef8e19', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat BKN C20- 3P', N'Hãng SX: LS; Mitsubishi', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'2beca8b6-5cdf-48a0-9190-ecf5d28872b4', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 100A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4c9315ca-0caf-42e5-ae36-eed628e89c3d', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co lơ nhựa phi 42', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'9dc47d0a-1022-4640-b1d6-f054d96bc4f1', N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Contactor 130A (220v)', N'Hãng SX: LS; Mitsubishi; 3 pha 3 cực.', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3b8ce09b-af16-4cb9-8dbe-f2592f096f0e', N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Cánh bơm bột IHD100-80-160', N'Bơm IHD100-80-160; Q=100, H=32', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'52ac1301-db7c-41fe-91e9-f2b05b374168', N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Xi lanh khí nén 63x200', N'Hãng: Airtac', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'f4bcd9f3-8ce9-467d-90b8-f568acf87bc2', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Co nhựa phi 42', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'c65f9b35-d29e-4d53-a8d3-f69923334187', N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Rơ le nhiệt 95-130A', N'Hãng LG (LS);MT-150', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'ccc1c1e0-5994-4858-98fa-f6f238ee35a8', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Măng song phi 49', N'Dày 3mm; Đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'4622e9e5-c2dc-47ac-8f03-f8b14dc323f8', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Mặt bích nhựa phi 60', N'Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3f780ef5-a019-4b20-9d29-f8f9d0a5b52b', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B70', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'fea5ad00-68b2-44e9-bb55-fb627a5a1b6c', N'a4e309de-3ca6-4658-a490-953a01354aeb', N'26542b8d-0d40-47ca-8875-2b53c2c126da', N'Dây cu roa B74', N'Hãng ADR', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'8de86107-de8d-4622-a927-fbbb8a569c15', N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'49b9bd28-3069-45fd-9afc-570edd0546df', N'Ống nhựa phi 140', N'Dày 5,4mm; Hãng đệ Nhất', 1, NULL)
GO
INSERT [dbo].[DmLoaiVatTu] ([Id], [IdNhomVatTu], [IdDonViTinh], [Ten], [QuyCach], [TrangThai], [ChuThich]) VALUES (N'3065f0f2-a097-4438-a8de-ff403c29f142', N'59b6b860-f096-4e73-94cb-27427d3878c5', N'f3d92f03-b376-4b2c-bcdd-912af35af464', N'Aptomat BKN C50 - 3P', N'Hãng SX: LS; Mitsubishi', 1, NULL)
GO
INSERT [dbo].[DmNguonKho] ([Id], [IdKhoHang], [IdNguonNhap]) VALUES (N'2a9b018c-1802-4d2a-9f0b-0447aa1e16c6', 1, N'8380b88a-297a-4598-b356-13f490f21cb5')
GO
INSERT [dbo].[DmNguonKho] ([Id], [IdKhoHang], [IdNguonNhap]) VALUES (N'09f22e68-ce31-46a6-82af-09bc716cf33a', 2, N'835f11ff-62d5-4acf-8bf8-21b2315dfef3')
GO
INSERT [dbo].[DmNguonNhap] ([Id], [Ten], [DiaChi], [LienHe], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'8380b88a-297a-4598-b356-13f490f21cb5', N'Kho tổng', N'ĐN', N'', 0, -2, N'')
GO
INSERT [dbo].[DmNguonNhap] ([Id], [Ten], [DiaChi], [LienHe], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'835f11ff-62d5-4acf-8bf8-21b2315dfef3', N'Chi nhánh', N'ĐN', N'', 0, -2, N'')
GO
INSERT [dbo].[DmNguonNhap] ([Id], [Ten], [DiaChi], [LienHe], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'Công ty TNHH Nhựt Linh', N'Đà nẵng', NULL, 1, 1, N'')
GO
INSERT [dbo].[DmNguonNhap] ([Id], [Ten], [DiaChi], [LienHe], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'bb23a492-cd57-454a-8a72-f57f2f988e47', N'Hàng tồn', N'Đà nẵng', N'', 1, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'59b6b860-f096-4e73-94cb-27427d3878c5', N'Aptomat', 1, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'47e0664e-61fe-4e6f-bdf9-3260d00416c3', N'Xi lanh', 7, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'bb450d0e-38a0-4fd3-b442-35812fe1cd0f', N'Công tắc', 3, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'14f84a20-6ddd-436d-85d1-6f2ca6cac7c5', N'Cánh bơm', 2, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'3116ed1b-2a6b-4bf9-b584-855ee795483b', N'Ống nhựa', 5, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'5fd4deff-6d67-4ee2-9dcf-89e3588fe59c', N'Rơ le', 6, 1, N'')
GO
INSERT [dbo].[DmNhomVatTu] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (N'a4e309de-3ca6-4658-a490-953a01354aeb', N'Dây cu roa', 4, 1, N'')
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'BanQuyen', 1, N'Bản quyền', 5, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'BoPhan', 2, N'Bộ phận', 4, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'ChiNhanh', 2, N'Chi nhánh', 1, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'DonViTinh', 2, N'Đơn vị tính', 7, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangChuyen', 4, N'Hàng chuyển', 3, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangLuuKho', 4, N'Hàng lưu kho', 6, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangNhap', 4, N'Hàng nhập', 1, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangTonKho', 3, N'Hàng tồn kho', 8, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangTonTheoKho', 4, N'Hàng tồn theo kho', 8, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'HangXuat', 4, N'Hàng xuất', 2, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'KhoHang', 2, N'Kho hàng', 2, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'LoaiVatTu', 2, N'Loại vật tư', 6, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'NguoiDung', 1, N'Người dùng', 3, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'NguonNhap', 2, N'Nguồn nhập', 3, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'NhapXuatTon', 4, N'Nhập xuất tồn', 5, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'NhomVatTu', 2, N'Nhóm vật tư', 5, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'PhanQuyen', 1, N'Phân quyền', 4, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'PhieuChuyen', 3, N'Phiếu chuyển', 4, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'PhieuNhap', 3, N'Phiếu nhập', 1, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'PhieuNhapNb', 3, N'Phiếu nhận hàng', 5, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'PhieuXuat', 3, N'Phiếu xuất', 2, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'ThietLap', 1, N'Thiết lập', 1, NULL)
GO
INSERT [dbo].[HtChucNang] ([TenForm], [IdPhanHe], [Ten], [ThuTu], [ChuThich]) VALUES (N'VaiTro', 1, N'Vai trò', 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[HtNguoiDung] ON 
GO
INSERT [dbo].[HtNguoiDung] ([Id], [Ten], [TenTruyCap], [MatKhau], [DangNhap], [TrangThai], [ChuThich]) VALUES (1, N'Quản trị', N'admin', N'21232f297a57a5a743894a0e4a801fc3', 1, 1, N'')
GO
INSERT [dbo].[HtNguoiDung] ([Id], [Ten], [TenTruyCap], [MatKhau], [DangNhap], [TrangThai], [ChuThich]) VALUES (2, N'Thủ kho tổng', N'thukhotong', N'9d067a3405c4eff48edd0bc6a4716a99', 1, 1, N'')
GO
INSERT [dbo].[HtNguoiDung] ([Id], [Ten], [TenTruyCap], [MatKhau], [DangNhap], [TrangThai], [ChuThich]) VALUES (3, N'Thủ kho Chi nhánh', N'thukhocn', N'871557b6d44a7922fc30d791f9a0ddc8', 1, 1, N'')
GO
SET IDENTITY_INSERT [dbo].[HtNguoiDung] OFF
GO
SET IDENTITY_INSERT [dbo].[HtNguoiDungVaiTro] ON 
GO
INSERT [dbo].[HtNguoiDungVaiTro] ([Id], [IdNguoiDung], [IdVaiTro], [IdKhoHang], [MacDinh]) VALUES (1, 1, 1, 1, 1)
GO
INSERT [dbo].[HtNguoiDungVaiTro] ([Id], [IdNguoiDung], [IdVaiTro], [IdKhoHang], [MacDinh]) VALUES (2, 1, 1, 2, 0)
GO
INSERT [dbo].[HtNguoiDungVaiTro] ([Id], [IdNguoiDung], [IdVaiTro], [IdKhoHang], [MacDinh]) VALUES (3, 2, 2, 1, 1)
GO
INSERT [dbo].[HtNguoiDungVaiTro] ([Id], [IdNguoiDung], [IdVaiTro], [IdKhoHang], [MacDinh]) VALUES (4, 3, 2, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[HtNguoiDungVaiTro] OFF
GO
INSERT [dbo].[HtPhanHe] ([Id], [Ten], [ThuTu], [ChuThich]) VALUES (1, N'Hệ thống', 1, N'1')
GO
INSERT [dbo].[HtPhanHe] ([Id], [Ten], [ThuTu], [ChuThich]) VALUES (2, N'Danh mục', 2, N'1')
GO
INSERT [dbo].[HtPhanHe] ([Id], [Ten], [ThuTu], [ChuThich]) VALUES (3, N'Kho hàng', 3, N'1')
GO
INSERT [dbo].[HtPhanHe] ([Id], [Ten], [ThuTu], [ChuThich]) VALUES (4, N'Báo cáo', 4, N'1')
GO
SET IDENTITY_INSERT [dbo].[HtQuyenHan] ON 
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (2, 1, N'BoPhan', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (3, 1, N'ChiNhanh', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (4, 1, N'DonViTinh', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (5, 1, N'HangChuyen', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (6, 1, N'HangLuuKho', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (7, 1, N'HangNhap', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (8, 1, N'HangTon', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (11, 1, N'HangXuat', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (13, 1, N'KhoHang', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (14, 1, N'LoaiVatTu', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (15, 1, N'NguoiDung', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (16, 1, N'NguonNhap', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (17, 1, N'NhapXuatTon', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (19, 1, N'NhomVatTu', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (20, 1, N'PhanQuyen', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (21, 1, N'PhieuChuyen', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (23, 1, N'PhieuNhap', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (24, 1, N'PhieuNhapNb', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (26, 1, N'PhieuXuat', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (28, 1, N'ThietLap', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (29, 1, N'VaiTro', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (32, 1, N'HangTonKho', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (33, 1, N'HangTonTheoKho', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (62, 2, N'HangNhap', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (63, 2, N'PhieuNhap', 1, 1, 1, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (64, 2, N'HangXuat', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (65, 2, N'PhieuXuat', 1, 1, 1, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (66, 2, N'HangChuyen', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (67, 2, N'BoPhan', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (68, 2, N'PhieuChuyen', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (69, 2, N'NhapXuatTon', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (70, 2, N'NhomVatTu', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (71, 2, N'PhieuNhapNb', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (72, 2, N'HangLuuKho', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (73, 2, N'LoaiVatTu', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (74, 2, N'DonViTinh', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (75, 2, N'HangTonKho', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (76, 2, N'HangTonTheoKho', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (77, 3, N'ChiNhanh', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (78, 3, N'HangNhap', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (79, 3, N'PhieuNhap', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (80, 3, N'HangXuat', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (81, 3, N'KhoHang', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (82, 3, N'PhieuXuat', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (83, 3, N'HangChuyen', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (84, 3, N'NguonNhap', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (85, 3, N'BoPhan', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (86, 3, N'PhieuChuyen', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (87, 3, N'NhapXuatTon', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (88, 3, N'NhomVatTu', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (89, 3, N'PhieuNhapNb', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (90, 3, N'HangLuuKho', 1, 0, 0, 0)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (91, 3, N'LoaiVatTu', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (92, 3, N'DonViTinh', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (93, 3, N'HangTonKho', 1, 1, 1, 1)
GO
INSERT [dbo].[HtQuyenHan] ([Id], [IdVaiTro], [TenForm], [Xem], [Them], [Sua], [Xoa]) VALUES (94, 3, N'HangTonTheoKho', 1, 0, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[HtQuyenHan] OFF
GO
INSERT [dbo].[HtThietLap] ([Id], [TenPhanMem], [NgayDuLieu], [KieuKhoa], [ThoiGianKhoa], [XoaQuaNgay]) VALUES (1, N'Inventory Warehouse Management System', 90, 1, 5, 1)
GO
SET IDENTITY_INSERT [dbo].[HtVaiTro] ON 
GO
INSERT [dbo].[HtVaiTro] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (1, N'Quản trị', 1, 1, N'')
GO
INSERT [dbo].[HtVaiTro] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (2, N'Thủ kho', 2, 1, N'')
GO
INSERT [dbo].[HtVaiTro] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (3, N'Quản lý', 3, 1, N'')
GO
INSERT [dbo].[HtVaiTro] ([Id], [Ten], [ThuTu], [TrangThai], [ChuThich]) VALUES (4, N'Giao nhận', 4, 1, N'')
GO
SET IDENTITY_INSERT [dbo].[HtVaiTro] OFF
GO
INSERT [dbo].[KhPhieuChuyen] ([Id], [IdKhoHang], [IdKhoNhan], [SoPhieu], [IdNguoiGiao], [TrangThai], [TrangThaiNhan], [IdNguoiTao], [NgayTao], [NgayTaoDate], [ChuThich]) VALUES (N'5c5fd319-3053-469f-94c0-c37b73fcac8d', 1, 2, N'PCK106210001', 1, 1, 1, 1, CAST(N'2021-06-15T14:44:12.097' AS DateTime), CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuChuyenCt] ([Id], [IdPhieuChuyen], [IdLoaiVatTu], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'8898ed71-5517-4abf-b7b2-bb7ad1396ef5', N'5c5fd319-3053-469f-94c0-c37b73fcac8d', N'54fad264-c2cf-45c7-90a9-03b7c9adce39', 5, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuChuyenCt] ([Id], [IdPhieuChuyen], [IdLoaiVatTu], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'3337f85d-f2bc-4e54-894a-f302befef7b4', N'5c5fd319-3053-469f-94c0-c37b73fcac8d', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', 5, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuChuyenSp] ([Id], [IdPhieuChuyenCt], [IdSanPham], [SoLuong], [NgayTaoDate]) VALUES (N'5bcc4803-099d-4fe4-b094-90b97223aa5f', N'8898ed71-5517-4abf-b7b2-bb7ad1396ef5', N'3eb51c55-c432-4f69-9beb-a4fa168800b9', 5, CAST(N'2021-06-15' AS Date))
GO
INSERT [dbo].[KhPhieuChuyenSp] ([Id], [IdPhieuChuyenCt], [IdSanPham], [SoLuong], [NgayTaoDate]) VALUES (N'40134d9d-d555-4b38-952f-d2ce74cf6a25', N'3337f85d-f2bc-4e54-894a-f302befef7b4', N'07f79c54-4f76-4574-a649-666529e2ca40', 5, CAST(N'2021-06-15' AS Date))
GO
INSERT [dbo].[KhPhieuNhap] ([Id], [IdKhoHang], [IdNguonNhap], [IdPhieuChuyen], [IdKhoChuyen], [LoaiNhap], [SoPhieu], [IdNguoiTao], [NgayTao], [NgayTaoDate], [UpdateTon], [ChuThich]) VALUES (N'3f06b69c-8f8b-4b6f-99b7-6672485adff9', 2, N'8380b88a-297a-4598-b356-13f490f21cb5', N'5c5fd319-3053-469f-94c0-c37b73fcac8d', 1, 2, N'PNK206210001', 1, CAST(N'2021-06-15T15:13:28.437' AS DateTime), CAST(N'2021-06-15' AS Date), 0, NULL)
GO
INSERT [dbo].[KhPhieuNhap] ([Id], [IdKhoHang], [IdNguonNhap], [IdPhieuChuyen], [IdKhoChuyen], [LoaiNhap], [SoPhieu], [IdNguoiTao], [NgayTao], [NgayTaoDate], [UpdateTon], [ChuThich]) VALUES (N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', NULL, NULL, 0, N'PNK106210001', 1, CAST(N'2021-06-15T14:01:23.500' AS DateTime), CAST(N'2021-06-15' AS Date), 0, N'')
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'214cd33d-f09a-4a12-99ca-1300014e46a4', N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', N'07f79c54-4f76-4574-a649-666529e2ca40', 20, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'f519987f-ffec-4a31-a30c-5796c7d59cc7', N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', N'9edd23d2-e352-4926-be45-cb7b0173db9b', N'cca9428c-5219-45a6-a501-d37059869150', 17, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'891c936e-2705-43e3-9222-ba5ad5c39463', N'3f06b69c-8f8b-4b6f-99b7-6672485adff9', N'54fad264-c2cf-45c7-90a9-03b7c9adce39', N'667695ad-5e4b-4b12-b664-4016e0c24d33', 5, CAST(N'2021-06-15' AS Date), NULL)
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'cc269fd6-c601-4bec-a38a-bd4f9bcd1e05', N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', N'64a8cc1e-ee28-4bc4-9de0-0d07a1efb030', N'9e48399d-88e3-4f62-9ff7-53675dc17833', 10, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'f768da8d-7ea0-4772-bb1e-ccdf06ca1971', N'3f06b69c-8f8b-4b6f-99b7-6672485adff9', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', N'a791bbc5-acbf-418d-bf1e-41482c6f8d06', 5, CAST(N'2021-06-15' AS Date), NULL)
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'9b7e5ad6-0b75-49c6-a77c-f23b15f873a4', N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', N'971dcf8e-225b-453d-bf1f-e9836e0141f2', N'a543351d-81c8-4a4b-8cdf-726a1655ed05', 10, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuNhapCt] ([Id], [IdPhieuNhap], [IdLoaiVatTu], [IdSanPham], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'59f08aa8-e6c4-4928-acc8-f901f800b4b8', N'02fc127e-2a2f-4c47-a5f8-85055a9a2bab', N'54fad264-c2cf-45c7-90a9-03b7c9adce39', N'3eb51c55-c432-4f69-9beb-a4fa168800b9', 10, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuXuat] ([Id], [IdKhoHang], [IdBoPhan], [SoPhieu], [IdNguoiNhan], [IdNguoiTao], [NgayTao], [NgayTaoDate], [UpdateTon], [ChuThich]) VALUES (N'22ed8467-8d21-443b-b5f3-75b53184a4ff', 1, N'6f84e1c5-3cd5-4cc2-abcd-73a1898345ac', N'PXK106210001', 1, 1, CAST(N'2021-06-15T15:20:11.817' AS DateTime), CAST(N'2021-06-15' AS Date), 0, N'')
GO
INSERT [dbo].[KhPhieuXuatCt] ([Id], [IdPhieuXuat], [IdLoaiVatTu], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'459089a7-7314-4c86-905d-4c1946214473', N'22ed8467-8d21-443b-b5f3-75b53184a4ff', N'64a8cc1e-ee28-4bc4-9de0-0d07a1efb030', 2, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuXuatCt] ([Id], [IdPhieuXuat], [IdLoaiVatTu], [SoLuong], [NgayTaoDate], [ChuThich]) VALUES (N'0c27892a-a6e6-4036-a3ea-b2f799fc3e39', N'22ed8467-8d21-443b-b5f3-75b53184a4ff', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', 5, CAST(N'2021-06-15' AS Date), N'')
GO
INSERT [dbo].[KhPhieuXuatSp] ([Id], [IdPhieuXuatCt], [IdSanPham], [SoLuong]) VALUES (N'17a63e96-9f09-4a63-99c4-5ded1290725e', N'0c27892a-a6e6-4036-a3ea-b2f799fc3e39', N'07f79c54-4f76-4574-a649-666529e2ca40', 5)
GO
INSERT [dbo].[KhPhieuXuatSp] ([Id], [IdPhieuXuatCt], [IdSanPham], [SoLuong]) VALUES (N'4d07eb08-6d33-4393-9962-a3e3d087a0c3', N'459089a7-7314-4c86-905d-4c1946214473', N'9e48399d-88e3-4f62-9ff7-53675dc17833', 2)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'667695ad-5e4b-4b12-b664-4016e0c24d33', N'3eb51c55-c432-4f69-9beb-a4fa168800b9', 2, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'54fad264-c2cf-45c7-90a9-03b7c9adce39', 5, 5, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'a791bbc5-acbf-418d-bf1e-41482c6f8d06', N'07f79c54-4f76-4574-a649-666529e2ca40', 2, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', 5, 5, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'9e48399d-88e3-4f62-9ff7-53675dc17833', N'9e48399d-88e3-4f62-9ff7-53675dc17833', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'64a8cc1e-ee28-4bc4-9de0-0d07a1efb030', 10, 8, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'07f79c54-4f76-4574-a649-666529e2ca40', N'07f79c54-4f76-4574-a649-666529e2ca40', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'cd57eb98-62d5-48aa-9681-b9441ffc906a', 20, 10, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'a543351d-81c8-4a4b-8cdf-726a1655ed05', N'a543351d-81c8-4a4b-8cdf-726a1655ed05', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'971dcf8e-225b-453d-bf1f-e9836e0141f2', 10, 10, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'3eb51c55-c432-4f69-9beb-a4fa168800b9', N'3eb51c55-c432-4f69-9beb-a4fa168800b9', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'54fad264-c2cf-45c7-90a9-03b7c9adce39', 10, 5, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
INSERT [dbo].[KhSanPham] ([Id], [IdSanPham], [IdKhoHang], [IdNguonNhap], [IdLoaiVatTu], [SoLuongNhap], [SoLuongTon], [NgayTao], [ChuThich]) VALUES (N'cca9428c-5219-45a6-a501-d37059869150', N'cca9428c-5219-45a6-a501-d37059869150', 1, N'a7dc57fa-5ca8-422f-82ab-b894626accfd', N'9edd23d2-e352-4926-be45-cb7b0173db9b', 17, 17, CAST(N'2021-06-15T14:01:23.500' AS DateTime), NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_DM_KhoHang_TenVietTat]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[DmKhoHang] ADD  CONSTRAINT [UQ_DM_KhoHang_TenVietTat] UNIQUE NONCLUSTERED 
(
	[TenVietTat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_DM_LoaiVatTu_IdDonViTinh_TrangThai]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_DM_LoaiVatTu_IdDonViTinh_TrangThai] ON [dbo].[DmLoaiVatTu]
(
	[IdDonViTinh] ASC,
	[TrangThai] ASC
)
INCLUDE([Id],[Ten]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_DM_LoaiVatTu_IdNhomVatTu_TrangThai]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_DM_LoaiVatTu_IdNhomVatTu_TrangThai] ON [dbo].[DmLoaiVatTu]
(
	[IdNhomVatTu] ASC,
	[TrangThai] ASC
)
INCLUDE([Id],[Ten]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_HT_NguoiDung_TenTruyCap]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[HtNguoiDung] ADD  CONSTRAINT [UQ_HT_NguoiDung_TenTruyCap] UNIQUE NONCLUSTERED 
(
	[TenTruyCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [UQ_HT_NguoiDungVaiTro_IdVaiTro_IdNguoiDun_IdKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[HtNguoiDungVaiTro] ADD  CONSTRAINT [UQ_HT_NguoiDungVaiTro_IdVaiTro_IdNguoiDun_IdKhoHang] UNIQUE NONCLUSTERED 
(
	[IdVaiTro] ASC,
	[IdNguoiDung] ASC,
	[IdKhoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [INDEX]
GO
/****** Object:  Index [UQ_HT_NguoiDungVaiTro_IdVaiTro_IdNguoiDung_IdKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[HtNguoiDungVaiTro] ADD  CONSTRAINT [UQ_HT_NguoiDungVaiTro_IdVaiTro_IdNguoiDung_IdKhoHang] UNIQUE NONCLUSTERED 
(
	[IdVaiTro] ASC,
	[IdNguoiDung] ASC,
	[IdKhoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [INDEX]
GO
/****** Object:  Index [UQ_KH_NhapXuat_IdKhoHang_IdLoaiSanPham_Thang]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[KhNhapXuat] ADD  CONSTRAINT [UQ_KH_NhapXuat_IdKhoHang_IdLoaiSanPham_Thang] UNIQUE NONCLUSTERED 
(
	[IdKhoHang] ASC,
	[IdLoaiVatTu] ASC,
	[Thang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_IdKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_IdKhoHang] ON [dbo].[KhPhieuChuyen]
(
	[IdKhoHang] ASC
)
INCLUDE([NgayTao],[SoPhieu]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_IdKhoHang_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_IdKhoHang_NgayTaoDate] ON [dbo].[KhPhieuChuyen]
(
	[IdKhoHang] ASC,
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_IdKhoHang_TrangThai_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_IdKhoHang_TrangThai_NgayTaoDate] ON [dbo].[KhPhieuChuyen]
(
	[IdKhoHang] ASC,
	[TrangThai] ASC,
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_IdKhoNhan_NgayTaoDate_TrangThai]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_IdKhoNhan_NgayTaoDate_TrangThai] ON [dbo].[KhPhieuChuyen]
(
	[IdKhoNhan] ASC,
	[NgayTaoDate] ASC,
	[TrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [UQ_KH_PhieuChuyen_Ct_IdPhieuChuyen_IdLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[KhPhieuChuyenCt] ADD  CONSTRAINT [UQ_KH_PhieuChuyen_Ct_IdPhieuChuyen_IdLoaiVatTu] UNIQUE NONCLUSTERED 
(
	[IdPhieuChuyen] ASC,
	[IdLoaiVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_Ct_IdLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_Ct_IdLoaiVatTu] ON [dbo].[KhPhieuChuyenCt]
(
	[IdLoaiVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_Ct_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_Ct_NgayTaoDate] ON [dbo].[KhPhieuChuyenCt]
(
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuChuyen_Sp_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuChuyen_Sp_NgayTaoDate] ON [dbo].[KhPhieuChuyenSp]
(
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_IdKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_IdKhoHang] ON [dbo].[KhPhieuNhap]
(
	[IdKhoHang] ASC
)
INCLUDE([NgayTao],[SoPhieu]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_IdKhoHang_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_IdKhoHang_NgayTaoDate] ON [dbo].[KhPhieuNhap]
(
	[IdKhoHang] ASC,
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_LoaiNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_LoaiNhap] ON [dbo].[KhPhieuNhap]
(
	[LoaiNhap] ASC
)
INCLUDE([Id],[IdKhoHang],[SoPhieu],[NgayTao]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_LoaiNhap_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_LoaiNhap_NgayTaoDate] ON [dbo].[KhPhieuNhap]
(
	[LoaiNhap] ASC,
	[NgayTaoDate] ASC
)
INCLUDE([Id]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [UQ_KH_PhieuNhap_Ct_IdPhieuNhap_IdLoaiVatTu_IdSanPham]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[KhPhieuNhapCt] ADD  CONSTRAINT [UQ_KH_PhieuNhap_Ct_IdPhieuNhap_IdLoaiVatTu_IdSanPham] UNIQUE NONCLUSTERED 
(
	[IdPhieuNhap] ASC,
	[IdLoaiVatTu] ASC,
	[IdSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_Ct_IdLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_Ct_IdLoaiVatTu] ON [dbo].[KhPhieuNhapCt]
(
	[IdLoaiVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_Ct_IdSanPham]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_Ct_IdSanPham] ON [dbo].[KhPhieuNhapCt]
(
	[IdSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuNhap_Ct_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuNhap_Ct_NgayTaoDate] ON [dbo].[KhPhieuNhapCt]
(
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [UQ_KH_PhieuNhapNb_Ct_IdPhieuNhapNb_IdLoaiVatTu_IdSanPham]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[KhPhieuNhapNbCt] ADD  CONSTRAINT [UQ_KH_PhieuNhapNb_Ct_IdPhieuNhapNb_IdLoaiVatTu_IdSanPham] UNIQUE NONCLUSTERED 
(
	[IdPhieuNhapNb] ASC,
	[IdLoaiVatTu] ASC,
	[IdSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuXuat_IdKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuXuat_IdKhoHang] ON [dbo].[KhPhieuXuat]
(
	[IdKhoHang] ASC
)
INCLUDE([NgayTao],[SoPhieu]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuXuat_IdKhoHang_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuXuat_IdKhoHang_NgayTaoDate] ON [dbo].[KhPhieuXuat]
(
	[IdKhoHang] ASC,
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 100) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuXuat_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuXuat_NgayTaoDate] ON [dbo].[KhPhieuXuat]
(
	[NgayTaoDate] ASC
)
INCLUDE([Id]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_KH_PhieuXuat_Ct_IdPhieuXuat_IdLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
ALTER TABLE [dbo].[KhPhieuXuatCt] ADD  CONSTRAINT [UQ_KH_PhieuXuat_Ct_IdPhieuXuat_IdLoaiVatTu] UNIQUE NONCLUSTERED 
(
	[IdPhieuXuat] ASC,
	[IdLoaiVatTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuXuat_Ct_IdLoaiVatTu]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuXuat_Ct_IdLoaiVatTu] ON [dbo].[KhPhieuXuatCt]
(
	[IdLoaiVatTu] ASC
)
INCLUDE([IdPhieuXuat],[SoLuong]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_PhieuXuat_Ct_NgayTaoDate]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_PhieuXuat_Ct_NgayTaoDate] ON [dbo].[KhPhieuXuatCt]
(
	[NgayTaoDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_SanPham_IdKhoHang_IdLoaiVatTu_SoLuongTon]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_SanPham_IdKhoHang_IdLoaiVatTu_SoLuongTon] ON [dbo].[KhSanPham]
(
	[IdKhoHang] ASC,
	[IdLoaiVatTu] ASC,
	[SoLuongTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_SanPham_IdKhoHang_SoLuongTon]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_SanPham_IdKhoHang_SoLuongTon] ON [dbo].[KhSanPham]
(
	[IdKhoHang] ASC,
	[SoLuongTon] ASC
)
INCLUDE([Id],[IdLoaiVatTu]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_SanPham_IdLoaiVatTu_SoLuongTon]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_SanPham_IdLoaiVatTu_SoLuongTon] ON [dbo].[KhSanPham]
(
	[IdLoaiVatTu] ASC,
	[SoLuongTon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
/****** Object:  Index [IX_KH_SanPham_SoLuongTon]    Script Date: 11/07/2021 12:37:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_KH_SanPham_SoLuongTon] ON [dbo].[KhSanPham]
(
	[SoLuongTon] ASC
)
INCLUDE([IdKhoHang],[IdLoaiVatTu]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [INDEX]
GO
ALTER TABLE [dbo].[DmBoPhan] ADD  CONSTRAINT [DF_DM_BoPhan_ThuTu]  DEFAULT ((0)) FOR [ThuTu]
GO
ALTER TABLE [dbo].[DmBoPhan] ADD  CONSTRAINT [DF_DM_BoPhan_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DmChiNhanh] ADD  CONSTRAINT [DF_DM_ChiNhanh_ThuTu]  DEFAULT ((0)) FOR [ThuTu]
GO
ALTER TABLE [dbo].[DmChiNhanh] ADD  CONSTRAINT [DF_DM_ChiNhanh_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DmNguonKho] ADD  CONSTRAINT [DF_DM_NguonKho_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[DmNguonNhap] ADD  CONSTRAINT [DF_DM_NguonNhap_ThuTu]  DEFAULT ((0)) FOR [ThuTu]
GO
ALTER TABLE [dbo].[DmNguonNhap] ADD  CONSTRAINT [DF_DM_NguonNhap_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro] ADD  CONSTRAINT [DF_HT_NguoiDungVaiTro_MacDinh]  DEFAULT ((0)) FOR [MacDinh]
GO
ALTER TABLE [dbo].[HtThietLap] ADD  CONSTRAINT [DF_HT_ThietLap_NgayDuLieu]  DEFAULT ((0)) FOR [NgayDuLieu]
GO
ALTER TABLE [dbo].[HtThietLap] ADD  CONSTRAINT [DF_HT_ThietLap_KieuKhoa]  DEFAULT ((0)) FOR [KieuKhoa]
GO
ALTER TABLE [dbo].[HtThietLap] ADD  CONSTRAINT [DF_HT_ThietLap_ThoiGianKhoa]  DEFAULT ((0)) FOR [ThoiGianKhoa]
GO
ALTER TABLE [dbo].[HtThietLap] ADD  CONSTRAINT [DF_HT_ThietLap_XoaQuaNgay]  DEFAULT ((0)) FOR [XoaQuaNgay]
GO
ALTER TABLE [dbo].[HtVaiTro] ADD  CONSTRAINT [DF_HT_VaiTro_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[KhNhapXuat] ADD  CONSTRAINT [DF_KH_NhapXuat_Nhap]  DEFAULT ((0)) FOR [Nhap]
GO
ALTER TABLE [dbo].[KhNhapXuat] ADD  CONSTRAINT [DF_KH_NhapXuat_Xuat]  DEFAULT ((0)) FOR [Xuat]
GO
ALTER TABLE [dbo].[KhNhapXuat] ADD  CONSTRAINT [DF_KH_NhapXuat_Chuyen]  DEFAULT ((0)) FOR [Chuyen]
GO
ALTER TABLE [dbo].[KhPhieuChuyen] ADD  CONSTRAINT [DF_KH_PhieuChuyen_TrangThaiNhan]  DEFAULT ((1)) FOR [TrangThaiNhan]
GO
ALTER TABLE [dbo].[KhPhieuChuyenCt] ADD  CONSTRAINT [DF_KH_PhieuChuyen_Ct_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhPhieuChuyenSp] ADD  CONSTRAINT [DF_KH_PhieuChuyen_Sp_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhPhieuNhap] ADD  CONSTRAINT [DF_KH_PhieuNhap_LoaiNhap]  DEFAULT ((0)) FOR [LoaiNhap]
GO
ALTER TABLE [dbo].[KhPhieuNhap] ADD  CONSTRAINT [DF_KH_PhieuNhap_UpdateTon]  DEFAULT ((0)) FOR [UpdateTon]
GO
ALTER TABLE [dbo].[KhPhieuNhapCt] ADD  CONSTRAINT [DF_KH_PhieuNhap_Ct_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] ADD  CONSTRAINT [DF_KH_PhieuNhapNb_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt] ADD  CONSTRAINT [DF_KH_PhieuNhapNb_Ct_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt] ADD  CONSTRAINT [DF_KH_PhieuNhapNb_Ct_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[KhPhieuXuat] ADD  CONSTRAINT [DF_KH_PhieuXuat_UpdateTon]  DEFAULT ((0)) FOR [UpdateTon]
GO
ALTER TABLE [dbo].[KhPhieuXuatCt] ADD  CONSTRAINT [DF_KH_PhieuXuat_Ct_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhPhieuXuatSp] ADD  CONSTRAINT [DF_KH_PhieuXuat_Sp_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[KhSanPham] ADD  CONSTRAINT [DF_KH_SanPham_SoLuongNhap]  DEFAULT ((0)) FOR [SoLuongNhap]
GO
ALTER TABLE [dbo].[KhSanPham] ADD  CONSTRAINT [DF_KH_SanPham_SoLuongTon]  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[DmKhoHang]  WITH CHECK ADD  CONSTRAINT [FK_DM_KhoHang_DM_ChiNhanh] FOREIGN KEY([IdChiNhanh])
REFERENCES [dbo].[DmChiNhanh] ([Id])
GO
ALTER TABLE [dbo].[DmKhoHang] CHECK CONSTRAINT [FK_DM_KhoHang_DM_ChiNhanh]
GO
ALTER TABLE [dbo].[DmLoaiVatTu]  WITH CHECK ADD  CONSTRAINT [FK_DM_LoaiVatTu_DM_DonViTinh] FOREIGN KEY([IdDonViTinh])
REFERENCES [dbo].[DmDonViTinh] ([Id])
GO
ALTER TABLE [dbo].[DmLoaiVatTu] CHECK CONSTRAINT [FK_DM_LoaiVatTu_DM_DonViTinh]
GO
ALTER TABLE [dbo].[DmLoaiVatTu]  WITH CHECK ADD  CONSTRAINT [FK_DM_LoaiVatTu_DM_NhomVatTu] FOREIGN KEY([IdNhomVatTu])
REFERENCES [dbo].[DmNhomVatTu] ([Id])
GO
ALTER TABLE [dbo].[DmLoaiVatTu] CHECK CONSTRAINT [FK_DM_LoaiVatTu_DM_NhomVatTu]
GO
ALTER TABLE [dbo].[DmNguonKho]  WITH CHECK ADD  CONSTRAINT [FK_DM_NguonKho_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[DmNguonKho] CHECK CONSTRAINT [FK_DM_NguonKho_DM_KhoHang]
GO
ALTER TABLE [dbo].[DmNguonKho]  WITH CHECK ADD  CONSTRAINT [FK_DM_NguonKho_DM_NguonNhap] FOREIGN KEY([IdNguonNhap])
REFERENCES [dbo].[DmNguonNhap] ([Id])
GO
ALTER TABLE [dbo].[DmNguonKho] CHECK CONSTRAINT [FK_DM_NguonKho_DM_NguonNhap]
GO
ALTER TABLE [dbo].[HtChucNang]  WITH CHECK ADD  CONSTRAINT [FK_HT_ChucNang_HT_PhanHe] FOREIGN KEY([IdPhanHe])
REFERENCES [dbo].[HtPhanHe] ([Id])
GO
ALTER TABLE [dbo].[HtChucNang] CHECK CONSTRAINT [FK_HT_ChucNang_HT_PhanHe]
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro]  WITH CHECK ADD  CONSTRAINT [FK_HT_NguoiDungVaiTro_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro] CHECK CONSTRAINT [FK_HT_NguoiDungVaiTro_DM_KhoHang]
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro]  WITH CHECK ADD  CONSTRAINT [FK_HT_NguoiDungVaiTro_HT_NguoiDung] FOREIGN KEY([IdNguoiDung])
REFERENCES [dbo].[HtNguoiDung] ([Id])
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro] CHECK CONSTRAINT [FK_HT_NguoiDungVaiTro_HT_NguoiDung]
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro]  WITH CHECK ADD  CONSTRAINT [FK_HT_NguoiDungVaiTro_HT_VaiTro] FOREIGN KEY([IdVaiTro])
REFERENCES [dbo].[HtVaiTro] ([Id])
GO
ALTER TABLE [dbo].[HtNguoiDungVaiTro] CHECK CONSTRAINT [FK_HT_NguoiDungVaiTro_HT_VaiTro]
GO
ALTER TABLE [dbo].[HtQuyenHan]  WITH CHECK ADD  CONSTRAINT [FK_HT_QuyenHan_HT_VaiTro] FOREIGN KEY([IdVaiTro])
REFERENCES [dbo].[HtVaiTro] ([Id])
GO
ALTER TABLE [dbo].[HtQuyenHan] CHECK CONSTRAINT [FK_HT_QuyenHan_HT_VaiTro]
GO
ALTER TABLE [dbo].[KhPhieuChuyen]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyen] CHECK CONSTRAINT [FK_KH_PhieuChuyen_DM_KhoHang]
GO
ALTER TABLE [dbo].[KhPhieuChuyen]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_DM_KhoHang_IdKhoNhan] FOREIGN KEY([IdKhoNhan])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyen] CHECK CONSTRAINT [FK_KH_PhieuChuyen_DM_KhoHang_IdKhoNhan]
GO
ALTER TABLE [dbo].[KhPhieuChuyenCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_Ct_DM_LoaiVatTu] FOREIGN KEY([IdLoaiVatTu])
REFERENCES [dbo].[DmLoaiVatTu] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyenCt] CHECK CONSTRAINT [FK_KH_PhieuChuyen_Ct_DM_LoaiVatTu]
GO
ALTER TABLE [dbo].[KhPhieuChuyenCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_Ct_KH_PhieuChuyen] FOREIGN KEY([IdPhieuChuyen])
REFERENCES [dbo].[KhPhieuChuyen] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyenCt] CHECK CONSTRAINT [FK_KH_PhieuChuyen_Ct_KH_PhieuChuyen]
GO
ALTER TABLE [dbo].[KhPhieuChuyenSp]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_Sp_KH_PhieuChuyen_Ct] FOREIGN KEY([IdPhieuChuyenCt])
REFERENCES [dbo].[KhPhieuChuyenCt] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyenSp] CHECK CONSTRAINT [FK_KH_PhieuChuyen_Sp_KH_PhieuChuyen_Ct]
GO
ALTER TABLE [dbo].[KhPhieuChuyenSp]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuChuyen_Sp_KH_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[KhSanPham] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuChuyenSp] CHECK CONSTRAINT [FK_KH_PhieuChuyen_Sp_KH_SanPham]
GO
ALTER TABLE [dbo].[KhPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhap] CHECK CONSTRAINT [FK_KH_PhieuNhap_DM_KhoHang]
GO
ALTER TABLE [dbo].[KhPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_DM_KhoHang_IdKhoChuyen] FOREIGN KEY([IdKhoChuyen])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhap] CHECK CONSTRAINT [FK_KH_PhieuNhap_DM_KhoHang_IdKhoChuyen]
GO
ALTER TABLE [dbo].[KhPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_DM_NguonNhap] FOREIGN KEY([IdNguonNhap])
REFERENCES [dbo].[DmNguonNhap] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhap] CHECK CONSTRAINT [FK_KH_PhieuNhap_DM_NguonNhap]
GO
ALTER TABLE [dbo].[KhPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_KH_PhieuChuyen] FOREIGN KEY([IdPhieuChuyen])
REFERENCES [dbo].[KhPhieuChuyen] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhap] CHECK CONSTRAINT [FK_KH_PhieuNhap_KH_PhieuChuyen]
GO
ALTER TABLE [dbo].[KhPhieuNhapCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_Ct_DM_LoaiVatTu] FOREIGN KEY([IdLoaiVatTu])
REFERENCES [dbo].[DmLoaiVatTu] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapCt] CHECK CONSTRAINT [FK_KH_PhieuNhap_Ct_DM_LoaiVatTu]
GO
ALTER TABLE [dbo].[KhPhieuNhapCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_Ct_KH_PhieuNhap] FOREIGN KEY([IdPhieuNhap])
REFERENCES [dbo].[KhPhieuNhap] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapCt] CHECK CONSTRAINT [FK_KH_PhieuNhap_Ct_KH_PhieuNhap]
GO
ALTER TABLE [dbo].[KhPhieuNhapCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhap_Ct_KH_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[KhSanPham] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapCt] CHECK CONSTRAINT [FK_KH_PhieuNhap_Ct_KH_SanPham]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_DM_KhoHang]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_DM_KhoHang_IdKhoChuyen] FOREIGN KEY([IdKhoChuyen])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_DM_KhoHang_IdKhoChuyen]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_DM_NguonNhap] FOREIGN KEY([IdNguonNhap])
REFERENCES [dbo].[DmNguonNhap] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_DM_NguonNhap]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_KH_PhieuChuyen] FOREIGN KEY([IdPhieuChuyen])
REFERENCES [dbo].[KhPhieuChuyen] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_KH_PhieuChuyen]
GO
ALTER TABLE [dbo].[KhPhieuNhapNb]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_KH_PhieuNhap] FOREIGN KEY([IdPhieuNhap])
REFERENCES [dbo].[KhPhieuNhap] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNb] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_KH_PhieuNhap]
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_Ct_DM_LoaiVatTu] FOREIGN KEY([IdLoaiVatTu])
REFERENCES [dbo].[DmLoaiVatTu] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_Ct_DM_LoaiVatTu]
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_Ct_KH_PhieuNhapNb] FOREIGN KEY([IdPhieuNhapNb])
REFERENCES [dbo].[KhPhieuNhapNb] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_Ct_KH_PhieuNhapNb]
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuNhapNb_Ct_KH_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[KhSanPham] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuNhapNbCt] CHECK CONSTRAINT [FK_KH_PhieuNhapNb_Ct_KH_SanPham]
GO
ALTER TABLE [dbo].[KhPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_DM_BoPhan] FOREIGN KEY([IdBoPhan])
REFERENCES [dbo].[DmBoPhan] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuat] CHECK CONSTRAINT [FK_KH_PhieuXuat_DM_BoPhan]
GO
ALTER TABLE [dbo].[KhPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuat] CHECK CONSTRAINT [FK_KH_PhieuXuat_DM_KhoHang]
GO
ALTER TABLE [dbo].[KhPhieuXuatCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_Ct_DM_LoaiVatTu] FOREIGN KEY([IdLoaiVatTu])
REFERENCES [dbo].[DmLoaiVatTu] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuatCt] CHECK CONSTRAINT [FK_KH_PhieuXuat_Ct_DM_LoaiVatTu]
GO
ALTER TABLE [dbo].[KhPhieuXuatCt]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_Ct_KH_PhieuXuat] FOREIGN KEY([IdPhieuXuat])
REFERENCES [dbo].[KhPhieuXuat] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuatCt] CHECK CONSTRAINT [FK_KH_PhieuXuat_Ct_KH_PhieuXuat]
GO
ALTER TABLE [dbo].[KhPhieuXuatSp]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_Sp_KH_PhieuXuat_Ct] FOREIGN KEY([IdPhieuXuatCt])
REFERENCES [dbo].[KhPhieuXuatCt] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuatSp] CHECK CONSTRAINT [FK_KH_PhieuXuat_Sp_KH_PhieuXuat_Ct]
GO
ALTER TABLE [dbo].[KhPhieuXuatSp]  WITH CHECK ADD  CONSTRAINT [FK_KH_PhieuXuat_Sp_KH_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[KhSanPham] ([Id])
GO
ALTER TABLE [dbo].[KhPhieuXuatSp] CHECK CONSTRAINT [FK_KH_PhieuXuat_Sp_KH_SanPham]
GO
ALTER TABLE [dbo].[KhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_KH_SanPham_DM_KhoHang] FOREIGN KEY([IdKhoHang])
REFERENCES [dbo].[DmKhoHang] ([Id])
GO
ALTER TABLE [dbo].[KhSanPham] CHECK CONSTRAINT [FK_KH_SanPham_DM_KhoHang]
GO
ALTER TABLE [dbo].[KhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_KH_SanPham_DM_LoaiVatTu] FOREIGN KEY([IdLoaiVatTu])
REFERENCES [dbo].[DmLoaiVatTu] ([Id])
GO
ALTER TABLE [dbo].[KhSanPham] CHECK CONSTRAINT [FK_KH_SanPham_DM_LoaiVatTu]
GO
ALTER TABLE [dbo].[KhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_KH_SanPham_DM_NguonNhap] FOREIGN KEY([IdNguonNhap])
REFERENCES [dbo].[DmNguonNhap] ([Id])
GO
ALTER TABLE [dbo].[KhSanPham] CHECK CONSTRAINT [FK_KH_SanPham_DM_NguonNhap]
GO
ALTER TABLE [dbo].[KhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_KH_SanPham_KH_SanPham] FOREIGN KEY([IdSanPham])
REFERENCES [dbo].[KhSanPham] ([Id])
GO
ALTER TABLE [dbo].[KhSanPham] CHECK CONSTRAINT [FK_KH_SanPham_KH_SanPham]
GO
/****** Object:  StoredProcedure [dbo].[Custom_DmLoaiVatTu_Get_DropDown]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the DmLoaiVatTu table
----------------------------------------------------------------------------------------------------
*/
--exec [Custom_DmLoaiVatTu_Get_DropDown] 1, '00000000-0000-0000-0000-000000000000', 0
CREATE PROCEDURE [dbo].[Custom_DmLoaiVatTu_Get_DropDown] 
(
	@IdKhoHang		int,
	@IdNhomVatTu	uniqueidentifier,
	@LoaiGet		int				
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPLoaiVatTu
	(
		Id				uniqueidentifier, 
		IdDonViTinh		uniqueidentifier,
		Ten				nvarchar(100), 
		QuyCach			nvarchar(300), 
		SoLuong			int
	)

	IF(@LoaiGet=0)
	BEGIN
		INSERT INTO #TMPLoaiVatTu(Id,IdDonViTinh,Ten,QuyCach,SoLuong)
		 SELECT Id,
				IdDonViTinh,
				Ten,
				QuyCach,
				0
		   FROM 
				dbo.DmLoaiVatTu		
		  WHERE 
				(@IdNhomVatTu='00000000-0000-0000-0000-000000000000' OR IdNhomVatTu=@IdNhomVatTu) AND
				(TrangThai=1)
	END
	ELSE IF(@LoaiGet=1)
	BEGIN
		INSERT INTO #TMPLoaiVatTu(Id,IdDonViTinh,Ten,QuyCach,SoLuong)
		SELECT  HT.IdLoaiVatTu,
				LH.IdDonViTinh,
				LH.Ten,
				LH.QuyCach,
				HT.SoLuong
		  FROM 
				(SELECT SP.IdLoaiVatTu,
						SUM(SP.SoLuongTon) as SoLuong
				   FROM
						(SELECT Id,
								IdLoaiVatTu,
								SoLuongTon
						   FROM dbo.KhSanPham
						  WHERE (IdKhoHang=@IdKhoHang) AND
								(SoLuongTon>0)
						) as SP INNER JOIN
						(SELECT IdSanPham
						   FROM dbo.KhPhieuNhapCt
						) as CT ON SP.Id=CT.IdSanPham
				GROUP BY
						SP.IdLoaiVatTu
				) as HT INNER JOIN
				(SELECT Id,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM 
						dbo.DmLoaiVatTu		
				  WHERE 
						(@IdNhomVatTu='00000000-0000-0000-0000-000000000000' OR IdNhomVatTu=@IdNhomVatTu)
				) as LH ON HT.IdLoaiVatTu=LH.Id
	END

	 SELECT LH.Id,
			LH.Ten,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			LH.SoLuong
	  FROM 
			#TMPLoaiVatTu as LH INNER JOIN
			(SELECT Id,
					Ten
			   FROM 
					dbo.DmDonViTinh		
			) as DV ON LH.IdDonViTinh=DV.Id
	ORDER BY
			LH.Ten ASC		
	
	DROP TABLE #TMPLoaiVatTu



















































































GO
/****** Object:  StoredProcedure [dbo].[Custom_DmLoaiVatTu_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the DmLoaiSanPham table
----------------------------------------------------------------------------------------------------
*/
--exec [Custom_DmLoaiSanPham_Get_ListSoLuong] 1, '10e531c8-7515-498f-8fb1-f0b5a4c29db8'
CREATE PROCEDURE [dbo].[Custom_DmLoaiVatTu_Get_List] 
(
	@IdNhomVatTu	uniqueidentifier,
	@TrangThai		int
)
AS
	SET NOCOUNT OFF
	
	SELECT  LH.Id,
			LH.IdNhomVatTu,
			LH.IdDonViTinh,
		    LH.Ten,
			LH.QuyCach,
			DV.TenDonViTinh,
			LH.TrangThai,
			LH.ChuThich
	  FROM 
		    (SELECT Id,
					IdNhomVatTu,
					IdDonViTinh,
					Ten,
					QuyCach,
					TrangThai,
					ChuThich
			   FROM 
					dbo.DmLoaiVatTu
			  WHERE 
					(@IdNhomVatTu IS NULL OR IdNhomVatTu=@IdNhomVatTu) AND
					((@TrangThai=0 AND TrangThai<>-1) OR (@TrangThai=-1 AND TrangThai=-1))
			) as LH INNER JOIN
			(SELECT	Id,
					Ten as TenDonViTinh
			   FROM	
					dbo.DmDonViTinh		
			) as DV ON LH.IdDonViTinh=DV.Id 
    ORDER BY
			LH.Ten ASC		
					   


























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtNgayThang_GetValue]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOC_SINH table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE [dbo].[Custom_HtNgayThang_GetValue]
AS
SET NOCOUNT OFF				
SELECT GetDate() as ServerDateTime



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtNguoiDung_Get_DropDown]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_HtNguoiDung_Get_DropDown] 
(
	@IdKhoHang	int
)
AS
	SET NOCOUNT OFF

	SELECT ND.Id,
		   ND.Ten
	  FROM (SELECT DISTINCT	
				   IdNguoiDung
			  FROM 
				   dbo.HtNguoiDungVaiTro
			 WHERE
				   (@IdKhoHang=0 OR IdKhoHang=@IdKhoHang)
			) as QT INNER JOIN
			(SELECT Id,
					Ten
			   FROM dbo.HtNguoiDung
			  WHERE TrangThai=1
			) as ND ON QT.IdNguoiDung=ND.Id
   ORDER BY
			ND.Id, ND.Ten		
	

























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtNguoiDung_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HT_NguoiDung table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE [dbo].[Custom_HtNguoiDung_Get_List]
(
	@IdChiNhanh		int,
	@IdKhoHang		int,
	@IdVaiTro		int,
	@HienThi		int
)
AS
	SET NOCOUNT OFF

	SELECT	ND.Id,
			ND.Ten,
			ND.TenTruyCap,
			ND.MatKhau,
			ND.DangNhap,
			ND.TrangThai,
			ND.ChuThich
	  FROM
			(SELECT DISTINCT	
					QT.IdNguoiDung
			   FROM
					(SELECT Id 
					   FROM dbo.DmKhoHang
					  WHERE (@IdChiNhanh=0 OR IdChiNhanh=@IdChiNhanh) AND
							(@IdKhoHang=0 OR Id=@IdKhoHang)
					) as KH INNER JOIN
					(SELECT IdNguoiDung, 
							IdKhoHang
					   FROM 
							dbo.HtNguoiDungVaiTro
					  WHERE
							(@IdKhoHang=0 OR IdKhoHang=@IdKhoHang) AND
							(@IdVaiTro=0 OR IdVaiTro=@IdVaiTro)
					) as QT ON KH.Id=QT.IdKhoHang
			) as QT INNER JOIN
			(SELECT Id,
					Ten,
					TenTruyCap,
					MatKhau,
					DangNhap,
					TrangThai,
					ChuThich
				FROM 
					dbo.HtNguoiDung
				WHERE
					((@HienThi=0 AND TrangThai<>-1) OR (@HienThi=-1 AND TrangThai=-1))
			) as ND ON QT.IdNguoiDung=ND.Id
	ORDER BY
			ND.Ten ASC



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtNguoiDung_Get_ListKhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_HtNguoiDung_Get_ListKhoHang] 
(
	@IdNguoiDung	int
)
AS
	SET NOCOUNT OFF

	SELECT	KH.Id,
			KH.Ten, 
			KH.TenVietTat, 
			VT.IdVaiTro,
			VT.MacDinh			
	  FROM
			(SELECT IdVaiTro,
					IdKhoHang,
					MacDinh
			   FROM 
					dbo.HtNguoiDungVaiTro
			  WHERE
					(IdNguoiDung=@IdNguoiDung) 
			) as VT INNER JOIN	
			(SELECT Id, 
					Ten,
					TenVietTat,
					ThuTu
			   FROM 
					dbo.DmKhoHang
			  WHERE
					(TrangThai=1)
			) as KH ON VT.IdKhoHang=KH.Id
	ORDER BY
			KH.ThuTu, KH.Ten ASC














































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtNguoiDung_Get_ListVaiTro]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO














































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_HtNguoiDung_Get_ListVaiTro]
(
	@IdNguoiDung	int
)
AS
	SET NOCOUNT OFF

	SELECT	KH.Id as IdKhoHang,
			KH.Ten as TenKhoHang, 
			VT.IdVaiTro, 
			ISNULL(VT.MacDinh, Convert(bit,0)) as MacDinh
	  FROM
			(SELECT IdVaiTro,
				    IdKhoHang,
				    MacDinh
			   FROM 
					dbo.HtNguoiDungVaiTro
			  WHERE
					(IdNguoiDung=@IdNguoiDung) 
			) as VT RIGHT JOIN	
			(SELECT Id, 
					Ten,
					ThuTu
			   FROM 
					dbo.DmKhoHang
			  WHERE
					(TrangThai=1)
			) as KH ON VT.IdKhoHang=KH.Id
	ORDER BY
			KH.ThuTu, KH.Ten ASC

























































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtQuyenHan_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: Tuanpm (www.tuanpm.com)
-- Purpose: Gets all records from the VaiTro_ChucNang table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE [dbo].[Custom_HtQuyenHan_Get_List]
(
	@IdVaiTro int   
)
AS
	SET NOCOUNT OFF

	SELECT  ISNULL(QH.Id,0) as Id,	
			CN.IdPhanHe,
			@IdVaiTro as IdVaiTro,
			CN.TenForm,
			PH.Ten as TenPhanHe,
			PH.ThuTu as ThuTuPhanHe,				
			CN.Ten as TenChucNang,					
			ISNULL(QH.Xem,Convert(bit,0)) as Xem,
			ISNULL(QH.Them,Convert(bit,0)) as Them,
			ISNULL(QH.Sua,Convert(bit,0)) as Sua,
			ISNULL(QH.Xoa,Convert(bit,0)) as Xoa,
			Convert(int,0) as ThayDoi
	  FROM
			(SELECT TenForm,
					IdPhanHe,
					Ten,
					ThuTu
			   FROM 
					dbo.HtChucNang
			) as CN INNER JOIN
			(SELECT Id,
					Ten,
					ThuTu
			   FROM 
					dbo.HtPhanHe
			) as PH ON CN.IdPhanHe=PH.Id LEFT JOIN
			(SELECT Id,
					IdVaiTro,
					TenForm,
					Xem,
					Them,
					Sua,
					Xoa
			   FROM
					dbo.HtQuyenHan	
			  WHERE									
					IdVaiTro=@IdVaiTro
			) as QH ON CN.TenForm=QH.TenForm
	ORDER BY
			CN.ThuTu, CN.TenForm ASC




























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_HtVaiTro_Get_KhoHang]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


























































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_HtVaiTro_Get_KhoHang]
(
	@IdKhoHang	int
)
AS
	SET NOCOUNT OFF

	SELECT	VT.Id,
			VT.Ten
	  FROM
			(SELECT DISTINCT
					IdVaiTro
			   FROM dbo.HtNguoiDungVaiTro
			  WHERE (IdKhoHang=@IdKhoHang) 
			) as QH INNER JOIN	
			(SELECT Id, 
					Ten,
					ThuTu
			   FROM 
					dbo.HtVaiTro
			  WHERE
					(TrangThai=1)
			) as VT ON QH.IdVaiTro=VT.Id
	ORDER BY
			VT.ThuTu, VT.Ten ASC



































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhNhapXuat_Insert_Data]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















































































--exec Custom_KhNhapXuat_Insert_Data 1, '1990-01-01'

CREATE PROCEDURE [dbo].[Custom_KhNhapXuat_Insert_Data]
(
	@IdKhoHang	int, 
	@NgayChay	date
)
AS

	SET TRANSACTION ISOLATION LEVEL SNAPSHOT;

	BEGIN TRANSACTION NhapXuat;

	IF(@NgayChay='1990-01-01') 
	BEGIN
		DELETE FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang
		SET @NgayChay=(SELECT TOP 1 NgayTaoDate FROM dbo.KhPhieuNhap WHERE IdKhoHang=@IdKhoHang ORDER BY NgayTao ASC)
	END
	
	DECLARE @dCurrDay date, @dFirstDay date, @dLastDay date
	SET @dCurrDay=DATEADD(MONTH,-1,DATEADD(dd,-DAY(GETDATE())+1,GETDATE()))
	SET @dFirstDay=DATEADD(dd,-DAY(@NgayChay)+1,@NgayChay)

	WHILE @dFirstDay<=@dCurrDay
	BEGIN
		SET @dLastDay=DATEADD(dd,-DAY(DATEADD(mm,1,@dFirstDay)),DATEADD(mm,1,@dFirstDay))

		DELETE FROM dbo.KhNhapXuat WHERE (IdKhoHang=@IdKhoHang) AND (Thang=@dFirstDay)
		INSERT INTO dbo.KhNhapXuat(Id,IdKhoHang,IdLoaiVatTu,Thang,Nhap,Xuat,Chuyen)	
		SELECT NEWID(),
			   @IdKhoHang,
			   Id,
			   @dFirstDay,
			   0,0,0
		  FROM 
			   dbo.DmLoaiVatTu
		 WHERE
			   TrangThai=1
				   		
		UPDATE NX
		   SET NX.Nhap=HN.Nhap
		  FROM dbo.KhNhapXuat NX INNER JOIN  
		  	   (SELECT CT.IdLoaiVatTu,
					   SUM(CT.SoLuong) as Nhap
				  FROM (SELECT Id
						  FROM dbo.KhPhieuNhap 
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay) AND
							   (IdKhoHang=@IdKhoHang)
						) as PN INNER JOIN
						(SELECT IdPhieuNhap,
								IdLoaiVatTu,
								SoLuong
						   FROM dbo.KhPhieuNhapCt
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay)
						) as CT ON PN.Id=CT.IdPhieuNhap 
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HN ON NX.IdLoaiVatTu=HN.IdLoaiVatTu	   
		  WHERE (NX.IdKhoHang=@IdKhoHang) AND
				(NX.Thang=@dFirstDay)				   
				   
		UPDATE NX
		   SET NX.Xuat=HX.Xuat
		  FROM dbo.KhNhapXuat NX INNER JOIN  
		  	   (SELECT CT.IdLoaiVatTu,
					   SUM(CT.SoLuong) as Xuat
				  FROM (SELECT Id
						  FROM dbo.KhPhieuXuat 
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay) AND
							   (IdKhoHang=@IdKhoHang)
						) as PX INNER JOIN
						(SELECT IdPhieuXuat,
								IdLoaiVatTu,
								SoLuong
						   FROM dbo.KhPhieuXuatCt
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay)
						) as CT ON PX.Id=CT.IdPhieuXuat
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HX ON NX.IdLoaiVatTu=HX.IdLoaiVatTu	
		  WHERE (NX.IdKhoHang=@IdKhoHang) AND
				(NX.Thang=@dFirstDay)		
				
		UPDATE NX
		   SET NX.Chuyen=HC.Chuyen
		  FROM dbo.KhNhapXuat NX INNER JOIN  
		  	   (SELECT CT.IdLoaiVatTu,
					   SUM(CT.SoLuong) as Chuyen
				  FROM (SELECT Id
						  FROM dbo.KhPhieuChuyen
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay) AND
							   (IdKhoHang=@IdKhoHang) AND
							   (TrangThai=1)
						) as PC INNER JOIN
						(SELECT IdPhieuChuyen,
								IdLoaiVatTu,
								SoLuong
						   FROM dbo.KhPhieuChuyenCt
						 WHERE (NgayTaoDate BETWEEN @dFirstDay AND @dLastDay)
						) as CT ON PC.Id=CT.IdPhieuChuyen
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HC ON NX.IdLoaiVatTu=HC.IdLoaiVatTu	 
		  WHERE (NX.IdKhoHang=@IdKhoHang) AND
				(NX.Thang=@dFirstDay)							
	
		SET @dFirstDay=DATEADD(MONTH,1,@dFirstDay)	
	END				   
			   
	IF @@ERROR != 0
	BEGIN
		ROLLBACK TRANSACTION NhapXuat;
	END
	ELSE
	BEGIN
		COMMIT TRANSACTION NhapXuat;
	END








































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuChuyen_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuChuyen_Get_List]
(
	@IdKhoHang		int,
	@TuNgay			date,
	@DenNgay		date
)
AS
	SET NOCOUNT OFF

	SELECT  PC.Id,
			PC.IdKhoHang,
			PC.SoPhieu,	
			KN.TenKhoNhan,
			PC.TrangThai,
			PC.TrangThaiNhan,
			CASE
			  WHEN PC.TrangThai=0 THEN N'Chưa chuyển'
			  WHEN PC.TrangThai=1 THEN N'Đã chuyển'
			END as TenTrangThaiChuyen,
			CASE
			  WHEN PC.TrangThaiNhan=0 THEN N'Chưa nhận'
			  WHEN PC.TrangThaiNhan=1 THEN N'Đã nhận'
			  WHEN PC.TrangThaiNhan=2 THEN N'Đang nhận'
			END as TenTrangThaiNhan,				
			NG.TenNguoiGiao,
			NT.TenNguoiTao,
			PC.NgayTao,
			PC.ChuThich
	FROM
			(SELECT Id,
					IdKhoHang,
					SoPhieu,		
					IdKhoNhan,	
					IdNguoiGiao,
					TrangThai,
					TrangThaiNhan,
					IdNguoiTao,
					NgayTao,
					ChuThich
			   FROM
					dbo.KhPhieuChuyen
			  WHERE
					(IdKhoHang=@IdKhoHang) AND
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PC INNER JOIN
			(SELECT Id,
					Ten as TenKhoNhan
			   FROM
					dbo.DmKhoHang
			) as KN ON PC.IdKhoNhan=KN.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiGiao
			   FROM
					dbo.HtNguoiDung
			) as NG ON PC.IdNguoiGiao=NG.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiTao
			   FROM
					dbo.HtNguoiDung
			) as NT ON PC.IdNguoiTao=NT.Id
	ORDER BY
			PC.NgayTao DESC



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuChuyen_Get_ListChiTiet]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuChuyen_Get_ListChiTiet]
(
	@IdPhieuChuyen	uniqueidentifier
)
AS
	SET NOCOUNT OFF
	
	SELECT	CT.Id,
			CT.IdLoaiVatTu,
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			CT.SoLuong,
			CT.ChuThich,
			CT.SoLuong as SoLuongOld,
			Convert(int,1) as Status
	  FROM 
			(SELECT Id,
					IdLoaiVatTu,
					SoLuong,
					ChuThich
			   FROM	
					dbo.KhPhieuChuyenCt
			  WHERE
					IdPhieuChuyen=@IdPhieuChuyen	
			) as CT INNER JOIN
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
			) as LH ON CT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id				
	ORDER BY
			LH.Ten ASC



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhap_Check_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuNhap_Check_Delete]
(
	@IdPhieuNhap		uniqueidentifier,
	@IdLoaiVatTu		uniqueidentifier
)
AS
	SET NOCOUNT OFF

	DECLARE @SoDong int

	IF(@IdLoaiVatTu IS NULL)
	BEGIN
		SET @SoDong = (SELECT COUNT(CT.IdSanPham)
						 FROM (SELECT IdSanPham,
									  SoLuong
								 FROM dbo.KhPhieuNhapCt
								WHERE IdPhieuNhap=@IdPhieuNhap	
							  ) as CT INNER JOIN
							  (SELECT Id,
									  IdLoaiVatTu,
									  IdNguonNhap,
									  SoLuongTon
								 FROM	
									  dbo.KhSanPham
							  ) as HT ON CT.IdSanPham=HT.Id
						WHERE
							  HT.SoLuongTon<>CT.SoLuong
					  )
	END
	ELSE IF(@IdLoaiVatTu IS NOT NULL)
	BEGIN
		SET @SoDong = (SELECT COUNT(CT.IdSanPham)
						 FROM (SELECT IdSanPham,
									  SoLuong
								 FROM dbo.KhPhieuNhapCt
								WHERE (IdPhieuNhap=@IdPhieuNhap) AND
									  (IdLoaiVatTu=@IdLoaiVatTu)	
							  ) as CT INNER JOIN
							  (SELECT Id,
									  IdLoaiVatTu,
									  IdNguonNhap,
									  SoLuongTon
								 FROM	
									  dbo.KhSanPham
								WHERE (IdLoaiVatTu=@IdLoaiVatTu)	
							  ) as HT ON CT.IdSanPham=HT.Id
						WHERE
							  HT.SoLuongTon<>CT.SoLuong
					  )
	END

	IF(@SoDong IS NULL) SET @SoDong=0

	SELECT @SoDong as SoDong























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhap_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuNhap_Get_List]
(
	@IdKhoHang		int,
	@TuNgay			date,
	@DenNgay		date
)
AS
	SET NOCOUNT OFF

	SELECT  PN.Id,
			PN.IdKhoHang,
			PN.LoaiNhap,
			PN.SoPhieu,				
			NN.TenNguonNhap,
			CASE
				WHEN PN.LoaiNhap=0 THEN N'Nhập mới'
				WHEN PN.LoaiNhap=2 THEN N'Nhập nội bộ'
			END as TenLoaiNhap,
			NT.TenNguoiTao,
			PN.NgayTao,
			PN.ChuThich
	FROM
			(SELECT Id,
					IdKhoHang,
					SoPhieu,					
					LoaiNhap,
					IdNguonNhap,
					IdNguoiTao,
					NgayTao,
					ChuThich
			   FROM
					dbo.KhPhieuNhap
			  WHERE
					(IdKhoHang=@IdKhoHang) AND
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay) AND				  
					(LoaiNhap<>-1)					
			) as PN INNER JOIN
			(SELECT Id,
					Ten as TenNguonNhap
			   FROM 
					dbo.DmNguonNhap
			) as NN ON PN.IdNguonNhap=NN.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiTao
			   FROM 
					dbo.HtNguoiDung
			) as NT ON PN.IdNguoiTao=NT.Id
	ORDER BY
			PN.NgayTao DESC






































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhap_Get_ListChiTiet]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuNhap_Get_ListChiTiet]
(
	@IdPhieuNhap	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	SELECT  CT.Id,
			CT.IdSanPham,
			SP.IdLoaiVatTu,	
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			CT.SoLuong,
			SP.IdNguonNhap,
			SP.SoLuongNhap,
			SP.SoLuongTon,				
			CT.ChuThich,
			SP.IdLoaiVatTu as IdLoaiVatTuOld,
			CT.SoLuong as SoLuongOld,
			Convert(int,1) as Status
	  FROM 
			(SELECT Id,
					IdPhieuNhap,
					IdSanPham,
					SoLuong,
					ChuThich
			   FROM	
					dbo.KhPhieuNhapCt
			  WHERE
					IdPhieuNhap=@IdPhieuNhap
			) as CT INNER JOIN
			(SELECT Id,
					IdNguonNhap,
					IdLoaiVatTu,
					SoLuongNhap,
					SoLuongTon
			   FROM	
					dbo.KhSanPham
			) as SP ON CT.IdSanPham=SP.Id INNER JOIN		
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
			) as LH ON SP.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id				
	ORDER BY
			LH.Ten ASC		
	
























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhap_Get_ListChiTietNb]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuNhap_Get_ListChiTietNb]
(
	@IdPhieuNhap	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	SELECT  CT.IdLoaiVatTu,	
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			CT.SoLuong,
			CT.SoLuong as SoLuongOld,
			Convert(int,1) as Status
	  FROM 
			(SELECT HT.IdLoaiVatTu,
					SUM(CT.SoLuong) as SoLuong
			   FROM	
					(SELECT IdSanPham,
							SoLuong
					   FROM
							dbo.KhPhieuNhapCt
					  WHERE
							IdPhieuNhap=@IdPhieuNhap
					) as CT INNER JOIN
					(SELECT Id,
							IdLoaiVatTu
					   FROM	
							dbo.KhSanPham
					) as HT ON CT.IdSanPham=HT.Id
			GROUP BY
					HT.IdLoaiVatTu
			) as CT INNER JOIN
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
			) as LH ON CT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id									
	ORDER BY
			LH.Ten ASC		

























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhapNb_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuNhapNb_Get_List]
(
	@IdKhoHang		int
)
AS
	SET NOCOUNT OFF

	SELECT  PN.Id,
			PN.SoPhieu,	
			KN.TenKhoChuyen,
			PN.TrangThai,
			CASE
				WHEN PN.TrangThai=0 THEN N'Chưa nhận'
				WHEN PN.TrangThai=1 THEN N'Nhận một phần'			  
			END as TenTrangThai,
			NT.TenNguoiTao,
			PN.NgayTao,
			PN.ChuThich
	FROM
			(SELECT Id,
					SoPhieu,		
					IdKhoChuyen,
					TrangThai,
					IdNguoiTao,
					NgayTao,
					ChuThich
			   FROM
					dbo.KhPhieuNhapNb
			  WHERE
					(IdKhoHang=@IdKhoHang)
			) as PN INNER JOIN
			(SELECT Id,
					Ten as TenKhoChuyen
			   FROM
					dbo.DmKhoHang
			) as KN ON PN.IdKhoChuyen=KN.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiTao
			   FROM
					dbo.HtNguoiDung
			) as NT ON PN.IdNguoiTao=NT.Id
	ORDER BY
			PN.NgayTao DESC



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuNhapNb_Get_ListChiTiet]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Select records from the SanPham table through an index
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_KhPhieuNhapNb_Get_ListChiTiet]
(
	@IdPhieuNhapNb		uniqueidentifier
)
AS
	SET NOCOUNT OFF

	SELECT  CT.IdLoaiVatTu,			    
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			CT.SoLuong,
			CT.TrangThai as TrangThaiNhan,
			CT.TrangThai as TrangThaiNhanOld,			    
			CASE 
				WHEN CT.TrangThai=1 THEN Convert(bit,1)
				ELSE Convert(bit,0)
			END as CheckBox,	
			CASE 
				WHEN CT.TrangThai=0 THEN N'Chưa kiểm'
				WHEN CT.TrangThai=1 THEN N'Đã nhận'
				WHEN CT.TrangThai=2 THEN N'Hợp lệ'
			END as TenTrangThai			    
	  FROM 
			(SELECT HT.IdLoaiVatTu,
					SUM(CT.SoLuong) as SoLuong,
					CT.TrangThai
			   FROM	
					(SELECT IdSanPham,
							SoLuong,
							TrangThai
					   FROM
							dbo.KhPhieuNhapNbCt
					  WHERE
							IdPhieuNhapNb=@IdPhieuNhapNb
					) as CT INNER JOIN
					(SELECT Id,
							IdLoaiVatTu
					   FROM	
							dbo.KhSanPham
					) as HT ON CT.IdSanPham=HT.Id
			GROUP BY
					HT.IdLoaiVatTu, CT.TrangThai
			) as CT INNER JOIN
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM 
					dbo.DmLoaiVatTu 
			) as LH ON CT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id
	ORDER BY
			LH.Ten ASC



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuXuat_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuXuat_Get_List]
(
	@IdKhoHang		int,
	@TuNgay			date,
	@DenNgay		date
)
AS
	SET NOCOUNT OFF

	SELECT  PX.Id,
			PX.IdKhoHang,
			PX.IdBoPhan,
			PX.SoPhieu,	
			KH.TenBoPhan,
			NB.TenNguoiNhan,
			NT.TenNguoiTao,
			PX.NgayTao,
			PX.ChuThich
	FROM
			(SELECT Id,	
					IdKhoHang,
					IdBoPhan,
					SoPhieu,		
					IdNguoiNhan,
					IdNguoiTao,	
					NgayTao,
					ChuThich
			   FROM
					dbo.KhPhieuXuat
			  WHERE
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay) AND				 
					(IdKhoHang=@IdKhoHang)		
			) as PX INNER JOIN
			(SELECT Id,
					Ten as TenBoPhan
			   FROM
					dbo.DmBoPhan
			) as KH ON PX.IdBoPhan=KH.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiNhan
			   FROM
					dbo.HtNguoiDung
			) as NB ON PX.IdNguoiNhan=NB.Id INNER JOIN
			(SELECT Id,
					Ten as TenNguoiTao
			   FROM
					dbo.HtNguoiDung
			) as NT ON PX.IdNguoiTao=NT.Id
	ORDER BY
			PX.NgayTao DESC


























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhPhieuXuat_Get_ListChiTiet]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_KhPhieuXuat_Get_ListChiTiet]
(
	@IdPhieuXuat	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	SELECT	CT.Id,
			CT.IdLoaiVatTu,
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			CT.SoLuong,
			CT.ChuThich,
			CT.SoLuong as SoLuongOld,
			Convert(int,1) as Status
	  FROM 
			(SELECT Id,
					IdLoaiVatTu,
					SoLuong,
					ChuThich
			   FROM	
					dbo.KhPhieuXuatCt
			  WHERE
					IdPhieuXuat=@IdPhieuXuat
			) as CT INNER JOIN
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
			) as LH ON CT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id								
	ORDER BY
			LH.Ten ASC

























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhSanPham_Get_List]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





















































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the TheCao table
----------------------------------------------------------------------------------------------------
*/
--exec Custom_SanPhamKt_Get_SoLuong 4, '03118750-B85F-435D-83EB-2C0102363352'
CREATE PROCEDURE [dbo].[Custom_KhSanPham_Get_List]
(
	@IdKhoHang		int,
	@IdNhomVatTu	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	SELECT	HT.IdLoaiVatTu,
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			HT.SoLuong
	  FROM 
			(SELECT IdLoaiVatTu,
					SUM(SoLuongTon) as SoLuong
			   FROM	
					dbo.KhSanPham
			  WHERE
					(IdKhoHang=@IdKhoHang) AND
					(SoLuongTon>0)
		   GROUP BY
					IdLoaiVatTu
			) as HT INNER JOIN
			(SELECT Id,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
		      WHERE
					(@IdNhomVatTu IS NULL OR IdNhomVatTu=@IdNhomVatTu)
			) as LH ON HT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id	
	ORDER BY
			LH.Ten ASC














































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_KhSanPham_Get_SoLuong]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the KhSanPham table
----------------------------------------------------------------------------------------------------
*/
--exec Custom_KhSanPham_Get_SoLuong 4, '03118750-B85F-435D-83EB-2C0102363352'
CREATE PROCEDURE [dbo].[Custom_KhSanPham_Get_SoLuong]
(
	@IdKhoHang			int,
	@IdLoaiVatTu		uniqueidentifier
)
AS
	SET NOCOUNT OFF

	DECLARE	@SoLuong int
	
	SET @SoLuong = (SELECT SUM(SoLuongTon) 
					  FROM dbo.KhSanPham 
					 WHERE (@IdKhoHang=0 OR IdKhoHang=@IdKhoHang) AND 
						   (IdLoaiVatTu=@IdLoaiVatTu) AND
						   (SoLuongTon>0)
					)
    IF (@SoLuong IS NULL OR @SoLuong < 0) SET @SoLuong = 0

	SELECT @SoLuong as SoLuong


























































































/****** Object:  StoredProcedure [dbo].[Custom_RP_HangChuyen]    Script Date: 06/06/2021 12:41:38 PM ******/
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[Custom_RpHangChuyen]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets records from the HoaDonXuat table passing page index AND page count parameters
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_RpHangChuyen]
(
	@ListKhoHang		varchar(100),	
	@IdKhoNhan			int,		
	@ListNhomVatTu		varchar(MAX),
	@TuNgay				date,
	@DenNgay			date,
	@LoaiBaoCao			int	
)
AS
	SET NOCOUNT OFF

	IF(@LoaiBaoCao=0)
	BEGIN
		SELECT  LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HC.SoLuong
		  FROM
				(SELECT CT.IdLoaiVatTu,
						SUM(CT.SoLuong) as SoLuong	
				   FROM	   
						(SELECT Id, 
								IdKhoHang
						   FROM		
								dbo.KhPhieuChuyen 
						  WHERE		
								(@IdKhoNhan IS NULL OR IdKhoNhan=@IdKhoNhan) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PC INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') IK ON PC.IdKhoHang=IK.Id INNER JOIN
						(SELECT IdPhieuChuyen,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuChuyenCt
						  WHERE		
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PC.Id=CT.IdPhieuChuyen
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HC INNER JOIN					
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HC.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id			
		ORDER BY
				NH.ThuTu, NH.Ten, LH.Ten ASC					
	END
	ELSE IF(@LoaiBaoCao=1)
	BEGIN
		SELECT	HC.TenKhoNhan,
				HC.SoPhieu,
				HC.TenNguoiGiao,
				HC.TenNguoiTao,
				HC.NgayTao,
				LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HC.SoLuong
		  FROM
				(SELECT PC.SoPhieu,
						KN.TenKhoNhan,
						NG.TenNguoiGiao,
						NT.TenNguoiTao,
						PC.NgayTao,
						CT.IdLoaiVatTu,
						CT.SoLuong
				   FROM	   
						(SELECT Id, 
								IdKhoHang,
								SoPhieu,
								IdKhoNhan,
								IdNguoiGiao,
								IdNguoiTao,
								NgayTao
						   FROM		
								dbo.KhPhieuChuyen 
						  WHERE		
								(@IdKhoNhan IS NULL OR IdKhoNhan=@IdKhoNhan) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PC INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') IK ON PC.IdKhoHang=IK.Id INNER JOIN
						(SELECT Id,
								Ten as TenKhoNhan
						   FROM	
								dbo.DmKhoHang
						) as KN ON PC.IdKhoNhan=KN.Id INNER JOIN
						(SELECT Id,
								Ten as TenNguoiGiao
						   FROM	
								dbo.HtNguoiDung
						) as NG ON PC.IdNguoiGiao=NG.Id INNER JOIN						
						(SELECT Id,
								Ten as TenNguoiTao
						   FROM	
								dbo.HtNguoiDung
						) as NT ON PC.IdNguoiTao=NT.Id INNER JOIN
						(SELECT IdPhieuChuyen,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuChuyenCt
						  WHERE		
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PC.Id=CT.IdPhieuChuyen
				) as HC INNER JOIN
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HC.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id				
		ORDER BY
				HC.NgayTao, NH.ThuTu, NH.Ten, LH.Ten ASC				
	END















































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpHangLuuKho]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






































































































CREATE PROCEDURE [dbo].[Custom_RpHangLuuKho]
(
	@ListKhoHang		varchar(100),
	@ListNhomVatTu		varchar(MAX),
	@NgayLuuKho			int
)
AS
	SET NOCOUNT OFF

	SELECT	LH.IdNhomVatTu,
			KH.Ten as TenKhoHang,
			NH.Ten as TenNhomVatTu,
			LH.Ten as TenLoaiVatTu,
			LH.QuyCach,
			DV.Ten as TenDonViTinh,
			HT.SoLuong,
			HT.NgayTon,
			HT.NgayTao
	  FROM	   
			(SELECT IdKhoHang,
					IdLoaiVatTu,
					SoLuongTon as SoLuong,
					NgayTao,
					DATEDIFF(day,NgayTao,CONVERT(date,GETDATE())) as NgayTon
			   FROM 
					dbo.KhSanPham
			  WHERE
					(SoLuongTon>0) AND
					(NgayTao<=DATEADD(day,-@NgayLuuKho,GETDATE())) 
			) as HT INNER JOIN	
			dbo.uf_Get_TableInt(@ListKhoHang, 'KhoHang') as IK ON HT.IdKhoHang=IK.Id INNER JOIN	
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmKhoHang 
			) as KH ON HT.IdKhoHang=KH.Id INNER JOIN				
			(SELECT Id,
					IdNhomVatTu,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM	
					dbo.DmLoaiVatTu 
			) as LH ON HT.IdLoaiVatTu=LH.Id INNER JOIN
			(SELECT Id,
					Ten
				FROM	
					dbo.DmDonViTinh 
			) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
			dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
			(SELECT Id,
					Ten,
					ThuTu
			   FROM	
					dbo.DmNhomVatTu 
			) as NH ON LH.IdNhomVatTu=NH.Id				
	ORDER BY
			NH.ThuTu, NH.Ten, LH.Ten ASC


























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpHangNhap]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets records from the HoaDonXuat table passing page index AND page count parameters
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_RpHangNhap]
(
	@ListKhoHang		varchar(100),	
	@IdNguonNhap		uniqueidentifier,		
	@ListNhomVatTu		varchar(MAX),
	@LoaiNhap			int,
	@TuNgay				date,
	@DenNgay			date,
	@LoaiBaoCao			int	
)
AS
	SET NOCOUNT OFF

	IF(@LoaiBaoCao=0)
	BEGIN
		SELECT	LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HN.SoLuong
		  FROM
				(SELECT CT.IdLoaiVatTu,
						SUM(CT.SoLuong) as SoLuong	
				   FROM	   
						(SELECT Id, 
								IdKhoHang
						   FROM		
								dbo.KhPhieuNhap 
						  WHERE		
								(@IdNguonNhap IS NULL OR IdNguonNhap=@IdNguonNhap) AND
								(@LoaiNhap=-2 OR LoaiNhap=@LoaiNhap) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PN INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') IK ON PN.IdKhoHang=IK.Id INNER JOIN
						(SELECT IdPhieuNhap,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuNhapCt
						  WHERE
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PN.Id=CT.IdPhieuNhap
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HN INNER JOIN					
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HN.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id					
		ORDER BY
				NH.ThuTu, NH.Ten, LH.Ten ASC				
	END
	ELSE IF(@LoaiBaoCao=1)
	BEGIN
		SELECT	HN.Id,
				HN.TenNguonNhap,
				HN.SoPhieu,
				CASE 
					WHEN HN.LoaiNhap=0 THEN N'Nhập mới'
					WHEN HN.LoaiNhap=2 THEN N'Nhập nội bộ'
				END as TenLoaiNhap,
				HN.TenNguoiTao,
				HN.NgayTao,
				LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HN.SoLuong
		   FROM
				(SELECT PN.Id,
						NN.TenNguonNhap,
						PN.SoPhieu,
						PN.LoaiNhap,
						NT.TenNguoiTao,
						PN.NgayTao,
						CT.IdLoaiVatTu,
						CT.SoLuong
				   FROM	   
						(SELECT Id, 
								IdKhoHang,
								SoPhieu,
								LoaiNhap,
								IdNguonNhap,
								IdNguoiTao,
								NgayTao
						   FROM		
								dbo.KhPhieuNhap 
						  WHERE		
								(@IdNguonNhap IS NULL OR IdNguonNhap=@IdNguonNhap) AND
								(@LoaiNhap=-2 OR LoaiNhap=@LoaiNhap) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PN INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') ID ON PN.IdKhoHang=ID.Id INNER JOIN
						(SELECT Id,
								Ten as TenNguonNhap
						   FROM	
								dbo.DmNguonNhap
						) as NN ON PN.IdNguonNhap=NN.Id INNER JOIN	
						(SELECT Id,
								Ten as TenNguoiTao
						   FROM	
								dbo.HtNguoiDung
						) as NT ON PN.IdNguoiTao=NT.Id INNER JOIN
						(SELECT IdPhieuNhap,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuNhapCt
						  WHERE
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PN.Id=CT.IdPhieuNhap
				) as HN INNER JOIN
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HN.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id						
		ORDER BY
				HN.NgayTao, NH.ThuTu, NH.Ten, LH.Ten ASC			
	END















































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpHangTonTheoKho]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets records from the PhieuXuat table passing page index AND page count parameters
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[Custom_RpHangTonTheoKho]
(
	@ListKhoHang		varchar(100),
	@ListNhomVatTu		varchar(MAX)
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPHangTonKho
	(
		IdKhoHang		int,
		IdLoaiVatTu		uniqueidentifier,
		TenKhoHang		nvarchar(100),
		TenNhomVatTu	nvarchar(200),
		TenLoaiVatTu	nvarchar(200),
		SoLuong			int	
	)
	CREATE TABLE #TMPKhoHang
	(
		Id		int,
		Ten		nvarchar(100)
	)
	INSERT INTO #TMPKhoHang(Id,Ten)
	SELECT IK.Id, KH.Ten 
	  FROM dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as IK INNER JOIN
		   (SELECT Id, 
				   Ten
			  FROM dbo.DmKhoHang
		     WHERE TrangThai=1
		   ) as KH ON IK.Id=KH.Id	
		   	
	DECLARE @IdKhoHang int, @TenKhoHang nvarchar(100)
	WHILE (SELECT COUNT(*) FROM #TMPKhoHang) > 0
	BEGIN
		SELECT TOP 1 @IdKhoHang=Id,@TenKhoHang=Ten From #TMPKhoHang

		INSERT INTO #TMPHangTonKho(IdKhoHang,IdLoaiVatTu,TenKhoHang,TenNhomVatTu,TenLoaiVatTu,SoLuong)		
		SELECT  @IdKhoHang,
				LH.Id,
				@TenKhoHang,
				NH.Ten,
				LH.Ten,
				CONVERT(int,0)		
		 FROM	   
				(SELECT Id,
						IdNhomVatTu,
						Ten
				   FROM 
						dbo.DmLoaiVatTu
				  WHERE
						(TrangThai=1)
				) as LH INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM 
						dbo.DmNhomVatTu
				  WHERE
						(TrangThai=1)						
				) as NH ON LH.IdNhomVatTu=NH.Id

		DELETE #TMPKhoHang Where Id=@IdKhoHang
	END

	UPDATE HT
	   SET HT.SoLuong=SP.SoLuong
	  FROM #TMPHangTonKho HT INNER JOIN 
		   (SELECT IdKhoHang,
				   IdLoaiVatTu,
				   SUM(SoLuongTon) as SoLuong
			  FROM
				   dbo.KhSanPham
			 WHERE
				   (SoLuongTon > 0) 
		  GROUP BY
				   IdKhoHang, IdLoaiVatTu 													
		   ) as SP ON HT.IdLoaiVatTu=SP.IdLoaiVatTu	
	 WHERE
		   (HT.IdKhoHang=SP.IdKhoHang)

	SELECT TenKhoHang,
		   TenNhomVatTu,
		   TenLoaiVatTu,
		   SoLuong
	  FROM  
		   #TMPHangTonKho	
	 WHERE  
		   SoLuong>0				

	DROP TABLE #TMPKhoHang
	DROP TABLE #TMPHangTonKho



























































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpHangXuat]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets records from the HoaDonXuat table passing page index AND page count parameters
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[Custom_RpHangXuat]
(
	@ListKhoHang		varchar(100),	
	@IdBoPhan			uniqueidentifier,		
	@ListNhomVatTu		varchar(MAX),
	@TuNgay				date,
	@DenNgay			date,
	@LoaiBaoCao			int	
)
AS
	SET NOCOUNT OFF

	IF(@LoaiBaoCao=0)
	BEGIN
		SELECT	LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HX.SoLuong
		  FROM
				(SELECT CT.IdLoaiVatTu,
						SUM(CT.SoLuong) as SoLuong	
				   FROM	   
						(SELECT Id, 
								IdKhoHang
						   FROM		
								dbo.KhPhieuXuat 
						  WHERE		
								(@IdBoPhan IS NULL OR IdBoPhan=@IdBoPhan) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PX INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') IK ON PX.IdKhoHang=IK.Id INNER JOIN
						(SELECT IdPhieuXuat,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuXuatCt
						  WHERE
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PX.Id=CT.IdPhieuXuat
				GROUP BY					 				
						CT.IdLoaiVatTu
				) as HX INNER JOIN					
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HX.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id				
		ORDER BY
				NH.ThuTu, NH.Ten, LH.Ten ASC					
	END
	ELSE IF(@LoaiBaoCao=1)
	BEGIN
		SELECT	HX.Id,
				HX.TenBoPhan,
				HX.SoPhieu,
				HX.TenNguoiNhan,
				HX.TenNguoiTao,
				HX.NgayTao,
				LH.IdNhomVatTu,
				NH.Ten as TenNhomVatTu,
				LH.Ten as TenLoaiVatTu,
				LH.QuyCach,
				DV.Ten as TenDonViTinh,
				HX.SoLuong
		  FROM
				(SELECT PX.Id,
						PX.SoPhieu,
						KH.TenBoPhan,
						NN.TenNguoiNhan,
						NT.TenNguoiTao,
						PX.NgayTao,
						CT.IdLoaiVatTu,
						CT.SoLuong
				   FROM	   
						(SELECT Id, 
								IdKhoHang,
								SoPhieu,
								IdBoPhan,
								IdNguoiNhan,
								IdNguoiTao,
								NgayTao
						   FROM		
								dbo.KhPhieuXuat 
						  WHERE		
								(@IdBoPhan IS NULL OR IdBoPhan=@IdBoPhan) AND
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as PX INNER JOIN
						dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') IK ON PX.IdKhoHang=IK.Id INNER JOIN
						(SELECT Id,
								Ten as TenBoPhan
						   FROM	
								dbo.DmBoPhan
						) as KH ON PX.IdBoPhan=KH.Id INNER JOIN	
						(SELECT Id,
								Ten as TenNguoiNhan
						   FROM	
								dbo.HtNguoiDung
						) as NN ON PX.IdNguoiNhan=NN.Id INNER JOIN
						(SELECT Id,
								Ten as TenNguoiTao
						   FROM	
								dbo.HtNguoiDung
						) as NT ON PX.IdNguoiTao=NT.Id INNER JOIN
						(SELECT IdPhieuXuat,
								IdLoaiVatTu,
								SoLuong
						   FROM 
								dbo.KhPhieuXuatCt
						  WHERE
								(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
						) as CT ON PX.Id=CT.IdPhieuXuat
				) as HX INNER JOIN
				(SELECT Id,
						IdNhomVatTu,
						IdDonViTinh,
						Ten,
						QuyCach
				   FROM	
						dbo.DmLoaiVatTu 
				) as LH ON HX.IdLoaiVatTu=LH.Id INNER JOIN
				(SELECT Id,
						Ten
				   FROM	
						dbo.DmDonViTinh 
				) as DV ON LH.IdDonViTinh=DV.Id INNER JOIN
				dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id INNER JOIN
				(SELECT Id,
						Ten,
						ThuTu
				   FROM	
						dbo.DmNhomVatTu 
				) as NH ON LH.IdNhomVatTu=NH.Id				
		ORDER BY
				HX.NgayTao, NH.ThuTu, NH.Ten, LH.Ten ASC				
	END














































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpNhapXuatTon]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


























































































CREATE PROCEDURE [dbo].[Custom_RpNhapXuatTon]
(
	@ListKhoHang		varchar(100),
	@ListNhomVatTu		varchar(MAX),		
	@TuNgay				date,
	@DenNgay			date	
)
AS
	SET NOCOUNT OFF
	
	CREATE TABLE #TMPNhapXuatTon
	(
		IdNhomVatTu		uniqueidentifier,
		IdLoaiVatTu		uniqueidentifier,
		IdDonViTinh		uniqueidentifier,
		Ten				nvarchar(100),
		QuyCach			nvarchar(300),
		TonDau			int,		
		Nhap			int,
		NhapDk			int,		
		Xuat			int,
		XuatDk			int,	
		Chuyen			int,
		ChuyenDk		int,	
		TonCuoi			int		
	)
	INSERT INTO #TMPNhapXuatTon(IdNhomVatTu,IdLoaiVatTu,IdDonViTinh,Ten,QuyCach,TonDau,Nhap,NhapDk,Xuat,XuatDk,Chuyen,ChuyenDk,TonCuoi)		
	SELECT  LH.IdNhomVatTu,
			LH.Id,
			LH.IdDonViTinh,
			LH.Ten,
			LH.QuyCach,
			0,0,0,0,0,0,0,0
	 FROM	   
			(SELECT Id,
					IdNhomVatTu,
					IdDonViTinh,
					Ten,
					QuyCach
			   FROM 
					dbo.DmLoaiVatTu
			  WHERE
				    (TrangThai=1)
			) as LH INNER JOIN
			dbo.uf_Get_TableGuid(@ListNhomVatTu, 'NhomVatTu') as ID ON LH.IdNhomVatTu=ID.Id
			
	UPDATE NXT
	   SET NXT.Nhap=HNX.Nhap,
		   NXT.Xuat=HNX.Xuat,
		   NXT.Chuyen=HNX.Chuyen
	  FROM #TMPNhapXuatTon NXT INNER JOIN 
		   (SELECT IdLoaiVatTu,
				   SUM(Nhap) as Nhap,
				   SUM(Xuat) as Xuat,
				   SUM(Chuyen) as Chuyen
			  FROM		
				   dbo.uf_Get_NhapXuat(@ListKhoHang,@TuNgay,@DenNgay)
		  GROUP BY	
				   IdLoaiVatTu 				
		   ) as HNX ON NXT.IdLoaiVatTu=HNX.IdLoaiVatTu	
		   
	UPDATE NXT
	   SET NXT.NhapDk=TDK.Nhap,
		   NXT.XuatDk=TDK.Xuat,
		   NXT.ChuyenDk=TDK.Chuyen
	  FROM #TMPNhapXuatTon NXT INNER JOIN 
		   (SELECT TDK.IdLoaiVatTu,					
	   			   SUM(TDK.Nhap) as Nhap,
	   			   SUM(TDK.Xuat) as Xuat,
				   SUM(TDK.Chuyen) as Chuyen   	   	   	   	   
			  FROM			   	      
				   (SELECT IdKhoHang,
						   IdLoaiVatTu,					
	   					   SUM(Nhap) as Nhap,
	   					   SUM(Xuat) as Xuat,
						   SUM(Chuyen) as Chuyen
					  FROM		
						   dbo.KhNhapXuat
					 WHERE
						   Thang<DATEADD(dd,-DAY(@TuNgay)+1,@TuNgay)
				  GROUP BY						   				   
						   IdKhoHang, IdLoaiVatTu
					) as TDK INNER JOIN
					dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as IDK ON TDK.IdKhoHang=IDK.Id
			GROUP BY
					TDK.IdLoaiVatTu	
		   ) as TDK ON NXT.IdLoaiVatTu=TDK.IdLoaiVatTu	
		   
	UPDATE NXT
	   SET NXT.NhapDk=NXT.NhapDk+HNX.Nhap,
		   NXT.XuatDk=NXT.XuatDk+HNX.Xuat,
		   NXT.ChuyenDk=NXT.ChuyenDk+HNX.Chuyen
	  FROM #TMPNhapXuatTon NXT INNER JOIN 
		   (SELECT IdLoaiVatTu,
				   SUM(Nhap) as Nhap,
				   SUM(Xuat) as Xuat,
				   SUM(Chuyen) as Chuyen
			  FROM		
				   dbo.uf_Get_NhapXuat(@ListKhoHang,DATEADD(dd,-DAY(@TuNgay)+1,@TuNgay),DATEADD(DAY,-1,@TuNgay))
		  GROUP BY	
				   IdLoaiVatTu 				
		   ) as HNX ON NXT.IdLoaiVatTu=HNX.IdLoaiVatTu	
		   
	UPDATE #TMPNhapXuatTon
	   SET TonDau=(NhapDk)-(XuatDk+ChuyenDk)
		   
	UPDATE #TMPNhapXuatTon
	   SET TonCuoi=(TonDau+Nhap)-(Xuat+Chuyen)

	SELECT  NX.IdNhomVatTu,
			NX.IdLoaiVatTu,
			NH.Ten as TenNhomVatTu,
			NX.Ten as TenLoaiVatTu,
			DV.Ten as TenDonViTinh,
			NX.QuyCach,
			NX.TonDau,
			NX.Nhap,
			NX.Xuat,
			NX.Chuyen,
			NX.TonCuoi
	  FROM    
			(SELECT IdNhomVatTu,
					IdLoaiVatTu,
					IdDonViTinh,
					Ten,
					QuyCach,
					TonDau,
					Nhap,
					Xuat,
					Chuyen,
					TonCuoi
			   FROM
					#TMPNhapXuatTon
			  WHERE
					(TonDau + Nhap + Xuat + Chuyen > 0)
			) as NX INNER JOIN
			(SELECT Id,
					Ten
			   FROM	
					dbo.DmDonViTinh
			) as DV ON NX.IdDonViTinh=DV.Id INNER JOIN
			(SELECT Id,
					Ten,
					ThuTu
			   FROM	
					dbo.DmNhomVatTu
			) as NH ON NX.IdNhomVatTu=NH.Id
	ORDER BY
			NH.ThuTu, NH.Ten, NX.Ten ASC

	DROP TABLE #TMPNhapXuatTon



































































































GO
/****** Object:  StoredProcedure [dbo].[Custom_RpNhapXuatTonChiTiet]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





















































































-- exec Custom_RP_NhapXuatTonChiTiet '1,2','0EF7A76D-6921-4B92-98D9-B13E394DD3D7', '2020-10-01','2020-10-26'


CREATE PROCEDURE [dbo].[Custom_RpNhapXuatTonChiTiet]
(
	@ListKhoHang	varchar(100),
	@IdLoaiVatTu	uniqueidentifier,
	@TuNgay			date,
	@DenNgay		date	
)
AS
	SET NOCOUNT OFF
	
	CREATE TABLE #TMPDauKy
	(
		IdLoaiVatTu		uniqueidentifier,
		NhapDk			int,		
		XuatDk			int,
		ChuyenDk		int
	)
	INSERT INTO #TMPDauKy(IdLoaiVatTu,NhapDk,XuatDk,ChuyenDk)
	SELECT @IdLoaiVatTu, 0, 0, 0

	 UPDATE DK
	    SET DK.NhapDk=NX.Nhap,
		    DK.XuatDk=NX.Xuat,
		    DK.ChuyenDk=NX.Chuyen
	  FROM	#TMPDauKy DK INNER JOIN
			(SELECT NX.IdLoaiVatTu,					
	   				SUM(NX.Nhap) as Nhap,
	   				SUM(NX.Xuat) as Xuat,
					SUM(NX.Chuyen) as Chuyen   	   	   	   	   
			   FROM			   	      
					(SELECT IdKhoHang,
							IdLoaiVatTu,					
	   						SUM(Nhap) as Nhap,
	   						SUM(Xuat) as Xuat,
							SUM(Chuyen) as Chuyen
					   FROM		
							dbo.KhNhapXuat
					  WHERE
							(IdLoaiVatTu=@IdLoaiVatTu) AND
							(Thang<DATEADD(dd,-DAY(@TuNgay)+1,@TuNgay))
					GROUP BY						   				   
							IdKhoHang, IdLoaiVatTu
					) as NX INNER JOIN
					dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON NX.IdKhoHang=ID.Id
			GROUP BY
					NX.IdLoaiVatTu	
		   ) as NX ON DK.IdLoaiVatTu=NX.IdLoaiVatTu

	UPDATE DK
	   SET DK.NhapDk += NX.Nhap,
		   DK.XuatDk += NX.Xuat,
		   DK.ChuyenDk += NX.Chuyen
	  FROM #TMPDauKy as DK INNER JOIN 
		   (SELECT IdLoaiVatTu,
				   SUM(Nhap) as Nhap,
				   SUM(Xuat) as Xuat,
				   SUM(Chuyen) as Chuyen
			  FROM		
				   dbo.uf_Get_NhapXuat(@ListKhoHang, DATEADD(dd,-DAY(@TuNgay)+1, @TuNgay), DATEADD(DAY,-1, @TuNgay))
			WHERE
				   (IdLoaiVatTu=@IdLoaiVatTu)
		  GROUP BY	
				   IdLoaiVatTu 				
		   ) as NX ON DK.IdLoaiVatTu=NX.IdLoaiVatTu

	DECLARE @TonDau int

	SET @TonDau=(SELECT TOP 1 (NhapDk)-(XuatDk+ChuyenDk) FROM #TMPDauKy)
	IF(@TonDau IS NULL) SET @TonDau=0

	CREATE TABLE #TMPNhapXuatTon
	(
		RowNumber		int,
		IdLoaiVatTu		uniqueidentifier,
		NgayTao			datetime,
		LoaiPhieu		smallint,
		IdPhieu			uniqueidentifier,
		IdPhieuChiTiet	uniqueidentifier,
		SoPhieuNhap		nvarchar(20),
		SoPhieuXuat		nvarchar(20),
		SoPhieuChuyen	nvarchar(20),
		DienGiai		nvarchar(200),
		Nhap			int,		
		Xuat			int,
		Chuyen			int,		
		Ton				int
	)

	INSERT INTO #TMPNhapXuatTon(IdLoaiVatTu,NgayTao,LoaiPhieu,IdPhieu,IdPhieuChiTiet,SoPhieuNhap,SoPhieuXuat,SoPhieuChuyen,DienGiai,Nhap,Xuat,Chuyen,Ton)
	SELECT  @IdLoaiVatTu,
			PN.NgayTao,
			0,
			PN.Id,
			CT.Id,
			PN.SoPhieu,
			NULL,NULL,
			N'Nhập kho từ: ' + NN.Ten,
			CT.SoLuong,
			0,0,0
	   FROM 
			(SELECT Id, 
					IdKhoHang,
					SoPhieu,
					IdNguonNhap,
					NgayTao
			   FROM		
					dbo.KhPhieuNhap 
			  WHERE		
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PN INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PN.IdKhoHang=ID.Id INNER JOIN
			(SELECT Id, 
					Ten
			   FROM		
					dbo.DmNguonNhap 
			) as NN ON PN.IdNguonNhap=NN.Id INNER JOIN
			(SELECT Id,
					IdPhieuNhap,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuNhapCt
			  WHERE
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay) AND
					(IdLoaiVatTu=@IdLoaiVatTu)
			) as CT ON PN.Id=CT.IdPhieuNhap	
				
	INSERT INTO #TMPNhapXuatTon(IdLoaiVatTu,NgayTao,LoaiPhieu,IdPhieu,IdPhieuChiTiet,SoPhieuNhap,SoPhieuXuat,SoPhieuChuyen,DienGiai,Nhap,Xuat,Chuyen,Ton)
	SELECT  @IdLoaiVatTu,
			PX.NgayTao,
			1,
			PX.Id,
			CT.Id,
			NULL,
			PX.SoPhieu,
			NULL,
			N'Xuất kho cho: ' + BP.Ten,
			0,
			CT.SoLuong,
			0,0
	   FROM 
			(SELECT Id, 
					IdKhoHang,
					SoPhieu,
					IdBoPhan,
					NgayTao
			   FROM		
					dbo.KhPhieuXuat
			  WHERE		
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PX INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PX.IdKhoHang=ID.Id INNER JOIN
			(SELECT Id, 
					Ten
			   FROM		
					dbo.DmBoPhan 
			) as BP ON PX.IdBoPhan=BP.Id INNER JOIN
			(SELECT Id,
					IdPhieuXuat,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuXuatCt
			  WHERE
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay) AND
					(IdLoaiVatTu=@IdLoaiVatTu)
			) as CT ON PX.Id=CT.IdPhieuXuat	
				
	INSERT INTO #TMPNhapXuatTon(IdLoaiVatTu,NgayTao,LoaiPhieu,IdPhieu,IdPhieuChiTiet,SoPhieuNhap,SoPhieuXuat,SoPhieuChuyen,DienGiai,Nhap,Xuat,Chuyen,Ton)
	SELECT  @IdLoaiVatTu,
			PC.NgayTao,
			2,
			PC.Id,
			CT.Id,
			NULL,NULL,
			PC.SoPhieu,
			N'Chuyển kho cho: ' + KN.Ten,
			0,0,
			CT.SoLuong,
			0
	  FROM 
			(SELECT Id, 
					IdKhoHang,
					SoPhieu,
					IdKhoNhan,
					NgayTao
			   FROM		
					dbo.KhPhieuChuyen
			  WHERE		
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay)
			) as PC INNER JOIN
			dbo.uf_Get_TableInt(@ListKhoHang,'KhoHang') as ID ON PC.IdKhoHang=ID.Id INNER JOIN
			(SELECT Id, 
					Ten
			   FROM		
					dbo.DmKhoHang 
			) as KN ON PC.IdKhoNhan=KN.Id INNER JOIN
			(SELECT Id,
					IdPhieuChuyen,
					IdLoaiVatTu,
					SoLuong
			   FROM 
					dbo.KhPhieuChuyenCt
			  WHERE
					(NgayTaoDate BETWEEN @TuNgay AND @DenNgay) AND
					(IdLoaiVatTu=@IdLoaiVatTu)
			) as CT ON PC.Id=CT.IdPhieuChuyen	
	
	CREATE TABLE #TMPNgayGiaoDich
	(
		IdPhieuChiTiet	uniqueidentifier,
		LoaiPhieu		smallint,
		RowNumber		int
	)
	INSERT INTO #TMPNgayGiaoDich(IdPhieuChiTiet,LoaiPhieu,RowNumber)
	SELECT IdPhieuChiTiet, LoaiPhieu, ROW_NUMBER() OVER (ORDER BY NgayTao ASC) FROM #TMPNhapXuatTon

	DECLARE @IdPhieuChiTiet uniqueidentifier, @RowNumber int, @SoLuong int, @LoaiPhieu smallint, @TonCuoi int

	SET @RowNumber = 1

	SET @TonCuoi=@TonDau

	WHILE ((SELECT COUNT(*) FROM #TMPNgayGiaoDich) > 0)
	BEGIN
		SELECT TOP 1 @IdPhieuChiTiet=IdPhieuChiTiet, @LoaiPhieu=LoaiPhieu FROM #TMPNgayGiaoDich WHERE RowNumber=@RowNumber

		IF(@LoaiPhieu=0)
		BEGIN
			SET @SoLuong=(SELECT TOP 1 Nhap FROM #TMPNhapXuatTon WHERE (IdPhieuChiTiet=@IdPhieuChiTiet) AND (LoaiPhieu=@LoaiPhieu))
			SET @TonCuoi=@TonCuoi+@SoLuong
		END
		ELSE IF(@LoaiPhieu=1)
		BEGIN
			SET @SoLuong=(SELECT TOP 1 Xuat FROM #TMPNhapXuatTon WHERE (IdPhieuChiTiet=@IdPhieuChiTiet) AND (LoaiPhieu=@LoaiPhieu))
			SET @TonCuoi=@TonCuoi-@SoLuong
		END
		IF(@LoaiPhieu=2)
		BEGIN
			SET @SoLuong=(SELECT TOP 1 Chuyen FROM #TMPNhapXuatTon WHERE (IdPhieuChiTiet=@IdPhieuChiTiet) AND (LoaiPhieu=@LoaiPhieu))
			SET @TonCuoi=@TonCuoi-@SoLuong
		END

		UPDATE #TMPNhapXuatTon
		   SET RowNumber=@RowNumber,
			   Ton=@TonCuoi
		 WHERE (IdPhieuChiTiet=@IdPhieuChiTiet) AND
			   (LoaiPhieu=@LoaiPhieu)

		DELETE FROM #TMPNgayGiaoDich
		      WHERE RowNumber=@RowNumber

		SET @RowNumber = @RowNumber + 1
	END

	INSERT INTO #TMPNhapXuatTon(RowNumber,DienGiai,Ton)
	SELECT	0,
			N'Tồn trước ngày: ' + FORMAT(@TuNgay,'dd/MM/yyyy'),
			@TonDau

	INSERT INTO #TMPNhapXuatTon(RowNumber,DienGiai,Ton)
	SELECT	100000,
			N'Tồn cuối ngày: ' + FORMAT(@DenNgay,'dd/MM/yyyy'),
			@TonCuoi

	SELECT	RowNumber,
			NgayTao, 
			LoaiPhieu, 
			IdPhieu, 
			IdPhieuChiTiet, 
			SoPhieuNhap, 
			SoPhieuXuat, 
			SoPhieuChuyen, 
			SoPhieuTra, 
			DienGiai, 
			Nhap, 
			Xuat, 
			Chuyen, 
			Ton 
	  FROM	
			#TMPNhapXuatTon 
	ORDER BY
			RowNumber ASC

	DROP TABLE #TMPNhapXuatTon
	DROP TABLE #TMPDauKy
	DROP TABLE #TMPNgayGiaoDich


































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_DmLoaiVatTu_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

























































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_DmLoaiVatTu_Delete]
(
	@IdLoaiVatTu	uniqueidentifier,
	@DeleteAll		bit		
)
AS
	SET NOCOUNT OFF

	DELETE FROM dbo.DmLoaiVatTuViTri
		  WHERE IdLoaiVatTu=@IdLoaiVatTu
		
	IF(@DeleteAll=1)
	BEGIN
		DELETE FROM dbo.DmLoaiVatTu
			  WHERE Id=@IdLoaiVatTu
	END			
				














































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuChuyen_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

























































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuChuyen_Delete]
(
	@IdKhoHang		int,
	@IdPhieuChuyen	uniqueidentifier,
	@DeleteAll		bit		
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPHangChuyen
	(
		IdSanPham		uniqueidentifier, 
		SoLuongXoa		int
	)
	INSERT INTO #TMPHangChuyen(IdSanPham,SoLuongXoa)
	SELECT XP.IdSanPham,
		   SUM(XP.SoLuong)
	  FROM (SELECT Id
			  FROM dbo.KhPhieuChuyenCt
			 WHERE IdPhieuChuyen=@IdPhieuChuyen						
		   ) as CT INNER JOIN					  
		   (SELECT IdPhieuChuyenCt,
				   IdSanPham,
				   SoLuong
			  FROM dbo.KhPhieuChuyenSp
		    ) as XP ON CT.Id=XP.IdPhieuChuyenCt
	GROUP BY
			XP.IdSanPham

	DELETE XP 
	  FROM dbo.KhPhieuChuyenSp XP INNER JOIN
		   (SELECT Id
			  FROM dbo.KhPhieuChuyenCt
			 WHERE IdPhieuChuyen=@IdPhieuChuyen						
		   ) as CT ON XP.IdPhieuChuyenCt=CT.Id

	DELETE FROM dbo.KhPhieuChuyenCt
			WHERE IdPhieuChuyen=@IdPhieuChuyen
			  
	UPDATE HT
	   SET HT.SoLuongTon=HT.SoLuongTon + HX.SoLuongXoa
	  FROM dbo.KhSanPham as HT INNER JOIN 
		   #TMPHangChuyen as HX ON HT.Id=HX.IdSanPham
	  WHERE HT.IdKhoHang=@IdKhoHang		   
		
	IF(@DeleteAll=1)
	BEGIN
		DELETE FROM dbo.KhPhieuChuyen
			  WHERE Id=@IdPhieuChuyen
	END			
				
	DROP TABLE #TMPHangChuyen			

















































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuChuyen_Get_SoPhieu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuChuyen_Get_SoPhieu]
(
	@IdKhoHang		int,
	@MaKhoHang		nvarchar(5),
	@MonthYear		varchar(4)
)
AS
	SET NOCOUNT OFF

	DECLARE @SoPhieu varchar(20), @PhanKyTu varchar(20)

	SET @PhanKyTu = 'PC' + @MaKhoHang + @MonthYear

	IF((SELECT TOP 1 Id FROM dbo.KhPhieuChuyen WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu) IS NULL)
	BEGIN
		SET @SoPhieu = @PhanKyTu + '0001'
	END
	ELSE
	BEGIN
		DECLARE @TMPPhieuChuyen TABLE(SoPhieu int)
		INSERT INTO @TMPPhieuChuyen(SoPhieu)
		SELECT TOP 10 CONVERT(int,RIGHT(SoPhieu,4)) FROM dbo.KhPhieuChuyen WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu ORDER BY NgayTao DESC
		SET @SoPhieu=RTRIM(CONVERT(varchar(4),(SElECT TOP 1 SoPhieu FROM @TMPPhieuChuyen ORDER BY SoPhieu DESC)+1))
		WHILE (LEN(@SoPhieu) < 4)
		BEGIN
			SET @SoPhieu = '0' + @SoPhieu
		END
		SET @SoPhieu=@PhanKyTu+@SoPhieu
	END

	SELECT @SoPhieu AS SoPhieu

























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuChuyenCt_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[CustomGen_KhPhieuChuyenCt_Update]
(
	@IdKhoHang		int,
	@IdPhieuChuyen	uniqueidentifier,
	@IdPhieuNhapNb	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPLoaiVatTu
	(
		IdPhieuChuyenCt	uniqueidentifier,
		IdLoaiVatTu		uniqueidentifier,
		SoLuongXuat		int,
		NgayTaoDate		date
	)
	CREATE TABLE #TMPSanPham
	(
		IdSanPham		uniqueidentifier,
		SoLuongTon		int
	)

	INSERT INTO #TMPLoaiVatTu (IdPhieuChuyenCt,IdLoaiVatTu,SoLuongXuat,NgayTaoDate)
	SELECT Id,
		   IdLoaiVatTu,
		   SoLuong,
		   NgayTaoDate
	  FROM dbo.KhPhieuChuyenCt
	 WHERE IdPhieuChuyen=@IdPhieuChuyen

	DECLARE @IdPhieuChuyenCt uniqueidentifier, @IdLoaiVatTu uniqueidentifier, @IdSanPham uniqueidentifier, @NgayTaoDate date
	DECLARE @SoLuongXuat int, @SoLuongDaChon int, @SoLuongLay int, @SoLuongTon int

	SET @SoLuongDaChon=0
	SET @SoLuongLay=0

	WHILE (SELECT COUNT(IdPhieuChuyenCt) FROM #TMPLoaiVatTu) > 0
	BEGIN
		SELECT TOP 1 @IdPhieuChuyenCt=IdPhieuChuyenCt,@IdLoaiVatTu=IdLoaiVatTu,@SoLuongXuat=SoLuongXuat,@NgayTaoDate=NgayTaoDate FROM #TMPLoaiVatTu

		DELETE FROM #TMPSanPham

		INSERT INTO #TMPSanPham (IdSanPham,SoLuongTon)
		SELECT Id, 
			   SoLuongTon
		  FROM dbo.KhSanPham
		 WHERE (IdKhoHang=@IdKhoHang) AND
			   (IdLoaiVatTu=@IdLoaiVatTu) AND
			   (SoLuongTon>0)
	  ORDER BY
			   NgayTao ASC

		SET @SoLuongDaChon=0
		SET @SoLuongLay=0

		WHILE (SELECT COUNT(IdSanPham) FROM #TMPSanPham) > 0
		BEGIN		
			SELECT TOP 1 @IdSanPham=IdSanPham, @SoLuongTon=SoLuongTon FROM #TMPSanPham	
			IF (@SoLuongDaChon < @SoLuongXuat)
			BEGIN
				IF(@SoLuongTon > (@SoLuongXuat-@SoLuongDaChon))
				BEGIN
					SET @SoLuongLay = @SoLuongXuat - @SoLuongDaChon
				END
				ELSE
				BEGIN
					SET @SoLuongLay = @SoLuongTon
				END
				SET @SoLuongDaChon = @SoLuongDaChon + @SoLuongLay

				INSERT INTO dbo.KhPhieuChuyenSp (Id,IdPhieuChuyenCt,IdSanPham,SoLuong,NgayTaoDate)
					 VALUES (NewId(),@IdPhieuChuyenCt,@IdSanPham,@SoLuongLay,@NgayTaoDate)

				INSERT INTO dbo.KhPhieuNhapNbCt(Id,IdPhieuNhapNb,IdLoaiVatTu,IdSanPham,SoLuong)
					 VALUES (NewId(),@IdPhieuNhapNb,@IdLoaiVatTu,@IdSanPham,@SoLuongLay)

				UPDATE dbo.KhSanPham
				   SET SoLuongTon=SoLuongTon-@SoLuongLay
				 WHERE Id=@IdSanPham

				DELETE #TMPSanPham WHERE IdSanPham = @IdSanPham
			END
			ELSE
			BEGIN
				BREAK
			END
		END
		DELETE #TMPLoaiVatTu WHERE IdPhieuChuyenCt = @IdPhieuChuyenCt
	END 
	
	DROP TABLE #TMPLoaiVatTu
	DROP TABLE #TMPSanPham



























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuNhap_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






















































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuNhap_Delete]
(
	@IdKhoHang		int,
	@IdPhieuNhap	uniqueidentifier,
	@DeleteAll		bit	
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPHangNhap
	(
		IdSanPham		uniqueidentifier, 
		SoLuongXoa		int
	)
	INSERT INTO #TMPHangNhap(IdSanPham,SoLuongXoa)
	SELECT IdSanPham,
		   SUM(SoLuong)
	  FROM dbo.KhPhieuNhapCt
	 WHERE IdPhieuNhap=@IdPhieuNhap
  GROUP BY IdSanPham	

	DELETE FROM dbo.KhPhieuNhapCt
		  WHERE IdPhieuNhap=@IdPhieuNhap		

	DELETE SP
	  FROM dbo.KhSanPham SP INNER JOIN
		   #TMPHangNhap HN ON SP.Id=HN.IdSanPham
		
	IF(@DeleteAll=1)
	BEGIN			
		DELETE FROM dbo.KhPhieuNhap
			   WHERE Id=@IdPhieuNhap

		DELETE FROM dbo.KhSanPham
			  WHERE Id NOT IN (SELECT IdSanPham FROM dbo.KhPhieuNhapCt)
	END	
					
	DROP TABLE #TMPHangNhap	
















































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuNhap_Get_SoPhieu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuNhap_Get_SoPhieu]
(
	@IdKhoHang		int,
	@MaKhoHang		nvarchar(5),
	@MonthYear		varchar(4)
)
AS
	SET NOCOUNT OFF

	DECLARE @SoPhieu varchar(20), @PhanKyTu varchar(20)
	SET @PhanKyTu = 'PN' + @MaKhoHang + @MonthYear

	IF((SELECT TOP 1 Id FROM dbo.KhPhieuNhap WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu) IS NULL)
	BEGIN
		SET @SoPhieu = @PhanKyTu + '0001'
	END
	ELSE
	BEGIN
		DECLARE @TMPPhieuNhap TABLE(SoPhieu int)
		INSERT INTO @TMPPhieuNhap(SoPhieu)
		SELECT TOP 10 CONVERT(int,RIGHT(SoPhieu,4)) FROM dbo.KhPhieuNhap WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu ORDER BY NgayTao DESC
		SET @SoPhieu=RTRIM(CONVERT(varchar(4),(SElECT TOP 1 SoPhieu FROM @TMPPhieuNhap ORDER BY SoPhieu DESC)+1))
		WHILE (LEN(@SoPhieu) < 4)
		BEGIN
			SET @SoPhieu = '0' + @SoPhieu
		END
		SET @SoPhieu=@PhanKyTu+@SoPhieu
	END

	SELECT @SoPhieu AS SoPhieu

























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuNhap_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO














































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[CustomGen_KhPhieuNhap_Update]
(
	@IdPhieuNhap	uniqueidentifier,
	@IdNguonNhap	uniqueidentifier
)
AS
	SET NOCOUNT OFF
 
	UPDATE SP
	   SET SP.IdNguonNhap=@IdNguonNhap
	  FROM dbo.KhSanPham SP INNER JOIN 
		   (SELECT IdSanPham 
			  FROM dbo.KhPhieuNhapCt
			 WHERE IdPhieuNhap=@IdPhieuNhap
		   ) as CT ON SP.IdSanPham=CT.IdSanPham
	

























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuNhapNb_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[CustomGen_KhPhieuNhapNb_Delete]
(
	@IdPhieuNhapNb		uniqueidentifier,
	@DeleteAll			bit						
)
AS
	SET NOCOUNT OFF

	DELETE FROM dbo.KhPhieuNhapNbCt
		  WHERE IdPhieuNhapNb=@IdPhieuNhapNb
			  
	IF(@DeleteAll=1)
	BEGIN
		DELETE FROM dbo.KhPhieuNhapNb
			  WHERE Id=@IdPhieuNhapNb		
	END					  

























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuNhapNb_Get_SoPhieu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuNhapNb_Get_SoPhieu]
(
	@IdKhoHang		int,
	@MonthYear		varchar(4)
)
AS
	SET NOCOUNT OFF

	DECLARE @MaKhoHang	nvarchar(5), @SoPhieu varchar(20), @PhanKyTu varchar(20)

	SET @MaKhoHang = (SELECT TOP 1 TenVietTat FROM dbo.DmKhoHang WHERE Id=@IdKhoHang)
	SET @PhanKyTu = 'PN' + @MaKhoHang + @MonthYear

	IF((SELECT TOP 1 Id FROM dbo.KhPhieuNhapNb WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu) IS NULL)
	BEGIN
		SET @SoPhieu=@PhanKyTu+'0001'
	END
	ELSE
	BEGIN
		DECLARE @TMPPhieuNhapNb TABLE(SoPhieu int)
		INSERT INTO @TMPPhieuNhapNb(SoPhieu)
		SELECT TOP 10 CONVERT(int,RIGHT(SoPhieu,4)) FROM dbo.KhPhieuNhapNb WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu ORDER BY NgayTao DESC
		SET @SoPhieu=RTRIM(CONVERT(varchar(4),(SElECT TOP 1 SoPhieu FROM @TMPPhieuNhapNb ORDER BY SoPhieu DESC)+1))
		WHILE (LEN(@SoPhieu) < 4)
		BEGIN
			SET @SoPhieu = '0' + @SoPhieu
		END
		SET @SoPhieu=@PhanKyTu+@SoPhieu
	END

	SELECT @SoPhieu AS SoPhieu

























































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuXuat_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

























































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuXuat_Delete]
(
	@IdKhoHang		int,
	@IdPhieuXuat	uniqueidentifier,
	@DeleteAll		bit		
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPHangXuat
	(
		IdSanPham		uniqueidentifier, 
		SoLuongXoa		int
	)
	INSERT INTO #TMPHangXuat(IdSanPham,SoLuongXoa)
	SELECT XP.IdSanPham,
		   SUM(XP.SoLuong)	
	  FROM (SELECT Id
			  FROM dbo.KhPhieuXuatCt
			 WHERE IdPhieuXuat=@IdPhieuXuat						
		   ) as CT INNER JOIN	
		   (SELECT IdPhieuXuatCt,
				   IdSanPham,
				   SoLuong
			  FROM dbo.KhPhieuXuatSp
		    ) as XP ON CT.Id=XP.IdPhieuXuatCt
	GROUP BY
			XP.IdSanPham

	DELETE XP 
	  FROM dbo.KhPhieuXuatSp as XP INNER JOIN
		   (SELECT Id
			  FROM dbo.KhPhieuXuatCt
			 WHERE IdPhieuXuat=@IdPhieuXuat						
		   ) as CT ON XP.IdPhieuXuatCt=CT.Id

	DELETE FROM dbo.KhPhieuXuatCt
			WHERE IdPhieuXuat=@IdPhieuXuat
			  
	UPDATE HT
	   SET HT.SoLuongTon=HT.SoLuongTon + HX.SoLuongXoa
	  FROM dbo.KhSanPham as HT INNER JOIN
		   #TMPHangXuat as HX ON HT.Id=HX.IdSanPham
	  WHERE HT.IdKhoHang=@IdKhoHang		   
		
	IF(@DeleteAll=1)
	BEGIN
		DELETE FROM dbo.KhPhieuXuat
			  WHERE Id=@IdPhieuXuat
	END			
				
	DROP TABLE #TMPHangXuat			

















































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuXuat_Get_SoPhieu]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



























































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_Xuat table
----------------------------------------------------------------------------------------------------
*/
CREATE PROCEDURE [dbo].[CustomGen_KhPhieuXuat_Get_SoPhieu]
(
	@IdKhoHang		int,
	@MaKhoHang		nvarchar(5),
	@MonthYear		varchar(4)
)
AS
	SET NOCOUNT OFF

	DECLARE @SoPhieu varchar(20), @PhanKyTu varchar(100)
	SET @PhanKyTu = 'PX' + @MaKhoHang + @MonthYear

	IF((SELECT TOP 1 Id FROM dbo.KhPhieuXuat WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu) IS NULL)
	BEGIN
		SET @SoPhieu=@PhanKyTu+'0001'
	END
	ELSE
	BEGIN
		DECLARE @TMPPhieuXuat TABLE(SoPhieu int)
		INSERT INTO @TMPPhieuXuat(SoPhieu)
		SELECT TOP 10 CONVERT(int,RIGHT(SoPhieu,4)) FROM dbo.KhPhieuXuat WHERE IdKhoHang=@IdKhoHang AND LEFT(SoPhieu,LEN(@PhanKyTu))=@PhanKyTu ORDER BY NgayTao DESC
		SET @SoPhieu=RTRIM(CONVERT(varchar(4),(SElECT TOP 1 SoPhieu FROM @TMPPhieuXuat ORDER BY SoPhieu DESC)+1))
		WHILE (LEN(@SoPhieu) < 4)
		BEGIN
			SET @SoPhieu = '0' + @SoPhieu
		END
		SET @SoPhieu=@PhanKyTu+@SoPhieu
	END

	SELECT @SoPhieu AS SoPhieu













































































































GO
/****** Object:  StoredProcedure [dbo].[CustomGen_KhPhieuXuatCt_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
























































































































/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.vn)
-- Purpose: Gets all records from the HOA_DON_NHAP table
----------------------------------------------------------------------------------------------------
*/

CREATE PROCEDURE [dbo].[CustomGen_KhPhieuXuatCt_Update]
(
	@IdKhoHang		int,
	@IdPhieuXuat	uniqueidentifier
)
AS
	SET NOCOUNT OFF

	CREATE TABLE #TMPLoaiVatTu
	(
		IdPhieuXuatCt	uniqueidentifier,
		IdLoaiVatTu		uniqueidentifier,
		SoLuongXuat		int,
		NgayTaoDate		date
	)
	CREATE TABLE #TMPSanPham
	(
		IdSanPham		uniqueidentifier,
		SoLuongTon		int
	)
	INSERT INTO #TMPLoaiVatTu (IdPhieuXuatCt,IdLoaiVatTu,SoLuongXuat,NgayTaoDate)
	SELECT Id, IdLoaiVatTu, SoLuong, NgayTaoDate FROM dbo.KhPhieuXuatCt WHERE IdPhieuXuat=@IdPhieuXuat						

	DECLARE @IdPhieuXuatCt uniqueidentifier, @IdLoaiVatTu uniqueidentifier, @IdSanPham uniqueidentifier, @NgayTaoDate date
	DECLARE @SoLuongTra int, @SoLuongDaChon int, @SoLuongLay int, @SoLuongTon int

	SET @SoLuongTra=0 
	SET @SoLuongDaChon=0
	SET @SoLuongLay=0

	WHILE (SELECT COUNT(IdPhieuXuatCt) FROM #TMPLoaiVatTu) > 0
	BEGIN
		SELECT TOP 1 @IdPhieuXuatCt=IdPhieuXuatCt, @IdLoaiVatTu=IdLoaiVatTu, @SoLuongTra=SoLuongXuat, @NgayTaoDate=NgayTaoDate FROM #TMPLoaiVatTu

		DELETE FROM #TMPSanPham

		INSERT INTO #TMPSanPham (IdSanPham,SoLuongTon)
		SELECT Id, 
			   SoLuongTon
		  FROM dbo.KhSanPham
		 WHERE (IdKhoHang=@IdKhoHang) AND
			   (IdLoaiVatTu=@IdLoaiVatTu) AND
			   (SoLuongTon>0)
	   ORDER BY
			   NgayTao ASC

		SET @SoLuongDaChon=0
		SET @SoLuongLay=0

		WHILE (SELECT COUNT(IdSanPham) FROM #TMPSanPham) > 0
		BEGIN		
			SELECT TOP 1 @IdSanPham=IdSanPham, @SoLuongTon=SoLuongTon FROM #TMPSanPham	
			IF (@SoLuongDaChon < @SoLuongTra)
			BEGIN
				IF(@SoLuongTon > (@SoLuongTra- @SoLuongDaChon))
				BEGIN
					SET @SoLuongLay = @SoLuongTra - @SoLuongDaChon
				END
				ELSE
				BEGIN
					SET @SoLuongLay = @SoLuongTon
				END
				SET @SoLuongDaChon = @SoLuongDaChon + @SoLuongLay

				INSERT INTO dbo.KhPhieuXuatSp (Id,IdPhieuXuatCt,IdSanPham,SoLuong)
					 VALUES (NEWID(),@IdPhieuXuatCt,@IdSanPham,@SoLuongLay)

				UPDATE dbo.KhSanPham
				   SET SoLuongTon=SoLuongTon-@SoLuongLay
				 WHERE Id=@IdSanPham

				DELETE #TMPSanPham WHERE IdSanPham=@IdSanPham
			END
			ELSE
			BEGIN
				BREAK
			END
		END
		DELETE #TMPLoaiVatTu WHERE IdPhieuXuatCt = @IdPhieuXuatCt
	END 
	
	DROP TABLE #TMPLoaiVatTu
	DROP TABLE #TMPSanPham
















































































GO
/****** Object:  StoredProcedure [dbo].[ImplementNamingStandard]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE PROCEDURE [dbo].[ImplementNamingStandard]
    @SELECT_Only        BIT = 1,
    @PrimaryKeys        BIT = 1,
    @ForeignKeys        BIT = 1,
    @Indexes            BIT = 1,
    @UniqueConstraints  BIT = 1,
    @DefaultConstraints BIT = 1,
    @CheckConstraints   BIT = 1
AS
BEGIN
    SET NOCOUNT ON;


    DECLARE @sql NVARCHAR(MAX), @cr CHAR(2);
    SELECT @sql = N'', @cr = CHAR(13) + CHAR(10);

    
    DECLARE @TableLimit TINYINT, @ColumnLimit TINYINT;
    SELECT @TableLimit = 24, @ColumnLimit = 24;


    IF @PrimaryKeys = 1
    BEGIN
        SELECT @sql = @sql + @cr + @cr + N'/* ---- Primary Keys ---- */' + @cr;
        SELECT @sql = @sql + @cr + N'EXEC sp_rename @objname = N''' 
            + REPLACE(name, '''', '''''') + ''', @newname = N''PK_' 
            + LEFT(REPLACE(OBJECT_NAME(parent_object_id), '''', ''), @TableLimit) + ''';'
        FROM sys.key_constraints
        WHERE type = 'PK'
        AND is_ms_shipped = 0;
    END


    IF @ForeignKeys = 1
    BEGIN
        SELECT @sql = @sql + @cr + @cr + N'/* ---- Foreign Keys ---- */' + @cr;
        SELECT @sql = @sql + @cr + N'EXEC sp_rename @objname = N''' 
            + REPLACE(name, '''', '''''') + ''', @newname = N''FK_' 
            + LEFT(REPLACE(OBJECT_NAME(parent_object_id), '''', ''), @TableLimit)
            + '_' + LEFT(REPLACE(OBJECT_NAME(referenced_object_id), '''', ''), @TableLimit) + ''';'
        FROM sys.foreign_keys
        WHERE is_ms_shipped = 0;
    END


    IF (@UniqueConstraints = 1 OR @Indexes = 1)
    BEGIN
        SELECT @sql = @sql + @cr + @cr + N'/* ---- Indexes / Unique Constraints ---- */' + @cr;
        SELECT @sql = @sql + @cr + N'EXEC sp_rename @objname = N''' 
   + CASE is_unique_constraint WHEN 0 THEN
   QUOTENAME(REPLACE(OBJECT_NAME(i.[object_id]), '''', '''''')) + '.' ELSE '' END
            + QUOTENAME(REPLACE(i.name, '''', '''''')) + ''', @newname = N'''
            + CASE is_unique_constraint WHEN 1 THEN 'UQ_' ELSE 'IX_'
              + CASE is_unique WHEN 1 THEN 'U_'  ELSE '' END 
            END + CASE has_filter WHEN 1 THEN 'F_'  ELSE '' END
            + LEFT(REPLACE(OBJECT_NAME(i.[object_id]), '''', ''), @TableLimit) 
            + '_' + STUFF((SELECT '_' + LEFT(REPLACE(c.name, '''', ''), @ColumnLimit)
                FROM sys.columns AS c 
                    INNER JOIN sys.index_columns AS ic
                    ON ic.column_id = c.column_id
                    AND ic.[object_id] = c.[object_id]
                WHERE ic.[object_id] = i.[object_id] 
                AND ic.index_id = i.index_id
                AND is_included_column = 0
                ORDER BY ic.index_column_id FOR XML PATH(''), 
                TYPE).value('.', 'nvarchar(max)'), 1, 1, '') +''';'
        FROM sys.indexes AS i
        WHERE index_id > 0 AND is_primary_key = 0 AND type IN (1,2)
        AND OBJECTPROPERTY(i.[object_id], 'IsMsShipped') = 0;
    END


    IF @DefaultConstraints = 1
    BEGIN
        SELECT @sql = @sql + @cr + @cr + N'/* ---- DefaultConstraints ---- */' + @cr;
        SELECT @sql = @sql + @cr + N'EXEC sp_rename @objname = N''' 
            + REPLACE(dc.name, '''', '''''') + ''', @newname = N''DF_' 
            + LEFT(REPLACE(OBJECT_NAME(dc.parent_object_id), '''',''), @TableLimit)
            + '_' + LEFT(REPLACE(c.name, '''', ''), @ColumnLimit) + ''';'
        FROM sys.default_constraints AS dc
        INNER JOIN sys.columns AS c
        ON dc.parent_object_id = c.[object_id]
        AND dc.parent_column_id = c.column_id
        AND dc.is_ms_shipped = 0;
    END


    IF @CheckConstraints = 1
    BEGIN
        SELECT @sql = @sql + @cr + @cr + N'/* ---- CheckConstraints ---- */' + @cr;
        SELECT @sql = @sql + @cr + N'EXEC sp_rename @objname = N''' 
            + REPLACE(cc.name, '''', '''''') + ''', @newname = N''CK_' 
            + LEFT(REPLACE(OBJECT_NAME(cc.parent_object_id), '''',''), @TableLimit)
            + '_' + LEFT(REPLACE(c.name, '''', ''), @ColumnLimit) + ''';'
        FROM sys.check_constraints AS cc
        INNER JOIN sys.columns AS c
        ON cc.parent_object_id = c.[object_id]
        AND cc.parent_column_id = c.column_id
        AND cc.is_ms_shipped = 0;
    END


    SELECT @sql;


    IF @SELECT_Only = 0 AND @sql > N''
    BEGIN
        EXEC sp_executesql @sql;
    END
END
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuChuyen_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[tg_KhPhieuChuyen_Delete]
ON [dbo].[KhPhieuChuyen]
AFTER DELETE NOT FOR REPLICATION
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM deleted
SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<=@NgayLuu)
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayTao
END
GO
ALTER TABLE [dbo].[KhPhieuChuyen] ENABLE TRIGGER [tg_KhPhieuChuyen_Delete]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuChuyen_Insert]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[tg_KhPhieuChuyen_Insert]
ON [dbo].[KhPhieuChuyen]
AFTER INSERT
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM inserted

SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)>DATEADD(MONTH,1,@NgayLuu))
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuChuyen] ENABLE TRIGGER [tg_KhPhieuChuyen_Insert]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuChuyen_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TRIGGER [dbo].[tg_KhPhieuChuyen_Update]
ON [dbo].[KhPhieuChuyen]
AFTER UPDATE
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @Id uniqueidentifier,@IdKhoHang int,@NgayTao date,@UpdateTon int,@UpdateTien int,@NgayLuu date
SELECT TOP 1 @Id=Id,@IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM inserted
SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<DATEADD(MONTH,1,@NgayLuu) AND @UpdateTon=1)
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuChuyen] ENABLE TRIGGER [tg_KhPhieuChuyen_Update]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuNhap_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tg_KhPhieuNhap_Delete]
ON [dbo].[KhPhieuNhap]
AFTER DELETE NOT FOR REPLICATION
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM deleted
SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<=DATEADD(MONTH,1,@NgayLuu))
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuNhap] ENABLE TRIGGER [tg_KhPhieuNhap_Delete]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuNhap_Insert]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tg_KhPhieuNhap_Insert]
ON [dbo].[KhPhieuNhap]
AFTER INSERT
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM inserted
SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)>DATEADD(MONTH,1,@NgayLuu))
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuNhap] ENABLE TRIGGER [tg_KhPhieuNhap_Insert]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuNhap_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[tg_KhPhieuNhap_Update]
ON [dbo].[KhPhieuNhap]
AFTER UPDATE
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @Id uniqueidentifier,@IdKhoHang int,@UpdateTon int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @Id=Id,@IdKhoHang=IdKhoHang,@UpdateTon=UpdateTon,@NgayTao=NgayTaoDate FROM inserted
SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<DATEADD(MONTH,1,@NgayLuu) AND @UpdateTon=1)
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
UPDATE dbo.KhPhieuNhap
   SET UpdateTon=0
 WHERE Id=@Id
GO
ALTER TABLE [dbo].[KhPhieuNhap] ENABLE TRIGGER [tg_KhPhieuNhap_Update]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuXuat_Delete]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_KhPhieuXuat_Delete]
ON [dbo].[KhPhieuXuat]
AFTER DELETE NOT FOR REPLICATION
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM deleted

SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<=@NgayLuu)
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayTao
END
GO
ALTER TABLE [dbo].[KhPhieuXuat] ENABLE TRIGGER [tg_KhPhieuXuat_Delete]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuXuat_Insert]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_KhPhieuXuat_Insert]
ON [dbo].[KhPhieuXuat]
AFTER INSERT
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date,@NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang,@NgayTao=NgayTaoDate FROM inserted

SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)>DATEADD(MONTH,1,@NgayLuu))
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuXuat] ENABLE TRIGGER [tg_KhPhieuXuat_Insert]
GO
/****** Object:  Trigger [dbo].[tg_KhPhieuXuat_Update]    Script Date: 11/07/2021 12:37:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_KhPhieuXuat_Update]
ON [dbo].[KhPhieuXuat]
AFTER UPDATE
AS
IF @@ROWCOUNT = 0 RETURN

DECLARE @IdKhoHang int,@NgayTao date, @UpdateTon int, @NgayLuu date
SELECT TOP 1 @IdKhoHang=IdKhoHang, @NgayTao=NgayTaoDate FROM inserted

SET @NgayLuu=(SELECT TOP 1 Thang FROM dbo.KhNhapXuat WHERE IdKhoHang=@IdKhoHang ORDER BY Thang DESC)
IF(DATEADD(dd,-DAY(@NgayTao)+1,@NgayTao)<DATEADD(MONTH,1,@NgayLuu) AND @UpdateTon=1)
BEGIN
	EXEC dbo.Custom_KhNhapXuat_Insert_Data @IdKhoHang, @NgayLuu
END
GO
ALTER TABLE [dbo].[KhPhieuXuat] ENABLE TRIGGER [tg_KhPhieuXuat_Update]
GO
