USE [Employee_Management]
GO

/****** Object:  Table [dbo].[TrainingFiles]    Script Date: 3/5/2020 11:46:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TrainingFiles](
	[TrainingFileID] [int] IDENTITY(1,1) NOT NULL,
	[TrainingID] [int] NOT NULL,
	[TrainingFileOrderNo] [int] NOT NULL,
	[TrainingFileDescription] [varchar](200) NOT NULL,
	[TrainingFilePath] [varchar](100) NOT NULL,
	[IsComposite] [bit] NULL,
	[CompositeRefTrainingId] [varchar](100) NULL,
	[CompositeRefFileOrderNo] [varchar](100) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TrainingFiles]  WITH CHECK ADD FOREIGN KEY([TrainingID])
REFERENCES [dbo].[Trainings] ([TrainingID])
GO

ALTER TABLE [dbo].[TrainingFiles]  WITH CHECK ADD FOREIGN KEY([TrainingID])
REFERENCES [dbo].[Trainings] ([TrainingID])
GO

ALTER TABLE [dbo].[TrainingFiles]  WITH CHECK ADD FOREIGN KEY([TrainingID])
REFERENCES [dbo].[Trainings] ([TrainingID])
GO

ALTER TABLE dbo.[TrainingFiles]
ADD CONSTRAINT PK_TrainingFiles
PRIMARY KEY(TrainingID, TrainingFileOrderNo)

