USE [WindowFormDB]
GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 09.06.2022 13:50:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci](
	[numara] [int] NULL,
	[ad] [varchar](50) NULL,
	[soyad] [varchar](50) NULL,
	[notu] [int] NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY]
GO
