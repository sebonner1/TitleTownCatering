--
-- File generated with SQLiteStudio v3.2.1 on Mon Apr 12 19:46:27 2021
--
-- Text encoding used: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: cart
CREATE TABLE cart (ItemID INTEGER PRIMARY KEY, Name STRING, Quantity INTEGER, Price DOUBLE);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
