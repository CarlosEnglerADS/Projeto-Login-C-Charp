[10:19, 05/10/2023]
--create database LoginCharp
--use LoginCharp



CREATE TABLE [dbo].[Usuario] (
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (20) NOT NULL,
    [ID]       VARCHAR(10)   NULL
);


No Sql Server crie o primeiro user com Insert
nao esqueçade trocar todas as conexções para sua string de conexão