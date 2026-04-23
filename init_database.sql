-- Crear base de datos
CREATE DATABASE IF NOT EXISTS stock_db;
USE stock_db;

-- Tabla de géneros
CREATE TABLE IF NOT EXISTS genero (
    id INT PRIMARY KEY AUTO_INCREMENT,
    descripcion VARCHAR(100) NOT NULL UNIQUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla de tipos de teléfono
CREATE TABLE IF NOT EXISTS tipo_telefono (
    id INT PRIMARY KEY AUTO_INCREMENT,
    descripcion VARCHAR(100) NOT NULL UNIQUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Tabla de proveedores
CREATE TABLE IF NOT EXISTS proveedores (
    idProveedor INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(150) NOT NULL,
    email VARCHAR(150) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    direcccion VARCHAR(255) NOT NULL,
    fechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_nombre (nombre)
);

-- Tabla de productos
CREATE TABLE IF NOT EXISTS productos (
    idProducto INT PRIMARY KEY AUTO_INCREMENT,
    nombreProducto VARCHAR(150) NOT NULL,
    descripcionProducto VARCHAR(500),
    precio DECIMAL(10, 2) NOT NULL CHECK (precio > 0),
    stock INT DEFAULT 0,
    idProveedor INT NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (idProveedor) REFERENCES proveedores(idProveedor) ON DELETE RESTRICT,
    INDEX idx_nombre (nombreProducto),
    INDEX idx_proveedor (idProveedor)
);

-- Tabla de clientes
CREATE TABLE IF NOT EXISTS clientes (
    idCliente INT PRIMARY KEY AUTO_INCREMENT,
    nombreCliente VARCHAR(100) NOT NULL,
    apellidoCliente VARCHAR(100) NOT NULL,
    numDocumento VARCHAR(20) NOT NULL UNIQUE,
    emailCliente VARCHAR(150) NOT NULL,
    telefonoCliente VARCHAR(20) NOT NULL,
    direccionCliente VARCHAR(255) NOT NULL,
    idGenero INT,
    idTipoTelefono INT,
    fechaRegistroCliente DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (idGenero) REFERENCES genero(id) ON DELETE RESTRICT,
    FOREIGN KEY (idTipoTelefono) REFERENCES tipo_telefono(id) ON DELETE RESTRICT,
    INDEX idx_nombre (nombreCliente),
    INDEX idx_documento (numDocumento),
    INDEX idx_genero (idGenero),
    INDEX idx_tipo_telefono (idTipoTelefono)
);

-- Tabla de compras
CREATE TABLE IF NOT EXISTS compras (
    idCompra INT PRIMARY KEY AUTO_INCREMENT,
    idProveedor INT NOT NULL,
    fechaCompra DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(15, 2) DEFAULT 0,
    FOREIGN KEY (idProveedor) REFERENCES proveedores(idProveedor) ON DELETE RESTRICT,
    INDEX idx_fecha (fechaCompra),
    INDEX idx_proveedor (idProveedor)
);

-- Tabla de detalles de compra
CREATE TABLE IF NOT EXISTS detalles_compra (
    detalleCompra INT PRIMARY KEY AUTO_INCREMENT,
    idCompra INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precioUnitario DECIMAL(10, 2) NOT NULL CHECK (precioUnitario > 0),
    subTotal DECIMAL(15, 2) GENERATED ALWAYS AS (cantidad * precioUnitario) STORED,
    FOREIGN KEY (idCompra) REFERENCES compras(idCompra) ON DELETE CASCADE,
    FOREIGN KEY (idProducto) REFERENCES productos(idProducto) ON DELETE RESTRICT,
    INDEX idx_compra (idCompra),
    INDEX idx_producto (idProducto)
);

-- Tabla de ventas
CREATE TABLE IF NOT EXISTS ventas (
    idVenta INT PRIMARY KEY AUTO_INCREMENT,
    idCliente INT NOT NULL,
    fechaVenta DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(15, 2) DEFAULT 0,
    formaPago VARCHAR(50),
    FOREIGN KEY (idCliente) REFERENCES clientes(idCliente) ON DELETE RESTRICT,
    INDEX idx_fecha (fechaVenta),
    INDEX idx_cliente (idCliente)
);

-- Tabla de detalles de venta
CREATE TABLE IF NOT EXISTS detalles_venta (
    idDetalleVenta INT PRIMARY KEY AUTO_INCREMENT,
    idVenta INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precioUnitario DECIMAL(10, 2) NOT NULL CHECK (precioUnitario > 0),
    subTotal DECIMAL(15, 2) GENERATED ALWAYS AS (cantidad * precioUnitario) STORED,
    FOREIGN KEY (idVenta) REFERENCES ventas(idVenta) ON DELETE CASCADE,
    FOREIGN KEY (idProducto) REFERENCES productos(idProducto) ON DELETE RESTRICT,
    INDEX idx_venta (idVenta),
    INDEX idx_producto (idProducto)
);

-- Insertar datos iniciales en géneros
INSERT INTO genero (descripcion) VALUES 
('Masculino'),
('Femenino'),
('Otro');

-- Insertar datos iniciales en tipos de teléfono
INSERT INTO tipo_telefono (descripcion) VALUES 
('Particular'),
('Laboral'),
('Casa'),
('Celular');

-- Crear índices adicionales para optimización
CREATE INDEX idx_clientes_genero ON clientes(idGenero);
CREATE INDEX idx_clientes_tipo_telefono ON clientes(idTipoTelefono);
CREATE INDEX idx_productos_proveedor ON productos(idProveedor);
CREATE INDEX idx_compras_proveedor ON compras(idProveedor);
CREATE INDEX idx_detalles_compra_compra ON detalles_compra(idCompra);
CREATE INDEX idx_detalles_compra_producto ON detalles_compra(idProducto);
CREATE INDEX idx_ventas_cliente ON ventas(idCliente);
CREATE INDEX idx_detalles_venta_venta ON detalles_venta(idVenta);
CREATE INDEX idx_detalles_venta_producto ON detalles_venta(idProducto);

-- Comentarios de tablas para documentación
ALTER TABLE genero COMMENT = 'Catálogo de géneros para clientes';
ALTER TABLE tipo_telefono COMMENT = 'Catálogo de tipos de teléfono';
ALTER TABLE proveedores COMMENT = 'Registro de proveedores';
ALTER TABLE productos COMMENT = 'Catálogo de productos con control de stock';
ALTER TABLE clientes COMMENT = 'Registro de clientes';
ALTER TABLE compras COMMENT = 'Cabecera de compras a proveedores';
ALTER TABLE detalles_compra COMMENT = 'Líneas de detalle de compras';
ALTER TABLE ventas COMMENT = 'Cabecera de ventas a clientes';
ALTER TABLE detalles_venta COMMENT = 'Líneas de detalle de ventas';
