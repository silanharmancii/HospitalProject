CREATE TABLE [dbo].[Clinics] (
    [ClinicId]   INT           IDENTITY (1, 1) NOT NULL,
    [ClinicName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Clinic] PRIMARY KEY CLUSTERED ([ClinicId] ASC)
);

