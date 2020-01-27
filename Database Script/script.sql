USE [master]
GO
/****** Object:  Database [StandardBooks]    Script Date: 1/27/2020 8:37:36 PM ******/
CREATE DATABASE [StandardBooks]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StandardBooks', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\StandardBooks.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StandardBooks_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\StandardBooks_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StandardBooks] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StandardBooks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StandardBooks] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StandardBooks] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StandardBooks] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StandardBooks] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StandardBooks] SET ARITHABORT OFF 
GO
ALTER DATABASE [StandardBooks] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StandardBooks] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StandardBooks] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StandardBooks] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StandardBooks] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StandardBooks] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StandardBooks] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StandardBooks] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StandardBooks] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StandardBooks] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StandardBooks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StandardBooks] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StandardBooks] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StandardBooks] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StandardBooks] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StandardBooks] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StandardBooks] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StandardBooks] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StandardBooks] SET  MULTI_USER 
GO
ALTER DATABASE [StandardBooks] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StandardBooks] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StandardBooks] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StandardBooks] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StandardBooks] SET DELAYED_DURABILITY = DISABLED 
GO
USE [StandardBooks]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Author] UNIQUE NONCLUSTERED 
(
	[AuthorName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Books]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [varchar](50) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[PublishingYear] [smallint] NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[AuthorID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
	[CurrencyID] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BooksSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BooksSubject](
	[ISBN] [varchar](50) NOT NULL,
	[SubjectID] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Challan]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Challan](
	[ChallanID] [bigint] IDENTITY(1,1) NOT NULL,
	[ChallanNo] [varchar](20) NOT NULL,
	[Date] [date] NOT NULL,
	[Batch] [varchar](10) NOT NULL,
	[Reference] [varchar](max) NULL,
	[PartyID] [int] NOT NULL,
	[BookQuantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Amount] [float] NOT NULL,
	[CurrencyList] [varchar](max) NOT NULL,
	[Approved] [bit] NOT NULL,
 CONSTRAINT [PK_Challan] PRIMARY KEY CLUSTERED 
(
	[ChallanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Challan] UNIQUE NONCLUSTERED 
(
	[ChallanNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChallanDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChallanDetails](
	[ChallanDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[ChallanID] [bigint] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[FinalAmount] [float] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_ChallanDetails] PRIMARY KEY CLUSTERED 
(
	[ChallanDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyInfo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](max) NULL,
	[City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Website] [varchar](50) NULL,
	[Remarks] [varchar](max) NULL,
	[SpecialRemarks] [varchar](max) NULL,
	[FYR] [varchar](50) NULL,
	[NTN] [varchar](50) NULL,
 CONSTRAINT [PK_CompanyInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Currency](
	[CurrencyID] [int] IDENTITY(1,1) NOT NULL,
	[Symbol] [nvarchar](10) NOT NULL,
	[CurrencyName] [varchar](max) NOT NULL,
	[ExchangeRate] [float] NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CurrencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Freight]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Freight](
	[FreightID] [int] IDENTITY(1,1) NOT NULL,
	[Abbreviation] [nvarchar](10) NOT NULL,
	[Destination] [varchar](max) NOT NULL,
	[Charges] [float] NOT NULL,
 CONSTRAINT [PK_Freight] PRIMARY KEY CLUSTERED 
(
	[FreightID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [varchar](20) NOT NULL,
	[Date] [date] NOT NULL,
	[Batch] [varchar](10) NOT NULL,
	[Reference] [varchar](max) NULL,
	[PartyID] [int] NOT NULL,
	[BookQuantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Amount] [float] NOT NULL,
	[SpecialDiscount] [int] NULL,
	[FreightName] [varchar](max) NULL,
	[Charges] [float] NULL,
	[CurrencyList] [varchar](max) NOT NULL,
	[ChallanID] [int] NULL,
	[Remarks] [bit] NOT NULL,
	[SpecialRemarks] [bit] NOT NULL,
	[NTN] [bit] NOT NULL,
	[PaidAmount] [float] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Invoice] UNIQUE NONCLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceID] [bigint] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[FinalAmount] [float] NOT NULL,
	[Price] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Links]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Links](
	[Facebook] [varchar](max) NULL,
	[Gmail] [varchar](max) NULL,
	[Twitter] [varchar](max) NULL,
	[Yahoo] [varchar](max) NULL,
	[SB] [varchar](max) NULL,
	[ID] [smallint] NULL,
	[Outlook] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Party]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Party](
	[PartyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Province] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Party] PRIMARY KEY CLUSTERED 
(
	[PartyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[PublisherName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Publisher] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseNo] [varchar](20) NOT NULL,
	[Date] [date] NOT NULL,
	[Reference] [varchar](max) NULL,
	[SupplierID] [int] NOT NULL,
	[BookQuantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Amount] [float] NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Purchase] UNIQUE NONCLUSTERED 
(
	[PurchaseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PurchaseDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PurchaseDetails](
	[PurchaseID] [bigint] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[FinalAmount] [float] NOT NULL,
	[Price] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quotation]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quotation](
	[QuotationID] [bigint] IDENTITY(1,1) NOT NULL,
	[QuotationNo] [varchar](20) NOT NULL,
	[Date] [date] NOT NULL,
	[Reference] [varchar](max) NULL,
	[Title] [varchar](max) NOT NULL,
	[PartyID] [int] NOT NULL,
	[BookQuantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Amount] [float] NOT NULL,
	[CurrencyList] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Quotation] PRIMARY KEY CLUSTERED 
(
	[QuotationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Quotation] UNIQUE NONCLUSTERED 
(
	[QuotationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuotationDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuotationDetails](
	[QuotationID] [bigint] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[FinalAmount] [float] NOT NULL,
	[Price] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receipts]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receipts](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [varchar](20) NOT NULL,
	[ReceiptNo] [varchar](10) NOT NULL,
	[Date] [date] NOT NULL,
	[Remarks] [varchar](max) NOT NULL,
	[Cheque_Cash] [varchar](max) NOT NULL,
	[Amount] [float] NOT NULL,
	[IncomeTax] [float] NULL,
 CONSTRAINT [PK_Receipts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Receipts] UNIQUE NONCLUSTERED 
(
	[ReceiptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Receipts_1] UNIQUE NONCLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectID] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Province] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Author] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Author]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Currency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[Currency] ([CurrencyID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Currency]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publisher] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publisher]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Subject]
GO
ALTER TABLE [dbo].[BooksSubject]  WITH CHECK ADD  CONSTRAINT [FK_BooksSubject_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BooksSubject] CHECK CONSTRAINT [FK_BooksSubject_Books]
GO
ALTER TABLE [dbo].[BooksSubject]  WITH CHECK ADD  CONSTRAINT [FK_BooksSubject_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO
ALTER TABLE [dbo].[BooksSubject] CHECK CONSTRAINT [FK_BooksSubject_Subject]
GO
ALTER TABLE [dbo].[Challan]  WITH CHECK ADD  CONSTRAINT [FK_Challan_Party] FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
GO
ALTER TABLE [dbo].[Challan] CHECK CONSTRAINT [FK_Challan_Party]
GO
ALTER TABLE [dbo].[ChallanDetails]  WITH CHECK ADD  CONSTRAINT [FK_ChallanDetails_Challan] FOREIGN KEY([ChallanID])
REFERENCES [dbo].[Challan] ([ChallanID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChallanDetails] CHECK CONSTRAINT [FK_ChallanDetails_Challan]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Party1] FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Party1]
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetails_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetails] CHECK CONSTRAINT [FK_InvoiceDetails_Invoice]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Supplier]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetails_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchase] ([PurchaseID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetails_Purchase]
GO
ALTER TABLE [dbo].[Quotation]  WITH CHECK ADD  CONSTRAINT [FK_Quotation_Party] FOREIGN KEY([PartyID])
REFERENCES [dbo].[Party] ([PartyID])
GO
ALTER TABLE [dbo].[Quotation] CHECK CONSTRAINT [FK_Quotation_Party]
GO
ALTER TABLE [dbo].[QuotationDetails]  WITH CHECK ADD  CONSTRAINT [FK_QuotationDetails_Quotation] FOREIGN KEY([QuotationID])
REFERENCES [dbo].[Quotation] ([QuotationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuotationDetails] CHECK CONSTRAINT [FK_QuotationDetails_Quotation]
GO
ALTER TABLE [dbo].[Receipts]  WITH CHECK ADD  CONSTRAINT [FK_Receipts_Invoice] FOREIGN KEY([InvoiceNo])
REFERENCES [dbo].[Invoice] ([InvoiceNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Receipts] CHECK CONSTRAINT [FK_Receipts_Invoice]
GO
/****** Object:  StoredProcedure [dbo].[get_FreightList]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_FreightList]
as
select
FreightID as 'ID',
Destination as 'Freight',
Charges as 'Charges'
from Freight
order by Destination
GO
/****** Object:  StoredProcedure [dbo].[get_PartyList]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[get_PartyList]
as
select
PartyID as 'ID',
'('+LTRIM(STR(Code))+') '+Name as 'Name'
from Party
order by Name asc
GO
/****** Object:  StoredProcedure [dbo].[get_supplierList]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_supplierList]
as
select
SupplierID as 'ID',
Name as 'Name'
from Supplier
order by Name
GO
/****** Object:  StoredProcedure [dbo].[link_facebook]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[link_facebook]
as
select Facebook from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[link_gmail]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[link_gmail]
as
select Gmail from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[link_outlook]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[link_outlook]
as
select Outlook from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[link_SB]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[link_SB]
as
select SB from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[link_twitter]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[link_twitter]
as
select Twitter from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[link_yahoo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[link_yahoo]
as
select Yahoo from Links where id =1
GO
/****** Object:  StoredProcedure [dbo].[sp_approvedChallan]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_approvedChallan]
@ChallanID bigint
as
update Challan
set
Approved = 1
where ChallanID = @ChallanID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteAuthor]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteAuthor]
@AuthorID int
as
delete from Author where AuthorID = @AuthorID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteBooks]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteBooks]
@ISBN varchar(50)
as
Delete from Books where ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteBooksSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteBooksSubject]
@ISBN varchar(50)
as
delete from BooksSubject where ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteChallan]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteChallan]
@ChallanID bigint
as
delete from Challan where ChallanID = @ChallanID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteCurrency]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteCurrency]
@CurrencyID int
as
delete from Currency where CurrencyID = @CurrencyID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteFreight]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_deleteFreight]
@FreightID int
as
delete from Freight where FreightID = @FreightID

GO
/****** Object:  StoredProcedure [dbo].[sp_deleteInvoice]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteInvoice]
@InvoiceID bigint
as
delete from Invoice where InvoiceID = @InvoiceID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteParty]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteParty]
@PartyID int
as
delete from Party where PartyID = @PartyID
GO
/****** Object:  StoredProcedure [dbo].[sp_deletePublisher]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deletePublisher]
@PublisherID int
as
delete from Publisher where PublisherID = @PublisherID
GO
/****** Object:  StoredProcedure [dbo].[sp_deletePurchase]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deletePurchase]
@PurchaseID bigint
as
delete from Purchase where PurchaseID = @PurchaseID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteQuotation]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteQuotation]
@QuotationID bigint
as
delete from Quotation where QuotationID = @QuotationID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteReceipt]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteReceipt]
@ID	bigint
as
delete from Receipts where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteSubject]
@SubjectID int
as
delete from [Subject] where SubjectID = @SubjectID
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteSupplier]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_deleteSupplier]
@SupplierID int
as
delete from Supplier where SupplierID = @SupplierID
GO
/****** Object:  StoredProcedure [dbo].[sp_getAuthorData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getAuthorData]
as
Select
AuthorID as 'ID',
AuthorName as 'Author Name'
from Author
order by AuthorName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getAuthorDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getAuthorDataLike]
@data varchar(50)
as
Select
AuthorID as 'ID',
AuthorName as 'Author Name'
from Author
where 
AuthorName like '%'+@data+'%'
order by AuthorName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookbyISBN]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBookbyISBN]
@ISBN varchar(50)
as
select
c.Symbol,
b.Price,
c.ExchangeRate,
b.Title
from Books b
inner join Currency c on c.CurrencyID = b.CurrencyID
where b.ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_getBooksData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBooksData]
as
select
b.ISBN as 'ISBN',
b.Title as 'Title',
b.PublishingYear as 'Publishing Year',
b.Price as 'Price',
b.Quantity as 'Quantity',
a.AuthorName as 'Author Name',
a.AuthorID as 'AuthorID',
s.SubjectName as 'Subject Name',
s.SubjectID as 'SubjectID',
p.PublisherName as 'Publisher Name',
p.PublisherID as 'PublisherID',
c.Symbol as 'CurrencyName',
c.CurrencyID as 'CurrencyID'
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join [Subject] s on s.SubjectID = b.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBooksDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBooksDataLike]
@data varchar(50)
as
select
b.ISBN as 'ISBN',
b.Title as 'Title',
b.PublishingYear as 'Publishing Year',
b.Price as 'Price',
b.Quantity as 'Quantity',
a.AuthorName as 'Author Name',
a.AuthorID as 'AuthorID',
s.SubjectName as 'Subject Name',
s.SubjectID as 'SubjectID',
p.PublisherName as 'Publisher Name',
p.PublisherID as 'PublisherID',
c.Symbol as 'CurrencyName',
c.CurrencyID as 'CurrencyID'
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join [Subject] s on s.SubjectID = b.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
where
b.ISBN like '%'+@data+'%'
or
b.Title like '%'+@data+'%'
or
a.AuthorName like '%'+@data+'%'
or
s.SubjectName like '%'+@data+'%'
or
p.PublisherName like '%'+@data+'%'
or
c.Symbol like '%'+@data+'%'
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBooksforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBooksforReport]
@data varchar(100)
as
select 
b.Title,
b.PublishingYear,
b.Price,
a.AuthorName,
s.SubjectName,
p.PublisherName,
c.Symbol
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join [Subject] s on s.SubjectID = b.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
where
b.Quantity > 0 and(
s.SubjectName like '%'+@data+'%'
or
a.AuthorName like '%'+@data+'%'
or
p.PublisherName like '%'+@data+'%'
or
b.Title like '%'+@data+'%')
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBooksforReportWithZeroStockQuantity]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBooksforReportWithZeroStockQuantity]
as
select 
b.Title,
b.PublishingYear,
b.Price,
a.AuthorName,
s.SubjectName,
p.PublisherName,
c.Symbol
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join [Subject] s on s.SubjectID = b.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBooksSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBooksSubject]
@ISBN varchar(50)
as
select
bs.SubjectID as 'ID',
s.SubjectName as 'Name'
from BooksSubject bs
inner join Subject s on s.SubjectID = bs.SubjectID
where bs.ISBN = @ISBN
order by s.SubjectName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookSubjectforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getBookSubjectforReport]
@SubjectID int,
@Condition tinyint,
@PubYear smallint
as
select 
b.Title,
b.PublishingYear,
b.Price,
a.AuthorName,
s.SubjectName,
p.PublisherName,
c.Symbol
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join BooksSubject bs on bs.ISBN = b.ISBN
inner join Subject s on s.SubjectID = bs.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
where
b.Quantity>0 and( 
bs.SubjectID = @SubjectID and @Condition = 0 and b.PublishingYear > @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 1 and b.PublishingYear < @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 2 and b.PublishingYear = @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 3
)
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookSubjectforReport0]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getBookSubjectforReport0]
@SubjectID int,
@Condition tinyint,
@PubYear smallint
as
select 
b.Title,
b.PublishingYear,
b.Price,
a.AuthorName,
s.SubjectName,
p.PublisherName,
c.Symbol
from Books b
inner join Author a on a.AuthorID = b.AuthorID
inner join BooksSubject bs on bs.ISBN = b.ISBN
inner join Subject s on s.SubjectID = bs.SubjectID
inner join Publisher p on p.PublisherID = b.PublisherID
inner join Currency c on c.CurrencyID = b.CurrencyID
where 
bs.SubjectID = @SubjectID and @Condition = 0 and b.PublishingYear > @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 1 and b.PublishingYear < @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 2 and b.PublishingYear = @PubYear
or
bs.SubjectID = @SubjectID and @Condition = 3
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallan]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallan]
as
select
c.ChallanID as 'ID',
c.ChallanNo as 'ChallanNo',
format(c.[Date],'dd-MMM-yyyy') as 'Date',
c.Batch as 'Batch',
c.BookQuantity as 'Books',
c.TotalAmount as 'Total Amount',
c.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
c.Reference as 'Reference'
from Challan c
inner join Party p on p.PartyID = c.PartyID
order by c.ChallanNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanbyChallanNo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanbyChallanNo]
@ChallanNo varchar(20)
as
select
c.ChallanID,
format(c.[Date],'dd-MMM-yyyy'),
c.Batch,
c.BookQuantity,
c.TotalAmount,
c.Amount,
'('+LTRIM(STR(p.Code))+') '+p.Name,
c.Reference,
p.Code
from Challan c
inner join Party p on p.PartyID = c.PartyID
where c.ChallanNo = @ChallanNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanDetails]
@ChallanID bigint
as
select
cd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
cd.Quantity as 'Quantity',
cd.Amount as 'Amount',
cd.Discount as 'Discount',
cd.FinalAmount as 'FinalAmount'
from ChallanDetails cd
inner join Books b on b.ISBN = cd.ISBN
where cd.ChallanID = @ChallanID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanDetailsLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanDetailsLike]
@ChallanID bigint,
@data varchar(50)
as
select
cd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
cd.Quantity as 'Quantity',
cd.Amount as 'Amount',
cd.Discount as 'Discount',
cd.FinalAmount as 'FinalAmount'
from ChallanDetails cd
inner join Books b on b.ISBN = cd.ISBN
where cd.ChallanID = @ChallanID
and
(cd.ISBN like '%'+@data+'%' or b.Title like '%'+@data+'%')
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanforReport]
@ChallanNo varchar(20)
as
select 
ch.ChallanNo,
ch.Date,
ch.Reference,
ch.CurrencyList,
p.Name,
p.Address,
p.Code,
p.City,
ch.BookQuantity,
ch.TotalAmount,
cd.ISBN,
b.Title,
b.PublishingYear,
a.AuthorName,
cd.Quantity,
cd.Price,
c.Symbol,
c.ExchangeRate,
cd.Discount,
cd.Amount,
cd.FinalAmount
from Challan ch
inner join ChallanDetails cd on cd.ChallanID = ch.ChallanID
inner join Books b on b.ISBN = cd.ISBN
inner join Author a on a.AuthorID = b.AuthorID
inner join Currency c on c.CurrencyID = b.CurrencyID
inner join Party p on p.PartyID = ch.PartyID
where ch.ChallanNo = @ChallanNo
order by b.Title
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanLike]
@data varchar(50)
as
select
c.ChallanID as 'ID',
c.ChallanNo as 'ChallanNo',
format(c.[Date],'dd-MMM-yyyy') as 'Date',
c.Batch as 'Batch',
c.BookQuantity as 'Books',
c.TotalAmount as 'Total Amount',
c.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
c.Reference as 'Reference'
from Challan c
inner join Party p on p.PartyID = c.PartyID
where
c.ChallanNo like '%'+@data+'%'
or
c.[Date] like '%'+@data+'%'
or
c.Batch like '%'+@data+'%'
or
p.Name like '%'+@data+'%'
order by c.ChallanNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getChallanList]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getChallanList]
as
select
ChallanID as 'ID',
ChallanNo as 'ChallanNo'
from
Challan
where Approved=0
order by ChallanNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getCodebyPartyID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getCodebyPartyID]
@PartyID int
as
select
Code
from Party
where PartyID = @PartyID
GO
/****** Object:  StoredProcedure [dbo].[sp_getCompanyInfo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getCompanyInfo]
as
select
*
from CompanyInfo
where ID=1
GO
/****** Object:  StoredProcedure [dbo].[sp_getCurrancybyISBN]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getCurrancybyISBN]
@ISBN varchar(50)
as
select
' '+c.Symbol+' = '+LTRIm(STR(c.ExchangeRate,6,2))
from Books b
inner join Currency c on c.CurrencyID = b.CurrencyID
where b.ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_getCurrencyData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getCurrencyData]
as
select
CurrencyID as 'ID',
Symbol as 'Symbol',
CurrencyName as 'Currency Name',
ExchangeRate as 'Exchange Rate'  
from Currency
order by [Currency Name] asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getCurrencyDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getCurrencyDataLike]
@data varchar(50)
as
select
CurrencyID as 'ID',
Symbol as 'Symbol',
CurrencyName as 'Currency Name',
ExchangeRate as 'Exchange Rate'  
from Currency
where
Symbol like '%'+@data+'%'
or
CurrencyName like '%'+@data+'%'
order by [Currency Name] asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getFreightData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getFreightData]
as
select 
FreightID as 'ID',
Abbreviation as 'Abbreviation',
Destination as 'Destination',
Charges as 'Charges'
from Freight
order by Destination asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getFreightDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getFreightDataLike]
@data varchar(50)
as
select 
FreightID as 'ID',
Abbreviation as 'Abbreviation',
Destination as 'Destination',
Charges as 'Charges'
from Freight
where
Abbreviation like '%'+@data+'%'
or
Destination like '%'+@data+'%'
order by Destination asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoice]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getInvoice]
as
select
i.InvoiceID as 'ID',
i.InvoiceNo as 'InvoiceNo',
format(i.[Date],'dd-MMM-yyyy') as 'Date',
i.Batch as 'Batch',
i.BookQuantity as 'Books',
i.TotalAmount as 'Total Amount',
i.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
i.Reference as 'Reference'
from Invoice i
inner join Party p on p.PartyID = i.PartyID
order by i.InvoiceNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoicebyInvoiceNo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getInvoicebyInvoiceNo]
@InvoiceNo varchar(20)
as
select
i.InvoiceID,
format(i.[Date],'dd-MMM-yyyy'),
i.Batch,
i.BookQuantity,
i.TotalAmount,
i.Amount,
'('+LTRIM(STR(p.Code))+') '+p.Name,
i.Reference,
i.FreightName,
i.Charges,
i.SpecialDiscount,
p.Code,
i.ChallanID,
i.Remarks,
i.SpecialRemarks,
i.NTN
from Invoice i
inner join Party p on p.PartyID = i.PartyID
where i.InvoiceNo = @InvoiceNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getInvoiceDetails]
@InvoiceID bigint
as
select
id.ISBN as 'ISBN',
b.Title as 'Title',
id.Price as 'Price',
id.Quantity as 'Quantity',
id.Amount as 'Amount',
id.Discount as 'Discount',
id.FinalAmount as 'FinalAmount'
from InvoiceDetails id
inner join Books b on b.ISBN = id.ISBN
where id.InvoiceID = @InvoiceID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceDetailsLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getInvoiceDetailsLike]
@InvoiceID bigint,
@data varchar(50)
as
select
id.ISBN as 'ISBN',
b.Title as 'Title',
id.Price as 'Price',
id.Quantity as 'Quantity',
id.Amount as 'Amount',
id.Discount as 'Discount',
id.FinalAmount as 'FinalAmount'
from InvoiceDetails id
inner join Books b on b.ISBN = id.ISBN
where id.InvoiceID = @InvoiceID
and
(id.ISBN like '%'+@data+'%' or b.Title like '%'+@data+'%')
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceforReceipt]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getInvoiceforReceipt]
@InvoiceNo varchar(20)
as
select
format([Date],'dd-MMM-yyyy'),
ROUND(TotalAmount,0),
ROUND(PaidAmount,0)
from Invoice
where InvoiceNo = @InvoiceNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getInvoiceforReport]
@InvoiceNo varchar(20)
as
select 
i.InvoiceNo,
i.Date,
i.Reference,
i.CurrencyList,
i.SpecialDiscount,
i.Charges,
i.NTN,
i.Remarks,
i.SpecialRemarks,
p.Name,
p.Address,
p.Code,
p.City,
i.BookQuantity,
i.TotalAmount,
id.ISBN,
b.Title,
b.PublishingYear,
a.AuthorName,
id.Quantity,
id.Price,
c.Symbol,
c.ExchangeRate,
id.Discount,
id.Amount,
id.FinalAmount
from Invoice i
inner join InvoiceDetails id on id.InvoiceID = i.InvoiceID
inner join Books b on b.ISBN = id.ISBN
inner join Author a on a.AuthorID = b.AuthorID
inner join Currency c on c.CurrencyID = b.CurrencyID
inner join Party p on p.PartyID = i.PartyID
where i.InvoiceNo = @InvoiceNo
order by b.Title
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getInvoiceLike]
@data varchar(50)
as
select
i.InvoiceID as 'ID',
i.InvoiceNo as 'InvoiceNo',
format(i.[Date],'dd-MMM-yyyy') as 'Date',
i.Batch as 'Batch',
i.BookQuantity as 'Books',
i.TotalAmount as 'Total Amount',
i.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
i.Reference as 'Reference'
from Invoice i
inner join Party p on p.PartyID = i.PartyID
where
i.InvoiceNo like '%'+@data+'%'
or
i.[Date] like '%'+@data+'%'
or
i.Batch like '%'+@data+'%'
or
p.Name like '%'+@data+'%'
order by i.InvoiceNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getInvoiceReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getInvoiceReport]
@Batch varchar(10)
as
select
i.InvoiceNo,
i.Date,
i.TotalAmount,
i.PaidAmount,
r.IncomeTax,
r.Amount
from Invoice i
inner join Receipts r on r.InvoiceNo = i.InvoiceNo
where i.Batch = @Batch
order by i.InvoiceNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLastAuthorID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getLastAuthorID]
as
select top 1 AuthorID
from Author
order by AuthorID desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLastChallanID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getLastChallanID]
as
select top 1 ChallanID from Challan order by ChallanID desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLastInvoiceID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getLastInvoiceID]
as
select top 1 InvoiceID from Invoice order by InvoiceID desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLastPurchaseID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getLastPurchaseID]
as
select top 1 PurchaseID from Purchase order by PurchaseID desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLastQuotationID]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getLastQuotationID]
as
select top 1 QuotationID from Quotation order by QuotationID desc
GO
/****** Object:  StoredProcedure [dbo].[sp_getLinks]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getLinks]
as
select
Facebook,
Gmail,
Twitter,
Outlook,
Yahoo,
SB
from Links
where ID = 1
GO
/****** Object:  StoredProcedure [dbo].[sp_getOutstandingChallanforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getOutstandingChallanforReport]
@Batch varchar(10)
as
select
c.ChallanID,
c.ChallanNo,
c.Date,
c.PartyID,
p.Name,
p.Address,
p.City,
c.BookQuantity,
c.TotalAmount
from Challan c
inner join Party p on p.PartyID = c.PartyID
where c.Batch = @Batch and c.Approved=0
order by c.ChallanNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getOutstandingInvoiceforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getOutstandingInvoiceforReport]
@Batch varchar(10)
as
select
i.InvoiceNo,
i.Date,
p.Name,
p.Address,
p.City,
i.BookQuantity,
i.PaidAmount
from Invoice i
inner join Party p on p.PartyID = i.PartyID
where i.Batch = @Batch and i.PaidAmount>0
order by i.InvoiceNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getParameters]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getParameters]
as
select
[Address],
City,
Province,
Country,
Phone,
Mobile,
Email,
Website,
Remarks,
SpecialRemarks,
FYR,
NTN
from CompanyInfo
GO
/****** Object:  StoredProcedure [dbo].[sp_getPartybyCode]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPartybyCode]
@Code int
as
select
PartyID
from Party
where Code = @Code
GO
/****** Object:  StoredProcedure [dbo].[sp_getPartyData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getPartyData]
as
select
PartyID as 'ID',
Name as 'Name',
[Address] as 'Address',
City as 'City',
Province as 'Province',
Country as 'Country',
Phone as 'Phone',
Fax as 'Fax',
Email as 'Email',
Code as 'Code'
from Party
order by Code asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPartyDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getPartyDataLike]
@data varchar(50)
as
select
PartyID as 'ID',
Name as 'Name',
[Address] as 'Address',
City as 'City',
Province as 'Province',
Country as 'Country',
Phone as 'Phone',
Fax as 'Fax',
Email as 'Email',
Code as 'Code'
from Party
where
Name like '%'+@data+'%'
or
[Address] like '%'+@data+'%'
or
City like '%'+@data+'%'
or
Province like '%'+@data+'%'
or
Country like '%'+@data+'%'
or
Phone like '%'+@data+'%'
or
Fax like '%'+@data+'%'
or
Email like '%'+@data+'%'
or 
Code like '%'+@data+'%'
order by Code asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPartyLedgerforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getPartyLedgerforReport]
@Code int
as
select
i.InvoiceNo,
i.Date,
i.TotalAmount,
i.PaidAmount,
p.Name,
p.Address,
p.City,
p.Code,
r.IncomeTax,
r.Cheque_Cash,
r.Amount
from Invoice i
left join Receipts r on r.InvoiceNo = i.InvoiceNo
inner join Party p on p.PartyID = i.PartyID
where p.Code = @Code
order by i.InvoiceNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getPublisherData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPublisherData]
as
select
PublisherID as 'ID',
Code as 'Code',
PublisherName as 'Name'
from
Publisher
order by PublisherName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPublisherDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPublisherDataLike]
@data varchar(50)
as
select
PublisherID as 'ID',
Code as 'Code',
PublisherName as 'Name'
from
Publisher
where
Code like '%'+@data+'&'
or
PublisherName like '%'+@data+'%'
order by PublisherName asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchase]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPurchase]
as
select
p.PurchaseID as 'ID',
p.PurchaseNo as 'PurchaseNo',
format(p.[Date],'dd-MMM-yyyy') as 'Date',
p.BookQuantity as 'Books',
p.TotalAmount as 'Total Amount',
p.Amount as 'Amount',
s.SupplierID as 'SupplierID',
s.Name as 'Name',
p.Reference as 'Reference'
from Purchase p
inner join Supplier s on s.SupplierID = p.SupplierID
order by p.PurchaseNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchasebyPurchaseNo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getPurchasebyPurchaseNo]
@PurchaseNo varchar(20)
as
select
p.PurchaseID,
format(p.[Date],'dd-MMM-yyyy'),
p.BookQuantity,
p.TotalAmount,
p.Amount,
s.Name,
p.Reference
from Purchase p
inner join Supplier s on s.SupplierID = p.SupplierID
where p.PurchaseNo = @PurchaseNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchaseDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPurchaseDataLike]
@data varchar(50)
as
select
p.PurchaseID as 'ID',
format(p.[Date],'dd-MMM-yyyy') as 'Date',
p.BookQuantity as 'Books',
p.TotalAmount as 'Total Amount',
s.SupplierID as 'SupplierID',
s.Name as 'Name',
p.Reference as 'Reference'
from Purchase p
inner join Supplier s on s.SupplierID = p.SupplierID
where
p.PurchaseID like '%'+@data+'%'
or
s.Name like '%'+@data+'%'
or
format(p.[Date],'dd-MMM-yyyy') like '%'+@data+'%'
order by p.PurchaseID asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchaseDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPurchaseDetails]
@PurchaseID bigint
as
select
pd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
pd.Quantity as 'Quantity',
pd.Amount as 'Amount',
pd.Discount as 'Discount',
pd.FinalAmount as 'FinalAmount'
from PurchaseDetails pd
inner join Books b on b.ISBN = pd.ISBN
where pd.PurchaseID = @PurchaseID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchaseDetailsLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPurchaseDetailsLike]
@PurchaseID bigint,
@data varchar(50)
as
select
pd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
pd.Quantity as 'Quantity',
pd.Amount as 'Amount',
pd.Discount as 'Discount',
pd.FinalAmount as 'FinalAmount'
from PurchaseDetails pd
inner join Books b on b.ISBN = pd.ISBN
where pd.PurchaseID = @PurchaseID
and
(pd.ISBN like '%'+@data+'%' or b.Title like '%'+@data+'%')
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchaseforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getPurchaseforReport]
@PurchaseNo varchar(20)
as
select 
p.PurchaseNo,
p.Date,
p.Reference,
s.Name,
s.Address,
s.City,
p.BookQuantity,
p.TotalAmount,
pd.ISBN,
b.Title,
b.PublishingYear,
a.AuthorName,
pd.Quantity,
pd.Price,
c.Symbol,
pd.Discount,
pd.FinalAmount
from Purchase p
inner join PurchaseDetails pd on pd.PurchaseID = p.PurchaseID
inner join Books b on b.ISBN = pd.ISBN
inner join Author a on a.AuthorID = b.AuthorID
inner join Currency c on c.CurrencyID = b.CurrencyID
inner join Supplier s on s.SupplierID = p.SupplierID
where p.PurchaseNo = @PurchaseNo
order by b.Title

GO
/****** Object:  StoredProcedure [dbo].[sp_getPurchaseLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getPurchaseLike]
@data varchar(50)
as
select
p.PurchaseID as 'ID',
p.PurchaseNo as 'PurchaseNo',
format(p.[Date],'dd-MMM-yyyy') as 'Date',
p.BookQuantity as 'Books',
p.TotalAmount as 'Total Amount',
p.Amount as 'Amount',
s.SupplierID as 'SupplierID',
s.Name as 'Name',
p.Reference as 'Reference'
from Purchase p
inner join Supplier s on s.SupplierID = p.SupplierID
where
p.PurchaseNo like '%'+@data+'%'
or
p.[Date] like '%'+@data+'%'
or
s.Name like '%'+@data+'%'
order by p.PurchaseNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuantity]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getQuantity]
@ISBN varchar(50)
as
select Quantity from Books
where ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotation]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getQuotation]
as
select
q.QuotationID as 'ID',
q.QuotationNo as 'QuotationNo',
format(q.[Date],'dd-MMM-yyyy') as 'Date',
q.BookQuantity as 'Books',
q.TotalAmount as 'Total Amount',
q.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
q.Reference as 'Reference',
q.Title as 'Title'
from Quotation q
inner join Party p on p.PartyID = q.PartyID
order by q.QuotationNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotationbyQuotationNo]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getQuotationbyQuotationNo]
@QuotationNo varchar(20)
as
select
q.QuotationID,
format(q.[Date],'dd-MMM-yyyy'),
q.BookQuantity,
q.TotalAmount,
q.Amount,
'('+LTRIM(STR(p.Code))+') '+p.Name,
q.Reference,
q.Title,
p.Code
from Quotation q
inner join Party p on p.PartyID = q.PartyID
where q.QuotationNo = @QuotationNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotationDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getQuotationDetails]
@QuotationID bigint
as
select
qd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
qd.Quantity as 'Quantity',
qd.Amount as 'Amount',
qd.Discount as 'Discount',
qd.FinalAmount as 'FinalAmount'
from QuotationDetails qd
inner join Books b on b.ISBN = qd.ISBN
where qd.QuotationID = @QuotationID
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotationDetailsLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getQuotationDetailsLike]
@QuotationID bigint,
@data varchar(50)
as
select
qd.ISBN as 'ISBN',
b.Title as 'Title',
b.Price as 'Price',
qd.Quantity as 'Quantity',
qd.Amount as 'Amount',
qd.Discount as 'Discount',
qd.FinalAmount as 'FinalAmount'
from QuotationDetails qd
inner join Books b on b.ISBN = qd.ISBN
where qd.QuotationID = @QuotationID
and
(qd.ISBN like '%'+@data+'%' or b.Title like '%'+@data+'%')
order by b.Title asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotationforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getQuotationforReport]
@QuotationNo varchar(20)
as
select 
q.QuotationNo,
q.Date,
q.Reference,
q.Title as 'QTitle',
q.CurrencyList,
p.Name,
p.Address,
p.Code,
p.City,
q.BookQuantity,
q.TotalAmount,
qd.ISBN,
b.Title,
b.PublishingYear,
a.AuthorName,
qd.Quantity,
qd.Price,
c.Symbol,
c.ExchangeRate,
qd.Discount,
qd.Amount,
qd.FinalAmount
from Quotation q
inner join QuotationDetails qd on qd.QuotationID = q.QuotationID
inner join Books b on b.ISBN = qd.ISBN
inner join Author a on a.AuthorID = b.AuthorID
inner join Currency c on c.CurrencyID = b.CurrencyID
inner join Party p on p.PartyID = q.PartyID
where q.QuotationNo = @QuotationNo
order by b.Title
GO
/****** Object:  StoredProcedure [dbo].[sp_getQuotationLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getQuotationLike]
@data varchar(50)
as
select
q.QuotationID as 'ID',
q.QuotationNo as 'QuotationNo',
format(q.[Date],'dd-MMM-yyyy') as 'Date',
q.BookQuantity as 'Books',
q.TotalAmount as 'Total Amount',
q.Amount as 'Amount',
p.PartyID as 'PartyID',
p.Name as 'Name',
q.Reference as 'Reference',
q.Title as 'Title'
from Quotation q
inner join Party p on p.PartyID = q.PartyID
where
q.QuotationNo like '%'+@data+'%'
or
q.[Date] like '%'+@data+'%'
or
q.Title like '%'+@data+'%'
or
p.Name like '%'+@data+'%'
order by q.QuotationNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getReceiptforReport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getReceiptforReport]
@ReceiptNo varchar(10)
as
select
r.ReceiptNo,
r.Remarks,
r.Cheque_Cash,
r.Date,
r.Amount,
r.InvoiceNo,
i.Date as 'InvoiceDate'
from Receipts r
inner join Invoice i on i.InvoiceNo = r.InvoiceNo 
where r.ReceiptNo = @ReceiptNo
GO
/****** Object:  StoredProcedure [dbo].[sp_getReceiptsData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getReceiptsData]
as
select
r.ID as 'ID',
r.InvoiceNo as 'InvoiceNo',
r.ReceiptNo as 'ReceiptNo',
i.PaidAmount as 'PaidAmount',
format(i.[Date],'dd-MMM-yyyy') as 'InvoiceDate',
i.TotalAmount as 'InvoiceAmount',
format(r.[Date],'dd-MMM-yyyy') as 'Date',
r.Remarks as 'Remarks',
r.Cheque_Cash as 'CC',
r.IncomeTax as 'IncomeTax',
r.Amount as 'Amount'
from Receipts r
inner join Invoice i on i.InvoiceNo = r.InvoiceNo 
order by r.ReceiptNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getReceiptsDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getReceiptsDataLike]
@data varchar(50)
as
select
r.ID as 'ID',
r.InvoiceNo as 'InvoiceNo',
r.ReceiptNo as 'ReceiptNo',
i.PaidAmount as 'PaidAmount',
format(i.[Date],'dd-MMM-yyyy') as 'InvoiceDate',
i.TotalAmount as 'InvoiceAmount',
format(r.[Date],'dd-MMM-yyyy') as 'Date',
r.Remarks as 'Remarks',
r.Cheque_Cash as 'CC',
r.IncomeTax as 'IncomeTax',
r.Amount as 'Amount'
from Receipts r
inner join Invoice i on i.InvoiceNo = r.InvoiceNo 
where r.InvoiceNo like '%'+@data+'%'
or
r.ReceiptNo like '%'+@data+'%'
or
r.Date like '%'+@data+'%'
or
r.Remarks like '%'+@data+'%'
or
r.Cheque_Cash like '%'+@data+'%'
or
r.IncomeTax like '%'+@data+'%'
or
r.Amount like '%'+@data+'%'
order by r.ReceiptNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getSubjectData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getSubjectData]
as
select
SubjectID as 'ID',
SubjectName as 'Subject Name'
from Subject
order by [Subject Name] asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getSubjectDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getSubjectDataLike]
@data varchar(50)
as
select
SubjectID as 'ID',
SubjectName as 'Subject Name'
from Subject
where
SubjectName like '%'+@data+'%'
order by [Subject Name] asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getSupplierData]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getSupplierData]
as
select
SupplierID as 'ID',
Name as 'Name',
[Address] as 'Address',
City as 'City',
Province as 'Province',
Country as 'Country',
Phone as 'Phone',
Fax as 'Fax',
Email as 'Email'
from Supplier
order by Name asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getSupplierDataLike]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_getSupplierDataLike]
@data varchar(50)
as
select
SupplierID as 'ID',
Name as 'Name',
[Address] as 'Address',
City as 'City',
Province as 'Province',
Country as 'Country',
Phone as 'Phone',
Fax as 'Fax',
Email as 'Email'
from Supplier
where
Name like '%'+@data+'%'
or
[Address] like '%'+@data+'%'
or
City like '%'+@data+'%'
or
Province like '%'+@data+'%'
or
Country like '%'+@data+'%'
or
Phone like '%'+@data+'%'
or
Fax like '%'+@data+'%'
or
Email like '%'+@data+'%'
order by Name asc
GO
/****** Object:  StoredProcedure [dbo].[sp_getTagTrackforreport]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_getTagTrackforreport]
@ISBN varchar(50)
as
select
b.ISBN,
b.Title,
b.Quantity as 'BookQuantity',
i.InvoiceNo,
i.Date,
id.Quantity,
c.ChallanNo,
c.Date as 'ChallanDate',
p.Name,
p.Address,
p.City
from Books b
inner join InvoiceDetails id on id.ISBN = b.ISBN
inner join Invoice i on i.InvoiceID = id.InvoiceID
left join Challan c on c.ChallanID = i.ChallanID
inner join Party p on p.PartyID = i.PartyID
where b.ISBN = @ISBN
order by i.InvoiceNo asc
GO
/****** Object:  StoredProcedure [dbo].[sp_insertAuthor]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertAuthor]
@AuthorName varchar(100)
as
insert into Author values (@AuthorName)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertBooks]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertBooks]
@ISBN varchar(50),
@Title varchar(MAX),
@PublishingYear smallint,
@Price float,
@Quantity int,
@AuthorID int,
@SubjectID int,
@PublisherID int,
@CurrencyID int
as
insert into Books values (@ISBN,@Title,@PublishingYear,ROUND(@Price,3),@Quantity,@AuthorID,@SubjectID,@PublisherID,@CurrencyID)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertBooksSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertBooksSubject]
@ISBN varchar(50),
@SubjectID int
as
insert into BooksSubject values (@ISBN, @SubjectID)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertChallan]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertChallan]
@ChallanNo varchar(20),
@Date date,
@Batch varchar(10),
@Reference varchar(MAX),
@PartyID int,
@BookQuantity int,
@TotalAmount float,
@Amount float,
@CurrencyList varchar(MAX)
as
insert into Challan values (@ChallanNo,@Date,@Batch,@Reference,@PartyID,@BookQuantity,ROUND(@TotalAmount,2),ROUND(@Amount,2),@CurrencyList,0)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertChallanDetail]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertChallanDetail]
@ChallanID bigint,
@ISBN varchar(50),
@Quantity int,
@Amount float,
@Discount float,
@FinalAmount float,
@Price float
as
insert into ChallanDetails values (@ChallanID,@ISBN,@Quantity,ROUND(@Amount,2),ROUND(@Discount,2),ROUND(@FinalAmount,2),ROUND(@Price,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertCurrency]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertCurrency]
@Symbol nvarchar(10),
@CurrencyName varchar(MAX),
@ExchangeRate float
as
insert into Currency values(@Symbol,@CurrencyName,Round(@ExchangeRate,3))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertFreight]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertFreight]
@Abbreviation nvarchar(10),
@Destination varchar(MAX),
@Charges float
as
insert into Freight values (@Abbreviation,@Destination,ROUND(@Charges,3))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertInvoice]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertInvoice]
@InvoiceNo varchar(20),
@Date date,
@Batch varchar(10),
@Reference varchar(MAX),
@PartyID int,
@BookQuantity int,
@TotalAmount float,
@Amount float,
@SpecialDiscount int,
@FreightName varchar(MAX),
@Charges float,
@CurrencyList varchar(MAX),
@ChallanID int,
@Remarks bit,
@SpecialRemarks bit,
@NTN bit
as
insert into Invoice values (@InvoiceNo,@Date,@Batch,@Reference,@PartyID,@BookQuantity,ROUND(@TotalAmount,2),ROUND(@Amount,2),@SpecialDiscount,@FreightName, ROUND(@Charges,2),@CurrencyList,@ChallanID,@Remarks,@SpecialRemarks,@NTN,@TotalAmount)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertInvoiceDetails]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertInvoiceDetails]
@InvoiceID bigint,
@ISBN varchar(50),
@Quantity int,
@Amount float,
@Discount float,
@FinalAmount float,
@Price float
as
insert into InvoiceDetails values (@InvoiceID,@ISBN,@Quantity,ROUND(@Amount,2),ROUND(@Discount,2),ROUND(@FinalAmount,2),ROUND(@Price,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertParty]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertParty]
@Name varchar(100),
@Address varchar(MAX),
@City varchar(50),
@Province varchar(50),
@Country varchar(50),
@Phone varchar(20),
@Fax varchar(20),
@Email varchar(100),
@Code int
as
insert into Party values (@Name,@Address,@City,@Province,@Country,@Phone,@Fax,@Email,@Code)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertPublisher]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertPublisher]
@Code varchar(10),
@PublisherName varchar(50)
as
insert into Publisher values(@Code,@PublisherName)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertPurchase]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertPurchase]
@PurchaseNo varchar(20),
@Date date,
@Reference varchar(MAX),
@SupplierID int,
@BookQuantity int,
@TotalAmount float,
@Amount float
as
insert into Purchase values (@PurchaseNo,@Date,@Reference,@SupplierID,@BookQuantity,ROUND(@TotalAmount,2),ROUND(@Amount,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertPurchaseDetail]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[sp_insertPurchaseDetail]
@PurchaseID bigint,
@ISBN varchar(50),
@Quantity int,
@Amount float,
@Discount float,
@FinalAmount float,
@Price float
as
insert into PurchaseDetails values (@PurchaseID,@ISBN,@Quantity,ROUND(@Amount,2),ROUND(@Discount,2),ROUND(@FinalAmount,2),ROUND(@Price,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertQuotation]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertQuotation]
@QuotationNo varchar(20),
@Date date,
@Reference varchar(MAX),
@Title varchar(MAX),
@PartyID int,
@BookQuantity int,
@TotalAmount float,
@Amount float,
@CurrencyList varchar(MAX)
as
insert into Quotation values (@QuotationNo,@Date,@Reference,@Title,@PartyID,@BookQuantity,ROUND(@TotalAmount,2),ROUND(@Amount,2),@CurrencyList)

GO
/****** Object:  StoredProcedure [dbo].[sp_insertQuotationDetail]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertQuotationDetail]
@QuotationID bigint,
@ISBN varchar(50),
@Quantity int,
@Amount float,
@Discount float,
@FinalAmount float,
@Price float
as
insert into QuotationDetails values (@QuotationID,@ISBN,@Quantity,ROUND(@Amount,2),ROUND(@Discount,2),ROUND(@FinalAmount,2),ROUND(@Price,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertReceipt]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertReceipt]
@InoiceNo varchar(20),
@ReceiptNo varchar(10),
@Date date,
@Remarks varchar(MAX),
@Cheque_Cash varchar(MAX),
@Amount float,
@IncomeTax float
as
insert into Receipts values (@InoiceNo,@ReceiptNo,@Date,@Remarks,@Cheque_Cash,ROUND(@Amount,2),ROUND(@IncomeTax,2))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertSubject]
@SubjectName varchar(100)
as
insert into [Subject] values (@SubjectName) 
GO
/****** Object:  StoredProcedure [dbo].[sp_insertSupplier]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertSupplier]
@Name varchar(100),
@Address varchar(MAX),
@City varchar(50),
@Province varchar(50),
@Country varchar(50),
@Phone varchar(20),
@Fax varchar(20),
@Email varchar(100)
as
insert into Supplier values (@Name,@Address,@City,@Province,@Country,@Phone,@Fax,@Email)
GO
/****** Object:  StoredProcedure [dbo].[sp_updateAuthor]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateAuthor]
@AuthorName varchar(100),
@AuthorID int
as
update Author
set
AuthorName = @AuthorName
where
AuthorID = @AuthorID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateBooks]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateBooks]
@ISBN varchar(50),
@Title varchar(MAX),
@PublishingYear smallint,
@Price float,
@Quantity int,
@AuthorID int,
@SubjectID int,
@PublisherID int,
@CurrencyID int
as
update Books
set
Title = @Title,
PublishingYear = @PublishingYear,
Price = ROUND(@Price,3),
Quantity = @Quantity,
AuthorID = @AuthorID,
SubjectID = @SubjectID,
PublisherID = @PublisherID,
CurrencyID = @CurrencyID
where
ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCurrency]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateCurrency]
@Symbol nvarchar(10),
@CurrencyName varchar(MAX),
@ExchangeRate float,
@CurrencyID int
as
update Currency
set
Symbol = @Symbol,
CurrencyName = @CurrencyName,
ExchangeRate = Round(@ExchangeRate,3)
where 
CurrencyID = @CurrencyID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateFreight]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateFreight]
@Abbreviation nvarchar(10),
@Destination varchar(MAX),
@Charges float,
@FreightID int
as
update Freight
set
Abbreviation = @Abbreviation,
Destination = @Destination,
Charges = @Charges
where
FreightID = @FreightID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateLinks]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateLinks]
@Facebook varchar(MAX),
@Gmail varchar(MAX),
@Twitter varchar(MAX),
@Outlook varchar(MAX),
@Yahoo varchar(MAX),
@SB varchar(MAX)
as
update Links
set
Facebook = @Facebook,
Gmail = @Gmail,
Twitter = @Twitter,
Outlook = @Outlook,
Yahoo = @Yahoo,
SB = @SB
where ID = 1
GO
/****** Object:  StoredProcedure [dbo].[sp_updatePaidAmount]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updatePaidAmount]
@PaidAmount float,
@InoiceNo varchar(20)
as
update Invoice
set
PaidAmount = @PaidAmount
where InvoiceNo = @InoiceNo
GO
/****** Object:  StoredProcedure [dbo].[sp_updateParameters]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateParameters]
@Address varchar(MAX),
@City varchar(50),
@Province varchar(50),
@Country varchar(50),
@Phone varchar(50),
@Mobile varchar(50),
@Email varchar(50),
@Website varchar(50),
@Remarks varchar(MAX),
@SpecialRemarks varchar(MAX),
@FYR varchar(50),
@NTN varchar(50),
@ID int
as
update CompanyInfo
set
[Address] = @Address,
City = @City,
Province = @Province,
Country = @Country,
Phone = @Phone,
Mobile = @Mobile,
Email = @Email,
Website = @Website,
Remarks = @Remarks,
SpecialRemarks = @SpecialRemarks,
FYR = @FYR,
NTN = @NTN
where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateParty]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateParty]
@Name varchar(100),
@Address varchar(MAX),
@City varchar(50),
@Province varchar(50),
@Country varchar(50),
@Phone varchar(20),
@Fax varchar(20),
@Email varchar(100),
@Code int,
@PartyID int
as
update Party
set
Name = @Name,
[Address] = @Address,
City = @City,
Province = @Province,
Country = @Country,
Phone = @Phone,
Fax = @Fax,
Email = @Email,
Code = @Code
where
PartyID = @PartyID
GO
/****** Object:  StoredProcedure [dbo].[sp_updatePublisher]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updatePublisher]
@Code varchar(10),
@PublisherName varchar(50),
@PublisherID int
as
update Publisher
set
Code = @Code,
PublisherName = @PublisherName
where 
PublisherID = @PublisherID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateReceipt]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateReceipt]
@ReceiptNo varchar(10),
@Date date,
@Remarks varchar(MAX),
@Cheque_Cash varchar(MAX),
@Amount float,
@IncomeTax float,
@ID bigint
as
update Receipts
set
ReceiptNo = @ReceiptNo,
Date = @Date,
Remarks = @Remarks,
Cheque_Cash = @Cheque_Cash,
Amount = @Amount,
IncomeTax = @IncomeTax
where ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateStock]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateStock]
@ISBN varchar(50),
@Quantity int
as
update Books
set
Quantity = @Quantity
where ISBN = @ISBN
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSubject]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateSubject]
@SubjectName varchar(100),
@SubjectID int
as
update [Subject]
set
SubjectName = @SubjectName
where 
SubjectID = @SubjectID
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSupplier]    Script Date: 1/27/2020 8:37:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateSupplier]
@Name varchar(100),
@Address varchar(MAX),
@City varchar(50),
@Province varchar(50),
@Country varchar(50),
@Phone varchar(20),
@Fax varchar(20),
@Email varchar(100),
@SupplierID int
as
update Supplier
set
Name = @Name,
[Address] = @Address,
City = @City,
Province = @Province,
Country = @Country,
Phone = @Phone,
Fax = @Fax,
Email = @Email
where
SupplierID = @SupplierID
GO
USE [master]
GO
ALTER DATABASE [StandardBooks] SET  READ_WRITE 
GO
