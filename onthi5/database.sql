create database qlxebuyt
go 
use qlxebuyt
go 
CREATE TABLE [dbo].[dsxe] (
    [nhan]  NVARCHAR (50) NOT NULL,
    [soghe] INT           NULL,
    [gia]   FLOAT (53)    NULL,
    [tuyen] INT           NULL,
    CONSTRAINT [PK_dsxe] PRIMARY KEY CLUSTERED ([nhan] ASC)
);

INSERT INTO [dbo].[dsxe] ([nhan], [soghe], [gia], [tuyen]) VALUES (N'xe1', 20, 2000, 1)
INSERT INTO [dbo].[dsxe] ([nhan], [soghe], [gia], [tuyen]) VALUES (N'xe2', 20, 3000, 2)
