USE [POS_DB_SQL]
GO

/****** Object:  Table [dbo].[tbSupplier]    Script Date: 11/29/2022 12:15:04 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSupplier]') AND type in (N'U'))
DROP TABLE [dbo].[tbSupplier]
GO

/****** Object:  Table [dbo].[tbSupplier]    Script Date: 11/29/2022 12:15:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbSupplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplier] [varchar](50) NOT NULL,
	[address] [text] NOT NULL,
	[contactperson] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_tbSupplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

