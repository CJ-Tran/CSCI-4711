-- Script Date: 2021-11-19 20:17  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [AccessEvent] (
  [User] TEXT NOT NULL
, [Time] NUMERIC NOT NULL
, [Type] TEXT NOT NULL
, CONSTRAINT [PK_AccessEvent] PRIMARY KEY ([User],[Time])
);
