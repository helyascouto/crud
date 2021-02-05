CREATE TABLE [dbo].[tb_Funcionarios] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [nome]       NVARCHAR (50) NOT NULL,
    [sexo]       CHAR (10)     NULL,
    [TELEFONE]   INT    NULL,
    [SALARIO]    REAL          NULL,
    [EMAIL]      NCHAR (30)    NULL,
    [NASCIMENTO] DATETIME      NULL,
    [CIDADE]     NCHAR (20)    NULL,
    [ESTADO]     NCHAR (20)    NULL,
    [CEP]        INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

