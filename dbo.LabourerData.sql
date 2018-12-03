CREATE TABLE [dbo].[LabourerData] (
    [Id]              INT          NOT NULL,
    [FirstName]       NCHAR (20)   NULL,
    [LastName]        NCHAR (20)   NULL,
    [Age]             DECIMAL (18) NULL,
    [Sex]             NCHAR (10)   NULL,
    [MaritalStatus]   NCHAR (10)   NULL,
    [Address]         NVarChar (100)         NULL,
    [ZipCode]         NVarChar (50)  NULL,
    [NRIC]            DECIMAL (50) NULL,
    [DateOfBirth]     DATE         NULL,
    [HandphoneNumber] decimal (50) NULL,
    [HouseNumber]     decimal (50) NULL,
    [Status]          NCHAR (20)   NULL,
    [DateOfHire]      DATE         NULL,
    [HourlyWage]      Money  NULL,
    [Username]        Nvarchar(50)        NULL,
    [Password]        NVarChar(50)        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

