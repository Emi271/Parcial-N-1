CREATE TABLE Productos_Lacteos (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_Lacteos (Nombre, Precio, Stock) VALUES
('Leche Entera Ilolay 1L', 2200, 50),
('Leche Entera Milkaout 1L', 1950 50),
('Leche Entera Apostoles', 1700, 50),
('Leche Entera 7 vidas', 1750, 50),
('Leche Entera La familia', 1400, 50),
('Queso Cremoso 250g', 2.80, 20),
('Manteca 200g', 1.90, 25),
('Crema de Leche 300ml', 2.10, 15);
('Dulce de lece', 2.10, 15);
('Crema de Leche 300ml', 2.10, 15);
('Crema de Leche 300ml', 2.10, 15);
('Crema de Leche 300ml', 2.10, 15);
('Crema de Leche 300ml', 2.10, 15);




CREATE TABLE Productos_Alimentos (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_Alimentos (Nombre, Precio, Stock) VALUES
('Fideos  Sol Pampeano Tallarin', 800, 50),
('Fideos  Sol Pampeano Spaggeti', 800, 50),
('Fideos  Sol Pampeano Tirabuzon', 800, 50),
('Fideos  Sol Pampeano Dedal', 800, 50),
('Fideos  Sol Pampeano Codo', 800, 50),
('Fideos  Sol Pampeano Mostachol', 800, 50),
('Arroz Maximo 1kg', 1900, 50),
('Molinos ALA', 2500, 20),
('Aceite natura 900ML', 2300, 25),
('Cocinero 900ml', 2700, 15);
('Sal fina Celusal 500g', 1290, 15);



CREATE TABLE Productos_Bebidas (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);



INSERT INTO Productos_Bebidas (Nombre, Precio, Stock) VALUES
('Gaseosa Secco 3L', 2000, 50),
('Gaseosa Manaos 3L', 3000, 50),
('Gaseosa Baggio 2.25l',1400, 50),
('Sprite 1.75L', 3400, 50),


CREATE TABLE Productos_Bebidas (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);



INSERT INTO Productos_Bebidas (Nombre, Precio, Stock) VALUES
('Gaseosa Secco 3L', 2000, 50),
('Gaseosa Manaos 3L', 3000, 50),
('Gaseosa Baggio 2.25l',1400, 50),
('Sprite 1.75L', 3400, 50),


CREATE TABLE Productos_BebidasAlcoholicas (
    ID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);



INSERT INTO Productos_BebidasAlcoholicas (Nombre, Precio, Stock) VALUES
('Vino tinto Gaul', 2100, 50),
('Cerveza Brahma 1L', 3000, 50),
('Gancia 450ml',2600, 50),
('Vino BLanco Estancia Mendoza', 2400, 50),




