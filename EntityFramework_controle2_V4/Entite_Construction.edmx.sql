
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/31/2022 23:03:05
-- Generated from EDMX file: C:\Users\pc\Desktop\Linq And Entity\All Ramzi Controle 2\EntityFramework_controle2_V4\EntityFramework_controle2_V4\Entite_Construction.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Entite_ConstructionModel_C2_v4];
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

-- Creating table 'Macons'
CREATE TABLE [dbo].[Macons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(50)  NULL,
    [prenom] nchar(10)  NULL
);
GO

-- Creating table 'Constructions'
CREATE TABLE [dbo].[Constructions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dateConstruction] datetime  NULL,
    [surface] nchar(10)   NULL,
    [idMacon] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Macons'
ALTER TABLE [dbo].[Macons]
ADD CONSTRAINT [PK_Macons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Constructions'
ALTER TABLE [dbo].[Constructions]
ADD CONSTRAINT [PK_Constructions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idMacon] in table 'Constructions'
ALTER TABLE [dbo].[Constructions]
ADD CONSTRAINT [FK_MaconConstruction]
    FOREIGN KEY ([idMacon])
    REFERENCES [dbo].[Macons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaconConstruction'
CREATE INDEX [IX_FK_MaconConstruction]
ON [dbo].[Constructions]
    ([idMacon]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------