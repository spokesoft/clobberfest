CREATE TABLE [Game].[Games]
(
    [Id] BIGINT NOT NULL,
    
    [CreatedAt] DATETIME2(7) NOT NULL,
    [UpdatedAt] DATETIME2(7) NOT NULL,
    [DeletedAt] DATETIME2(7) NULL,
    [CreatedById] BIGINT NOT NULL,
    [UpdatedById] BIGINT NOT NULL,
    [DeletedById] DATETIME2(7) NULL,
)