USE [otopark]
GO
/****** Object:  Table [dbo].[arackayit]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arackayit](
	[TcKimlikNo] [nvarchar](50) NOT NULL,
	[Ad] [nvarchar](20) NULL,
	[SoyAd] [nvarchar](20) NULL,
	[CepTel] [int] NULL,
	[PlakaNo] [nvarchar](20) NULL,
	[AracTipi] [nvarchar](20) NULL,
	[Model] [nvarchar](20) NULL,
	[Konumu] [nvarchar](50) NULL,
	[GirisTarihi] [datetime] NULL,
	[GirisSaati] [nvarchar](50) NULL,
	[ucret] [int] NULL,
 CONSTRAINT [PK_arackayit] PRIMARY KEY CLUSTERED 
(
	[TcKimlikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[aractipi]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aractipi](
	[AracTipi] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bos]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bos](
	[BosYerler] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cikisSaati]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cikisSaati](
	[cikisSaati] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kullanici]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanici](
	[TcKimlikNo] [nvarchar](11) NOT NULL,
	[Sifre] [nvarchar](16) NULL,
 CONSTRAINT [PK_kullanici] PRIMARY KEY CLUSTERED 
(
	[TcKimlikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[park]    Script Date: 31.8.2016 12:40:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[park](
	[parkyeri] [nvarchar](10) NOT NULL,
	[durum] [nvarchar](10) NULL,
 CONSTRAINT [PK_park] PRIMARY KEY CLUSTERED 
(
	[parkyeri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[arackayit] ([TcKimlikNo], [Ad], [SoyAd], [CepTel], [PlakaNo], [AracTipi], [Model], [Konumu], [GirisTarihi], [GirisSaati], [ucret]) VALUES (N'3', N'CEYLAN', N'YILDIZ', 33333333, N'41 CYLN 58', N'Otomobil', N'BMW', N'A2        ', CAST(N'2016-08-30 00:00:00.000' AS DateTime), N'14:50', 5)
GO
INSERT [dbo].[arackayit] ([TcKimlikNo], [Ad], [SoyAd], [CepTel], [PlakaNo], [AracTipi], [Model], [Konumu], [GirisTarihi], [GirisSaati], [ucret]) VALUES (N'4', N'NURİ', N'YILDIZ', 4444444, N'58NR41', N'Minibüs', N'VOLVO', N'B4        ', CAST(N'2016-08-30 00:00:00.000' AS DateTime), N'14:52', 5)
GO
INSERT [dbo].[aractipi] ([AracTipi]) VALUES (N'Otomobil')
GO
INSERT [dbo].[aractipi] ([AracTipi]) VALUES (N'Otobüs')
GO
INSERT [dbo].[aractipi] ([AracTipi]) VALUES (N'Minibüs')
GO
INSERT [dbo].[aractipi] ([AracTipi]) VALUES (N'Kamyon')
GO
INSERT [dbo].[aractipi] ([AracTipi]) VALUES (N'Tır')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'A4        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'A5        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'B2        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'C1        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'C3        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'C4        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'C5        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'D2        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'D3        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'D4        ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[bos] ([BosYerler]) VALUES (N'          ')
GO
INSERT [dbo].[cikisSaati] ([cikisSaati]) VALUES (N'10:21')
GO
INSERT [dbo].[cikisSaati] ([cikisSaati]) VALUES (N'10:27')
GO
INSERT [dbo].[cikisSaati] ([cikisSaati]) VALUES (N'12:11')
GO
INSERT [dbo].[cikisSaati] ([cikisSaati]) VALUES (N'12:29')
GO
INSERT [dbo].[kullanici] ([TcKimlikNo], [Sifre]) VALUES (N'1234', N'1234')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'A1', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'A2', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'A3', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'A4', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'A5', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'B1', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'B2', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'B3', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'B4', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'B5', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'C1', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'C2', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'C3', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'C4', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'C5', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'D1', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'D2', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'D3', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'D4', N'BOS')
GO
INSERT [dbo].[park] ([parkyeri], [durum]) VALUES (N'D5', N'BOS')
GO
