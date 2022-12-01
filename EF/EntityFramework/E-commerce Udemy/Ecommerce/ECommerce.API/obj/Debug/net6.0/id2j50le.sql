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

CREATE TABLE [Departamentos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Departamentos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Sexo] nvarchar(max) NULL,
    [RG] nvarchar(max) NULL,
    [CPF] nvarchar(max) NOT NULL,
    [NomeMae] nvarchar(max) NULL,
    [SituacaoCadastro] nvarchar(max) NULL,
    [DataCadastro] datetimeoffset NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Contatos] (
    [Id] int NOT NULL IDENTITY,
    [UsuarioId] int NOT NULL,
    [Telefone] nvarchar(max) NULL,
    [Celular] nvarchar(max) NULL,
    CONSTRAINT [PK_Contatos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Contatos_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [DepartamentoUsuario] (
    [ListaDepartamentosId] int NOT NULL,
    [ListaUsuariosId] int NOT NULL,
    CONSTRAINT [PK_DepartamentoUsuario] PRIMARY KEY ([ListaDepartamentosId], [ListaUsuariosId]),
    CONSTRAINT [FK_DepartamentoUsuario_Departamentos_ListaDepartamentosId] FOREIGN KEY ([ListaDepartamentosId]) REFERENCES [Departamentos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DepartamentoUsuario_Usuarios_ListaUsuariosId] FOREIGN KEY ([ListaUsuariosId]) REFERENCES [Usuarios] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Enderecos] (
    [Id] int NOT NULL IDENTITY,
    [UsuarioId] int NOT NULL,
    [NomeEndereco] nvarchar(max) NOT NULL,
    [CEP] nvarchar(max) NOT NULL,
    [Estado] nvarchar(max) NOT NULL,
    [Cidade] nvarchar(max) NOT NULL,
    [Bairro] nvarchar(max) NOT NULL,
    [Endereco] nvarchar(max) NOT NULL,
    [Numero] nvarchar(max) NULL,
    [Complemento] nvarchar(max) NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([Id]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_Contatos_UsuarioId] ON [Contatos] ([UsuarioId]);
GO

CREATE INDEX [IX_DepartamentoUsuario_ListaUsuariosId] ON [DepartamentoUsuario] ([ListaUsuariosId]);
GO

CREATE INDEX [IX_Enderecos_UsuarioId] ON [Enderecos] ([UsuarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221117183550_Migration1.0.0', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Usuarios] ADD [NomePai] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221118130029_Migration1.0.1', N'7.0.0');
GO

COMMIT;
GO

