CREATE DATABASE [ElectricIO_DB]
GO
USE [ElectricIO_DB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[Manufacturer] [nvarchar](50) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Subversion] [float] NOT NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Device] ON 

GO
INSERT [dbo].[Device] ([DeviceID], [Name],	[ReleaseDate], [Manufacturer], [Model], [Subversion]) 
VALUES (1, N'Raspberry Pi', CAST(N'2019-07-01 00:00:00.000' AS DateTime), N'Pi Foundation', N'4', 0)
GO

SET IDENTITY_INSERT [dbo].[Movie] OFF
GO
