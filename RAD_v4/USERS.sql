-- Script Date: 2021-11-19 20:02  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [User] (
  [uName] TEXT NOT NULL
, [pwdHash] TEXT NOT NULL
, [type] INTEGER NOT NULL
, CONSTRAINT [PK_User] PRIMARY KEY ([uName])
);
