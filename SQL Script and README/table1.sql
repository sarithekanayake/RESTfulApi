USE [imaginary]
GO

/****** Object:  Table [dbo].[employees]    Script Date: 04/20/2018 19:57:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[employees](
	[EMP_ID] [int] IDENTITY(1,1) NOT NULL,
	[EMP_Name] [varchar](150) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[EMP_Address] [varchar](150) NOT NULL,
	[EMP_Email] [varchar](50) NOT NULL,
	[Tel_No] [int] NOT NULL,
	[Privilage_Level] [int] NOT NULL,
	[EMP_Password] [varchar](150) NOT NULL,
	[EMP_UserName] [varchar](50) NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


