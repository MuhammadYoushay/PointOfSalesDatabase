USE [POS_DB_SQL]
GO

ALTER TABLE [dbo].[tbUser] DROP CONSTRAINT [DF_tnUser_isActive]
GO

/****** Object:  Table [dbo].[tbUser]    Script Date: 11/29/2022 12:15:28 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbUser]') AND type in (N'U'))
DROP TABLE [dbo].[tbUser]
GO

/****** Object:  Table [dbo].[tbUser]    Script Date: 11/29/2022 12:15:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbUser](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[isActive] [varchar](50) NULL,
 CONSTRAINT [PK_tnUser] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbUser] ADD  CONSTRAINT [DF_tnUser_isActive]  DEFAULT ('True') FOR [isActive]
GO

