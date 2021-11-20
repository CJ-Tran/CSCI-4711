-- Script Date: 2021-11-19 20:06  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [Key] (
  [Id] INTEGER NOT NULL
, [CurrentAssigned] TEXT NULL
, [LastAssigned] TEXT NULL
, [RoomNum] INTEGER NOT NULL
, [Status] INTEGER NOT NULL
, CONSTRAINT [PK_Key] PRIMARY KEY ([Id])
);
