CREATE DATABASE [Quanlyvetauhoa]
go

USE [Quanlyvetauhoa]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Datve(
	[mave] [nchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[Ngaydi] [date] NOT NULL,
	[Giodi] [nchar](10) NOT NULL,
	[Gioitinh] [nchar](10) NOT NULL,
	[Dantoc] [nchar](10) NOT NULL,
	[Cmnd] [int] NULL,
	[Diemden] [nvarchar](50) NOT NULL,
	[Gia] [int] NOT NULL,
CONSTRAINT [PK_datve] PRIMARY KEY CLUSTERED 
([mave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Nguoidung(
	[taikhoan] [nchar](10) NOT NULL,
	[pass] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
INSERT datve ([mave], [hoten], [ngaydi], [giodi], [gioitinh], [dantoc], [cmnd], [diemden], [gia]) 
VALUES (N'A001', N'Hà Nhựt Nam', CAST(N'2018-05-13' AS Date), N'6.00', N'nam', N'kinh', 281178366, N'TP.Đà Nẵng', 270000)
INSERT datve ([mave], [hoten], [ngaydi], [giodi], [gioitinh], [dantoc], [cmnd], [diemden], [gia]) 
VALUES (N'A002', N'Nguyễn Quang Huy', CAST(N'2018-07-25' AS Date), N'3.00', N'nam', N'Kinh',281267893, N'TP.Bien hoa', 110000)
INSERT datve ([mave], [hoten], [ngaydi], [giodi], [gioitinh], [dantoc], [cmnd], [diemden], [gia]) 
VALUES (N'A003', N'Lê Kiều Oanh', CAST(N'2019-03-18' AS Date), N'2.00', N'nu', N'Kinh',282828282, N'TP.Hải Phòng', 330000)
INSERT Nguoidung([taikhoan], [pass]) VALUES (N'admin', N'admin')

USE [master]
GO
ALTER DATABASE [Quanlyvetauhoa] SET  READ_WRITE 
GO

