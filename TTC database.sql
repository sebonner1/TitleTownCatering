--
<<<<<<< HEAD
-- File generated with SQLiteStudio v3.2.1 on Mon Apr 12 19:46:27 2021
=======
-- File generated with SQLiteStudio v3.2.1 on Wed Apr 7 15:47:46 2021
>>>>>>> 0b7f236f5c31b2f039186c77f29459b047f78657
--
-- Text encoding used: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

<<<<<<< HEAD
-- Table: cart
CREATE TABLE cart (ItemID INTEGER PRIMARY KEY, Name STRING, Quantity INTEGER, Price DOUBLE);
=======
-- Table: myItems
CREATE TABLE myItems (id INTEGER PRIMARY KEY, description DATETIME, price TEXT);
INSERT INTO myItems (id, description, price) VALUES (1, '2021-03-31 09:59:32.903543', 'MIS is the coolest');
INSERT INTO myItems (id, description, price) VALUES (2, '2021-03-30 18:42:54.825046', 'National Champs');
INSERT INTO myItems (id, description, price) VALUES (3, '2021-03-30 18:43:02.957051', 'Championship School');
INSERT INTO myItems (id, description, price) VALUES (4, '2021-03-30 18:43:14.584546', 'MIS rocks');
>>>>>>> 0b7f236f5c31b2f039186c77f29459b047f78657

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
