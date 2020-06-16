USE [Employee_Management]
GO

/****** Object:  Table [dbo].[AssetsUsers]    Script Date: 3/5/2020 11:46:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AssetsUsers](
	[AssetsUserID] [int] IDENTITY(1,1) NOT NULL,
	[AssetID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[UsersAssetsExperienceStart] [date] NULL,
	[UsersAssetsExperienceEnd] [date] NULL,
	[UsersAssetsNotes] [varchar](2000) NULL,
 CONSTRAINT [PK_AssetsUserID] PRIMARY KEY CLUSTERED 
(
	[AssetsUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AssetsUsers]  WITH CHECK ADD FOREIGN KEY([AssetID])
REFERENCES [dbo].[Assets] ([AssetID])
GO

ALTER TABLE [dbo].[AssetsUsers]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO


