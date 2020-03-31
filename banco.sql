create database dbbanco;
use dbbanco;

create table tb_conta(
cd_banco varchar(50) not null,
nm_banco varchar(100) not null,
cd_agencia varchar (50) not null,
nm_agencia varchar(100) not null,
cd_contacorrente varchar(45)not null,
nm_titular varchar(50) not null,
cd_cpf char(15) not null,
cd_saldo varchar(100)not null);

create table tb_movimenta(
cd_lancamento varchar(50) not null,
dt_lancamento varchar(11)not null,
nm_historico varchar(100),
ic_dc char(1),
vl_movimenta varchar(50) not null,
CONSTRAINT pk_lancamento,
PRIMARY KEY (cd_lancamento)

);


select * from tb_conta;

drop table tb_conta;