-- Eliminar la base de datos si ya existe y crearla de nuevo
DROP DATABASE IF EXISTS clubdeportivo;
CREATE DATABASE clubdeportivo;
USE clubdeportivo;

-- Eliminar la tabla usuario si ya existe
DROP TABLE IF EXISTS usuario;

-- Crear la tabla usuario con id autoincremental
CREATE TABLE usuario (
    id BIGINT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

-- Insertar el usuario 'admin' con la contraseña '1234'
INSERT INTO usuario (username, password) VALUES ('admin', '1234');

ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY '060966';
FLUSH PRIVILEGES;

CREATE TABLE socio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    documento VARCHAR(20) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    genero VARCHAR(10) NOT NULL,
    email VARCHAR(100) NOT NULL,
    fechaCobro DATE NOT NULL
);



SELECT * FROM socio;

