create database karaoke

use karaoke


CREATE TABLE Clientes (
    Id_cliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Telefono VARCHAR(10) NOT NULL,
    Dui VARCHAR(20) NOT NULL
);


CREATE TABLE Usuarios (
    Id_usuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
	Telefono VARCHAR(10) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Dui VARCHAR(20) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);

CREATE TABLE Salas (
    Id_sala INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Capacidad INT NOT NULL,
    Precio DECIMAL(3,1) NOT NULL,
    Disponible BIT NOT NULL
);

CREATE TABLE Recursos (
    Id_recurso INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Tipo NVARCHAR(100) NOT NULL,
    Costo DECIMAL(10,2) NOT NULL,
    Cantidad DECIMAL(4,0)
);

CREATE TABLE Reservas (
    Id_reserva INT PRIMARY KEY IDENTITY(1,1),
    SalaId INT NOT NULL,
    ClienteId INT NOT NULL,
    FechaReservado DATETIME NOT NULL,
    Estado NVARCHAR(20) NOT NULL, 
    CONSTRAINT FK_Reservas_Sala FOREIGN KEY (SalaId) REFERENCES Salas(Id_sala),
    CONSTRAINT FK_Reservas_Cliente FOREIGN KEY (ClienteId) REFERENCES Clientes(Id_cliente)
);
GO


CREATE TABLE ReservaRecurso (
    Id INT PRiMARY KEY IDENTITY(1,1),
    ReservaId INT NOT NULL,
    RecursoId INT NOT NULL,
    CONSTRAINT FK_ReservaRecurso_Reserva FOREIGN KEY (ReservaId) REFERENCES Reservas(Id_reserva),
    CONSTRAINT FK_ReservaRecurso_Recurso FOREIGN KEY (RecursoId) REFERENCES Recursos(Id_recurso)
);
GO

-- para agregar un super usuario    
