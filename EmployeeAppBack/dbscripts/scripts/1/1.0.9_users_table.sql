USE [Employee_Management]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 3/5/2020 11:47:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[UserType] [varchar](50) NOT NULL,
	[UserName] [varchar](50) NULL,
	[PasswordString] [varchar](50) NULL,
	[Salt] [varchar](50) NULL,
	[UserEmailAddress] [varchar](50) NOT NULL,
	[UserFirstName] [varchar](50) NOT NULL,
	[UserLastName] [varchar](50) NOT NULL,
	[UserPhoneNumber] [varchar](15) NOT NULL,
 CONSTRAINT [pk_UserID] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CHK_Salt] CHECK  (([UserType]<>'User' OR [Salt] IS NOT NULL))
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CHK_Salt]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CHK_User] CHECK  (([UserType]='Employee' OR [UserType]='User' OR [UserType]='Admin'))
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CHK_User]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CHK_UserName] CHECK  (([UserName] IS NOT NULL OR [UserType]<>'User'))
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CHK_UserName]
GO


