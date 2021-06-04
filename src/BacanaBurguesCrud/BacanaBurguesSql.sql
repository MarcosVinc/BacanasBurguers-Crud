 CREATE DATABASE BacanasBurgues; 
 GO
 use BacanasBurgues
 GO
 CREATE TABLE Produtos (
     Identificador varchar(255) PRIMARY KEY,
     Nome varchar(255),
     Tipo varchar(255),    
     Preco decimal(19,2), 
	 lucro int,
	 Quantidade int );
GO
use BacanasBurgues
GO
 CREATE TABLE Usuario (
     Identificador varchar(255) PRIMARY KEY,
     Logim varchar(255),
     Senha varchar(255),    
 );
GO
use BacanasBurgues
GO
CREATE TABLE Cliente (
	Identificador varchar(255) PRIMARY KEY,
	Nome varchar(255),
	Endereco varchar(255),
	Telefone varchar(255),
	Cep int);
GO
use BacanasBurgues
GO
CREATE TABLE TelefonesUteis (
	Identificador varchar(255) PRIMARY KEY,
	Nome varchar(255),
	Telefone varchar(255),);
GO



