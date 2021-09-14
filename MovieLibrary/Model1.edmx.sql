
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/13/2021 18:04:12
-- Generated from EDMX file: C:\Users\yigit\Desktop\Movie-Library\MovieLibrary\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MovieLibrary];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TBL_FAVOURITE_TBL_MOVIE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_FAVOURITE] DROP CONSTRAINT [FK_TBL_FAVOURITE_TBL_MOVIE];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_FAVOURITE_TBL_USER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_FAVOURITE] DROP CONSTRAINT [FK_TBL_FAVOURITE_TBL_USER];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_WATCHLIST_ELEMENT_TBL_MOVIE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_WATCHLIST_ELEMENT] DROP CONSTRAINT [FK_TBL_WATCHLIST_ELEMENT_TBL_MOVIE];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_WATCHLIST_ELEMENT_TBL_WATCHLIST]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_WATCHLIST_ELEMENT] DROP CONSTRAINT [FK_TBL_WATCHLIST_ELEMENT_TBL_WATCHLIST];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_WATCHLIST_TBL_USER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_WATCHLIST] DROP CONSTRAINT [FK_TBL_WATCHLIST_TBL_USER];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TBL_FAVOURITE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_FAVOURITE];
GO
IF OBJECT_ID(N'[dbo].[TBL_MOVIE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_MOVIE];
GO
IF OBJECT_ID(N'[dbo].[TBL_MOVIEPREVIEW]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_MOVIEPREVIEW];
GO
IF OBJECT_ID(N'[dbo].[TBL_USER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_USER];
GO
IF OBJECT_ID(N'[dbo].[TBL_WATCHLIST]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_WATCHLIST];
GO
IF OBJECT_ID(N'[dbo].[TBL_WATCHLIST_ELEMENT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_WATCHLIST_ELEMENT];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TBL_FAVOURITE'
CREATE TABLE [dbo].[TBL_FAVOURITE] (
    [FavId] smallint IDENTITY(1,1) NOT NULL,
    [PersonalRating] decimal(18,0)  NULL,
    [Notes] varchar(max)  NULL,
    [imdbId] varchar(50)  NOT NULL,
    [userId] smallint  NULL
);
GO

-- Creating table 'TBL_MOVIE'
CREATE TABLE [dbo].[TBL_MOVIE] (
    [Title] varchar(200)  NULL,
    [Year] varchar(50)  NULL,
    [Rated] varchar(50)  NULL,
    [Released] varchar(50)  NULL,
    [Runtime] varchar(100)  NULL,
    [Genre] varchar(100)  NULL,
    [Director] varchar(200)  NULL,
    [Writer] varchar(100)  NULL,
    [Actors] varchar(200)  NULL,
    [Plot] varchar(max)  NULL,
    [Language] varchar(100)  NULL,
    [Country] varchar(100)  NULL,
    [Awards] varchar(200)  NULL,
    [Poster] varchar(max)  NULL,
    [Metascore] varchar(50)  NULL,
    [imdbRating] varchar(50)  NULL,
    [imdbVotes] varchar(200)  NULL,
    [imdbId] varchar(50)  NOT NULL,
    [Type] varchar(100)  NULL,
    [DVD] varchar(100)  NULL,
    [BoxOffice] varchar(200)  NULL,
    [Production] varchar(200)  NULL,
    [Website] varchar(200)  NULL,
    [Response] varchar(100)  NULL
);
GO

-- Creating table 'TBL_MOVIEPREVIEW'
CREATE TABLE [dbo].[TBL_MOVIEPREVIEW] (
    [Year] varchar(50)  NULL,
    [Title] varchar(50)  NULL,
    [imdbID] varchar(50)  NOT NULL,
    [Type] varchar(50)  NULL,
    [Poster] varchar(max)  NULL,
    [id] smallint  NOT NULL
);
GO

-- Creating table 'TBL_USER'
CREATE TABLE [dbo].[TBL_USER] (
    [userId] smallint IDENTITY(1,1) NOT NULL,
    [userName] varchar(50)  NULL,
    [password] varchar(50)  NULL
);
GO

-- Creating table 'TBL_WATCHLIST'
CREATE TABLE [dbo].[TBL_WATCHLIST] (
    [WatchListId] smallint IDENTITY(1,1) NOT NULL,
    [WatchListName] varchar(50)  NOT NULL,
    [userId] smallint  NULL
);
GO

-- Creating table 'TBL_WATCHLIST_ELEMENT'
CREATE TABLE [dbo].[TBL_WATCHLIST_ELEMENT] (
    [WatchListName] varchar(50)  NOT NULL,
    [imdbId] varchar(50)  NOT NULL,
    [Date] datetime  NULL,
    [Notes] varchar(max)  NULL,
    [WatchListElementId] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [FavId] in table 'TBL_FAVOURITE'
ALTER TABLE [dbo].[TBL_FAVOURITE]
ADD CONSTRAINT [PK_TBL_FAVOURITE]
    PRIMARY KEY CLUSTERED ([FavId] ASC);
GO

-- Creating primary key on [imdbId] in table 'TBL_MOVIE'
ALTER TABLE [dbo].[TBL_MOVIE]
ADD CONSTRAINT [PK_TBL_MOVIE]
    PRIMARY KEY CLUSTERED ([imdbId] ASC);
GO

-- Creating primary key on [imdbID] in table 'TBL_MOVIEPREVIEW'
ALTER TABLE [dbo].[TBL_MOVIEPREVIEW]
ADD CONSTRAINT [PK_TBL_MOVIEPREVIEW]
    PRIMARY KEY CLUSTERED ([imdbID] ASC);
GO

-- Creating primary key on [userId] in table 'TBL_USER'
ALTER TABLE [dbo].[TBL_USER]
ADD CONSTRAINT [PK_TBL_USER]
    PRIMARY KEY CLUSTERED ([userId] ASC);
GO

-- Creating primary key on [WatchListName] in table 'TBL_WATCHLIST'
ALTER TABLE [dbo].[TBL_WATCHLIST]
ADD CONSTRAINT [PK_TBL_WATCHLIST]
    PRIMARY KEY CLUSTERED ([WatchListName] ASC);
GO

-- Creating primary key on [WatchListElementId] in table 'TBL_WATCHLIST_ELEMENT'
ALTER TABLE [dbo].[TBL_WATCHLIST_ELEMENT]
ADD CONSTRAINT [PK_TBL_WATCHLIST_ELEMENT]
    PRIMARY KEY CLUSTERED ([WatchListElementId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [imdbId] in table 'TBL_FAVOURITE'
ALTER TABLE [dbo].[TBL_FAVOURITE]
ADD CONSTRAINT [FK_TBL_FAVOURITE_TBL_MOVIE]
    FOREIGN KEY ([imdbId])
    REFERENCES [dbo].[TBL_MOVIE]
        ([imdbId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_FAVOURITE_TBL_MOVIE'
CREATE INDEX [IX_FK_TBL_FAVOURITE_TBL_MOVIE]
ON [dbo].[TBL_FAVOURITE]
    ([imdbId]);
GO

-- Creating foreign key on [userId] in table 'TBL_FAVOURITE'
ALTER TABLE [dbo].[TBL_FAVOURITE]
ADD CONSTRAINT [FK_TBL_FAVOURITE_TBL_USER]
    FOREIGN KEY ([userId])
    REFERENCES [dbo].[TBL_USER]
        ([userId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_FAVOURITE_TBL_USER'
CREATE INDEX [IX_FK_TBL_FAVOURITE_TBL_USER]
ON [dbo].[TBL_FAVOURITE]
    ([userId]);
GO

-- Creating foreign key on [imdbId] in table 'TBL_WATCHLIST_ELEMENT'
ALTER TABLE [dbo].[TBL_WATCHLIST_ELEMENT]
ADD CONSTRAINT [FK_TBL_WATCHLIST_ELEMENT_TBL_MOVIE]
    FOREIGN KEY ([imdbId])
    REFERENCES [dbo].[TBL_MOVIE]
        ([imdbId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_WATCHLIST_ELEMENT_TBL_MOVIE'
CREATE INDEX [IX_FK_TBL_WATCHLIST_ELEMENT_TBL_MOVIE]
ON [dbo].[TBL_WATCHLIST_ELEMENT]
    ([imdbId]);
GO

-- Creating foreign key on [userId] in table 'TBL_WATCHLIST'
ALTER TABLE [dbo].[TBL_WATCHLIST]
ADD CONSTRAINT [FK_TBL_WATCHLIST_TBL_USER]
    FOREIGN KEY ([userId])
    REFERENCES [dbo].[TBL_USER]
        ([userId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_WATCHLIST_TBL_USER'
CREATE INDEX [IX_FK_TBL_WATCHLIST_TBL_USER]
ON [dbo].[TBL_WATCHLIST]
    ([userId]);
GO

-- Creating foreign key on [WatchListName] in table 'TBL_WATCHLIST_ELEMENT'
ALTER TABLE [dbo].[TBL_WATCHLIST_ELEMENT]
ADD CONSTRAINT [FK_TBL_WATCHLIST_ELEMENT_TBL_WATCHLIST]
    FOREIGN KEY ([WatchListName])
    REFERENCES [dbo].[TBL_WATCHLIST]
        ([WatchListName])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_WATCHLIST_ELEMENT_TBL_WATCHLIST'
CREATE INDEX [IX_FK_TBL_WATCHLIST_ELEMENT_TBL_WATCHLIST]
ON [dbo].[TBL_WATCHLIST_ELEMENT]
    ([WatchListName]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------