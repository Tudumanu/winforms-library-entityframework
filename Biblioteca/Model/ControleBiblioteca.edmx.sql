
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/18/2016 19:46:36
-- Generated from EDMX file: c:\users\tudu\documents\visual studio 2015\Projects\Biblioteca\Biblioteca\Model\ControleBiblioteca.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'LivroSet'
CREATE TABLE [dbo].[LivroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [Editora] nvarchar(max)  NOT NULL,
    [Ano] nvarchar(max)  NOT NULL,
    [NumeroChamada] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AutorSet'
CREATE TABLE [dbo].[AutorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [LivroId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'LivroSet'
ALTER TABLE [dbo].[LivroSet]
ADD CONSTRAINT [PK_LivroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AutorSet'
ALTER TABLE [dbo].[AutorSet]
ADD CONSTRAINT [PK_AutorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [LivroId] in table 'AutorSet'
ALTER TABLE [dbo].[AutorSet]
ADD CONSTRAINT [FK_LivroAutor]
    FOREIGN KEY ([LivroId])
    REFERENCES [dbo].[LivroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LivroAutor'
CREATE INDEX [IX_FK_LivroAutor]
ON [dbo].[AutorSet]
    ([LivroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------