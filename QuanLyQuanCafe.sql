create database [QuanLyQuanCafe]
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 25-Oct-22 12:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Cà phê đen', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Cà phê sữa đá', 1, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Bạc sĩu', 1, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Sting', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Number One', 2, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Red Bull', 2, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Warrior', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Dr. Thanh', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Bí Đao', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Mì xào trứng', 3, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Mì xào bò', 3, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Bánh mì trứng ốp la', 3, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Bánh Flan', 4, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Rau câu', 4, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Bánh Mochi', 4, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Sinh tố bơ', 5, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Sinh tố dâu', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Nước ép dâu', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Nước ép nho', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Nước ép dưa hấu', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Nước ép cam', 6, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (24, N'Nước ép cà rốt', 6, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (25, N'Nước ép chanh dây', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (26, N'Sinh tố dưa lưới bạc hà', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (27, N'Sinh tố mãng cầu', 5, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (28, N'Macha Latte', 7, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (29, N'Tea Latte', 7, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (30, N'Sinh tố Kiwi', 6, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (31, N'Sinh tố chuối', 6, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (32, N'Cappuccino', 1, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (33, N'Cà phê sữa nóng', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (34, N'Cà phê đen nóng', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (35, N'Cà phê Milkshake', 1, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (36, N'Coca Cola', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (37, N'Pessi', 2, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (38, N'7Up', 2, 15000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Cà phê')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Nước ngọt')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Bữa ăn')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Bữa ăn nhẹ')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Sinh tố')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (6, N'Nước ép')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (7, N'Latte')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF

GO --thêm bàn
DECLARE @i INT =0

WHILE @i <=10
BEGIN 
	INSERT dbo.TableFood(name)VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Kter') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Bàn chưa có tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO

GO
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

EXEC dbo.USP_GetTableList
