USE [POS_DB_SQL]
GO

ALTER TABLE [dbo].[tbProduct] DROP CONSTRAINT [FK_tbProduct_tbBrand]
GO

ALTER TABLE [dbo].[tbProduct] DROP CONSTRAINT [DF_tbProduct_qty]
GO

/****** Object:  Table [dbo].[tbProduct]    Script Date: 11/29/2022 12:14:16 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbProduct]') AND type in (N'U'))
DROP TABLE [dbo].[tbProduct]
GO

/****** Object:  Table [dbo].[tbProduct]    Script Date: 11/29/2022 12:14:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbProduct](
	[pcode] [varchar](50) NOT NULL,
	[barcode] [varchar](50) NULL,
	[pdesc] [varchar](max) NOT NULL,
	[bid] [int] NOT NULL,
	[cid] [int] NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[qty] [int] NULL,
	[reorder] [int] NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[pcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbProduct] ADD  CONSTRAINT [DF_tbProduct_qty]  DEFAULT ((0)) FOR [qty]
GO

ALTER TABLE [dbo].[tbProduct]  WITH CHECK ADD  CONSTRAINT [FK_tbProduct_tbBrand] FOREIGN KEY([bid])
REFERENCES [dbo].[tbBrand] ([id])
GO

ALTER TABLE [dbo].[tbProduct] CHECK CONSTRAINT [FK_tbProduct_tbBrand]
GO

