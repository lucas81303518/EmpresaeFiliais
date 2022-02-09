create database Empresas;
use Empresas;

create table Empresa(
idEmpresa int auto_increment primary key,
CNPJ varchar(45) not null,
Situacao varchar(45) not null,
NomeFantasia varchar(45) not null,
Telefone varchar(45) not null,
Capital float not null,
Cep varchar(45) not null,
UF varchar(45) not null,
Cidade varchar(45) not null,
Rua varchar(45) not null,
Numero varchar(45)not null
);
create table Filial(
idFilial int auto_increment primary key,
CNPJ varchar(45) not null,
Situacao varchar(45) not null,
NomeFantasia varchar(45) not null,
Telefone varchar(45) not null,
Capital float not null,
Cep varchar(45) not null,
UF varchar(45) not null,
Cidade varchar(45) not null,
Rua varchar(45) not null,
Numero varchar(45)not null,
FK_EmpresaId int not null,
foreign key (FK_EmpresaId) references Empresa(idEmpresa) 
);
