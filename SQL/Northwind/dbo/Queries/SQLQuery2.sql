CREATE TABLE Persoane (
    ID int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int
);

INSERT INTO Persoane
VALUES ('Hansen','Ola',32);

INSERT INTO Persoane
VALUES('Svendson','Tove',25);

INSERT INTO Persoane
VALUES('Pettersen','Kari',27);

INSERT INTO Persoane
VALUES ('Lars','Monsen',22);

DELETE FROM Persoane
WHERE ID=5;

ALTER TABLE Persoane
ALTER COLUMN FirstName varchar(255) NOT NULL

ALTER TABLE Persoane
ADD CHECK(Age>20)

INSERT INTO Persoane
VALUES ('Larsen','Loren',22);

UPDATE Persoane
SET Age=22
WHERE LastName='Larsen'

INSERT INTO Persoane
VALUES ('Williams','Emily',25);

SELECT FirstName
FROM Persoane
WHERE Age>25 AND LastName LIKE '%a%'

SELECT * 
FROM Persoane