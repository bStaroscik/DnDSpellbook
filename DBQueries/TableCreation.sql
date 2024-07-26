CREATE TABLE [dbo].[DNDBookTable]
(
    [DNDBookId]   INT          NOT NULL IDENTITY,
    [BookName] VARCHAR(100) NULL, 
    [PublishYear] INT NULL, 
    CONSTRAINT [PK_DNDBookTable] PRIMARY KEY ([DNDBookId]) 
)

CREATE TABLE [dbo].[SpellClassTable]
(
	[ClassId]   INT          NOT NULL IDENTITY, 
    [ClassName] VARCHAR(50) NULL, 
    CONSTRAINT [PK_SpellClassTable] PRIMARY KEY ([ClassId]), 
)

CREATE TABLE [dbo].[SpellSchoolTable]
(
	[SchoolId]   INT          NOT NULL IDENTITY, 
    [SchoolName] VARCHAR(50) NULL, 
    CONSTRAINT [PK_SpellSchoolTable] PRIMARY KEY ([SchoolId]), 
)

CREATE TABLE [dbo].[SpellsTable] (
    [SpellId]      INT           NOT NULL IDENTITY,
    [SpellName]    VARCHAR (50)  NULL,
    [SpellLevel]   INT           NULL,
    [Components]   VARCHAR (50)  NULL,
    [SpellRange]   VARCHAR (50)  NULL,
    [AreaOfEffect] VARCHAR (50)  NULL,
    [SpellSave]    VARCHAR (50)  NULL,
    [CastingTime]  VARCHAR (50)  NULL,
    [Duration]     VARCHAR (50)  NULL,
    [SpellClass]   INT           NULL,
    [SpellSchool]  INT           NULL,
    [Description]  VARCHAR (MAX) NULL,
    [Reversible]   BIT           NULL,
    PRIMARY KEY CLUSTERED ([SpellId] ASC),
    CONSTRAINT [FK_Table_ToTable_3] FOREIGN KEY ([SpellClass]) REFERENCES [dbo].[SpellClassTable] ([ClassId]),
    CONSTRAINT [FK_Table_ToTable_4] FOREIGN KEY ([SpellSchool]) REFERENCES [dbo].[SpellSchoolTable] ([SchoolId])
);


CREATE TABLE [dbo].[SpellandBookCompTable]
(
	[SpellCompId] INT NOT NULL , 
    [SpellBookId] INT NOT NULL, 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([SpellCompId]) REFERENCES [SpellsTable]([SpellId]), 
    CONSTRAINT [FK_Table_ToTable_1] FOREIGN KEY ([SpellBookId]) REFERENCES [DNDBookTable]([DNDBookId])
)

CREATE TABLE [dbo].[SpellandSchoolCompTable] (
    [SpellCompId] INT NOT NULL,
    [SpellSchoolId] INT NOT NULL,
    CONSTRAINT [FK_Table_ToTable_5] FOREIGN KEY ([SpellSchoolId]) REFERENCES [dbo].[SpellSchoolTable] ([SchoolId]),
    CONSTRAINT [FK_Table_ToTable_6] FOREIGN KEY ([SpellCompId]) REFERENCES [dbo].[SpellsTable] ([SpellId])
);

