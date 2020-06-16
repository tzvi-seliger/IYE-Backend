USE [Employee_Management]
GO

/****** Object:  Table [dbo].[Accounts]    Script Date: 3/5/2020 11:44:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [varchar](50) NOT NULL,
	[AccountDescription] [varchar](1000) NOT NULL,
	[AccountLogo] [varchar](100) NULL,
 CONSTRAINT [pk_AccountID] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


