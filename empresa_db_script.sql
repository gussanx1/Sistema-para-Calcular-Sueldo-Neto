
-- Crear la base de datos
CREATE DATABASE Empresa;

-- Usar la base de datos creada
USE Empresa;

-- Crear la tabla Trabajador
CREATE TABLE Trabajador (
    Categoria VARCHAR(3) NOT NULL,      -- Código de la categoría (Adm, Ope, Obr)
    Basico FLOAT NOT NULL,             -- Sueldo básico del trabajador
    Descripcion VARCHAR(20) NOT NULL,  -- Descripción de la categoría
    PRIMARY KEY (Categoria)
);

-- Insertar datos iniciales en la tabla Trabajador
INSERT INTO Trabajador (Categoria, Basico, Descripcion) VALUES
('Adm', 5000, 'Administrativo'),
('Ope', 3000, 'Operario'),
('Obr', 2000, 'Obrero');

-- Crear una tabla adicional para registrar cálculos de sueldos
CREATE TABLE CalculoSueldo (
    ID INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único para cada cálculo
    Categoria VARCHAR(3) NOT NULL,    -- Relación con la categoría del trabajador
    AFP FLOAT NOT NULL,               -- Descuento por AFP
    QuintaCategoria FLOAT NOT NULL,   -- Descuento por 5ta categoría
    Productividad FLOAT NOT NULL,     -- Incremento por productividad
    CargaSocial FLOAT NOT NULL,       -- Incremento por carga social
    SueldoNeto FLOAT NOT NULL,        -- Sueldo neto calculado
    FechaCalculo DATETIME DEFAULT GETDATE(), -- Fecha del cálculo
    FOREIGN KEY (Categoria) REFERENCES Trabajador(Categoria)
);

-- Insertar datos de cálculo de sueldos en la tabla CalculoSueldo
INSERT INTO CalculoSueldo (Categoria, AFP, QuintaCategoria, Productividad, CargaSocial, SueldoNeto)
VALUES 
('Adm', 650, 500, 400, 250, (5000 - 650 - 500 + 400 + 250)),
('Ope', 300, 240, 180, 90, (3000 - 300 - 240 + 180 + 90)),
('Obr', 140, 80, 80, 40, (2000 - 140 - 80 + 80 + 40));
