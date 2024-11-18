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

INSERT INTO socio (nombre, apellido, documento, fecha_nacimiento, genero, email, fechaCobro)
VALUES 
('Juan', 'Pérez', '12345678', '1985-07-15', 'Masculino', 'juan.perez@example.com', '2024-11-01'),
('María', 'González', '87654321', '1990-05-20', 'Femenino', 'maria.gonzalez@example.com', '2024-11-10'),
('Carlos', 'López', '11223344', '1988-03-30', 'Masculino', 'carlos.lopez@example.com', '2024-11-15'),
('Laura', 'Martínez', '55667788', '1995-12-10', 'Femenino', 'laura.martinez@example.com', '2024-11-20'),
('Ana', 'Rodríguez', '99887766', '2000-01-25', 'Femenino', 'ana.rodriguez@example.com', '2024-12-01');


SELECT * FROM socio;


-- Crear la tabla actividades
CREATE TABLE actividades (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre_actividad VARCHAR(100) NOT NULL,
    horario_actividad TIME NOT NULL,
    cupo INT NOT NULL CHECK (cupo <= 15),
    dni_inscritos TEXT -- Almacena DNIs inscritos como una lista separada por comas
);

-- Insertar ejemplo de actividad
INSERT INTO actividades (nombre_actividad, horario_actividad, cupo, dni_inscritos) 
VALUES ('Fútbol', '18:00:00', 15, '');

INSERT INTO actividades (nombre_actividad, horario_actividad, cupo, dni_inscritos) 
VALUES ('Basquet', '19:00:00', 15, '');

