create database CONJUNTO
default character set utf8
default collate utf8_general_ci;

create table CONDOMINIO (
	id int not null auto_increment,
	nome varchar(30) not null,
	bairro varchar(50)
);

create table FAMILIA (
	id int not null auto_increment,
	nome varchar(30) not null,
	id_Condominio int,
	apto int
);

create table MORADOR (
	id int not null auto_increment,
	id_Familia int,
	nome varchar(30) not null,
	quantidadeBichosEstimacao int
);