CREATE TABLE [dbo].[Equipments] (
    [EquipmentId]     INT             IDENTITY (1, 1) NOT NULL,
    [ClinicId]        INT             NOT NULL,
    [EquipmentName]   NVARCHAR (50)   NOT NULL,
    [ProcurementDate] DATETIME        NULL,
    [UnitsInStock]    SMALLINT        NOT NULL,
    [UnitPrice]       DECIMAL (18, 2) NOT NULL,
    [UsageRate]       DECIMAL (18)    NOT NULL,
    CONSTRAINT [PK_Equipments] PRIMARY KEY CLUSTERED ([EquipmentId] ASC)
);

