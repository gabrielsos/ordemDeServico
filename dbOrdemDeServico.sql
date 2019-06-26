DROP DATABASE IF EXISTS sistemaos;

create database sistemaos;
use sistemaos;
create table hardware(
	cd_hard int,
	nm_hard varchar(50),
	constraint pk_hardware primary key (cd_hard)
);
insert into hardware(cd_hard, nm_hard) values (1, "Placa Mae");
insert into hardware(cd_hard, nm_hard) values (2, "Processador");
insert into hardware(cd_hard, nm_hard) values (3, "Memoria");
insert into hardware(cd_hard, nm_hard) values (4, "Placa de Video");
insert into hardware(cd_hard, nm_hard) values (5, "Placa de Rede");
insert into hardware(cd_hard, nm_hard) values (6, "Fonte");
insert into hardware(cd_hard, nm_hard) values (7, "Cooler");
select * from hardware;

create table modelo(
	cd_modelo int,
	nm_modelo varchar(50),
	nm_foto blob,
	constraint pk_modelo primary key (cd_modelo)
);
insert into modelo(cd_modelo, nm_modelo) values (1, "HP");
insert into modelo(cd_modelo, nm_modelo) values (2, "Lenovo");
insert into modelo(cd_modelo, nm_modelo) values (3, "Hitachi");
insert into modelo(cd_modelo, nm_modelo) values (4, "EPSON");
insert into modelo(cd_modelo, nm_modelo) values (5, "Benq");
insert into modelo(cd_modelo, nm_modelo, nm_foto) values (6, "Positivo", null);
select * from modelo;

create table local(
	cd_local int,
	nm_local varchar(45),
	constraint pk_local primary key (cd_local)
);
insert into local(cd_local, nm_local) values (1, "INFO01");
insert into local(cd_local, nm_local) values (2, "INFO02");
insert into local(cd_local, nm_local) values (3, "INFO03");
insert into local(cd_local, nm_local) values (4, "INFO04");
insert into local(cd_local, nm_local) values (5, "INFO05");
insert into local(cd_local, nm_local) values (6, "INFO06");
insert into local(cd_local, nm_local) values (7, "INFO07");
insert into local(cd_local, nm_local) values (8, "INFO MEC");
insert into local(cd_local, nm_local) values (9, "EDIF02");
insert into local(cd_local, nm_local) values (10, "EDIF03");
insert into local(cd_local, nm_local) values (11, "EDIF04");
insert into local(cd_local, nm_local) values (12, "LAB08");
insert into local(cd_local, nm_local) values (13, "LAB D");
insert into local(cd_local, nm_local) values (14, "LAB F");
insert into local(cd_local, nm_local) values (15, "SECRETARIA");
insert into local(cd_local, nm_local) values (16, "COORDENACAO");
insert into local(cd_local, nm_local) values (17, "SECRETARIA DE SERVIÇOS");
insert into local(cd_local, nm_local) values (18, "CPD");
insert into local(cd_local, nm_local) values (19, "DEPOSITO");
select * from local;

create table tipo_equipamento(
	cd_tipo_equipamento int,
	nm_tipo_equipamento varchar(45),
	constraint pk_tipo_equipamento primary key (cd_tipo_equipamento)
);
insert into tipo_equipamento(cd_tipo_equipamento, nm_tipo_equipamento) values (1, "NoteBook");
insert into tipo_equipamento(cd_tipo_equipamento, nm_tipo_equipamento) values (2, "Computador");
insert into tipo_equipamento(cd_tipo_equipamento, nm_tipo_equipamento) values (3, "DataShow");
insert into tipo_equipamento(cd_tipo_equipamento, nm_tipo_equipamento) values (4, "Impressora");
insert into tipo_equipamento(cd_tipo_equipamento, nm_tipo_equipamento) values (5, "Periferico");
select * from tipo_equipamento;

create table solicitante(
	cd_solicitante int,
	nm_solicitante varchar(45),
	nm_email varchar(50),
	constraint pk_solicitante primary key (cd_solicitante)
);
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (1, "Debora", "debora@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (2, "Maristela", "maristela@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (3, "Freddy", "proffreddy@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (4, "Luiz Tavares", "tavares@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (5, "Balula", "balula@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (6, "Adilson", "adilson@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (7, "Carla", "carla@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (8, "Yara", "yara@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (9, "Rosa", "rosa@etec.sp.gov.br");
insert into solicitante(cd_solicitante, nm_solicitante, nm_email) values (10, "CPD", "cpdetecaf@gmail.com");
select * from solicitante;

create table tipo_os(
	cd_tipo int,
	nm_tipo varchar(45),
	constraint pk_tipo_os primary key (cd_tipo)
);
insert into tipo_os(cd_tipo, nm_tipo) values (1, "Instalacao");
insert into tipo_os(cd_tipo, nm_tipo) values (2, "Servico");
insert into tipo_os(cd_tipo, nm_tipo) values (3, "Manutencao");
select * from tipo_os;

create table situacao_os(
	cd_situacao int,
	nm_situacao varchar(45),
	constraint pk_situacao_os primary key (cd_situacao)
);
insert into situacao_os(cd_situacao, nm_situacao) values (1, "Aberto");
insert into situacao_os(cd_situacao, nm_situacao) values (2, "Finalizado");
insert into situacao_os(cd_situacao, nm_situacao) values (3, "Aguardando Peça");
select * from situacao_os;

create table usuario(
	nm_login varchar(20),
	nm_usuario varchar(100),
    nm_senha varchar(64),
	constraint pk_usuario primary key (nm_login)
);
insert into usuario values ("Freddy", "Freddy", md5('123'));
insert into usuario  values ("Saulo","Saulo", md5('123'));
insert into usuario  values ("Thiago","Thiago", md5('123'));
insert into usuario  values ("Roberto", "Roberto", md5('123'));
insert into usuario values ("Alexander","Alexander", md5('123'));
insert into usuario  values ("Gabriel","Gabriel", md5('123'));
select * from usuario;

create table equipamento(
	cd_serial int,
	ic_ativo boolean,
	ds_patrimonio varchar(45),
	nm_apelido varchar(45),
	cd_modelo int,
	cd_local int,
	cd_tipo_equipamento int,
	constraint pk_equipamento primary key (cd_serial),
	constraint fk_equipamento_modelo foreign key (cd_modelo) references modelo(cd_modelo),
	constraint fk_equipamento_local foreign key (cd_local) references local(cd_local),
	constraint fk_equipamento_tipo_equipamento foreign key (cd_tipo_equipamento) references tipo_equipamento(cd_tipo_equipamento)
);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (111, true, "1111111", "PC01 INFO05", 1, 5, 2);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (222, true, "2222222", "IMPRESSORA", 2, 16, 4);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (333, false, "3333333", "PC08 SALA15", 1, 19, 2);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (444, false, "4444444", "PC LUCIANA", 6, 19, 2);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (555, true, "5555555", "PC LUCIANA", 6, 17, 2);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (666, true, "6666666", "NOTE01", 6, 18, 1);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (777, true, "7777777", "NOTE02", 6, 18, 1);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (888, true, "8888888", "NOTE03", 6, 18, 1);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (999, true, "9999999", "DATASHOW01", 5, 18, 3);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (101010, true, "10101010", "DATASHOW02", 5, 18, 3);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (111111, true, "12121212", "PC03 EDIF02", 1, 9, 1);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (121212, true, "13131313", "ESTABILIZADOR", 4, 15, 5);
insert into equipamento(cd_serial, ic_ativo, ds_patrimonio, nm_apelido, cd_modelo, cd_local, cd_tipo_equipamento) values (131313, true, "14141414", "NOTEBOOK 79", 1, 13, 1);
select * from equipamento;

create table os(
	cd_os int,
	dt_os date,
	ds_problema varchar(150),
	dt_finalizacao date,
	cd_tipo int,
	cd_situacao int,
	cd_solicitante int,
	constraint pk_os primary key (cd_os, dt_os),
	constraint fk_os_tipo_os foreign key (cd_tipo) references tipo_os(cd_tipo),
	constraint fk_os_situacao foreign key (cd_situacao) references situacao_os(cd_situacao),
	constraint fk_os_solicitante foreign key (cd_solicitante) references solicitante(cd_solicitante)
);
insert into os(cd_os, dt_os, ds_problema, dt_finalizacao, cd_tipo, cd_situacao, cd_solicitante) values (1, '2019-02-20', "instalacao do word", '2019-02-22', 1, 2, 8);
insert into os(cd_os, dt_os, ds_problema, dt_finalizacao, cd_tipo, cd_situacao, cd_solicitante) values (2, '2018-11-28', "estabilizador nao liga", '2018-12-01', 3, 3, 9);
insert into os(cd_os, dt_os, ds_problema, dt_finalizacao, cd_tipo, cd_situacao, cd_solicitante) values (3, '2018-09-18', "notebook com teclado disparado", '2018-10-17', 2, 1, 5);
insert into os(cd_os, dt_os, ds_problema, dt_finalizacao, cd_tipo, cd_situacao, cd_solicitante) values (4, '2018-09-19', "notebook com teclado", '2018-10-17', 2, 1, 5);
select * from os;

create table registro(
	cd_os int,
	dt_os date,
	dt_registro date,
	hr_registro time,
	nm_login varchar(20),
	ds_registro varchar(150),
	constraint pk_registro primary key (cd_os, dt_os, dt_registro,hr_registro, nm_login),
	constraint fk_registro_os foreign key (cd_os, dt_os) references os(cd_os, dt_os),
	constraint fk_registro_usuario foreign key (nm_login) references usuario(nm_login)
);
insert into registro values (1, '2019-02-20',curdate(), curtime() , "Gabriel", "Instalou com dificuldade");
insert into registro values (2, '2018-11-28',curdate(), curtime() , "Gabriel", "Instalou com dificuldade");
select * from registro;

create table equipamento_os(
	cd_serial int,
	cd_os int,
	dt_os date,
	ds_motivo varchar(150),
	ic_feito boolean,
	constraint pk_equipamento_os primary key (cd_serial, cd_os, dt_os),
	constraint fk_equipamento_os_equipamento foreign key (cd_serial) references equipamento(cd_serial),
	constraint fk_equipamento_os_os foreign key (cd_os, dt_os) references os(cd_os, dt_os)
);
insert into equipamento_os(cd_serial, cd_os, dt_os, ds_motivo, ic_feito) values (111111, 1, '2019-02-20', "Verificado os pcs", true);
insert into equipamento_os(cd_serial, cd_os, dt_os, ds_motivo, ic_feito) values (121212, 2, '2018-11-28', "Estabilizador trocado", true);
insert into equipamento_os(cd_serial, cd_os, dt_os, ds_motivo, ic_feito) values (131313, 3, '2018-09-18', "Finalizado", true);
select * from equipamento_os;