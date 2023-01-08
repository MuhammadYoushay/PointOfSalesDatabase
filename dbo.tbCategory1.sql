USE [POS_DB_SQL]
GO

/****** Object:  Table [dbo].[tbCategory1]    Script Date: 11/29/2022 12:13:47 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCategory1]') AND type in (N'U'))
DROP TABLE [dbo].[tbCategory1]
GO

/****** Object:  Table [dbo].[tbCategory1]    Script Date: 11/29/2022 12:13:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbCategory1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbCategory1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

