CREATE DATABASE CrudDB;
USE CrudDB;

CREATE TABLE Persona (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Edad INT NOT NULL
);

DELIMITER $$

CREATE PROCEDURE sp_GetPersonas()
BEGIN
    SELECT Id, Nombre, Apellido, Edad
    FROM Persona;
END$$

CREATE PROCEDURE sp_GetPersonaById(IN p_Id INT)
BEGIN
    SELECT Id, Nombre, Apellido, Edad
    FROM Persona
    WHERE Id = p_Id;
END$$

CREATE PROCEDURE sp_InsertPersona(
    IN p_Nombre VARCHAR(100),
    IN p_Apellido VARCHAR(100),
    IN p_Edad INT
)
BEGIN
    INSERT INTO Persona (Nombre, Apellido, Edad)
    VALUES (p_Nombre, p_Apellido, p_Edad);
END$$


CREATE PROCEDURE sp_UpdatePersona(
    IN p_Id INT,
    IN p_Nombre VARCHAR(100),
    IN p_Apellido VARCHAR(100),
    IN p_Edad INT
)
BEGIN
    UPDATE Persona
    SET Nombre = p_Nombre,
        Apellido = p_Apellido,
        Edad = p_Edad
    WHERE Id = p_Id;
END$$


CREATE PROCEDURE sp_DeletePersona(IN p_Id INT)
BEGIN
    DELETE FROM Persona
    WHERE Id = p_Id;
END$$

DELIMITER ;