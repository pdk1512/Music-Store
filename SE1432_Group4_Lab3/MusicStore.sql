USE [master]
GO
/****** Object:  Database [MusicStore]    Script Date: 01/26/2021 18:32:13 ******/
CREATE DATABASE [MusicStore] 
ALTER DATABASE [MusicStore] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MusicStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MusicStore] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [MusicStore] SET ANSI_NULLS OFF
GO
ALTER DATABASE [MusicStore] SET ANSI_PADDING OFF
GO
ALTER DATABASE [MusicStore] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [MusicStore] SET ARITHABORT OFF
GO
ALTER DATABASE [MusicStore] SET AUTO_CLOSE ON
GO
ALTER DATABASE [MusicStore] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [MusicStore] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [MusicStore] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [MusicStore] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [MusicStore] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [MusicStore] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [MusicStore] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [MusicStore] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [MusicStore] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [MusicStore] SET  ENABLE_BROKER
GO
ALTER DATABASE [MusicStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [MusicStore] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [MusicStore] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [MusicStore] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [MusicStore] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [MusicStore] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [MusicStore] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [MusicStore] SET  READ_WRITE
GO
ALTER DATABASE [MusicStore] SET RECOVERY SIMPLE
GO
ALTER DATABASE [MusicStore] SET  MULTI_USER
GO
ALTER DATABASE [MusicStore] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [MusicStore] SET DB_CHAINING OFF
GO
USE [MusicStore]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Type] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Type]) VALUES (7, N'admin', N'admin', N'Quan', N'Nguyen', N'Ha Noi', N'Ha Noi', N'Ha Noi', N'Viet Nam', N'0966 848 112', N'quanndh130577@fpt.edu.vn', 1)
INSERT [dbo].[User] ([id], [UserName], [Password], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Type]) VALUES (8, N'quannd', N'123', N'Quan', N'Nguyen', NULL, NULL, NULL, NULL, NULL, N'quan@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (1, CAST(0x01410B00 AS Date), N'Quan', N'Nguyen', N'Ha Noi 1', N'Ha Noi', N'Ha Noi', N'Viet Nam', N'0966 848 112', N'quanndh130577@fpt.edu.vn', 3100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (2, CAST(0xEC400B00 AS Date), N'Quan', N'Nguyen', N'', N'', N'', N'', N'', N'quan@gmail.com', 1900)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (3, CAST(0xEC400B00 AS Date), N'Quan', N'Nguyen', N'Hai Duong', N'Hai Duong', N'Thanh Ha', N'Viet Nam', N'1234', N'quan@gmail.com', 2400)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (4, CAST(0xEC400B00 AS Date), N'Quan', N'Nguyen', N'Ha Noi', N'Ha Noi', N'Ha Noi', N'Viet Nam', N'0966 848 112', N'quanndh130577@fpt.edu.vn', 1100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (8, CAST(0x0E420B00 AS Date), N'lan', N'nguyen', N'Số 6, ngách 19/15, Liễu Giai, Ba Đình', N'Hà Nội', N'vn', N'Vietnam', N'1234567890', N'ngthuong02@yahoo.com', 200)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (9, CAST(0x0E420B00 AS Date), N'lan', N'nguyen', N'Số 6, ngách 19/15, Liễu Giai, Ba Đình', N'Hà Nội', N'vn', N'Vietnam', N'1234567890', N'ngthuong02@yahoo.com', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (10, CAST(0x0E420B00 AS Date), N'Kien', N'Vuong', N'', N'', N'', N'', N'', N'kien@gmail.com', 400)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (11, CAST(0x0E420B00 AS Date), N'Anh', N'Nguyen', N'', N'', N'', N'', N'', N'anh@fpt', 300)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (12, CAST(0x0E420B00 AS Date), N'a', N'n', N'', N'', N'', N'', N'', N'n', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (13, CAST(0x0E420B00 AS Date), N'a', N'a', N'', N'', N'', N'', N'', N'a', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (14, CAST(0x0E420B00 AS Date), N'a', N'a', N'', N'', N'', N'', N'', N'a', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (15, CAST(0x0E420B00 AS Date), N'a', N'a', N'', N'', N'', N'', N'', N'a', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (16, CAST(0x0E420B00 AS Date), N'a', N'a', N'', N'', N'', N'', N'', N'a', 100)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [FirstName], [LastName], [Address], [City], [State], [Country], [Phone], [Email], [Total]) VALUES (17, CAST(0x0E420B00 AS Date), N'a', N'a', N'', N'', N'', N'', N'', N'a', 100)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Table [dbo].[Genres]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (2, N'Art Punk', N'Alternative')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (5, N'Alternative Rock', N'Alternative')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (6, N'Britpunk', N'Alternative')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (7, N'Anime', N'Anime')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (8, N'Acoustic Blues', N'Blues')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (9, N'Blues Rock', N'Blues')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (10, N'Lullabies', N'Children''s music')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (11, N'Stories', N'Children''s music')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (12, N'Ballet', N'Classical')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (13, N'Cantata', N'Classical')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (14, N'Novelty', N'Comedy')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (15, N'Parody Music', N'Comedy')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (16, N'Chu Tinh', N'Nhac Viet Nam')
INSERT [dbo].[Genres] ([GenreId], [Name], [Description]) VALUES (17, N'Nhac ROCK', N'nhac viet nam')
SET IDENTITY_INSERT [dbo].[Genres] OFF
/****** Object:  Table [dbo].[Artists]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists](
	[ArtistId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED 
(
	[ArtistId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Artists] ON
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (1, N'Katy Perry')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (2, N'Jennifer Lopez')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (3, N'Bruno Mars')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (4, N'Chris Brown')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (5, N'Lady Gaga')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (6, N'Justin Bieber')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (7, N'Taylor Swift')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (8, N'Adele')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (9, N'Beyonce')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (10, N'Rihanna')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (11, N'Son Tung MTP')
INSERT [dbo].[Artists] ([ArtistId], [Name]) VALUES (12, N'ABC Bands')
SET IDENTITY_INSERT [dbo].[Artists] OFF
/****** Object:  Table [dbo].[Albums]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Albums](
	[AlbumId] [int] IDENTITY(1,1) NOT NULL,
	[GenreId] [int] NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[AlbumUrl] [nvarchar](50) NULL,
 CONSTRAINT [PK_Albums] PRIMARY KEY CLUSTERED 
(
	[AlbumId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Albums] ON
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (3, 2, 1, N'Part Of Me', 100, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (7, 5, 1, N'The One That Got Away', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (8, 6, 1, N'Wide Awake', 300, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (10, 7, 2, N'New Kids On The Block', 400, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (11, 8, 3, N'Nothin'' on You', 300, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (12, 9, 3, N'Billionaire', 400, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (13, 10, 4, N'Royalty', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (14, 11, 5, N'The Fame', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (15, 12, 5, N'Born This Way', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (17, 13, 6, N'Career beginnings', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (18, 14, 6, N'Never Say Never', 100, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (19, 15, 7, N'Fearless ', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (20, 2, 7, N'Speak Now', 300, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (21, 5, 7, N'1989', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (22, 6, 8, N' 21, worldwide recognition', 100, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (23, 7, 8, N'25 and Adele Live 2016', 100, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (25, 8, 9, N'Destiny''s Child', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (26, 9, 9, N'Dangerously in Love', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (27, 10, 9, N'B''Day', 300, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (28, 11, 10, N'Beginnings', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (30, 12, 10, N'Annual releases and collaborations', 200, N'~/Images/placeholder.gif')
INSERT [dbo].[Albums] ([AlbumId], [GenreId], [ArtistId], [Title], [Price], [AlbumUrl]) VALUES (31, 16, 11, N'Con Mua Ngang Qua', 100, N'~/Images/placeholder.gif')
SET IDENTITY_INSERT [dbo].[Albums] OFF
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01/26/2021 18:32:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[AlbumId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (5, 1, 7, 2, 200)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (6, 1, 8, 2, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (7, 1, 11, 2, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (8, 1, 3, 3, 100)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (9, 1, 12, 3, 400)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (10, 2, 7, 1, 200)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (11, 2, 12, 1, 400)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (12, 2, 10, 1, 400)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (13, 2, 13, 3, 200)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (14, 2, 8, 1, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (15, 3, 8, 2, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (16, 3, 11, 2, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (17, 3, 10, 3, 400)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (18, 4, 3, 2, 100)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (19, 4, 8, 1, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (20, 4, 11, 2, 300)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (21, 8, 3, 2, 100)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (22, 9, 3, 1, 100)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [AlbumId], [Quantity], [UnitPrice]) VALUES (32, 17, 3, 1, 100)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
/****** Object:  Default [DF_Orders_OrderDate]    Script Date: 01/26/2021 18:32:13 ******/
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
/****** Object:  ForeignKey [FK_Albums_Artists]    Script Date: 01/26/2021 18:32:13 ******/
ALTER TABLE [dbo].[Albums]  WITH CHECK ADD  CONSTRAINT [FK_Albums_Artists] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([ArtistId])
GO
ALTER TABLE [dbo].[Albums] CHECK CONSTRAINT [FK_Albums_Artists]
GO
/****** Object:  ForeignKey [FK_Albums_Genres]    Script Date: 01/26/2021 18:32:13 ******/
ALTER TABLE [dbo].[Albums]  WITH CHECK ADD  CONSTRAINT [FK_Albums_Genres] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([GenreId])
GO
ALTER TABLE [dbo].[Albums] CHECK CONSTRAINT [FK_Albums_Genres]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Albums]    Script Date: 01/26/2021 18:32:13 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Albums] FOREIGN KEY([AlbumId])
REFERENCES [dbo].[Albums] ([AlbumId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Albums]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Orders]    Script Date: 01/26/2021 18:32:13 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
