CREATE TABLE [mtm].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Enabled] [bit] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [mtm].[Users] ADD  CONSTRAINT [DF_Users_Enabled]  DEFAULT ((1)) FOR [Enabled]