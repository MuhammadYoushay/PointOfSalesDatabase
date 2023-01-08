USE [POS_DB_SQL]
GO

ALTER TABLE [dbo].[tbStockIn] DROP CONSTRAINT [FK_tbStockIn_tbSupplier]
GO

ALTER TABLE [dbo].[tbStockIn] DROP CONSTRAINT [FK_tbStockIn_tbProduct]
GO

ALTER TABLE [dbo].[tbStockIn] DROP CONSTRAINT [DF_tbStockIn_status]
GO

ALTER TABLE [dbo].[tbStockIn] DROP CONSTRAINT [DF_tbStockIn_qty]
GO

/****** Object:  Table [dbo].[tbStockIn]    Script Date: 11/29/2022 12:14:38 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbStockIn]') AND type in (N'U'))
DROP TABLE [dbo].[tbStockIn]
GO

/****** Object:  Table [dbo].[tbStockIn]    Script Date: 11/29/2022 12:14:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbStockIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[refno] [varchar](50) NULL,
	[pcode] [varchar](50) NULL,
	[qty] [int] NULL,
	[sdate] [datetime] NULL,
	[stockinby] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[supplierid] [int] NULL,
 CONSTRAINT [PK_tbStockIn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbStockIn] ADD  CONSTRAINT [DF_tbStockIn_qty]  DEFAULT ((0)) FOR [qty]
GO

ALTER TABLE [dbo].[tbStockIn] ADD  CONSTRAINT [DF_tbStockIn_status]  DEFAULT ('Pending') FOR [status]
GO

ALTER TABLE [dbo].[tbStockIn]  WITH CHECK ADD  CONSTRAINT [FK_tbStockIn_tbProduct] FOREIGN KEY([pcode])
REFERENCES [dbo].[tbProduct] ([pcode])
GO

ALTER TABLE [dbo].[tbStockIn] CHECK CONSTRAINT [FK_tbStockIn_tbProduct]
GO

ALTER TABLE [dbo].[tbStockIn]  WITH CHECK ADD  CONSTRAINT [FK_tbStockIn_tbSupplier] FOREIGN KEY([supplierid])
REFERENCES [dbo].[tbSupplier] ([id])
GO

ALTER TABLE [dbo].[tbStockIn] CHECK CONSTRAINT [FK_tbStockIn_tbSupplier]
GO

