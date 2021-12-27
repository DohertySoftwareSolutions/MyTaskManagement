CREATE TABLE [mtm].[Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdatedOn] [datetime] NOT NULL
) ON [PRIMARY]