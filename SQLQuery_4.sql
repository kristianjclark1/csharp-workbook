CREATE DATABASE MYFILE7
GO
USE MYFILE7


CREATE TABLE ACTIONFIGS2 (
    NAME VARCHAR(10),
    PRICE DECIMAL,
    ID INT IDENTITY (1,1) PRIMARY KEY,
    STOCK INT
    
);

INSERT INTO ACTIONFIGS2 (NAME, PRICE, STOCK) VALUES
('TINKYWINKY', '8.00', '10'),
('PO', '8.00','10'),
('LALA', '8.00', '10'),
('DIPSY', '8.00', '10'),
('OPTIMUS', '8.00', '10'),
('BUMBLEBEE', '8.00', '10'),
('HE-MAN', '11.00', '10'),
('SKELETOR', '10.00', '10'),
('SNARF', '12.00',  '10'),
('SPIDERMAN', '8.00', '10');

DELETE FROM ACTIONFIGS2 
WHERE NAME='TINKYWINKY';

DELETE FROM ACTIONFIGS2 
WHERE NAME='PO';

INSERT INTO ACTIONFIGS2 (NAME, PRICE, STOCK) VALUES
('HULK', '12.00', '18'),
('FLASH', '12.00', '20');

ALTER TABLE ACTIONFIGS2
ADD AISLES INT;

CREATE TABLE AISLE(
 NAME VARCHAR(255),
 ID INT
 IDENTITY(1,1) PRIMARY KEY
 
 );

 INSERT INTO AISLE (NAME) VALUES
('12A'),
('12B'),
('12C'),
('12D'),
('12E');

ALTER TABLE ACTIONFIGS2
ADD CONSTRAINT FK_ACTIONFIGAISLE
FOREIGN KEY(AISLES) references AISLE(ID);

UPDATE ACTIONFIGS2
SET AISLES=1
WHERE AISLES=1;

SELECT NAME, PRICE, AISLES, STOCK
FROM ACTIONFIGS2
ORDER BY AISLES;
