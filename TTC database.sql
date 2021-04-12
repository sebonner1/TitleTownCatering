--
-- File generated with SQLiteStudio v3.2.1 on Wed Apr 7 15:47:46 2021
--
-- Text encoding used: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: myItems
CREATE TABLE myItems (id INTEGER PRIMARY KEY, description DATETIME, price TEXT);
INSERT INTO myItems (id, description, price) VALUES (1, '2021-03-31 09:59:32.903543', 'MIS is the coolest');
INSERT INTO myItems (id, description, price) VALUES (2, '2021-03-30 18:42:54.825046', 'National Champs');
INSERT INTO myItems (id, description, price) VALUES (3, '2021-03-30 18:43:02.957051', 'Championship School');
INSERT INTO myItems (id, description, price) VALUES (4, '2021-03-30 18:43:14.584546', 'MIS rocks');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
