USE [POS_DB_SQL]
GO

ALTER TABLE [dbo].[tbCart] DROP CONSTRAINT [FK_tbCart_tbProduct]
GO

ALTER TABLE [dbo].[tbCart] DROP CONSTRAINT [DF_tbCart1_status]
GO

ALTER TABLE [dbo].[tbCart] DROP CONSTRAINT [DF_tbCart1_disc]
GO

ALTER TABLE [dbo].[tbCart] DROP CONSTRAINT [DF_tbCart1_disc_perc]
GO

ALTER TABLE [dbo].[tbCart] DROP CONSTRAINT [DF_tbCart1_qty]
GO

/****** Object:  Table [dbo].[tbCart]    Script Date: 11/29/2022 12:13:17 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCart]') AND type in (N'U'))
DROP TABLE [dbo].[tbCart]
GO

/****** Object:  Table [dbo].[tbCart]    Script Date: 11/29/2022 12:13:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbCart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transno] [varchar](50) NULL,
	[pcode] [varchar](50) NULL,
	[price] [decimal](18, 2) NULL,
	[qty] [int] NULL,
	[disc_perc] [decimal](18, 2) NULL,
	[disc] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[sdate] [date] NULL,
	[status] [varchar](50) NULL,
	[cashier] [varchar](50) NULL,
 CONSTRAINT [PK_tbCart1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbCart] ADD  CONSTRAINT [DF_tbCart1_qty]  DEFAULT ((0)) FOR [qty]
GO

ALTER TABLE [dbo].[tbCart] ADD  CONSTRAINT [DF_tbCart1_disc_perc]  DEFAULT ((0)) FOR [disc_perc]
GO

ALTER TABLE [dbo].[tbCart] ADD  CONSTRAINT [DF_tbCart1_disc]  DEFAULT ((0)) FOR [disc]
GO

ALTER TABLE [dbo].[tbCart] ADD  CONSTRAINT [DF_tbCart1_status]  DEFAULT ('pending') FOR [status]
GO

ALTER TABLE [dbo].[tbCart]  WITH CHECK ADD  CONSTRAINT [FK_tbCart_tbProduct] FOREIGN KEY([pcode])
REFERENCES [dbo].[tbProduct] ([pcode])
GO

ALTER TABLE [dbo].[tbCart] CHECK CONSTRAINT [FK_tbCart_tbProduct]
GO

