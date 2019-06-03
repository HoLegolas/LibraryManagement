USE [master]
GO
CREATE DATABASE [QLThuVien] ON  PRIMARY 
( NAME = N'QLThuVien', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.LEO\MSSQL\DATA\QLThuVien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLThuVien_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.LEO\MSSQL\DATA\QLThuVien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLThuVien] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLThuVien] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLThuVien] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLThuVien] SET ARITHABORT OFF
GO
ALTER DATABASE [QLThuVien] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLThuVien] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLThuVien] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLThuVien] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLThuVien] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLThuVien] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLThuVien] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLThuVien] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLThuVien] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLThuVien] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLThuVien] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLThuVien] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLThuVien] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLThuVien] SET  READ_WRITE
GO
ALTER DATABASE [QLThuVien] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLThuVien] SET  MULTI_USER
GO
ALTER DATABASE [QLThuVien] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLThuVien] SET DB_CHAINING OFF
GO
USE [QLThuVien]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VITRI](
	[id] [int] NOT NULL,
	[pos] [nvarchar](50) NULL,
 CONSTRAINT [PK_VITRI] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[VITRI] ([id], [pos]) VALUES (0, N'Ban gián đốc')
INSERT [dbo].[VITRI] ([id], [pos]) VALUES (1, N'Thủ thư')
INSERT [dbo].[VITRI] ([id], [pos]) VALUES (2, N'Thủ kho')
INSERT [dbo].[VITRI] ([id], [pos]) VALUES (3, N'Thủ quỷ')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANQUANLI](
	[MANV] [varchar](10) NOT NULL,
	[HOTEN] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[DOB] [date] NULL,
	[CMND] [varchar](20) NULL,
	[EMAIL] [varchar](100) NULL,
	[NGAYLAPTHE] [date] NULL,
	[NVLAPTHE] [varchar](10) NULL,
	[BANGCAP] [nvarchar](50) NULL,
	[CHUCVU] [int] NULL,
	[USERNAME] [varchar](50) NULL,
	[PASSWORD] [varchar](20) NULL,
 CONSTRAINT [PK_BANQUANLI] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A001', N'Bao', N'190/19', N'0789578259', CAST(0x05220B00 AS Date), N'0789578259', N'bao@gmail.com', CAST(0xAC3F0B00 AS Date), N'A001', N'TienSi', 0, N'leonthaibao', N'leonthaibao')
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A002', N'Lake', N'Đồng Nai, quận 10', N'0123456789', CAST(0x0F220B00 AS Date), N'294478733', N'lake@gmail.com', CAST(0xAD3F0B00 AS Date), N'A001', N'Đại Học', 0, N'hoquandai', N'hoquandai')
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A003', N'lake', N'HCM', N'221421412', CAST(0x07220B00 AS Date), N'3534645757', N'lake@gmail.com', CAST(0xAF3F0B00 AS Date), N'A002', N'Thac si', 1, N'lake2', N'lake2')
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A004', N'Lake1', N'HCM', N'47634743634', CAST(0x94240B00 AS Date), N'68568573564', N'lake1@gmail.com', CAST(0xBA3F0B00 AS Date), N'A002', N'Đại học', 2, N'lake1', N'lake1')
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A005', N'Hồ Đại', N'HCM', N'012473254325', CAST(0x8C200B00 AS Date), N'235347568568', N'hodai@gmail.com', CAST(0xBA3F0B00 AS Date), N'A002', N'Đại học', 2, N'lake', N'lake')
INSERT [dbo].[BANQUANLI] ([MANV], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [BANGCAP], [CHUCVU], [USERNAME], [PASSWORD]) VALUES (N'A006', N'Hồ Đại', N'HCM', N'0124231234', CAST(0x731E0B00 AS Date), N'235243548679', N'hodai@gmail.com', CAST(0xBC3F0B00 AS Date), N'A002', N'Đại học', 3, N'lake3', N'lake3')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MADOCGIA] [varchar](10) NOT NULL,
	[HOTEN] [nvarchar](100) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[DOB] [date] NULL,
	[CMND] [varchar](20) NULL,
	[EMAIL] [varchar](100) NULL,
	[NGAYLAPTHE] [date] NULL,
	[NVLAPTHE] [varchar](10) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](20) NULL,
 CONSTRAINT [PK__DOCGIA__8CA726FC07020F21] PRIMARY KEY CLUSTERED 
(
	[MADOCGIA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DOCGIA] ([MADOCGIA], [HOTEN], [DIACHI], [SDT], [DOB], [CMND], [EMAIL], [NGAYLAPTHE], [NVLAPTHE], [username], [password]) VALUES (N'R001', N'Hồ Đại', N'Q.10 tpHCM', N'034455213', CAST(0xA9210B00 AS Date), N'1242363464', N'hodai@gmail.com', CAST(0xAE3F0B00 AS Date), N'A002', N'hodai', N'hodai')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [varchar](10) NOT NULL,
	[TENSACH] [nvarchar](100) NULL,
	[TACGIA] [nvarchar](100) NULL,
	[NSX] [int] NULL,
	[NXB] [nvarchar](100) NULL,
	[NGAYNHAP] [date] NULL,
	[GIA] [float] NULL,
	[NVTIEPNHAN] [varchar](10) NULL,
	[LOAI] [int] NULL,
 CONSTRAINT [PK__SACH__3FC48E4C7F60ED59] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B001', N'KinhVanHoa', N'NguyenNhatAnh', 1990, N'SaigonBook', CAST(0xC4150B00 AS Date), 120000, N'A005', 1)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B002', N'Thanh Xuân Không H?i Ti?c', N'Du Phong', 2018, N'SaigonBook', CAST(0xBA3F0B00 AS Date), 48000, N'A005', 0)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B003', N'Bước chân theo dấu mặt trời', N'Thu Thủy', 2019, N'SaigonBook', CAST(0xBA3F0B00 AS Date), 83000, N'A005', 0)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B004', N'Điều Kỳ Diệu Của Tiệm Tạp Hóa', N'Higashino Keigo', 2019, N'SaigonBook', CAST(0xBA3F0B00 AS Date), 103000, N'A005', 0)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B005', N'The Selfish Gene (Gene vị kỷ)', N'Richard Dawkins', 2000, N'InternationalBook', CAST(0xBA3F0B00 AS Date), 210000, N'A005', 1)
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TACGIA], [NSX], [NXB], [NGAYNHAP], [GIA], [NVTIEPNHAN], [LOAI]) VALUES (N'B006', N'No name', N'L.William', 2010, N'BookCity', CAST(0xBB3F0B00 AS Date), 120000, N'A005', 3)
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MAPHIEUTRA] [varchar](10) NOT NULL,
	[MADOCGIA] [varchar](10) NULL,
	[MASACH] [varchar](10) NULL,
	[NGAYTRA] [date] NULL,
	[TIENPHAT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTRA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MAPHIEUTHU] [varchar](10) NOT NULL,
	[MADOCGIA] [varchar](10) NULL,
	[MASACH] [varchar](10) NULL,
	[NGAYTHU] [date] NULL,
	[TIENPHAT] [float] NULL,
	[NVTHUTIEN] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTHU] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MAPHIEUMUON] [varchar](10) NOT NULL,
	[MADOCGIA] [varchar](10) NULL,
	[MASACH] [varchar](10) NULL,
	[NGAYMUON] [datetime2](0) NULL,
	[HANTRA] [datetime2](0) NULL,
 CONSTRAINT [PK__PHIEUMUO__3F97C76B0AD2A005] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUMUON] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MADOCGIA], [MASACH], [NGAYMUON], [HANTRA]) VALUES (N'BR001', N'R001', N'B002', CAST(0x00000000BC3F0B0000 AS DateTime2), CAST(0x00000000C23F0B0000 AS DateTime2))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MADOCGIA], [MASACH], [NGAYMUON], [HANTRA]) VALUES (N'BR002', N'R001', N'B004', CAST(0x00B03B01BC3F0B0000 AS DateTime2), CAST(0x00B03B01C33F0B0000 AS DateTime2))
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMAT](
	[MAPHIEUMAT] [varchar](10) NOT NULL,
	[MADOCGIA] [varchar](10) NULL,
	[MASACH] [varchar](10) NULL,
	[NGAYGHINHAN] [date] NULL,
	[TIENPHAT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUMAT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_BANQUANLI] FOREIGN KEY([NVLAPTHE])
REFERENCES [dbo].[BANQUANLI] ([MANV])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_BANQUANLI]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_BANQUANLI] FOREIGN KEY([NVTIEPNHAN])
REFERENCES [dbo].[BANQUANLI] ([MANV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_BANQUANLI]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_MADOCGIA] FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_MADOCGIA]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_MASACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_MASACH]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_MADOCGIA] FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_MADOCGIA]
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHU_MASACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUTHU] CHECK CONSTRAINT [FK_PHIEUTHU_MASACH]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_MADOCGIA] FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_MADOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_MASACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_MASACH]
GO
ALTER TABLE [dbo].[PHIEUMAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMAT_MADOCGIA] FOREIGN KEY([MADOCGIA])
REFERENCES [dbo].[DOCGIA] ([MADOCGIA])
GO
ALTER TABLE [dbo].[PHIEUMAT] CHECK CONSTRAINT [FK_PHIEUMAT_MADOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMAT_MASACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUMAT] CHECK CONSTRAINT [FK_PHIEUMAT_MASACH]
GO
