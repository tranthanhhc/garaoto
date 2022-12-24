USE [GaraData]
GO
/****** Object:  Database [GaraData]    Script Date: 12/20/2022 4:26:57 PM ******/
CREATE DATABASE [GaraData]
USE [GaraData]
GO
/****** Object:  Table [dbo].[db_admin]    Script Date: 12/20/2022 4:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_admin](
	[AdName] [nvarchar](50) NULL,
	[AdPass] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[db_bill]    Script Date: 12/20/2022 4:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_bill](
	[BiId] [int] IDENTITY(1,1) NOT NULL,
	[BiCode] [char](11) NOT NULL,
	[BiType] [nvarchar](50) NULL,
	[BiOName] [nvarchar](50) NULL,
	[BiPrice] [int] NULL,
	[BiQua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BiCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[db_cars]    Script Date: 12/20/2022 4:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_cars](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CarCode] [char](11) NOT NULL,
	[CarName] [nvarchar](30) NULL,
	[CarBrand] [nvarchar](50) NULL,
	[CarModel] [nvarchar](50) NULL,
	[CarOwner] [nvarchar](50) NULL,
	[CarTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CarCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[db_depot]    Script Date: 12/20/2022 4:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_depot](
	[DeId] [int] IDENTITY(1,1) NOT NULL,
	[DeCode] [char](11) NOT NULL,
	[DeName] [nvarchar](30) NULL,
	[DeModel] [nvarchar](50) NULL,
	[DeQua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[db_employees]    Script Date: 12/20/2022 4:26:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_employees](
	[EmId] [int] IDENTITY(1,1) NOT NULL,
	[EmCode] [char](11) NOT NULL,
	[EmName] [nvarchar](30) NULL,
	[EmAge] [int] NULL,
	[EmGender] [nchar](20) NULL,
	[EmAddress] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [GaraData] SET  READ_WRITE 
GO
