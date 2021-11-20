-- Script Date: 2021-11-19 20:02  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [User] (
  [UName] TEXT NOT NULL
, [PwdHash] TEXT NOT NULL
, [Type] INTEGER NOT NULL
, CONSTRAINT [PK_User] PRIMARY KEY ([UName])
);
