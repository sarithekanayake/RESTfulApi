USE [imaginary]
GO

/****** Object:  Table [dbo].[projects]    Script Date: 04/20/2018 19:57:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[projects](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[Project_Name] [varchar](150) NOT NULL,
	[Manager] [int] NOT NULL,
	[Developer] [varchar](50) NOT NULL,
	[Tot_Hours] [int] NULL,
 CONSTRAINT [PK_projects] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [FK_projects_employees] FOREIGN KEY([Manager])
REFERENCES [dbo].[employees] ([EMP_ID])
GO

ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [FK_projects_employees]
GO


