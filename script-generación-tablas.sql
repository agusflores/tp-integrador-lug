CREATE DATABASE TrabajoIntegradorLUG;

USE TrabajoIntegradorLUG; 

CREATE TABLE Vehiculos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Marca NVARCHAR(50) NOT NULL,
    Modelo NVARCHAR(50) NOT NULL,
    Anio INT NOT NULL,
    Kilometraje INT NOT NULL,
    Precio DECIMAL(18, 2) NOT NULL,
    Patente NVARCHAR(10) NOT NULL UNIQUE
);
GO

CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    DNI NVARCHAR(8) NOT NULL UNIQUE,
    Telefono NVARCHAR(15) NULL,
    Email NVARCHAR(100) NULL
);
GO

CREATE TABLE Ventas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdVehiculo INT NOT NULL,
    IdCliente INT NOT NULL,
    FechaVenta DATETIME NOT NULL,
    PrecioFinal DECIMAL(18, 2) NOT NULL,
    Observacion NVARCHAR(255) NULL,
    CONSTRAINT FK_Ventas_Vehiculos FOREIGN KEY (IdVehiculo) REFERENCES Vehiculos(Id),
    CONSTRAINT FK_Ventas_Clientes FOREIGN KEY (IdCliente) REFERENCES Clientes(Id)
);
GO