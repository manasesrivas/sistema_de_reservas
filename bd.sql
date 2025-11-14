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
    Correo NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Dui VARCHAR(20) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);

CREATE TABLE Salas (
    Id_sala INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Capacidad INT NOT NULL,
    Precio DECIMAL() NOT NULL,
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
    FechaRealizado DATETIME NOT NULL,
    Estado NVARCHAR(20) NOT NULL, 
    CONSTRAINT FK_Reservas_Sala FOREIGN KEY (SalaId) REFERENCES Salas(Id_salas),
    CONSTRAINT FK_Reservas_Cliente FOREIGN KEY (ClienteId) REFERENCES Cliente(Id_cliente)
);
GO


CREATE TABLE ReservaRecurso (
    Id INT PRYMARY KEY IDENTITY(1,1),
    ReservaId INT NOT NULL,
    RecursoId INT NOT NULL,
    PRIMARY KEY (ReservaId, RecursoId),
    CONSTRAINT FK_ReservaRecurso_Reserva FOREIGN KEY (ReservaId) REFERENCES Reservas(Id),
    CONSTRAINT FK_ReservaRecurso_Recurso FOREIGN KEY (RecursoId) REFERENCES Recursos(Id_recursos)
);
GO
