create database loja;

use loja;

create table usuarios(
  coduser int not null primary key auto_increment,
  usuario varchar(100) not null unique,
  senha varchar(100) not null,
  email varchar(255) not null);

create table paises(
  codpais int not null primary key auto_increment,
  pais varchar(100) not null,
  sigla varchar(6) not null,
  ddi varchar(6) not null,
  datacad date not null,
  dataultalt date not null,
  coduserultalt int not null,
  constraint FK_Paises foreign key (coduserultalt) references usuarios(coduser));

create table estados(
  codestado int not null primary key auto_increment,
  estado varchar(100) not null,
  uf varchar(6) not null,
  codpais int not null,
  datacad date not null,
  dataultalt date not null,
  coduserultalt int not null,
  constraint FK_CodUserEstados foreign key (coduserultalt) references usuarios(coduser),
  constraint FK_CodPaisEstados foreign key (codpais) references paises(codpais));

create table cidades(
  codcidade int not null primary key auto_increment,
  cidade varchar(100) not null,
  ddd varchar(6) not null,
  codestado int not null,
  datacad date not null,
  dataultalt date not null,
  coduserultalt int not null,
  constraint FK_CodUserCidades foreign key (coduserultalt) references usuarios(coduser),
  constraint FK_CodEstadoCidades foreign key (codestado) references Estados(codestado));