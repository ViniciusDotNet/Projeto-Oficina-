CREATE TABLE [dbo].[Servicos]
(
	[codigoservico] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TipoServico] NVARCHAR(50) NOT NULL, 
    [DescricaoServico] NVARCHAR(50) NOT NULL, 
    [StatuServico] NVARCHAR(50) NULL
)
