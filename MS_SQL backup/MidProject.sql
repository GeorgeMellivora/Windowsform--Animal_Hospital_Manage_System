USE [master]
GO
/****** Object:  Database [MidProject]    Script Date: 2022/12/19 上午 10:00:08 ******/
CREATE DATABASE [MidProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MidProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MidProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MidProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MidProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MidProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MidProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MidProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MidProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MidProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MidProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MidProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MidProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MidProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MidProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MidProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MidProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MidProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MidProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MidProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MidProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MidProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MidProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MidProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MidProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MidProject] SET RECOVERY FULL 
GO
ALTER DATABASE [MidProject] SET  MULTI_USER 
GO
ALTER DATABASE [MidProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MidProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MidProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MidProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MidProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MidProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MidProject', N'ON'
GO
ALTER DATABASE [MidProject] SET QUERY_STORE = OFF
GO
USE [MidProject]
GO
/****** Object:  Table [dbo].[ApplianceData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplianceData](
	[CommodityID] [int] IDENTITY(1,1) NOT NULL,
	[CommodityName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[NextPurchase] [date] NULL,
	[Cost] [int] NULL,
	[Price] [int] NULL,
	[DiscountedPrice] [int] NULL,
	[Describe] [nvarchar](250) NULL,
	[CommodityImage] [nvarchar](500) NULL,
 CONSTRAINT [PK_ApplianceData] PRIMARY KEY CLUSTERED 
(
	[CommodityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppointmentData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppointmentData](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[BreederNumber] [nvarchar](50) NULL,
	[PetName] [nvarchar](50) NULL,
	[Doctor] [nvarchar](50) NULL,
	[AppointmentDate] [datetime] NULL,
	[Situation] [nvarchar](250) NULL,
	[DiagnosticStatus] [nvarchar](50) NULL,
	[DiagnosticResult] [nvarchar](250) NULL,
	[DiagnosticCharge] [int] NULL,
 CONSTRAINT [PK_AppointmentData] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BreederData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BreederData](
	[BreederID] [int] IDENTITY(1,1) NOT NULL,
	[BreederNumber] [nvarchar](50) NULL,
	[BreederName] [nvarchar](50) NULL,
	[BreederBirth] [date] NULL,
	[BreederAddress] [nvarchar](100) NULL,
	[BreederPhone] [nchar](20) NULL,
 CONSTRAINT [PK_BreederData_1] PRIMARY KEY CLUSTERED 
(
	[BreederID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HRData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HRData](
	[HRID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[JobTitle] [nvarchar](10) NULL,
	[IDCardNumber] [nvarchar](50) NULL,
	[EmployeeBirth] [date] NULL,
	[EmployeePhone] [nchar](20) NULL,
	[EmployeeSalary] [int] NULL,
 CONSTRAINT [PK_HRData] PRIMARY KEY CLUSTERED 
(
	[HRID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderData](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[BreederID] [nvarchar](50) NULL,
	[OrderEmployee] [nvarchar](50) NULL,
	[PickUpWay] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[OrderDate] [date] NULL,
	[CommodityName] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_OrderData] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetData](
	[PetID] [int] IDENTITY(1,1) NOT NULL,
	[BreederNumber] [nvarchar](50) NOT NULL,
	[PetName] [nvarchar](50) NULL,
	[PetBirth] [date] NULL,
	[PetSort] [nvarchar](50) NULL,
	[PetSex] [nchar](10) NULL,
	[PetWeight] [int] NULL,
	[PetFeature] [nvarchar](150) NULL,
 CONSTRAINT [PK_PetData] PRIMARY KEY CLUSTERED 
(
	[PetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignData]    Script Date: 2022/12/19 上午 10:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignData](
	[SignID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[IDCardNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_SignData] PRIMARY KEY CLUSTERED 
(
	[SignID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ApplianceData] ON 

INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (1, N'寵物抗菌噴霧', 5, CAST(N'2022-11-06' AS Date), 300, 1500, 1200, N'犬貓用，品牌:[Aether依鈦]，500ml，抗菌除臭除黴，舒緩皮膚，保養毛髮', N'fvvjjhgvtdtg.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (2, N'寵物止血粉', 25, CAST(N'2022-11-06' AS Date), 150, 750, 600, N'犬貓消炎抗菌鎮痛斷指甲外傷', N'wefwehtrt.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (3, N'益生菌', 5, CAST(N'2022-10-20' AS Date), 450, 2250, 1800, N'犬貓用，品牌:[狗貓時代]，5g*30pcs，皮膚保健食品，含魚油', N'iehfuhcu.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (4, N'高效能活化益生菌', 10, CAST(N'2022-12-01' AS Date), 300, 1500, 1200, N'犬貓用，品牌:[美國in-Plus]，5g*24pcs，骨格關節&心臟強化配方', N'nwruiofgnau.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (5, N'鈣粉1', 3, CAST(N'2022-03-14' AS Date), 100, 500, 400, N'各式小動物&爬蟲用，品牌[Rep-Cal]，116g，含維生素D3', N'erhree.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (6, N'鈣粉2', 1, CAST(N'2022-08-27' AS Date), 75, 375, 300, N'各式小動物&爬蟲用，品牌[Rep-Cal]，116g，純鈣粉', N'thrth.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (7, N'綜合維他命', 7, CAST(N'2022-09-16' AS Date), 350, 1750, 1400, N'爬蟲用，品牌[Rep-Cal]，116g，純維他命', N'trehdbhry.JPG')
INSERT [dbo].[ApplianceData] ([CommodityID], [CommodityName], [Quantity], [NextPurchase], [Cost], [Price], [DiscountedPrice], [Describe], [CommodityImage]) VALUES (8, N'除淚痕液', 8, CAST(N'2022-12-06' AS Date), 100, 700, 550, N'犬貓用，品牌:[德國Bioline]，50ml，寵物眼睛淚腺分泌物清潔', N'rgsreth.JPG')
SET IDENTITY_INSERT [dbo].[ApplianceData] OFF
GO
SET IDENTITY_INSERT [dbo].[AppointmentData] ON 

INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (1, N'A136253649', N'老黃', N'李承恩       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'不吃', N'完成', N'犬傳染性肝炎', 2300)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (2, N'A136253649', N'小白', N'楊志青       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'嗜睡', N'完成', N'狂犬病', 300)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (3, N'A167180564', N'來福', N'楊志青       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'不舒服', N'完成', N'犬瘟熱', 5800)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (4, N'A144216696', N'拉拉', N'陳志甫       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬疥癬蟲症', 3600)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (5, N'A161404476', N'阿六', N'李承恩       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'活力差', N'完成', N'毛囊蟲症', 13400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (6, N'B172855033', N'熊熊', N'陳志甫       ', CAST(N'2022-10-08T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬冠狀病毒腸炎', 65800)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (7, N'A136253649', N'老黃', N'李承恩       ', CAST(N'2022-10-09T00:00:00.000' AS DateTime), N'咬人', N'完成', N'狂犬病', 23400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (8, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'流口水', N'完成', N'犬傳染性支氣管炎', 23600)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (9, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-10-11T00:00:00.000' AS DateTime), N'掉毛', N'完成', N'犬冠狀病毒腸炎', 23400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (10, N'A136253649', N'小白', N'黃政仲       ', CAST(N'2022-10-12T00:00:00.000' AS DateTime), N'活力差', N'完成', N'毛囊蟲症', 1700)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (11, N'A144216696', N'拉拉', N'黃政仲       ', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'活力差', N'完成', N'腎衰竭疾病', 7600)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (12, N'B172855033', N'熊熊', N'陳志甫       ', CAST(N'2022-10-14T00:00:00.000' AS DateTime), N'活力差', N'完成', N'腸胃疾病', 8900)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (13, N'A136253649', N'老黃', N'李承恩       ', CAST(N'2022-10-15T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬瘟熱', 6800)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (14, N'A136253649', N'小白', N'黃政仲       ', CAST(N'2022-10-16T00:00:00.000' AS DateTime), N'活力差', N'完成', N'鉤端螺旋體', 19000)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (15, N'A161404476', N'阿六', N'楊志青       ', CAST(N'2022-10-17T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬心絲蟲症', 9400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (16, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-18T00:00:00.000' AS DateTime), N'活力差', N'完成', N'心臟疾病', 5900)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (17, N'A161404476', N'阿六', N'李承恩       ', CAST(N'2022-10-19T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬病毒性腸炎', 9300)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (18, N'A144216696', N'拉拉', N'李承恩       ', CAST(N'2022-10-20T00:00:00.000' AS DateTime), N'活力差', N'完成', N'關節疾病', 5900)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (19, N'A167180564', N'來福', N'楊志青       ', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'打噴嚏', N'完成', N'犬副流行性感冒', 7300)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (20, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-10-22T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬心絲蟲症', 500)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (21, N'B172855033', N'熊熊', N'黃政仲       ', CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'一直抓', N'完成', N'毛囊蟲症', 540)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (22, N'A136253649', N'小白', N'李承恩       ', CAST(N'2022-10-24T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬瘟熱', 1400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (23, N'A136253649', N'小白', N'楊志青       ', CAST(N'2022-10-25T00:00:00.000' AS DateTime), N'呼吸急', N'完成', N'犬傳染性支氣管炎', 6400)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (24, N'A144216696', N'拉拉', N'黃政仲       ', CAST(N'2022-10-26T00:00:00.000' AS DateTime), N'活力差', N'完成', N'犬傳染性肝炎', 4500)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (25, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-10-27T00:00:00.000' AS DateTime), N'一直抓', N'完成', N'毛囊蟲症', 2800)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (26, N'B172855033', N'熊熊', N'李承恩       ', CAST(N'2022-12-19T00:00:00.000' AS DateTime), N'一直抓', N'完成', N'犬傳染性肝炎', 4500)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (27, N'A161404476', N'阿六', N'楊志青       ', CAST(N'2022-12-19T00:00:00.000' AS DateTime), N'活力差', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (28, N'A167180564', N'來福', N'陳志甫       ', CAST(N'2022-12-19T00:00:00.000' AS DateTime), N'打噴嚏', N'0', NULL, NULL)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (29, N'A136253649', N'小白', N'李承恩       ', CAST(N'2022-12-20T00:00:00.000' AS DateTime), N'呼吸急', N'0', NULL, NULL)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (31, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'流口水', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (32, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-10T00:00:00.000' AS DateTime), N'流口水', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (33, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-28T00:00:00.000' AS DateTime), N'流口水', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (34, N'A167180564', N'來福', N'李承恩       ', CAST(N'2022-10-28T17:30:00.000' AS DateTime), N'流口水', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (35, N'A167180564', N'來福', N'陳志甫       ', CAST(N'2022-11-30T18:45:00.000' AS DateTime), N'掉毛', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (36, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-12-28T22:45:00.000' AS DateTime), N'掉毛', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (37, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-11-30T10:45:00.000' AS DateTime), N'掉毛qasdfghjklolkijuhygfd', N'0', N'0', 0)
INSERT [dbo].[AppointmentData] ([AppointmentID], [BreederNumber], [PetName], [Doctor], [AppointmentDate], [Situation], [DiagnosticStatus], [DiagnosticResult], [DiagnosticCharge]) VALUES (38, N'A161404476', N'阿六', N'陳志甫       ', CAST(N'2022-11-30T19:45:00.000' AS DateTime), N'掉毛234567890', N'0', N'0', 0)
SET IDENTITY_INSERT [dbo].[AppointmentData] OFF
GO
SET IDENTITY_INSERT [dbo].[BreederData] ON 

INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (1, N'A110403023', N'卓品成', CAST(N'1990-01-01' AS Date), N'233 新北市烏來區金堰35號', N'0926315922          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (2, N'A136253649', N'鄭卓誠', CAST(N'1999-05-13' AS Date), N'220 新北市板橋區四維路13號', N'0914419635          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (3, N'A144216696', N'顏皓昀', CAST(N'1985-04-27' AS Date), N'236 新北市土城區自強街2號', N'0922775472          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (4, N'A161404476', N'饒威廷', CAST(N'1994-08-02' AS Date), N'231 新北市新店區灣潭路11號', N'0986944393          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (5, N'A167180564', N'楊惠玉', CAST(N'1944-09-18' AS Date), N'238 新北市樹林區武林街35號', N'0963867587          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (6, N'B172855033', N'蕭麗綠', CAST(N'1951-07-03' AS Date), N'223 新北市石碇區碇格路34號', N'0926370400          ')
INSERT [dbo].[BreederData] ([BreederID], [BreederNumber], [BreederName], [BreederBirth], [BreederAddress], [BreederPhone]) VALUES (7, N'C123456234567', N'123456', CAST(N'1991-06-11' AS Date), N'ndety', N'wrthrt              ')
SET IDENTITY_INSERT [dbo].[BreederData] OFF
GO
SET IDENTITY_INSERT [dbo].[HRData] ON 

INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (1, N'楊志青', N'BOSS', N'A124508255', CAST(N'1970-02-18' AS Date), N'0929301932          ', 95000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (2, N'李承恩', N'醫師', N'A116243969', CAST(N'1983-09-16' AS Date), N'0915721446          ', 78000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (3, N'陳志甫', N'醫師', N'A150873125', CAST(N'1975-04-19' AS Date), N'0924720003          ', 65000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (4, N'黃政仲', N'醫師', N'A137732461', CAST(N'1990-12-06' AS Date), N'0939696763          ', 70000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (5, N'金柏勳', N'助理', N'A183892881', CAST(N'1983-11-27' AS Date), N'0989597470          ', 45000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (6, N'張武丹', N'助理', N'A158393099', CAST(N'1995-07-30' AS Date), N'0937246781          ', 40000)
INSERT [dbo].[HRData] ([HRID], [EmployeeName], [JobTitle], [IDCardNumber], [EmployeeBirth], [EmployeePhone], [EmployeeSalary]) VALUES (7, N'楊欣潔', N'助理', N'A145529281', CAST(N'1985-09-24' AS Date), N'0914846739          ', 50000)
SET IDENTITY_INSERT [dbo].[HRData] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderData] ON 

INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (1, N'A161404476', N'張武丹', N'自取', NULL, CAST(N'2022-11-12' AS Date), N'寵物止血粉', 1, 600)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (2, N'A161404476', N'張武丹', N'自取', NULL, CAST(N'2022-11-12' AS Date), N'益生菌', 1, 1800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (3, N'A161404476', N'張武丹', N'自取', NULL, CAST(N'2022-11-12' AS Date), N'高效能活化益生菌', 2, 2400)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (4, N'A161404476', N'張武丹', N'自取', NULL, CAST(N'2022-11-12' AS Date), N'鈣粉1', 1, 400)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (5, N'A161404476', N'張武丹', N'自取', NULL, CAST(N'2022-11-12' AS Date), N'除淚痕液', 1, 550)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (6, N'A144216696', N'張武丹', N'自取', NULL, CAST(N'2022-11-13' AS Date), N'鈣粉1', 2, 800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (7, N'A144216696', N'張武丹', N'自取', NULL, CAST(N'2022-11-13' AS Date), N'益生菌', 1, 1800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (8, N'B172855033', N'楊欣潔', N'自取', NULL, CAST(N'2022-11-16' AS Date), N'綜合維他命', 1, 1400)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (9, N'B172855033', N'楊欣潔', N'自取', NULL, CAST(N'2022-11-16' AS Date), N'高效能活化益生菌', 1, 1200)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (10, N'B172855033', N'楊欣潔', N'自取', NULL, CAST(N'2022-11-16' AS Date), N'鈣粉2', 2, 600)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (11, N'A161404476', N'楊欣潔', N'自取', NULL, CAST(N'2022-11-18' AS Date), N'益生菌', 1, 1800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (13, N'A144216696', N'楊欣潔', N'貨運', N'236 新北市土城區自強街2號', CAST(N'2022-12-08' AS Date), N'益生菌', 1, 1800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (14, N'A144216696', N'楊欣潔', N'貨運', N'236 新北市土城區自強街2號', CAST(N'2022-12-08' AS Date), N'鈣粉1', 2, 800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (15, N'A161404476', N'金柏勳', N'自取', N'', CAST(N'2022-12-10' AS Date), N'益生菌', 1, 1800)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (16, N'A161404476', N'金柏勳', N'自取', N'', CAST(N'2022-12-10' AS Date), N'綜合維他命', 1, 1400)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (17, N'A161404476', N'金柏勳', N'自取', N'', CAST(N'2022-12-10' AS Date), N'除淚痕液', 2, 1100)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (21, N'A167180564', N'張武丹', N'自取', N'', CAST(N'2022-12-13' AS Date), N'寵物抗菌噴霧', 1, 1200)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (22, N'A167180564', N'張武丹', N'自取', N'', CAST(N'2022-12-13' AS Date), N'鈣粉1', 1, 400)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (23, N'A167180564', N'張武丹', N'自取', N'', CAST(N'2022-12-13' AS Date), N'除淚痕液', 2, 1100)
INSERT [dbo].[OrderData] ([OrderID], [BreederID], [OrderEmployee], [PickUpWay], [Address], [OrderDate], [CommodityName], [Quantity], [Price]) VALUES (24, N'A167180564', N'張武丹', N'自取', N'', CAST(N'2022-12-13' AS Date), N'鈣粉2', 1, 300)
SET IDENTITY_INSERT [dbo].[OrderData] OFF
GO
SET IDENTITY_INSERT [dbo].[PetData] ON 

INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (1, N'A136253649', N'小白', CAST(N'2020-08-15' AS Date), N'米克斯', N'M         ', 7683, N'qargjevfidasg')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (2, N'A136253649', N'小黃', CAST(N'2019-12-29' AS Date), N'米克斯', N'F         ', 8438, N'dfvjoiqjwfo')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (3, N'A144216696', N'拉拉', CAST(N'2017-06-07' AS Date), N'拉不拉多', N'M         ', 15678, N'ihuiqawmnrf')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (4, N'A161404476', N'阿金', CAST(N'2018-03-15' AS Date), N'黃金獵犬', N'M         ', 10843, N'cxvkjirqewgf')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (5, N'A167180564', N'小毛', CAST(N'2012-12-11' AS Date), N'米克斯', N'F         ', 7683, N'cxvhuiwehf')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (6, N'B172855033', N'小黑', CAST(N'2015-06-23' AS Date), N'西高地梗', N'M         ', 5679, N'ojfgoihjr')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (8, N'B172855033', N'小斑', CAST(N'2022-01-18' AS Date), N'米克斯', N'F         ', 9015, N'驅蟲jweoifjv')
INSERT [dbo].[PetData] ([PetID], [BreederNumber], [PetName], [PetBirth], [PetSort], [PetSex], [PetWeight], [PetFeature]) VALUES (9, N'A82334567', N'bsrb', CAST(N'1996-11-03' AS Date), N'wrtnbs', N'M         ', 25673, N'tyjedsfv')
SET IDENTITY_INSERT [dbo].[PetData] OFF
GO
SET IDENTITY_INSERT [dbo].[SignData] ON 

INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (1, N'1', N'1', N'A124508255')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (2, N'2', N'2', N'A116243969')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (3, N'3', N'3', N'A150873125')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (4, N'4', N'4', N'A137732461')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (5, N'5', N'5', N'A183892881')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (6, N'6', N'6', N'A158393099')
INSERT [dbo].[SignData] ([SignID], [ID], [Password], [IDCardNumber]) VALUES (7, N'7', N'7', N'A145529281')
SET IDENTITY_INSERT [dbo].[SignData] OFF
GO
USE [master]
GO
ALTER DATABASE [MidProject] SET  READ_WRITE 
GO
