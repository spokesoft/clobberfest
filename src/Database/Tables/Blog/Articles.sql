CREATE TABLE [Blog].[Articles]
(
    [Id] BIGINT NOT NULL,
    [Name] NVARCHAR(255) NOT NULL,
    [Content] TEXT NOT NULL,
    [CreatedAt] DATETIME2(7) NOT NULL,
    [UpdatedAt] DATETIME2(7) NOT NULL,
    [DeletedAt] DATETIME2(7) NULL,
    [CreatedById] BIGINT NULL,
    [UpdatedById] BIGINT NULL,
    [DeletedById] BIGINT NULL,
)