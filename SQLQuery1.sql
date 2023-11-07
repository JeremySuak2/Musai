use Servicios

CREATE TABLE Productos (
    IDProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    IDCategoria INT,
    FOREIGN KEY (IDCategoria) REFERENCES Categorias(IDCategoria)
);
CREATE TABLE Productos (
    IDProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(255) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    IDCategoria INT,
    Inventario INT NOT NULL, -- Nueva columna para el inventario
    FOREIGN KEY (IDCategoria) REFERENCES Categorias(IDCategoria)
);


