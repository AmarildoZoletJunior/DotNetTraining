IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Ingrediente] (
    [Id] int NOT NULL IDENTITY,
    [IngredienteUnico] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Ingrediente] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Un_Medida] (
    [Id] int NOT NULL IDENTITY,
    [Medida] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Un_Medida] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usuario] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Email] nvarchar(450) NOT NULL,
    [Senha] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Receita] (
    [ReceitaId] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NOT NULL,
    [Rendimento] int NOT NULL,
    [ModoPreparo] nvarchar(max) NOT NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_Receita] PRIMARY KEY ([ReceitaId]),
    CONSTRAINT [FK_Receita_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [IngredientesReceitas] (
    [IngredienteId] int NOT NULL,
    [ReceitaId] int NOT NULL,
    [Un_MedidaId] int NOT NULL,
    CONSTRAINT [PK_IngredientesReceitas] PRIMARY KEY ([ReceitaId], [IngredienteId], [Un_MedidaId]),
    CONSTRAINT [FK_IngredientesReceitas_Ingrediente_IngredienteId] FOREIGN KEY ([IngredienteId]) REFERENCES [Ingrediente] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IngredientesReceitas_Receita_ReceitaId] FOREIGN KEY ([ReceitaId]) REFERENCES [Receita] ([ReceitaId]) ON DELETE CASCADE,
    CONSTRAINT [FK_IngredientesReceitas_Un_Medida_Un_MedidaId] FOREIGN KEY ([Un_MedidaId]) REFERENCES [Un_Medida] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_IngredientesReceitas_IngredienteId] ON [IngredientesReceitas] ([IngredienteId]);
GO

CREATE INDEX [IX_IngredientesReceitas_Un_MedidaId] ON [IngredientesReceitas] ([Un_MedidaId]);
GO

CREATE INDEX [IX_Receita_UsuarioId] ON [Receita] ([UsuarioId]);
GO

CREATE UNIQUE INDEX [IX_Usuario_Email] ON [Usuario] ([Email]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221130165203_testebanco1.0', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Receita] DROP CONSTRAINT [FK_Receita_Usuario_UsuarioId];
GO

DROP TABLE [IngredientesReceitas];
GO

DROP TABLE [Un_Medida];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Receita]') AND [c].[name] = N'UsuarioId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Receita] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Receita] ALTER COLUMN [UsuarioId] int NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Receita]') AND [c].[name] = N'Rendimento');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Receita] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Receita] ALTER COLUMN [Rendimento] int NULL;
GO

CREATE TABLE [IngredienteReceita] (
    [ListaIngredientesId] int NOT NULL,
    [ListaReceitasReceitaId] int NOT NULL,
    CONSTRAINT [PK_IngredienteReceita] PRIMARY KEY ([ListaIngredientesId], [ListaReceitasReceitaId]),
    CONSTRAINT [FK_IngredienteReceita_Ingrediente_ListaIngredientesId] FOREIGN KEY ([ListaIngredientesId]) REFERENCES [Ingrediente] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IngredienteReceita_Receita_ListaReceitasReceitaId] FOREIGN KEY ([ListaReceitasReceitaId]) REFERENCES [Receita] ([ReceitaId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_IngredienteReceita_ListaReceitasReceitaId] ON [IngredienteReceita] ([ListaReceitasReceitaId]);
GO

ALTER TABLE [Receita] ADD CONSTRAINT [FK_Receita_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221201134649_teste', N'7.0.0');
GO

COMMIT;
GO

