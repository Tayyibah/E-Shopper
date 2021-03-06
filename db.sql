USE [dbdff3ef065cc44b009f7ba7ab00751cbc]
GO
/****** Object:  Table [dbo].[addToCart]    Script Date: 7/30/2017 1:57:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[addToCart](
	[cartID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_addToCart] PRIMARY KEY CLUSTERED 
(
	[cartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill_To]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill_To](
	[BillNo] [int] IDENTITY(1,1) NOT NULL,
	[Display_Name] [varchar](50) NULL,
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[confirm_password] [varchar](50) NULL,
	[Company_Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Title] [varchar](50) NULL,
	[First_Name] [varchar](50) NULL,
	[Middle_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Address_1] [varchar](50) NULL,
	[Address_2] [varchar](50) NULL,
	[Zip] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Phone1] [varchar](50) NULL,
	[Phone2] [varchar](50) NULL,
	[Mobile_Phone] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[message] [varchar](50) NULL,
	[Shipping] [varchar](50) NULL,
	[UserID] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_Bill_To] PRIMARY KEY CLUSTERED 
(
	[BillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cart]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cart](
	[user_option] [varchar](50) NULL,
	[single_fieldCountry] [varchar](50) NULL,
	[single_field_Region] [varchar](50) NULL,
	[Zip_Code] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ProductID] [int] NULL,
	[CommentText] [varchar](50) NULL,
	[CommentOn] [date] NULL,
	[UserName] [varchar](50) NULL,
	[PictureName] [varchar](50) NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contact_us]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contact_us](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[subject] [varchar](50) NULL,
	[message] [varchar](50) NULL,
	[Contact_Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_contact_us] PRIMARY KEY CLUSTERED 
(
	[Contact_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Document]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Document](
	[DocumentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Size] [bigint] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[FileContent] [varchar](max) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreadtedOn] [datetime] NOT NULL,
	[ModifieadOn] [datetime] NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[feedback](
	[email] [varchar](50) NULL,
	[message] [varchar](50) NULL,
	[Feedback_no] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_feedback] PRIMARY KEY CLUSTERED 
(
	[Feedback_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Images]    Script Date: 7/30/2017 1:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Images](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[ImageName] [varchar](50) NOT NULL,
	[ImageAlt] [varchar](50) NULL,
	[ImageData] [varchar](50) NOT NULL,
	[ContentType] [varchar](50) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login_form]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login_form](
	[name] [varchar](50) NULL,
	[Email_Address] [varchar](50) NULL,
	[checkbox_name] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MappingsTable]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MappingsTable](
	[MappingId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProductID] [int] NULL,
	[AddToCart] [bit] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_MappingsTable] PRIMARY KEY CLUSTERED 
(
	[MappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_details]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[product_details](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[textarea_text] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product1]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product1](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [int] NULL,
	[PictureName] [varchar](max) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedOn] [date] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_Products1] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [int] NULL,
	[PictureName] [varchar](50) NULL,
	[CreatedOn] [date] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedOn] [date] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reply_form]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reply_form](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[website] [varchar](50) NULL,
	[message] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shopper_Information]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shopper_Information](
	[Display_Name] [varchar](50) NULL,
	[User_Name] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[password2] [varchar](50) NULL,
 CONSTRAINT [PK_Shopper_Information] PRIMARY KEY CLUSTERED 
(
	[User_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Signup]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Signup](
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[isAdmin] [bit] NULL,
	[isActive] [bit] NULL,
	[PictureName] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users11]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users11](
	[UserID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[isAdmin] [bit] NOT NULL,
	[isActive] [bit] NOT NULL,
	[PictureName] [varchar](20) NULL,
	[Designation] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsersTable]    Script Date: 7/30/2017 1:57:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsersTable](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[isActive] [bit] NULL,
	[UsersType] [int] NULL,
	[MappingId] [int] NULL,
	[PictureName] [varchar](50) NULL,
 CONSTRAINT [PK_UsersTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[addToCart] ON 

INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1124, 32, 1019)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1125, 32, 11)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1126, 35, 11)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1127, 31, 1022)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1128, 35, 1023)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1130, 24, 1029)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1131, 43, 1048)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1133, 24, 4)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1135, 31, 1055)
INSERT [dbo].[addToCart] ([cartID], [ProductID], [UserID]) VALUES (1136, 46, 1023)
SET IDENTITY_INSERT [dbo].[addToCart] OFF
SET IDENTITY_INSERT [dbo].[Bill_To] ON 

INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (3, N'sssssssss', N'ssssssssssss', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'-- Country --', N'-- State / Province / Region --', N'', N'', N'', N'', N'', N'on', NULL, NULL)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (4, N'aisha', N'aishee', N'aisha', N'aisha', N'web', N'3465', N'buy', N'aiza', N'akeel', N'khan', N'ed', N'fd', N'654', N'United States', N'UK', N'6543', N'9876', NULL, N'8765', N'give me', N'on', 4, 2900)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (20, N'a', N'a', N'a', N'a', N'a', N'a', N'aa', N'a', N'a', N'a', N'a', N'a', N'aa', N'-- Country --', N'-- State / Province / Region --', N'a', N'a', NULL, N'aa', N'a', N'on', 8, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (21, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 11, 52902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 8100)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (23, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 12100)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (24, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, 9100)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1022, 0)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (26, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1022, 54402)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (27, N'q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'Q', N'-- Country --', N'-- State / Province / Region --', N'Q', N'Q', NULL, N'Q', N'Q', N'on', 1023, 4000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 11, 3500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (29, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1022, 0)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1022, 0)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (31, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1022, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (32, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (33, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 2500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (34, N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'E', N'-- Country --', N'-- State / Province / Region --', N'E', N'E', NULL, N'E', N'E', N'on', 1029, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (35, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1029, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (36, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1029, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (37, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1029, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (38, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1029, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (39, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 2500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, 0)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (41, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, 2001)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (42, N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'q', N'-- Country --', N'-- State / Province / Region --', N'q', N'q', NULL, N'q', N'q', N'on', 1055, 0)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (43, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1055, 4001)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (44, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1055, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (45, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1055, 2000)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (46, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (47, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4500)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (48, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4900)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (49, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 8902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (50, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 8902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (51, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (52, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (53, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 4902)
INSERT [dbo].[Bill_To] ([BillNo], [Display_Name], [User_Name], [Password], [confirm_password], [Company_Name], [Email], [Title], [First_Name], [Middle_Name], [Last_Name], [Address_1], [Address_2], [Zip], [Country], [State], [Phone1], [Phone2], [Mobile_Phone], [Fax], [message], [Shipping], [UserID], [Total]) VALUES (54, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1023, 900)
SET IDENTITY_INSERT [dbo].[Bill_To] OFF
INSERT [dbo].[cart] ([user_option], [single_fieldCountry], [single_field_Region], [Zip_Code]) VALUES (N'', N'', N'', N'')
INSERT [dbo].[cart] ([user_option], [single_fieldCountry], [single_field_Region], [Zip_Code]) VALUES (N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (97, 2, 22, N'is there any lower price', CAST(0xFA3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (98, 2, 23, N'nice one', CAST(0xFA3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (99, 4, 22, N'Aesom', CAST(0xFA3C0B00 AS Date), N'User', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (100, 4, 23, N'wow', CAST(0xFA3C0B00 AS Date), N'User', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (101, 4, 24, N'great', CAST(0xFA3C0B00 AS Date), N'User', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (102, NULL, NULL, NULL, NULL, NULL, N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (103, 1, 22, N'no this price iz fixed,thankx @User :)
', CAST(0xFA3C0B00 AS Date), N'Tahira', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (104, 1, 23, N'thankx', CAST(0xFA3C0B00 AS Date), N'Ayesha', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (105, 1, 24, N'thankx', CAST(0xFA3C0B00 AS Date), N'Ramo', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (106, 1, 25, N'sssssssss', CAST(0xFA3C0B00 AS Date), N'asd', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (107, 1, 25, N'hjfjhgjhg', CAST(0xFB3C0B00 AS Date), N'asd', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (108, 1, 22, N'nb', CAST(0xFB3C0B00 AS Date), N'asd', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (109, 3, 22, N'wow
', CAST(0xFB3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (110, 3, 22, N'nbnb', CAST(0xFC3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (111, 3, 22, N'nbnb', CAST(0xFC3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1112, 3, 22, N'mnbcmxncbv', CAST(0xFD3C0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1113, 1, 22, N'thanks :)', CAST(0xFD3C0B00 AS Date), N'asd', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1114, 1, 24, N'user @User thanks
', CAST(0xFE3C0B00 AS Date), N'asd', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1115, 4, 22, N'is it available in differnt color', CAST(0xFF3C0B00 AS Date), N'user', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1116, 3, 30, N'i want another piece', CAST(0x043D0B00 AS Date), N'qw', N'user.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1117, 1022, 32, N'wow', CAST(0x043D0B00 AS Date), N'unza', N'ef167fb2-de1e-4da2-a6d4-65f213ef2614.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1118, 1022, 33, N'great quality', CAST(0x043D0B00 AS Date), N'unza', N'ef167fb2-de1e-4da2-a6d4-65f213ef2614.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1119, 1, 33, N'thankx ', CAST(0x043D0B00 AS Date), N'Admin', N'aisha.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1120, 1019, 35, N'awesom', CAST(0x043D0B00 AS Date), N'alvi', N'alvi.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1121, 1019, 24, N'great', CAST(0x043D0B00 AS Date), N'alvi', N'alvi.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1122, 1, 33, N':)', CAST(0x043D0B00 AS Date), N'Admin', N'aisha.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1123, 1, 33, N'look', CAST(0x043D0B00 AS Date), N'Admin', N'aisha.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1124, 1, 35, N'thanks', CAST(0x043D0B00 AS Date), N'Admin', N'aisha.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1125, 1023, 24, N'nice one', CAST(0x043D0B00 AS Date), N'uneza', N'f5532032-38c2-4aab-bba4-419c724457ee.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1126, 2, 33, N'kjh', CAST(0x043D0B00 AS Date), N'Admin', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1127, 2, 24, N'thanks :)', CAST(0x043D0B00 AS Date), N'Admin', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1128, 2, 32, N'thanks', CAST(0x043D0B00 AS Date), N'Admin', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1129, 1022, 31, N'i want in green color', CAST(0x043D0B00 AS Date), N'unza', N'ef167fb2-de1e-4da2-a6d4-65f213ef2614.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1130, 1022, 35, N'wow', CAST(0x043D0B00 AS Date), N'unza', N'ef167fb2-de1e-4da2-a6d4-65f213ef2614.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1131, 1023, 31, N'thankx for sending :)', CAST(0x043D0B00 AS Date), N'uneza', N'f5532032-38c2-4aab-bba4-419c724457ee.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1132, 2, 31, N'', CAST(0x043D0B00 AS Date), N'Admin', N'admin.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1133, 1023, 35, N'wow', CAST(0x043D0B00 AS Date), N'uneza', N'f5532032-38c2-4aab-bba4-419c724457ee.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1134, 1029, 24, N'GREAT', CAST(0x063D0B00 AS Date), N'T', N'a99608d4-9a3b-4b84-9b87-9f453632847f.png')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1135, 1029, 24, N'(y)', CAST(0x063D0B00 AS Date), N'T', N'a99608d4-9a3b-4b84-9b87-9f453632847f.png')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1136, 1048, 24, N'great', CAST(0x063D0B00 AS Date), N'isha', N'ae890a59-5c12-4e39-bb64-85baee6dd988.png')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1137, 1055, 24, N'wow', CAST(0x163D0B00 AS Date), N'tayyibah', N'ef3d61d4-1817-42fb-9912-e30111122ddd.PNG')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1138, 1023, 24, N'niceOne
', CAST(0x1B3D0B00 AS Date), N'uneza', N'f5532032-38c2-4aab-bba4-419c724457ee.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1139, 1023, 24, N'niceOne
', CAST(0x1B3D0B00 AS Date), N'uneza', N'f5532032-38c2-4aab-bba4-419c724457ee.jpg')
INSERT [dbo].[Comments] ([CommentID], [UserID], [ProductID], [CommentText], [CommentOn], [UserName], [PictureName]) VALUES (1140, 1056, 24, N'Amazing', CAST(0x1B3D0B00 AS Date), N'QW', N'ffa8f890-de1b-4f6d-a8b0-68ba6bd63d47.jpg')
SET IDENTITY_INSERT [dbo].[Comments] OFF
SET IDENTITY_INSERT [dbo].[contact_us] ON 

INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'Tayyibah', N'biba@mail.com', N'low price', N'plz give me my products at lower price', 1)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 2)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 3)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 4)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 5)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 6)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 7)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 8)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'c', N's@s.f', N'd', N'c', 9)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'd', N'q@qq.q', N'q', N'q', 10)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'unaiza', N'u@f.d', N'nhgf', N'jhb', 11)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'beeba', N'bsef14a011@pucit.edu.pk', N'amount', N'update amount', 12)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'Tayyibah', N'tayyibahalauddin@yahoo.com', N'Shop', N'niceone', 13)
INSERT [dbo].[contact_us] ([name], [email], [subject], [message], [Contact_Id]) VALUES (N'Q', N'qurratulainshahbaz@hotmail.com', N'Q', N'Q', 14)
SET IDENTITY_INSERT [dbo].[contact_us] OFF
SET IDENTITY_INSERT [dbo].[feedback] ON 

INSERT [dbo].[feedback] ([email], [message], [Feedback_no]) VALUES (N'sssssss@s.s', N's@s.a', 1)
INSERT [dbo].[feedback] ([email], [message], [Feedback_no]) VALUES (N'tayyibahalauddin@yahoo.com', N'wow', 2)
SET IDENTITY_INSERT [dbo].[feedback] OFF
INSERT [dbo].[login_form] ([name], [Email_Address], [checkbox_name]) VALUES (N'beeba', N'beeba@shopper.com', 1)
SET IDENTITY_INSERT [dbo].[MappingsTable] ON 

INSERT [dbo].[MappingsTable] ([MappingId], [UserId], [ProductID], [AddToCart], [Date]) VALUES (1, 1, 1, 1, CAST(0x75250B00 AS Date))
INSERT [dbo].[MappingsTable] ([MappingId], [UserId], [ProductID], [AddToCart], [Date]) VALUES (2, 2, 2, 0, CAST(0x02270B00 AS Date))
INSERT [dbo].[MappingsTable] ([MappingId], [UserId], [ProductID], [AddToCart], [Date]) VALUES (3, 1, 2, 1, CAST(0x02270B00 AS Date))
SET IDENTITY_INSERT [dbo].[MappingsTable] OFF
INSERT [dbo].[product_details] ([name], [email], [textarea_text]) VALUES (N'beeba', N'beeba@gmail.com', N'bbbbiii')
INSERT [dbo].[product_details] ([name], [email], [textarea_text]) VALUES (N'', N'', N'')
INSERT [dbo].[product_details] ([name], [email], [textarea_text]) VALUES (N's', N'a@a.x', N's')
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (22, N'Eye Makeup', 500, N'a86adece-ad73-4410-ab3b-931c78d61f78.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (23, N'Eye Maskara', 400, N'c6bae47c-d5b4-491d-99f4-fdfba3faa1d0.png', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (24, N'Face Powder', 2000, N'931f7a0d-77c5-473e-bd4a-cb39d41d622f.png', CAST(0x00000000 AS Date), N'', CAST(0x00000000 AS Date), N'', 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (25, N'zzzz', 233333, N'a1cac352-51aa-49a2-9934-dd482ca0df4e.jpg', CAST(0x00000000 AS Date), N'', CAST(0x00000000 AS Date), N'', 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (26, N'mnmn', 8787, N'0b07b599-8948-4f5f-b5d6-0190b7f920d8.png', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (27, N'', 0, N'', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (28, N'dkjvnfdkv', 22222222, N'a9b2c8c9-55cb-487c-8257-9aff5e54d13a.jpg', CAST(0x00000000 AS Date), N'', CAST(0x00000000 AS Date), N'', 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (29, N'bags', 0, N'8aad100b-4087-4391-a215-6f8f8f9a3a14.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (30, N'lipLiner', 400, N'3bb71d75-71f5-4629-9358-3b8acdf3fb3e.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (31, N'Eye Liner', 2000, N'42560c48-8158-4b0e-873e-ae67ea48c51d.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (32, N'shades', 3000, N'2e8af83f-0885-4208-9af2-c8801dbbb695.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (33, N'Face powder', 50002, N'e3560089-ccd9-4560-9c13-b4e8c71f4962.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (34, N'lips stich', 500, N'872e2879-401e-454e-a87b-8591744be5e5.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (35, N'lips stick', 500, N'ac4d97ea-f628-408d-9350-993c9ea15c8a.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (36, N'lips stich', 500, N'9eb7fdc4-304d-49bf-905b-a52573949f36.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (37, N'lips stick', 500, N'4c57bc1b-2223-4985-8f34-b02bd0531b45.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (38, N'lips stich', 500, N'9aa7488a-a3da-4c24-9434-6b2787b0ef11.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (39, N'lips stick', 500, N'c6bc5214-3fc4-4517-9c8a-21c372a15b31.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (40, N'lips stick', 500, N'5f83f91f-23e4-4a91-9fc0-c3a94e5596be.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (41, N' cx ', 0, N'15ce1bc2-5101-4e11-a25f-c1cad166929d.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (42, N'qw', 0, N'4d601c18-c381-4ddb-8721-5b6a0b829f68.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (43, N'w', 0, N'a53e1f7d-8bec-468b-a87b-494b6600f44a.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (44, N'', 0, N'', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (45, N'', 0, N'', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (46, N'nail paint', 400, N'333283cb-ad85-406c-8254-9e976e2bd4e5.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (47, N'n', 0, N'55536e60-8e3d-4b02-9401-9859be4e4941.jpg', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (48, N'qw', 0, N'216c0762-c9ee-466c-b8c6-25c18f1a2192.PNG', CAST(0x00000000 AS Date), N'', NULL, NULL, 0)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [PictureName], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [isActive]) VALUES (49, N'water', 45, N'2a47cac8-44dd-4c11-8dba-e79da2526863.PNG', CAST(0x00000000 AS Date), N'', CAST(0x00000000 AS Date), N'', 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[reply_form] ([name], [email], [website], [message]) VALUES (N'user', N'user@shopper.com', N'myWeb', N'nice shop')
INSERT [dbo].[reply_form] ([name], [email], [website], [message]) VALUES (N'A', N'ashookhan76@gmail.com', N'za@s.c', N'z')
INSERT [dbo].[Shopper_Information] ([Display_Name], [User_Name], [password], [password2]) VALUES (N'', N'', N'', N'')
INSERT [dbo].[Shopper_Information] ([Display_Name], [User_Name], [password], [password2]) VALUES (N'q', N'q', N'q', N'q')
INSERT [dbo].[Shopper_Information] ([Display_Name], [User_Name], [password], [password2]) VALUES (N'teeba', N'TAYYIBAH', N'1234', N'1234')
INSERT [dbo].[Signup] ([name], [email], [Designation], [password]) VALUES (N'beeba', N'beeba@gmail.com', N'Lahore', N'1234')
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1, N'Admin', N'Admin', N'Admin', 1, 1, N'admin.jpg', N'Lahore', N'tayyibahalauddin@gmail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (2, N'Admin', N'Admin', N'1234', 1, 1, N'admin.jpg', N'Pindi', N'tayyibahalauddin@gmail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (3, N'Mehru', N'Mehru', N'qw', 0, 1, N'user.jpg', N'lhr', N'bsef14a011@pucit.edu.pk')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (4, N'user', N'user', N'user', 0, 1, N'user.jpg', N'pindi', N'user@gmail.pk')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (6, N'Ayesha', N'Ayesha', N'aisha', 0, 1, N'user.jpg', N'aisha', N'aisha@mail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (8, N'abhijeet', N'abhijeet', N'qw', 0, 1, N'user.jpg', N'qw', N'asd@mail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (11, N'mona', N'mona', N'mona', 0, 1, N'mona.jpg', N'aaa', N'asd@mail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1013, N'teeba', N'teeba', N'teeba1993', 0, 1, N'user.jpg', N'lhr', N'tayyibahalauddin@gmail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1019, N'alvi', N'alvi', N'alvi', 0, 1, N'alvi.jpg', N'lhr', N'alvi@gmail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1022, N'unza', N'unza', N'1234', 0, 1, N'aisha.jpg', N'cavalry', N'tayyibahalauddin@yahoo.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1023, N'uneza', N'uneza', N'uneza', 0, 1, N'f5532032-38c2-4aab-bba4-419c724457ee.jpg', N'pindi', N'uneza@mail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1024, N'q`w', N'q`w', N'hj', 0, 1, N'b2cda838-e0c2-40d4-b497-51e04cffb061.jpg', N'h', N'tayyibahalauddin@yahoo.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1025, N'q`w', N'q`w', N'hj', 0, 1, N'0fb25bf1-c300-45e1-bb63-8a96eaa40c99.jpg', N'h', N'tayyibahalauddin@yahoo.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1026, N'q`w', N'q`w', N'hj', 0, 1, N'f59dd23b-7956-4981-a184-49c4391e363a.jpg', N'h', N'tayyibahalauddin@yahoo.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1027, N'aAaS', N'aAaS', N'S', 0, 1, N'6185da60-6ec9-4dc6-bf1c-353f9b8cc104.jpg', N'S', N'S')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1028, N's', N's', N'', 0, 1, NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1029, N'T', N'T', N'T', 0, 1, N'a99608d4-9a3b-4b84-9b87-9f453632847f.png', N'T', N'T')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1030, N'g', N'g', N'y', 0, 1, NULL, N'g', N'g')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1031, N'k', N'k', N'k', 0, 1, NULL, N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1032, N'm', N'm', N'm', 0, 1, NULL, N'm', N'm')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1033, N'k', N'k', N'k', 0, 1, N'b8ed48eb-4bc8-4cc3-b292-f49b17031b10.png', N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1034, N'k', N'k', N'k', 0, 1, N'791cca44-dbde-48aa-9d97-45730c5b90e8.png', N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1035, N'k', N'k', N'k', 0, 1, N'a1f117ac-4e01-4457-97ec-49c1b3be9413.png', N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1036, N'k', N'k', N'k', 0, 1, N'88c47ac3-18d1-4922-b503-a023bdc39cfe.png', N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1037, N'q', N'q', N'q', 0, 1, N'345ded70-6fde-4e1c-82a3-6faf98160d7e.png', N'q', N'q')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1038, N'o', N'o', N'o', 0, 1, NULL, N'o', N'o')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1039, N'o', N'o', N'o', 0, 1, NULL, N'o', N'o')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1040, NULL, NULL, N'', 0, 1, N'8e7b739b-2ff8-4af0-a1a1-937094fda313.png', NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1041, N'2`2`', N'2`2`', N'3', 0, 1, NULL, N'3', N'3')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1042, N'2`2`', N'2`2`', N'3', 0, 1, NULL, N'3', N'3')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1043, N'j', N'j', N'j', 0, 1, NULL, N'j', N'j')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1044, N'e', N'e', N'e', 0, 1, NULL, N'e', N'e')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1045, N'e', N'e', N'e', 0, 1, NULL, N'e', N'e')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1046, N'e', N'e', N'e', 0, 1, NULL, N'e', N'e')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1047, N't', N't', N't', 0, 1, NULL, N't', N't')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1048, N'isha', N'isha', N'isha', 0, 1, N'ae890a59-5c12-4e39-bb64-85baee6dd988.png', N'lhr', N'isha@mail.com')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1049, NULL, NULL, N'k', 0, 1, NULL, N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1050, NULL, NULL, N'k', 0, 1, NULL, N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1051, NULL, NULL, N'k', 0, 1, NULL, N'k', N'k')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1052, NULL, NULL, N'', 0, 1, N'7905ae30-3457-403d-ab08-8db67d617fc8.PNG', NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1053, NULL, NULL, N'', 0, 1, N'695e024c-7fea-4622-bce0-4bc862ea451f.PNG', NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1054, NULL, NULL, N'', 0, 1, NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1055, N'tayyibah', N'tayyibah', N'tayyibah', 0, 1, N'ef3d61d4-1817-42fb-9912-e30111122ddd.PNG', N'tayyibah', N'tayyibah')
INSERT [dbo].[Users] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1056, N'QW', N'QW', N'QW', 0, 1, N'ffa8f890-de1b-4f6d-a8b0-68ba6bd63d47.jpg', N'QW', N'qw@qw.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
INSERT [dbo].[Users11] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (1, N'asd', N'asd', N'asd', 1, 1, N'admin', N'Lahore', N'admin@mail.com')
INSERT [dbo].[Users11] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (2, N'qw', N'qw', N'qw', 0, 1, N'user', N'Lahore', N'qw@mail.com')
INSERT [dbo].[Users11] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (3, N'Admin', N'Admin', N'1234', 1, 1, N'admin', N'Lahore', NULL)
INSERT [dbo].[Users11] ([UserID], [Name], [Login], [Password], [isAdmin], [isActive], [PictureName], [Designation], [Email]) VALUES (4, N'User', N'User', N'1234', 0, 1, N'user', N'pindi', N'User@User.com')
SET IDENTITY_INSERT [dbo].[UsersTable] ON 

INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1, N'Admin', N'1234', N'Lahore', N'Admin@shop.com', 1, 1, NULL, N'admin')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (2, N'User', N'1234', N'PINDI', N'user@shopper.com', 1, 2, NULL, N'user')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (3, N'asd', N'asd', N'asd', N'a@a.com', 1, 1, NULL, N'asd')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (4, N'qw', N'qw', N'qw', N'a@a.a', 1, 2, NULL, N'qw')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (5, N'a', N'as', N'a', N'a@a.a', 1, 1, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (6, N'q', N'a', N'a', N'a@a.x', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (7, N'a', N'a', N'a', N'anayamonakhan@gmail.com', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (8, N'c', N'a', N'a', N'zainh681@gmail.com', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (9, N'x', N'a', N'a', N'a@a.x', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (10, N'a', N'a', N'a', N'a@a.x', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (11, N'a', N'a', N'a', N'a@a.com', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (12, N'A', N'a', N'a', N'a@a.x', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (13, N'A', N'S', N'A', N'a@a.x', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (14, N'm,', N'a', N'a', N'', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (15, N'', N'a', N'a', N'', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (16, N'Admin', N'1234', N'Lahore', N'Admin@shop.com', 1, 1, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (17, N'', N'asd', N'asd', N'', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (18, N'sfdsf', N'asd', N'asd', N'dsfdsf@nmfr.ewfr', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1017, N'aiza', N'qw', N'qw', N'anayamonakhan@gmail.com', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1018, N'', N'asd', N'asd', N'', 1, 2, NULL, NULL)
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1019, N'asd', N'asd', N'lhr', N'asd@mail.com', 1, 2, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1020, N'qw', N'qw', N'qw', N'qw@qw.com', 1, 2, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1021, N'asd', N'asd', N'asd', N'asd@mail.com', 1, 2, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1022, N'asd', N'asd', N'asd', N'asd@mail.com', 1, 1, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1023, N'', N'asd', N'asd', N'', 1, 1, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1024, N'', N'asd', N'asd', N'', 1, 1, NULL, N'')
INSERT [dbo].[UsersTable] ([UserId], [Login], [Password], [Designation], [Email], [isActive], [UsersType], [MappingId], [PictureName]) VALUES (1025, N'Lahore', N'Lahore', N'Lahore', N'Lahore', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[UsersTable] OFF
ALTER TABLE [dbo].[addToCart]  WITH CHECK ADD  CONSTRAINT [FK_addToCart_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[addToCart] CHECK CONSTRAINT [FK_addToCart_Products]
GO
ALTER TABLE [dbo].[addToCart]  WITH CHECK ADD  CONSTRAINT [FK_addToCart_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[addToCart] CHECK CONSTRAINT [FK_addToCart_Users]
GO
ALTER TABLE [dbo].[Bill_To]  WITH CHECK ADD  CONSTRAINT [FK_Bill_To_Bill_To] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Bill_To] CHECK CONSTRAINT [FK_Bill_To_Bill_To]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Products]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users]
GO
ALTER TABLE [dbo].[UsersTable]  WITH CHECK ADD  CONSTRAINT [FK_UsersTable_MappingsTable] FOREIGN KEY([MappingId])
REFERENCES [dbo].[MappingsTable] ([MappingId])
GO
ALTER TABLE [dbo].[UsersTable] CHECK CONSTRAINT [FK_UsersTable_MappingsTable]
GO
