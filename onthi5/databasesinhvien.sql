CREATE DATABASE qlsinhvien
go 
USE qlsinhvien
GO

CREATE TABLE [dbo].[sinhvien] (
    [masinhvien] INT           NOT NULL,
    [hoten]      NVARCHAR (50) NULL,
    [ngaysinh]   DATETIME      NULL,
    [khoa]       NVARCHAR (50) NULL,
    [quequan]    NVARCHAR (50) NULL,
    CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED ([masinhvien] ASC)
);

INSERT INTO [dbo].[sinhvien] ([masinhvien], [hoten], [ngaysinh], [khoa], [quequan]) VALUES (1, N'A', N'2000-02-02 00:00:00', N'Điện tử', N'Hà Nội')
