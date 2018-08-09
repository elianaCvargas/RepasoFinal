USE [final-20180802]
GO

/****** Object:  Table [dbo].[Archivo]    Script Date: 31/7/2018 7:28:05 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Archivo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[contenido] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

