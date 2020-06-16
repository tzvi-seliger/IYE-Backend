USE [Employee_Management]
GO

/****** Object:  Table [dbo].[Assets]    Script Date: 3/5/2020 11:45:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Assets](
	[AssetDescription] [varchar](200) NULL,
	[AssetName] [varchar](50) NULL,
	[AssetID] [int] IDENTITY(1,1) NOT NULL,
	[AssetType] [varchar](20) NULL,
 CONSTRAINT [PK_AssetID] PRIMARY KEY CLUSTERED 
(
	[AssetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Assets]  WITH CHECK ADD CHECK  (([AssetType]='Skill' OR [AssetType]='Talent' OR [AssetType]='Position'))
GO


