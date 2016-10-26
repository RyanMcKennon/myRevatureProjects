/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
use master;
go

if(db_id(N'MonsterDB') is not null)
begin
	drop database MonsterDB;
end;

create database MonsterDB;
go

use MonsterDB;
go

if(SCHEMA_ID(N'Monster') is not null)
begin
	drop schema Monster;
end
go

--create schema Monster;
--go
--use master;
--go

--create schema Monster;
--go

----create the table by using the schema, and the table name followed by a dot
--create table Monster.Monster
--(
--    MonsterId int not null identity(1,1),
--    GenderId int null,
--    TitleId int null,
--    TypeId int not null,
--    Name nvarchar(250) not null,
--    PicturePath nvarchar(256) null,
--    Active bit not null
--);


--create table Monster.MonsterType
--(
--    MonsterTypeId int not null identity(1,1) primary key,
--    TypeName nvarchar(250) not null,
--    Active bit not null
--);


--create table Monster.Gender
--(
--    GenderId int not null identity(1,1) primary key,
--    GenderName nvarchar(250) not null,
--    Active bit not null
--);

--create table Monster.Title
--(
--    TitleId int not null identity(1,1) primary key,
--    TitleName nvarchar(250) not null,
--    Active bit not null
--);
--go


--alter table Monster.Monster
--    add constraint pk_monster_monsterid primary key clustered (MonsterId);

--alter table Monster.Monster
--    add constraint fk_monster_genderid foreign key (GenderId) references Monster.Gender (GenderId);

--alter table Monster.Monster
--    add constraint fk_monster_titleid foreign key (TitleId) references Monster.title (TitleId);

--alter table Monster.Monster
--    add constraint fk_monster_typeid foreign key (TypeId) references Monster.MonsterType (MonsterTypeId);
--go
