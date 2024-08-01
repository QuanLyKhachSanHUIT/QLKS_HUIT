USE [QuanLyKS]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [chk_gtKH]
GO
ALTER TABLE [dbo].[Account] DROP CONSTRAINT [chk_gt]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK__HoaDon__idPhong__628FA481]
GO
ALTER TABLE [dbo].[DatPhong] DROP CONSTRAINT [FK__DatPhong__idPhon__619B8048]
GO
ALTER TABLE [dbo].[DatPhong] DROP CONSTRAINT [FK__DatPhong__idKh__60A75C0F]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [FK__ChiTietHo__idSan__5FB337D6]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [FK__ChiTietHo__idPho__5EBF139D]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [FK__ChiTietHo__idHoa__5CD6CB2B]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [FK__ChiTietHo__idDic__5DCAEF64]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [DF__Phong__price__5BE2A6F2]
GO
ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [df_status]
GO
ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [DF__HoaDon__status__59FA5E80]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [DF__ChiTietHo__count__59063A47]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SanPham]') AND type in (N'U'))
DROP TABLE [dbo].[SanPham]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Phong]') AND type in (N'U'))
DROP TABLE [dbo].[Phong]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LOAI]') AND type in (N'U'))
DROP TABLE [dbo].[LOAI]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDon]') AND type in (N'U'))
DROP TABLE [dbo].[HoaDon]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DichVu]') AND type in (N'U'))
DROP TABLE [dbo].[DichVu]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DatPhong]') AND type in (N'U'))
DROP TABLE [dbo].[DatPhong]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHoaDon]') AND type in (N'U'))
DROP TABLE [dbo].[ChiTietHoaDon]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type in (N'U'))
DROP TABLE [dbo].[Account]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Dislayname] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[Gt] [nvarchar](10) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idHoaDon] [int] NOT NULL,
	[idPhong] [int] NOT NULL,
	[idDichVu] [int] NOT NULL,
	[idSanPham] [int] NOT NULL,
	[count] [int] NOT NULL,
	[tongtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idKh] [int] NOT NULL,
	[idPhong] [int] NOT NULL,
	[DateCheckin] [date] NULL,
	[DateCheckout] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idKh] ASC,
	[idPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[soluong] [int] NULL,
	[priceDv] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NULL,
	[DateCheckOut] [date] NULL,
	[idPhong] [int] NOT NULL,
	[status] [int] NOT NULL,
	[tongtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[Gt] [nvarchar](10) NULL,
	[CMND] [char](15) NOT NULL,
	[DTLH] [char](15) NOT NULL,
	[Email] [nvarchar](30) NULL,
	[Password] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAI](
	[MALOAI] [nchar](10) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAI] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[MALOAI] [nchar](10) NOT NULL,
	[loaiPhong] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[soluong] [int] NULL,
	[priceSP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [Dislayname], [NgaySinh], [Gt], [Username], [PassWord], [Type]) VALUES (1, N'Nguyễn Công Cảnh', CAST(N'2000-06-13' AS Date), N'Nam', N'D3nCy', N'123', 1)
INSERT [dbo].[Account] ([id], [Dislayname], [NgaySinh], [Gt], [Username], [PassWord], [Type]) VALUES (2, N'Võ Hồ Tấn Tài', CAST(N'2000-11-17' AS Date), N'Nam', N'Mac', N'123', 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (8, 1, 1, 1, 2, 0, 200000)
INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (9, 1, 1, 1, 5, 0, 15000)
INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (10, 1, 1, 5, 1, 0, 20000)
INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (11, 2, 2, 1, 3, 0, 100000)
INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (12, 2, 2, 1, 2, 0, 200000)
INSERT [dbo].[ChiTietHoaDon] ([id], [idHoaDon], [idPhong], [idDichVu], [idSanPham], [count], [tongtien]) VALUES (13, 2, 2, 1, 5, 0, 15000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[DatPhong] ON 

INSERT [dbo].[DatPhong] ([id], [idKh], [idPhong], [DateCheckin], [DateCheckout]) VALUES (1, 1, 1, CAST(N'2021-06-20' AS Date), CAST(N'2021-06-22' AS Date))
INSERT [dbo].[DatPhong] ([id], [idKh], [idPhong], [DateCheckin], [DateCheckout]) VALUES (9, 2, 2, CAST(N'2021-07-14' AS Date), CAST(N'2021-07-14' AS Date))
SET IDENTITY_INSERT [dbo].[DatPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([id], [name], [soluong], [priceDv]) VALUES (1, N'Không sử dụng dịch vụ', 0, 0)
INSERT [dbo].[DichVu] ([id], [name], [soluong], [priceDv]) VALUES (2, N'''Thuê xe máy (xe số)', 1, 120000)
INSERT [dbo].[DichVu] ([id], [name], [soluong], [priceDv]) VALUES (3, N'Thuê xe máy (xe tay ga)', 1, 150000)
INSERT [dbo].[DichVu] ([id], [name], [soluong], [priceDv]) VALUES (4, N'Thuê xe oto', 1, 300000)
INSERT [dbo].[DichVu] ([id], [name], [soluong], [priceDv]) VALUES (5, N'Giặt ủi', 1, 20000)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([id], [DateCheckIn], [DateCheckOut], [idPhong], [status], [tongtien]) VALUES (1, CAST(N'2021-06-20' AS Date), CAST(N'2021-06-22' AS Date), 1, 0, NULL)
INSERT [dbo].[HoaDon] ([id], [DateCheckIn], [DateCheckOut], [idPhong], [status], [tongtien]) VALUES (2, CAST(N'2021-07-14' AS Date), CAST(N'2021-07-14' AS Date), 2, 0, NULL)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id], [name], [Gt], [CMND], [DTLH], [Email], [Password]) VALUES (1, N'Nguyễn Hoàng Minh', N'Nam', N'02793777       ', N'03403993092    ', NULL, NULL)
INSERT [dbo].[KhachHang] ([id], [name], [Gt], [CMND], [DTLH], [Email], [Password]) VALUES (2, N'Lê Quốc Bảo', N'Nam', N'02848484       ', N'0948282828     ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML001     ', N'Phòng Đơn')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML002     ', N'Phòng Đôi')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML003     ', N'Phòng Luxery')
INSERT [dbo].[LOAI] ([MALOAI], [TENLOAI]) VALUES (N'ML004     ', N'Phòng Tổng Thống')
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (1, N'A101', N'ML001     ', N'Phòng đơn', N'Đang sử dụng', 30000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (2, N'A102', N'ML001     ', N'Phòng đơn', N'Đang sử dụng', 300000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (3, N'A103', N'ML002     ', N'Phòng đôi', N'Còn phòng', 400000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (4, N'A104', N'ML002     ', N'Phòng đôi', N'Còn phòng', 400000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (5, N'A201', N'ML001     ', N'Phòng đơn', N'Còn phòng', 300000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (6, N'A202', N'ML002     ', N'Phòng đơn', N'Còn phòng', 300000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (7, N'A203', N'ML002     ', N'Phòng đôi', N'Còn phòng', 400000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (8, N'A204', N'ML002     ', N'Phòng đôi', N'Còn phòng', 400000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (9, N'A301', N'ML003		   ', N'Phòng đơn(V.I.P)', N'Còn phòng', 500000)
INSERT [dbo].[Phong] ([id], [name], [MALOAI], [loaiPhong], [status], [price]) VALUES (10, N'A302', N'ML003		   ', N'Phòng đôi(V.I.P)', N'Còn phòng', 600000)
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([id], [name], [soluong], [priceSP]) VALUES (1, N'Không sử dụng dịch vụ', 0, 0)
INSERT [dbo].[SanPham] ([id], [name], [soluong], [priceSP]) VALUES (2, N'Kush', 1, 200000)
INSERT [dbo].[SanPham] ([id], [name], [soluong], [priceSP]) VALUES (3, N'Cam', 1, 100000)
INSERT [dbo].[SanPham] ([id], [name], [soluong], [priceSP]) VALUES (4, N'Nước ngọt các loại', 1, 15000)
INSERT [dbo].[SanPham] ([id], [name], [soluong], [priceSP]) VALUES (5, N'Bia 333', 1, 15000)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [df_status]  DEFAULT (N'Còn phòng') FOR [status]
GO
ALTER TABLE [dbo].[Phong] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idDichVu])
REFERENCES [dbo].[DichVu] ([id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idPhong])
REFERENCES [dbo].[Phong] ([id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([idKh])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([idPhong])
REFERENCES [dbo].[Phong] ([id])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idPhong])
REFERENCES [dbo].[Phong] ([id])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [chk_gt] CHECK  (([Gt]=N'Nam' OR [Gt]=N'Nữ'))
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [chk_gt]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [chk_gtKH] CHECK  (([Gt]=N'Nam' OR [Gt]=N'Nữ'))
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [chk_gtKH]
GO
