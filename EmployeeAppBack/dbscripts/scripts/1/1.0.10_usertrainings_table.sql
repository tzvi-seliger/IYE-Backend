USE [Employee_Management]
GO

/****** Object:  Table [dbo].[UserTrainings]    Script Date: 3/5/2020 11:47:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTrainings](
	[UserTrainingID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[TrainingID] [int] NOT NULL,
	[TrainingStatus] [varchar](20) NULL,
 CONSTRAINT [PK_UserTrainingID] PRIMARY KEY CLUSTERED 
(
	[UserTrainingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserTrainings]  WITH CHECK ADD FOREIGN KEY([TrainingID])
REFERENCES [dbo].[Trainings] ([TrainingID])
GO

ALTER TABLE [dbo].[UserTrainings]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE [dbo].[UserTrainings]  WITH CHECK ADD  CONSTRAINT [CHK_TrainingStatus] CHECK  (([TrainingStatus]='Recommended' OR [TrainingStatus]='Requested' OR [TrainingStatus]='In Progress' OR [TrainingStatus]='Completed'))
GO

ALTER TABLE [dbo].[UserTrainings] CHECK CONSTRAINT [CHK_TrainingStatus]
GO


