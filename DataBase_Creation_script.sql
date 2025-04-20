USE [master]
GO
/****** Object:  Database [db_ab1b63_chatapp]    Script Date: 3/14/2025 2:46:57 PM ******/
CREATE DATABASE [db_ab1b63_chatapp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_ab1b63_chatapp_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_ab1b63_chatapp_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'db_ab1b63_chatapp_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_ab1b63_chatapp_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_ab1b63_chatapp] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_ab1b63_chatapp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET  MULTI_USER 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_ab1b63_chatapp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_ab1b63_chatapp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_ab1b63_chatapp] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_ab1b63_chatapp] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_ab1b63_chatapp]
GO
/****** Object:  View [dbo].[VMessages]    Script Date: 3/14/2025 2:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VMessages]
AS
SELECT        dbo.TbMessages.FromUser, dbo.TbMessages.Subject, dbo.TbMessages.Message, dbo.TbMessages.IsRead, dbo.TbMessages.MessageDate, dbo.TbMessages.ToUser, dbo.Gusers.FullName
FROM            dbo.Gusers INNER JOIN
                         dbo.TbMessages ON dbo.Gusers.UserId = dbo.TbMessages.FromUser
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 3/14/2025 2:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
	[GroupDesc] [nvarchar](150) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 3/14/2025 2:47:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[Body] [nvarchar](150) NOT NULL,
	[Subject] [nvarchar](50) NOT NULL,
	[DateSent] [datetime] NULL,
	[SenderID] [int] NOT NULL,
	[RecipientID] [int] NOT NULL,
	[IsRead] [bit] NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/14/2025 2:47:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Phone] [char](11) NULL,
	[Email] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[GroupId] [int] NULL,
 CONSTRAINT [PK_Gusers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Groups] ON 
GO
INSERT [dbo].[Groups] ([GroupId], [GroupName], [GroupDesc]) VALUES (1, N'E-Commerce Platform', NULL)
GO
INSERT [dbo].[Groups] ([GroupId], [GroupName], [GroupDesc]) VALUES (2, N'تراثنا', NULL)
GO
INSERT [dbo].[Groups] ([GroupId], [GroupName], [GroupDesc]) VALUES (3, N'Clinic Booking System', NULL)
GO
INSERT [dbo].[Groups] ([GroupId], [GroupName], [GroupDesc]) VALUES (4, N'TechXpress E-commerce', NULL)
GO
SET IDENTITY_INSERT [dbo].[Groups] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (4, N'test', N'12345678901234567890123456789012345678901234567890', CAST(N'2024-12-25T12:07:46.423' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (6, N'test meassage', N'1', CAST(N'2025-01-16T22:48:53.470' AS DateTime), 9, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (7, N'test meassage', N'subject testing', CAST(N'2025-01-16T22:48:53.637' AS DateTime), 9, 4, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (8, N'second Message Test', N'second message', CAST(N'2025-01-18T18:36:19.100' AS DateTime), 9, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (9, N'message test', N'message to mohamed', CAST(N'2025-01-19T18:22:53.730' AS DateTime), 1, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (10, N'message test', N'message to mohamed', CAST(N'2025-01-19T18:22:53.883' AS DateTime), 1, 4, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (11, N'message test', N'message to mohamed', CAST(N'2025-01-19T18:22:54.043' AS DateTime), 1, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (12, N'test message to ahmed and nour', N'Hello', CAST(N'2025-01-19T18:47:58.050' AS DateTime), 6, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (13, N'test message to ahmed and nour', N'Hello', CAST(N'2025-01-19T18:47:58.217' AS DateTime), 6, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (17, N'TESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING ', N'NOUR TEST', CAST(N'2025-01-19T18:51:22.283' AS DateTime), 6, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (18, N'TESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING ', N'NOUR TEST', CAST(N'2025-01-19T18:51:22.447' AS DateTime), 6, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (19, N'TESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING MESSAGETESTING ', N'NOUR TEST', CAST(N'2025-01-19T18:51:22.620' AS DateTime), 6, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (20, N'test message to ibrahim', N'ibra', CAST(N'2025-01-20T17:59:32.983' AS DateTime), 1, 7, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (21, N'hi mohamed from nour', N'saying hi to mohamed', CAST(N'2025-01-20T22:39:07.050' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (22, N'message testing to mohamed, ahmed, ibrahim', N'testing message 249', CAST(N'2025-01-20T22:59:42.940' AS DateTime), 9, 7, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (23, N'message testing to mohamed, ahmed, ibrahim', N'testing message 249', CAST(N'2025-01-20T22:59:43.117' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (24, N'message testing to mohamed, ahmed, ibrahim', N'testing message 249', CAST(N'2025-01-20T22:59:43.287' AS DateTime), 9, 4, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (25, N'test testing message for youssif mohamed testing message for youssif mohamedtesting message for youssif mohamedtesting message for youssif mohamedtest', N'testing message for youssif mohamed andrew', CAST(N'2025-01-22T23:22:28.503' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (26, N'test testing message for youssif mohamed testing message for youssif mohamedtesting message for youssif mohamedtesting message for youssif mohamedtest', N'testing message for youssif mohamed andrew', CAST(N'2025-01-22T23:22:28.670' AS DateTime), 9, 11, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (27, N'ds', N'd', CAST(N'2025-01-23T19:13:57.450' AS DateTime), 9, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (28, N'sd', N'sd', CAST(N'2025-01-23T19:26:01.887' AS DateTime), 9, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (29, N'sd', N'sd', CAST(N'2025-01-23T19:26:02.047' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (30, N't', N'ssd', CAST(N'2025-01-23T19:44:44.573' AS DateTime), 9, 4, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (31, N'ds', N'sd', CAST(N'2025-01-23T20:30:32.797' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (32, N'ds', N'sd', CAST(N'2025-01-23T20:30:32.963' AS DateTime), 9, 4, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (33, N'ds', N'sd', CAST(N'2025-01-23T20:30:33.117' AS DateTime), 9, 5, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (34, N'ds', N'sd', CAST(N'2025-01-23T20:30:33.283' AS DateTime), 9, 8, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (35, N'ds', N'sd', CAST(N'2025-01-23T20:30:33.437' AS DateTime), 9, 7, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (36, N'hi nour', N'from ahmed to nour', CAST(N'2025-01-23T21:22:16.167' AS DateTime), 1, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (37, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (38, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 6, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (39, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 7, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (40, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 8, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (41, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (42, N'Your message body', N'Your message subject', CAST(N'2025-01-24T12:24:27.497' AS DateTime), 1, 11, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (43, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 3, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (44, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 6, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (45, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 7, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (46, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 8, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (47, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 9, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (48, N'message test e commerce platform', N'message test e commerce platform', CAST(N'2025-01-24T22:37:55.483' AS DateTime), 9, 11, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (49, N'sfsdfsd', N'test', CAST(N'2025-02-04T09:59:29.120' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (50, N'ssww', N'llllll', CAST(N'2025-02-22T16:44:29.120' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[Messages] ([MessageID], [Body], [Subject], [DateSent], [SenderID], [RecipientID], [IsRead]) VALUES (51, N'ssww', N'llllll', CAST(N'2025-02-22T16:44:29.293' AS DateTime), 1, 4, 0)
GO
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (1, N'Ahmed', N'Ahmed Rady', N'01094556050', N'Ahmed@gmail.com', N'1', NULL)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (3, N'MohamedBahgat', N'Mohamed Bahgat', N'01552126632', N'Mohamed@gmail.com', N'1', 1)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (4, N'AhmedHamdy', N'Ahmed Hamdy', N'01145045708', N'aaa6604h@gmail.com', N'1', 3)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (5, N'youssifMouhy', N'Youssif Mouhy', N'01222963997', N'youssifmouhy@gmail.com', N'1234', 3)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (6, N'yousefmo', N'Yousef Mohsen El-Sayed Abdullah', N'01024320290', N'yovsefmo04@gmail.com', N'11', 1)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (7, N'ibrahim_mohamed', N'Ibrahim Mohamed', N'01004362288', N'im3413834@gmail.com', N'12', 1)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (8, N'mariamnathan', N'Mariam Nathan Attia Khalil', N'01224893446', N'mariamnathan55@gmail.com', N'123', 1)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (9, N'NourElden', N'Nour Elden Mahmoud Mohamed Nour Elden ', N'01021195499', N'nour.elden.mahmoud8@gmail.com', N'1234455', 1)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (10, N'mustafamahmoud', N'mustafa mahmoud', N'01126499937', N'moorigi44@gmail.com', N'123', 4)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [FullName], [Phone], [Email], [password], [GroupId]) VALUES (11, N'AndrewAyman', N'Andrew Ayman', N'01098272242', N'Andrew Ayman2004@gg.com', N'1', 1)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Messages] ADD  CONSTRAINT [DF_TbMessages_MessageDate]  DEFAULT (getdate()) FOR [DateSent]
GO
ALTER TABLE [dbo].[Messages] ADD  CONSTRAINT [DF_TbMessages_IsRead]  DEFAULT ((0)) FOR [IsRead]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Users] FOREIGN KEY([SenderID])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Users]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Users1] FOREIGN KEY([RecipientID])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Users1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Groups] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([GroupId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Groups]
GO
/****** Object:  StoredProcedure [dbo].[GetLatestMessagesForRecipient]    Script Date: 3/14/2025 2:47:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetLatestMessagesForRecipient]
    @RecipientID INT
AS
BEGIN
    SET NOCOUNT ON;

    WITH RankedMessages AS (
        SELECT 
            *,
            ROW_NUMBER() OVER (
                PARTITION BY 
                    CASE 
                        WHEN SenderID = @RecipientID THEN RecipientID
                        ELSE SenderID
                    END
                ORDER BY DateSent DESC
            ) AS RowNum
        FROM Messages
        WHERE RecipientID = @RecipientID OR SenderID = @RecipientID
    )
    SELECT *
    FROM RankedMessages
    WHERE RowNum = 1
    ORDER BY DateSent DESC;
END;
GO
USE [master]
GO
ALTER DATABASE [db_ab1b63_chatapp] SET  READ_WRITE 
GO
