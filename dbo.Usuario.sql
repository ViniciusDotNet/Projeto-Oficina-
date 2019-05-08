CREATE TABLE [dbo].[Usuario]
(
	[Codigo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Endereco] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL
    
)
