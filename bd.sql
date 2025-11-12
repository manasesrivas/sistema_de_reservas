CREATE TABLE Cliente (
    Id_cliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL,
    Dui VARCHAR(20) NOT NULL
);


CREATE TABLE Usuario (
    Id_usuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Dui VARCHAR(20) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);

CREATE TABLE Salas (
    Id_salas INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Capacidad INT NOT NULL,
    Disponible BIT NOT NULL
);

CREATE TABLE Recursos (
    Id_recursos INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Tipo NVARCHAR(100) NOT NULL,
    Costo DECIMAL(10,2) NOT NULL,
    Cantidad DECIMAL(4,0)
);

CREATE TABLE Reservas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SalaId INT NOT NULL,
    ClienteId INT NOT NULL,
    FechaInicio DATETIME NOT NULL,
    FechaFin DATETIME NOT NULL,
    Tipo NVARCHAR(20) NOT NULL, -- 'Reserva' o 'Cita'
    Estado NVARCHAR(20) NOT NULL, -- 'Confirmada', 'Cancelada', etc.
    CONSTRAINT FK_Reservas_Sala FOREIGN KEY (SalaId) REFERENCES Salas(Id_salas),
    CONSTRAINT FK_Reservas_Cliente FOREIGN KEY (ClienteId) REFERENCES Cliente(Id_cliente)
);
GO


CREATE TABLE ReservaRecurso (
    ReservaId INT NOT NULL,
    RecursoId INT NOT NULL,
    PRIMARY KEY (ReservaId, RecursoId),
    CONSTRAINT FK_ReservaRecurso_Reserva FOREIGN KEY (ReservaId) REFERENCES Reservas(Id),
    CONSTRAINT FK_ReservaRecurso_Recurso FOREIGN KEY (RecursoId) REFERENCES Recursos(Id_recursos)
);
GO
