USE [imaginary]
GO

/****** Object:  Table [dbo].[tasks]    Script Date: 04/20/2018 19:58:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tasks](
	[Task_ID] [int] IDENTITY(1,1) NOT NULL,
	[Developer] [int] NOT NULL,
	[Project] [int] NOT NULL,
	[Task_Desc] [varchar](150) NOT NULL,
	[Task_Date] [date] NOT NULL,
	[Working_Hours] [int] NOT NULL,
	[Over_Time] [int] NOT NULL,
 CONSTRAINT [PK_tasks] PRIMARY KEY CLUSTERED 
(
	[Task_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tasks]  WITH CHECK ADD  CONSTRAINT [FK_tasks_projects] FOREIGN KEY([Project])
REFERENCES [dbo].[projects] ([P_ID])
GO

ALTER TABLE [dbo].[tasks] CHECK CONSTRAINT [FK_tasks_projects]
GO


