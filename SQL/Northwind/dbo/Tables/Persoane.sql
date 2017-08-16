CREATE TABLE [dbo].[Persoane] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [LastName]  VARCHAR (255) NOT NULL,
    [FirstName] VARCHAR (255) NULL,
    [Age]       INT           NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

