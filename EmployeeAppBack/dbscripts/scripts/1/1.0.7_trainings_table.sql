USE [Employee_Management]
GO

/****** Object:  Table [dbo].[Trainings]    Script Date: 3/5/2020 11:47:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Trainings](
	[TrainingID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[TrainingName] [varchar](50) NULL,
	[TrainingDescription] [varchar](200) NULL,
 CONSTRAINT [pk_trainingID] PRIMARY KEY CLUSTERED 
(
	[TrainingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Trainings]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO


