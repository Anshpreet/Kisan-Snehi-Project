USE [master]
GO
/****** Object:  Database [KisanSnehiDB]    Script Date: 31-03-2021 09:59:26 ******/
CREATE DATABASE [KisanSnehiDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KisanSnehiDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\KisanSnehiDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KisanSnehiDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\KisanSnehiDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KisanSnehiDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KisanSnehiDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KisanSnehiDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KisanSnehiDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KisanSnehiDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KisanSnehiDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KisanSnehiDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET RECOVERY FULL 
GO
ALTER DATABASE [KisanSnehiDB] SET  MULTI_USER 
GO
ALTER DATABASE [KisanSnehiDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KisanSnehiDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KisanSnehiDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KisanSnehiDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KisanSnehiDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'KisanSnehiDB', N'ON'
GO
ALTER DATABASE [KisanSnehiDB] SET QUERY_STORE = OFF
GO
USE [KisanSnehiDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [KisanSnehiDB]
GO
/****** Object:  Table [dbo].[Crop]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crop](
	[Crop_Id] [int] IDENTITY(1,1) NOT NULL,
	[Farmer_Id] [int] NOT NULL,
	[Crop_Name] [varchar](70) NOT NULL,
	[Crop_Quantity] [float] NOT NULL,
	[Crop_Quantity_InStock] [float] NOT NULL,
	[Crop_Desc] [varchar](200) NULL,
	[Crop_Price] [float] NOT NULL,
	[Created_Date] [date] NOT NULL,
	[Updated_Date] [date] NULL,
	[IsDeleted] [bit] NOT NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK_Crop] PRIMARY KEY CLUSTERED 
(
	[Crop_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Crop_Purchase]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crop_Purchase](
	[Crop_Purchase_Id] [int] IDENTITY(1,1) NOT NULL,
	[Farmer_Id] [int] NOT NULL,
	[Supplier_Id] [int] NOT NULL,
	[Crop_Id] [int] NOT NULL,
	[Crop_Purchase_Quantity] [float] NOT NULL,
	[Crop_Bill_Amount] [float] NOT NULL,
	[Crop_Purchase_Date] [date] NOT NULL,
 CONSTRAINT [PK_Crop_Purchase] PRIMARY KEY CLUSTERED 
(
	[Crop_Purchase_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[Feedback_Id] [int] IDENTITY(1,1) NOT NULL,
	[Reg_Id] [int] NOT NULL,
	[Feedback_Desc] [varchar](200) NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Reg_Date] [date] NOT NULL,
	[Updated_Date] [date] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[Feedback_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fertilizer]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fertilizer](
	[Fertilizer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Trader_Id] [int] NOT NULL,
	[Fertilizer_Name] [varchar](70) NOT NULL,
	[Fertilizer_Quantity] [float] NOT NULL,
	[Fertilizer_Quantity_InStock] [float] NOT NULL,
	[Fertilizer_Desc] [varchar](200) NULL,
	[Fertilizer_Price] [float] NOT NULL,
	[Created_Date] [date] NOT NULL,
	[Updated_Date] [date] NULL,
	[IsDeleted] [bit] NOT NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK_Fertilizer] PRIMARY KEY CLUSTERED 
(
	[Fertilizer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fertilizer_Purchase]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fertilizer_Purchase](
	[Fertilizer_Purchase_Id] [int] IDENTITY(1,1) NOT NULL,
	[Farmer_Id] [int] NOT NULL,
	[Trader_Id] [int] NOT NULL,
	[Fertilizer_Id] [int] NOT NULL,
	[Fertilizer_Purchase_Quantity] [float] NOT NULL,
	[Fertilizer_Bill_Amount] [float] NOT NULL,
	[Fertilizer_Purchase_Date] [date] NOT NULL,
 CONSTRAINT [PK_Fertilizer_Purchase] PRIMARY KEY CLUSTERED 
(
	[Fertilizer_Purchase_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Guidance]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guidance](
	[Guidance_Id] [int] IDENTITY(1,1) NOT NULL,
	[From_Month] [int] NOT NULL,
	[To_Month] [int] NOT NULL,
	[Crop_Name] [varchar](50) NOT NULL,
	[Crop_Desc] [varchar](200) NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK_Guidance] PRIMARY KEY CLUSTERED 
(
	[Guidance_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Location_Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[Pin] [bigint] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Location_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registration]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[Reg_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Type_Id] [int] NOT NULL,
	[Name] [varchar](70) NOT NULL,
	[EmailId] [varchar](50) NOT NULL,
	[PhoneNo] [bigint] NOT NULL,
	[Address] [varchar](100) NULL,
	[Location_Id] [int] NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Security_Que] [varchar](50) NOT NULL,
	[Answer] [varchar](20) NOT NULL,
	[Reg_Date] [date] NOT NULL,
	[UpdatedDate] [date] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK_Registeration] PRIMARY KEY CLUSTERED 
(
	[Reg_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserType]    Script Date: 31-03-2021 09:59:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[User_Type_Id] [int] NOT NULL,
	[User_Type] [varchar](10) NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[User_Type_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Crop]  WITH CHECK ADD  CONSTRAINT [FK_Crop_Registeration] FOREIGN KEY([Farmer_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Crop] CHECK CONSTRAINT [FK_Crop_Registeration]
GO
ALTER TABLE [dbo].[Crop_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Crop_Purchase_Crop] FOREIGN KEY([Crop_Id])
REFERENCES [dbo].[Crop] ([Crop_Id])
GO
ALTER TABLE [dbo].[Crop_Purchase] CHECK CONSTRAINT [FK_Crop_Purchase_Crop]
GO
ALTER TABLE [dbo].[Crop_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Crop_Purchase_Registeration] FOREIGN KEY([Farmer_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Crop_Purchase] CHECK CONSTRAINT [FK_Crop_Purchase_Registeration]
GO
ALTER TABLE [dbo].[Crop_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Crop_Purchase_Registeration1] FOREIGN KEY([Supplier_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Crop_Purchase] CHECK CONSTRAINT [FK_Crop_Purchase_Registeration1]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Registeration] FOREIGN KEY([Reg_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Registeration]
GO
ALTER TABLE [dbo].[Fertilizer]  WITH CHECK ADD  CONSTRAINT [FK_Fertilizer_Registeration] FOREIGN KEY([Trader_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Fertilizer] CHECK CONSTRAINT [FK_Fertilizer_Registeration]
GO
ALTER TABLE [dbo].[Fertilizer_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Fertilizer_Purchase_Fertilizer] FOREIGN KEY([Farmer_Id])
REFERENCES [dbo].[Fertilizer] ([Fertilizer_Id])
GO
ALTER TABLE [dbo].[Fertilizer_Purchase] CHECK CONSTRAINT [FK_Fertilizer_Purchase_Fertilizer]
GO
ALTER TABLE [dbo].[Fertilizer_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Fertilizer_Purchase_Registeration] FOREIGN KEY([Farmer_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Fertilizer_Purchase] CHECK CONSTRAINT [FK_Fertilizer_Purchase_Registeration]
GO
ALTER TABLE [dbo].[Fertilizer_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Fertilizer_Purchase_Registeration1] FOREIGN KEY([Trader_Id])
REFERENCES [dbo].[Registration] ([Reg_Id])
GO
ALTER TABLE [dbo].[Fertilizer_Purchase] CHECK CONSTRAINT [FK_Fertilizer_Purchase_Registeration1]
GO
USE [master]
GO
ALTER DATABASE [KisanSnehiDB] SET  READ_WRITE 
GO
