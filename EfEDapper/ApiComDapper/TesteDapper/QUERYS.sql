use TarefasDemoDb

select * from Tarefas


create database Filmes

use Filmes

create table Tb_produtora (
	id INT not null identity(1,1) primary key,
	nome varchar(100) not null
	)

create table Tb_Filme(
Id int not null identity(1,1) primary key,
nome varchar(50) not null,
ano int,
id_produtora int foreign key references Tb_produtora(id)
)

alter table tb_filme add constraint  fk_prod1 foreign key (id_produtora) references  tb_produtora (id) on  update cascade on delete cascade
insert into Tb_produtora values ('Warner Bros'),('Sony'),('Marvel Studios'),('Walter disney')
select * from Tb_produtora
insert into Tb_filme values ('Vingadores 1',2002,3)
insert into Tb_filme values ('Vingadores 2',2005,3)
insert into Tb_filme values ('Vingadores 3',2012,3)
insert into Tb_filme values ('Vingadores 4',2015,3)
insert into Tb_filme values ('Vingadores 5',2021,3)

insert into Tb_filme values ('Mickey Mouse 1',2005,4)
insert into Tb_filme values ('Mickey Mouse 2',2010,4)
insert into Tb_filme values ('Mickey Mouse 3',2012,4)
insert into Tb_filme values ('Mickey Mouse 4',2015,4)
insert into Tb_filme values ('Mickey Mouse 5',2019,4)
select * from Tb_Filme order by id_produtora
begin transaction
delete from tb_filme where id = 1;
rollback
insert into tb_filme values ('Harry Potter e a pedra filosofal',2001,1),('A Orfã',2009,1),('A mulher Rei',2022,2)

delete from tb_filme
delete from tb_produtora


ALTER TABLE tb_filme ADD CONSTRAINT unique_fk UNIQUE(id_produtora);

drop table tb_filme