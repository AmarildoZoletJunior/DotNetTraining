create database Receitas

use Receitas

create table Ingrediente(
id_ingrediente int identity(1,1) not null primary key,
ingrediente varchar(45) not null
)

create table Un_Medida(
id_Medida int identity(1,1) not null primary key,
unidade varchar(45) not null
)


create table Usuario(
id_usuario int identity(1,1) not null primary key,
nome varchar(60) not null,
email varchar(60) not null,
senha varchar(60) not null
)

create table tipo_Receita(
tipo varchar(30) not null primary key
)

create table Receita(
id_receita int identity(1,1) not null primary key,
titulo_receita varchar(60) not null,
rendimento varchar(60) not null,
modo_preparo varchar(60) not null,
id_usuarioDono int not null,
tipo_receita varchar(30) not null,
constraint fk_rec1 foreign key (id_usuarioDono) references usuario(id_usuario),
constraint fk_rec2 foreign key (tipo_receita) references tipo_Receita(tipo)
)



create table Receitas_Favoritos(
id_receita int foreign key references Receita(id_receita) not null,
id_usuario int foreign key references Usuario(id_usuario) not null,
)

ALTER TABLE Receitas_Favoritos 
  ADD CONSTRAINT fk_RF1 
  FOREIGN KEY (id_receita) 
  REFERENCES Receita(id_receita) 
  ON DELETE CASCADE;

delete from receitas_favoritos where id_usuario = 1, id_receita = 2;

select u.nome,u.id_usuario,r.titulo_receita,r.id_receita from Receitas_Favoritos b inner join Receita r on r.id_receita = b.id_receita inner join Usuario u on u.id_usuario = b.id_usuario where b.id_usuario = 1


insert into Receitas_Favoritos values (1,2)
select * from Receitas_Favoritos

create table Ingrediente_Has_Receita(
id_ingrediente int foreign key references Ingrediente(id_ingrediente) not null,
id_receita int foreign key references Receita(id_receita) not null,
id_medida int foreign key references Un_medida(id_medida) not null,
quantidadeIngrediente numeric(9,2) not null,
)
ALTER TABLE Ingrediente_Has_Receita 
  ADD CONSTRAINT fk_iR1 
  FOREIGN KEY (id_receita) 
  REFERENCES Receita(id_receita) 
  ON DELETE CASCADE;

select * from Ingrediente;
select * from Ingrediente_Has_Receita;
select * from Receita;
select * from Receitas_favoritos;

insert into Receitas_Favoritos values (5,2)
select * from un_medida;
select * from usuario;
select * from tipo_Receita;
insert into Usuario(nome,email,senha) values ('{usuario.Nome}','{usuario.Email}','{usuario.Senha}')



insert into Ingrediente values ('Arroz'),('Feijão'),('Cebola'),('Cebolinha'),('Alho'),('Sal')
insert into Ingrediente values ('Salsinha'),('Alface'),('Oregano'),('Picanha'),('Alcatra com osso'),('Alcatra sem osso'),('Maminha'),('Linguicinha'),('Salame'),('Macarrão'),('Batata'),('Cenoura')

insert into un_medida values ('Kg'),('Ml'),('G'),('L')

insert tipo_receita values ('Doce'),('Salgado')

insert into usuario values ('Amarildo','amarildo@gmail.com','1234'),('Carlos','carlos@gmail.com','1234'),('Gabriel','gabriel@gmail.com','gabriel123')

insert into Receita values ('Feijoada',5,'1-Coloque tudo dentro da panela',1,'Salgado'),
('Arroz',5,'1-panela e agua',1,'Salgado'),('Carne assada',5,'1-Fogo e carvão',1,'Salgado')



insert into Ingrediente_Has_Receita values (2,1,1,1.5),(3,1,3,300),(6,1,3,50),(1,5,1,1),(6,5,3,50),(10,6,1,1),(6,6,3,100)








