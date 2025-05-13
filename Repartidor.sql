CREATE DATABASE Repartidores
GO

USE Repartidores
GO


CREATE TABLE Repartidores (
    PersonaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    Celular VARCHAR(20),
    Localidad VARCHAR(100),
    TipoDeVehiculo VARCHAR(50)
);

INSERT INTO Repartidores (Nombre, Apellido, Email, Celular, Localidad, TipoDeVehiculo)
VALUES 
('Carlos', 'Gómez', 'carlos.gomez@example.com', '1123456789', 'Buenos Aires', 'Auto'),
('Lucía', 'Martínez', 'lucia.martinez@example.com', '1134567890', 'Rosario', 'Bicicleta'),
('Juan', 'Pérez', 'juan.perez@example.com', '1145678901', 'Córdoba', 'Auto'),
('Sofía', 'López', 'sofia.lopez@example.com', '1156789012', 'Mendoza', 'Moto'),
('Diego', 'Ramírez', 'diego.ramirez@example.com', '1167890123', 'La Plata', 'Camioneta');
