CREATE DATABASE biblioteca;
USE biblioteca;

CREATE TABLE Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Idade INT NOT NULL
);

CREATE TABLE Livros (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Titulo VARCHAR(150) NOT NULL,
    Autor VARCHAR(100) NOT NULL,
    Ano INT NOT NULL
);

CREATE TABLE Emprestimos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    IdUsuario INT NOT NULL,
    IdLivro INT NOT NULL,
    DataEmprestimo DATETIME NOT NULL,
    DataDevolucao DATETIME,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id),
    FOREIGN KEY (IdLivro) REFERENCES Livros(Id)
);

INSERT INTO Usuarios (Nome, Idade) VALUES ('Gustavo Druzian', 22);
INSERT INTO Livros (Titulo, Autor, Ano) VALUES ('Dom Casmurro', 'Machado de Assis', 1899);