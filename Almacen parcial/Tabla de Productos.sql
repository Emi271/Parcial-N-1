CREATE DATABASE MenuAlimentos;
GO

USE  MenuAlimentos;
GO

CREATE TABLE Productos_Lacteos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_Lacteos (Nombre, Precio, Stock) VALUES
('Leche Entera Ilolay 1L', 2200.00, 50),
('Leche Entera Milkaout 1L', 1950.00, 50),
('Leche Entera Apostoles', 1700.00, 50),
('Leche Entera 7 vidas', 1750.00, 50),
('Leche Entera La familia', 1400.00, 50),
('Queso Cremoso 250g', 2800.00, 20),
('Manteca La Familia 200g', 1900.00, 25),
('Crema de Leche La Familia 200ml', 2100.00, 15),
('Dulce de leche Tonadita 400g', 2100.00, 15),
('Dulce de leche Milkaut 400g', 2600.00, 15),
('Dulce de leche La Paulina 400g', 3200.00, 15);


CREATE TABLE Productos_Alimentos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_Alimentos (Nombre, Precio, Stock) VALUES
('Fideos  Sol Pampeano Tallarin', 800.00, 50),
('Fideos  Sol Pampeano Spaggeti', 800.00, 50),
('Fideos  Sol Pampeano Tirabuzon', 800.00, 50),
('Fideos  Sol Pampeano Dedal', 800.00, 50),
('Fideos  Sol Pampeano Codo', 800.00, 50),
('Fideos  Sol Pampeano Mostachol', 800.00, 50),
('Arroz Maximo 1kg', 1900.00, 50),
('Molinos ALA', 2500.00, 20),
('Aceite natura 900ML', 2300.00, 25),
('Cocinero 900ml', 2700.00, 15),
('Sal fina Celusal 500g', 1290.00, 15),
('Pure de Tomate Mora 520g', 730.00, 25),
('Pure de Tomate INCAA 520g', 1000.00, 25),
('Mayonesa Hellmans 500ml', 2850.00, 30),
('Mayonesa Hellmans 250ml', 1450.00, 50),
('Mayonesa CadaDia 250ml', 950.00, 25),
('Yerba Union 500g', 2200.00, 15),
('Yerba Chamigo 500g', 1900.00, 15),
('Yerba Amanda 500g', 2350.00, 15),
('Yerba Rosamonte 500g', 2100.00, 15),
('Yerba Mañanita 500g', 2200.00, 15),
('Yerba Taragui 500g', 2200.00, 15),
('Harina Leudante Morixe 1kg', 1200.00, 20),
('Harina Leudante Pureza 1kg', 1650.00, 15),
('Azucar Comun Doña Ines 1kg', 1100.00, 35),
('Polenta S&P 500g', 750.00, 40),
('Chocolatada en polvo Nesquik 360g', 3400.00, 25),
('Chocolatada en polvo Chocolino 180g', 1800.00, 35);

CREATE TABLE Productos_Bebidas (
    ID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_Bebidas (Nombre, Precio, Stock) VALUES
('Gaseosa Secco 3L', 2000.00, 50),
('Gaseosa Manaos 3L', 3000.00, 50),
('Gaseosa Baggio 2.25l', 1400.00, 50),
('Sprite 1.75L', 3400.00, 50),
('Jugo de Uva Brio Villa del Sur', 950.00, 35),
('Jugo de Naranja Brio Villa del Sur 1.75l', 920.00, 60),
('Jugo de Pomelo Brio Villa del Sur 1.75l', 920.00, 60),
('Jugo Multifruta Brio Villa del Sur 1.75l', 920.00, 60);

CREATE TABLE Productos_BebidasAlcoholicas (
    ID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(6,2) NOT NULL,
    Stock INT NOT NULL
);

INSERT INTO Productos_BebidasAlcoholicas (Nombre, Precio, Stock) VALUES
('Vino tinto Gual 1l', 2100.00, 50),
('Cerveza Brahma 1L', 3000.00, 50),
('Aperitivo Gancia Americano 450ml', 2600.00, 50),
('Vino BLanco Estancia Mendoza', 2400.00, 50);