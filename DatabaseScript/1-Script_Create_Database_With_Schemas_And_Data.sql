USE [master]
GO
CREATE DATABASE [CaptaTecnologiaTeste]
GO
USE [CaptaTecnologiaTeste]
GO
/****** Object:  Schema [ACCOUNT]    Script Date: 31/08/2019 23:23:38 ******/
CREATE SCHEMA [ACCOUNT]
GO
/****** Object:  Schema [JOB]    Script Date: 31/08/2019 23:23:38 ******/
CREATE SCHEMA [JOB]
GO
/****** Object:  Schema [SIS]    Script Date: 31/08/2019 23:23:38 ******/
CREATE SCHEMA [SIS]
GO
/****** Object:  Table [ACCOUNT].[User]    Script Date: 31/08/2019 23:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ACCOUNT].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](20) NULL,
	[Password] [nvarchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [JOB].[Candidate]    Script Date: 31/08/2019 23:23:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [JOB].[Candidate](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[LastName] [nvarchar](50) NULL,
	[GenderCodigo] [nchar](1) NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SIS].[Gender]    Script Date: 31/08/2019 23:23:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SIS].[Gender](
	[Codigo] [nchar](1) NOT NULL,
	[Description] [nvarchar](9) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [ACCOUNT].[User] ON 

INSERT [ACCOUNT].[User] ([Id], [Username], [Password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [ACCOUNT].[User] OFF
INSERT [SIS].[Gender] ([Codigo], [Description]) VALUES (N'F', N'Feminino')
INSERT [SIS].[Gender] ([Codigo], [Description]) VALUES (N'M', N'Masculino')
ALTER TABLE [JOB].[Candidate]  WITH CHECK ADD  CONSTRAINT [FK_Candidate_Gender] FOREIGN KEY([GenderCodigo])
REFERENCES [SIS].[Gender] ([Codigo])
GO
ALTER TABLE [JOB].[Candidate] CHECK CONSTRAINT [FK_Candidate_Gender]
GO
USE [master]
GO
ALTER DATABASE [CaptaTecnologiaTeste] SET  READ_WRITE 
GO
