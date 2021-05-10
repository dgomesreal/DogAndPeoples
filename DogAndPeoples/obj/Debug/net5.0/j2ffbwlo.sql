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

CREATE TABLE [Peoples] (
    [PeopleID] int NOT NULL IDENTITY,
    [PeopleName] nvarchar(max) NULL,
    CONSTRAINT [PK_Peoples] PRIMARY KEY ([PeopleID])
);
GO

CREATE TABLE [Dogs] (
    [DogID] int NOT NULL IDENTITY,
    [DogName] nvarchar(max) NULL,
    [DogBreed] nvarchar(max) NULL,
    [PeopleID] int NOT NULL,
    CONSTRAINT [PK_Dogs] PRIMARY KEY ([DogID]),
    CONSTRAINT [FK_Dogs_Peoples_PeopleID] FOREIGN KEY ([PeopleID]) REFERENCES [Peoples] ([PeopleID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Dogs_PeopleID] ON [Dogs] ([PeopleID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210510030220_initial', N'5.0.5');
GO

COMMIT;
GO

