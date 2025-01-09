---- PROCESO DE CREACIÓN DE BASE DE DATOS Y TABLAS
-- Crear Base de Datos
CREATE DATABASE MiniCoreGastos

-- Usar la Base de Datos adecuada
USE MiniCoreGastos

-- Crear Tabla 'Empleado'
CREATE TABLE Empleado (
	empleadoID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	empleadoNombre NVARCHAR(50) NOT NULL
);

-- Crear Tabla 'Departamento'
CREATE TABLE Departamento (
	departamentoID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	departamentoNombre NVARCHAR(50) NOT NULL
);

-- Crear Tabla 'Gasto'
CREATE TABLE Gasto (
	gastoID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	gastoFecha DATE NOT NULL,
	gastoDescripcion NVARCHAR(100),
	gastoMonto DECIMAL (10,2) NOT NULL,
	gastoEmpleadoID INT FOREIGN KEY REFERENCES Empleado(empleadoID),
	gastoDepartamentoID INT FOREIGN KEY REFERENCES Departamento(departamentoID)
);

----INSERCIÓN DE REGISTROS EN LAS TABLAS CREADAS
-- Insertar Registros en la tabla 'Empleado'
INSERT INTO Empleado (empleadoNombre) VALUES
('Claire Redfield'),
('Barry Burton'),
('Jill Valentine'),
('Carlos Oliveira'),
('Sherry Birkin');

-- Insertar Registros en la tabla 'Departamento'
INSERT INTO Departamento (departamentoNombre) VALUES
('IT'),
('Desarrollo'),
('Diseño'),
('Marketing'),
('Recursos Humanos'),
('Finanzas'),
('Ventas'),
('Atención al Cliente'),
('Logística'),
('Administración');

-- Insertar Registros en la tabla 'Gasto'
INSERT INTO Gasto (gastoFecha, gastoDescripcion, gastoMonto, gastoEmpleadoID, gastoDepartamentoID) VALUES
('2023-01-15', 'Monitor Secundario', 250.50, 1, 2),
('2023-02-10', 'Silla Ergonómica', 180.00, 2, 4),
('2023-03-05', 'Mouse Inalámbrico', 35.75, 3, 1),
('2023-03-15', 'Teclado Mecánico', 120.00, 4, 2),
('2023-04-01', 'Cable HDMI', 15.00, 5, 1),
('2023-05-20', 'UPS', 300.00, 1, 3),
('2023-06-18', 'Rollup Publicitario', 200.00, 2, 4),
('2023-07-22', 'Tarjetas de Presentación', 75.00, 3, 5),
('2023-08-10', 'Cámara de Seguridad', 450.00, 4, 6),
('2023-09-15', 'Auriculares', 80.00, 5, 2),
('2023-10-03', 'Laptop', 1200.00, 1, 1),
('2023-11-12', 'Mesa de Reuniones', 600.00, 2, 9),
('2023-12-05', 'Impresora Láser', 250.00, 3, 6),
('2024-01-18', 'Software de Diseño', 500.00, 4, 3),
('2024-02-14', 'Toner de Impresora', 80.00, 5, 6),
('2024-03-08', 'Publicidad en Redes Sociales', 300.00, 1, 4),
('2024-04-22', 'Papelería', 50.00, 2, 9),
('2024-05-15', 'Servidor Dedicado', 2000.00, 3, 1),
('2024-06-01', 'Mesa de Trabajo', 150.00, 4, 8),
('2024-07-10', 'Proyector', 700.00, 5, 3),
('2024-08-05', 'Cafetera', 120.00, 1, 9),
('2024-08-18', 'Escritorio', 250.00, 2, 10),
('2024-09-10', 'Software de Gestión', 1500.00, 3, 7),
('2024-09-25', 'Cable de Red', 20.00, 4, 1),
('2024-10-02', 'Lámparas de Oficina', 80.00, 5, 9),
('2024-10-10', 'Refrigerador', 400.00, 1, 10),
('2024-10-15', 'Router', 100.00, 2, 1),
('2024-10-20', 'Micrófono', 70.00, 3, 2),
('2024-10-25', 'Pantalla LED', 900.00, 4, 3),
('2024-10-30', 'Material de Limpieza', 30.00, 5, 9);

---- COMPROBAR INSERCIÓN
SELECT * FROM Empleado
SELECT * FROM Departamento
SELECT * FROM Gasto