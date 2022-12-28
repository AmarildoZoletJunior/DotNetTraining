use curso

SELECT * FROM senso;

SELECT * FROM senso WHERE nome_mun = 'Águas de lindóia';

SELECT * FROM senso WHERE nome_mun = 'Aguas de lindoia';

SELECT * FROM senso WHERE nome_mun = 'Dourado';

SELECT * FROM senso WHERE populacao > 1000;

SELECT * FROM senso WHERE populacao < 1000;

SELECT * FROM senso WHERE populacao <= 1000;

SELECT * FROM senso WHERE uf <> 'SP' AND uf <> 'SC';

SELECT * FROM senso WHERE populacao <= 100000 AND uf = 'SP' AND nome_mun <> 'Adamantina';

SELECT d.cod_uf,d.nome_mun,d.populacao,d.populacao / 2 AS 'TESTE' FROM senso AS d WHERE uf = 'SP';

SELECT * FROM senso WHERE cod_uf NOT BETWEEN 30 AND 40;

SELECT cod_uf FROM senso WHERE cod_uf > ANY(SELECT populacao FROM senso);

SELECT cod_uf,nome_mun FROM senso WHERE cod_uf = 35;

use crm;
SELECT * FROM cliente;

SELECT primeiro_nome,ultimo_nome,codigo_pais,nascimento FROM cliente WHERE sexo = 'Female' AND codigo_pais = 'BR';

Select primeiro_nome,ultimo_nome,nascimento,etnia FROM cliente WHERE id_profissao not in ('91','47') and etnia in('Asian');

SELECT primeiro_nome FROM cliente where primeiro_nome LIKE 'or%';

SELECT primeiro_nome FROM cliente where primeiro_nome LIKE '%or_%';
SELECT primeiro_nome FROM cliente where primeiro_nome LIKE '%or';
SELECT primeiro_nome FROM cliente where primeiro_nome LIKE 'or%';
SELECT primeiro_nome FROM cliente where primeiro_nome LIKE 'a%o';
SELECT primeiro_nome FROM cliente where primeiro_nome LIKE 'A_a';
select primeiro_nome FROM cliente where primeiro_nome LIKE 'c[ER]%';

USE curso;
select * from senso;
SELECT * FROM senso WHERE uf LIKE 'S%' AND populacao > 1000000 AND NOT cod_uf = 11;

SELECT nome_mun,uf,populacao FROM senso WHERE populacao > 100000 AND (uf = 'SC' OR uf = 'SE');


Use AdventureWorks2017

Select * from person.person;
SELECT * FROM person.person Where Title IS NOT NULL;
SELECT PersonType, COUNT(PersonType) as QuantidadePersonId FROM person.person GROUP BY PersonType HAVING COUNT(EmailPromotion) > 2;
Select EmailPromotion,count(EmailPromotion) as QuantidadeTitulo FROM person.person GROUP BY EmailPromotion HAVING count(FirstName) > 0;
SELECT MiddleName,count(MiddleName) as QuantidadeNome FROM person.person GROUP BY MiddleName HAVING COUNT(EmailPromotion) > 0 ORDER BY MiddleName;
select PersonType,Title, count(Title) as QuantidadePessoas FROM person.person GROUP BY PersonType,Title HAVING COUNT(PersonType) > 0 ORDER BY PersonType;


USE curso;

select * from senso;
select uf, Count(uf) as QuantidadeCidade FROM senso GROUP BY uf HAVING sum(populacao) > 100;
select uf,sum(populacao) as QuantidadePopulacao FROM senso GROUP BY uf HAVING sum(populacao) > 0 ORDER BY QuantidadePopulacao;

Use curso;

Create Table Funcionarios(
ID int identity(1,1) NOT NULL Primary Key,
NOME Varchar(50) NOT NULL,
SALARIO Decimal(10,2),
SETOR Varchar(30)
);

Select * from Funcionarios;

Select nome,setor From Funcionarios;

Select NOME,SETOR from Funcionarios;

Select nome,setor,salario as depto FROM Funcionarios;

Insert Into Funcionarios (nome,salario) Values ('Amarildo',2500);
Insert Into Funcionarios (nome,salario) Values ('Pedro',1000), ('Eduardo',1500);

Update Funcionarios Set SALARIO = Salario*1.5 WHERE id = '1';

Update Funcionarios Set SALARIO += Salario *0.50 Where id = '1';
Update Funcionarios SET salario = Salario*1.5,SETOR = 'T.I' Where id <> '1';
Delete Funcionarios Where id = '1';


Use curso;

Create Table Colaborador(
Matricula INT IDENTITY(1,1) NOT NULL,
nome VarChar(50) NOT NULL,
sobrenome VARCHAR(50) NOT NULL,
endereco VARCHAR(50) NOT NULL,
cidade VARCHAR(50) NOT NULL,
pais VARCHAR(25) NOT NULL,
data_nascimento DATE NOT NULL check(data_nascimento<getdate()),
data_cadastro DateTime default getdate(),
situacao char(1) default('A')
);
ALTER Table colaborador ADD PRIMARY KEY (Matricula);

Create table salario(
matricula INT PRIMARY KEY NOT NULL,
salario DECIMAL(10,2) NOT NULL check (salario > 0)
Foreign KEY (matricula) REFERENCES Colaborador(Matricula)   -- Aqui uma relação um para um;
);

Select * from salario;
select * from FUNC;
insert into colaborador (nome,sobrenome,endereco,cidade,pais,data_nascimento,data_cadastro,situacao) Values ('Amarildo','Junior','Rua veronica','Guaramirim','Brasil','2002/11/26','2022/12/05','A');
insert into salario (matricula,salario) values (4,'2200');

CREATE TABLE audit_salario(
transacao int identity(1,1) NOT NULL PRIMARY KEY,
matricula INT NOT NULL,
data_trans Datetime NOT NULL,
sal_antigo DECIMAL(10,2),
sal_novo DECIMAl (10,2),
Usuario VARCHAR(20) NOT NULL
);

Alter table audit_salario
add foreign key (matricula) references colaborador(matricula);

alter table colaborador add Genero char(1);

exec sp_rename 'colaborador.endereco', 'ender','COLUMN';

ALTER TABLE colaborador ALTER COLUMN ender VARCHAR(30);

alter table colaborador drop column genero;

alter table salario drop constraint FK__salario__salario__0B91BA14;

exec sp_rename 'colaborador', 'FUNC';


drop table salario;

create view v_colaborador as select * from FUNC;

alter view v_colaborador as select matricula,nome from FUNC;

drop view v_colaborador;






select * from func;


create table Cadastro(
Nome varchar(50) not null,
docto varchar(20) not null
)

begin transaction;

insert into cadastro values ('amarildo','123456');
save transaction a1;

insert into cadastro values ('pedro','123456');
save transaction a2;
insert into cadastro values ('jonas','123456');
save transaction a3;

select * from Cadastro;
rollback transaction a2;
rollback;

commit transaction;

select * from Cadastro;

delete cadastro;



use curso;

Select '1',1 union select 'A',2;


Use AdventureWorks2017;

select city from Person.Address where AddressId < 15000 union select city from person.Address where AddressID>= 15000 order by city;


use crm;

Select * from cliente;
select c.primeiro_nome,c.ultimo_nome, (select a.id_carro from carro_cliente a where) as nome_carro from cliente c;
select cidade,codigo_pais,id_profissao,sexo,primeiro_nome from cliente where sexo = 'Female' union Select cidade,codigo_pais,id_profissao,sexo,primeiro_nome from cliente where id_profissao = 91 order by sexo;
select a.id_cliente, a.primeiro_nome, a.ultimo_nome, a.sexo from cliente a where a.id_cliente in (select b.id_cliente from carro_cliente b where b.ano ='2012');
select * from carro_cliente order by id_carro;
select * from carro_montadora;
select * from carro_cliente where id_carro in ( select id_carro from carro_montadora where id_montadora = '2') order by id_carro;
select a.id_cliente,(select b.primeiro_nome from cliente b where b.id_cliente = a.id_cliente) as Nome_cliente, a.id_carro,(select b.nome_carro from carro_montadora b where a.id_carro = b.id_carro) as Modelo_carro, a.ano from carro_cliente a where id_cliente < 100 order by Modelo_carro;
alter table carro_montadora add qtd int;

select * from carro_montadora order by nome_carro;

update carro_montadora set qtd =(select count(*) as qtd from carro_cliente b inner join carro_montadora c on c.id_carro = b.id_carro and carro_montadora.id_carro = b.id_carro group by b.id_carro);


use curso;

create table alunos(
id_aluno int identity(1,1),
nome varchar(20) not null
);

create table disciplina(
id_disciplina int identity(1,1),
nome_disc varchar(20)
);

create table matricula(
id_aluno int,
id_disciplina int,
periodo varchar(10)
);

--Estamos alterando na tabela aluno, a coluna id_aluno para ser int not null
alter table matricula alter column id_aluno int not null;


alter table matricula alter column id_disciplina int not null;


alter table matricula add constraint pk_1 primary key (id_aluno,id_disciplina);


alter table disciplina add constraint pk2 primary key (id_disciplina);

alter table alunos add constraint pk1 primary key (id_aluno);

alter table matricula add constraint fk_math1 foreign key (id_aluno) references alunos(id_aluno);

alter table matricula add constraint fk_math2 foreign key (id_disciplina) references disciplina(id_disciplina);

insert into alunos values ('joao'), ('maria'), ('pedro'), ('tiago'), ('henrique');

select * from alunos;

insert into disciplina values ('Matemática'),('Fisica'),('Ingles'),('Português');
insert into disciplina values ('ed.fisica');
select * from disciplina;

insert into matricula values ('1','1','Noturno');
insert into matricula values ('1','2','Noturno');
insert into matricula values ('1','3','Noturno');

insert into matricula values ('2','3','Noturno');
insert into matricula values ('2','4','Noturno');

insert into matricula values ('3','1','Noturno');
insert into matricula values ('3','3','Noturno');
insert into matricula values ('3','4','Noturno');

insert into matricula values ('5','1','Noturno');
insert into matricula values ('5','2','Noturno');
insert into matricula values ('5','4','Noturno');

select * from matricula;


select a.id_aluno,a.nome,c.id_disciplina,c.nome_disc,b.periodo from alunos a inner join matricula b on a.id_aluno=b.id_aluno inner join disciplina c on b.id_disciplina = c.id_disciplina;

select a.id_aluno,a.nome,c.id_disciplina,c.nome_disc,b.periodo from alunos a left join matricula b on a.id_aluno=b.id_aluno left join disciplina c on b.id_disciplina = c.id_disciplina;

select a.id_aluno,a.nome,c.id_disciplina,c.nome_disc,b.periodo from alunos a right join matricula b on a.id_aluno=b.id_aluno right join disciplina c on b.id_disciplina = c.id_disciplina;

select a.id_aluno,a.nome,c.id_disciplina,c.nome_disc,b.periodo from alunos a full join matricula b on a.id_aluno=b.id_aluno full join disciplina c on b.id_disciplina = c.id_disciplina order by nome_disc;



select a.id_aluno,a.nome,b.periodo from alunos a left join matricula b on a.id_aluno = b.id_aluno;


use crm;


select * from carro_montadora;
select * from carro_cliente;
select * from cliente;
select * from montadora;

select a.id_cliente,a.primeiro_nome,a.ultimo_nome,b.id_carro,c.nome_carro,d.nome_montadora from cliente a 
inner join carro_cliente b 
on b.id_cliente = a.id_cliente 
inner join carro_montadora c 
on c.id_carro = b.id_carro 
inner join montadora d
on d.id_montadora = c.id_montadora order by nome_montadora; 

use AdventureWorks2017;

select * from person.Person where BusinessEntityID = '292';
select * from person.PersonPhone

select * from person.StateProvince where rowguid = '92C4279F-1207-48A3-8448-4636514EB7E2';

select top 10 a.BusinessEntityID,a.FirstName,a.LastName,b.PhoneNumber as NumeroTelefone,rank() over(order by  a.BusinessEntityID desc) as posições from person.person a inner join person.PersonPhone b on a.BusinessEntityID = b.BusinessEntityID;

select * from person.EmailAddress;
select * from HumanResources.Employee;

select a.FirstName,a.MiddleName,a.LastName,b.EmailAddress,c.NationalIDNumber,c.LoginId,c.JobTitle from person.Person a inner join person.EmailAddress b on b.BusinessEntityID = a.BusinessEntityID inner join HumanResources.Employee c on c.BusinessEntityID = b.BusinessEntityID;
select a.FirstName,a.MiddleName,a.LastName,b.EmailAddress,c.NationalIDNumber,c.LoginId,c.JobTitle from person.Person a left join person.EmailAddress b on b.BusinessEntityID = a.BusinessEntityID left join HumanResources.Employee c on c.BusinessEntityID = b.BusinessEntityID;
select a.FirstName,a.MiddleName,a.LastName,b.EmailAddress,c.NationalIDNumber,c.LoginId,c.JobTitle from person.Person a right join person.EmailAddress b on b.BusinessEntityID = a.BusinessEntityID right join HumanResources.Employee c on c.BusinessEntityID = b.BusinessEntityID;
select a.FirstName,a.MiddleName,a.LastName,b.EmailAddress,c.NationalIDNumber,c.LoginId,c.JobTitle from person.Person a full join person.EmailAddress b on b.BusinessEntityID = a.BusinessEntityID full join HumanResources.Employee c on c.BusinessEntityID = b.BusinessEntityID;


use curso;

select top 10 * from senso;
select uf,avg(populacao) from senso group by uf;
select uf,sum(populacao) from senso group by uf;

select a.* from (select cod_uf,miN(populacao) as populacao from senso group by cod_uf) b join senso a on a.cod_uf = b.cod_uf and a.populacao = b.populacao order by a.populacao;

select * from regiao;

select cast(250.0 as varbinary(20));
select cast(cast(250.0 as varbinary(20)) as decimal(4, 1));
select b.estado,min(a.populacao) from senso a inner join regiao b on b.cod_uf = a.cod_uf group by b.estado;

select b.regiao,avg(a.populacao) from senso a inner join regiao b on a.cod_uf = b.cod_uf group by b.regiao;

select * from uf;

select a.cod_uf,count(b.area_km2) from senso a inner join uf b on b.cod_uf = a.cod_uf group by a.cod_uf;

select avg(populacao) as media_pop, min(populacao) Minimo_pop,max(populacao) Max_pop, sum(populacao) Total_pop, Count(*) qtd_cidades from senso;

use crm;

select * from carro_cliente;
select * from carro_montadora;
select * from cliente;
select * from montadora;

select c.nome_montadora,count(a.id_carro) as QuantidadeCarros from carro_cliente a inner join carro_montadora b on b.id_carro = a.id_carro inner join montadora c on c.id_montadora = b.id_montadora group by nome_montadora order by nome_montadora;
select c.nome_montadora,count(a.id_carro) as QuantidadeCarros from carro_cliente a inner join carro_montadora b on b.id_carro = a.id_carro inner join montadora c on c.id_montadora = b.id_montadora group by c.nome_montadora order by nome_montadora;



use curso;

select rank() Over (order by estado asc) as rank_uf, estado from uf;
select rank () over (order by estado asc) as rank_uf, regiao,estado from regiao;

select rank() over(order by regiao asc) as rank_uf,regiao,estado from regiao;

select rank() over (order by estado desc) as rank_uf,regiao from regiao;


select ntile(10) over (order by regiao asc) as ntile_uf, regiao,estado from regiao;

select dense_rank() over (order by regiao asc) as ntile_uf, regiao,estado from regiao;


select row_number() over (order by regiao asc) as ntile_uf, regiao,estado from regiao;

select * from regiao;

declare @a int = 45;
declare @b int = 40;
select iif (@a < @b, 'true', 'false') as resultado;
declare @a int = 45;
declare @b int = 40;
select iif (@a < @b, 'maior', 'menor') as resultado;

select iif(45 > 30, 'maior', 'menor') as resultado;

select abs(-1.0),abs(0.0),abs(5.0),abs(10.2),abs(-2.8);


select rand();

select round(123.562612,1);

Select Round(150.75,0);

select power(2,3);

select sqrt(27);

declare @valorUnico decimal(5,2);
set @valorUnico = 193.24;

select cast(@valorUnico as varbinary(20));

select cast(cast(@valorUnico as varbinary(20)) as decimal(5,2));
select cast (@valorUnico as decimal(6,3));


use AdventureWorks2017;

SELECT * FROM production.Product;

select distinct 'Preço:'  + cast(a.ListPrice as varChar(12)) as PrecoComNome from Production.Product a;

select try_parse('2010/10/30' as datetime using 'pt-BR') AS resposta;

select try_convert(datetime,'20/10/2020') AS resposta;

select try_convert(datetime2,'20/10/2020') as resposta2;

select ASCII(a.Name) from Production.Product a;


select str(201.45, 5,1);
select 'olamundo' + str(201.45, 6,4);


select top 1 concat(CURRENT_USER, ' Seu saldo é ', a.ListPrice,' em ', day(getdate()),'/',month(getdate()),'/',year(getdate())) as resultado from Production.Product a WHERE a.ListPrice = 539.99;




select SYSDATETIME() as SYSDATETIM, SYSDATETIMEOFFSET() as sysoffset, SYSUTCDATETIME() as sysu, GETDATE() as getdat, GETUTCDATE() as getutc;



select DATENAME(day,getdate()) as datname, DATEPART(month,getdate()) as datepar,day(getdate()) as dias,MONTH(getdate()) as mes,year(getdate()) as ano;


use crm;

select * from cliente;

select count(*) as contagem,day(a.nascimento)mes from cliente a group by day(a.nascimento) order by day(a.nascimento);


select concat('Contagem total:',count(*),', Os dias são estes:',day(a.nascimento)) from cliente a group by day(a.nascimento) order by day(a.nascimento);


select datediff(day,DATEADD(Day,15,getdate()),DATEADD(Day,30,getdate()));


select datediff(day,'2002-11-26',getdate());


select datediff(day,'2003-12-13',getdate());


select datediff(day,'1970-10-24',getdate());


select datediff(day,'1970-08-31',getdate());

select datediff(day,'1952-12-21',getdate());


select datediff(day,a.nascimento,getdate()),a.nascimento from cliente a order by a.nascimento;

select convert(varchar,getdate(),103)
select convert(varchar,getdate(),107)
select convert(varchar,getdate(),102)
select convert(varchar,getdate(),104)


select datename(MONTH,getdate());


select a.codigo_pais,case 
	when a.codigo_pais = 'BR' Then 'Brasil'
	when a.codigo_pais = 'US' Then 'Gringo'
	else 'não sei' end CategoriaPais from cliente a order by CategoriaPais


select nullif(10,10);

select isnull(null,2)


select * from cliente;

use crm;
select * from carro_montadora; -- b
select * from carro_cliente; ---c
select * from cliente; --a
select * from montadora; ---d

create view v_CarroClienteTotal as select a.id_cliente,a.primeiro_nome, a.ultimo_nome,a.nascimento, b.id_carro,b.nome_carro,c.ano,d.nome_montadora from cliente a inner join carro_cliente c on c.id_cliente = a.id_cliente inner join carro_montadora b on b.id_carro = c.id_carro inner join montadora d on d.id_montadora = b.id_montadora;

select * from v_CarroClienteTotal where year(nascimento) = '2009'


select * from v_CarroClienteTotal;

select primeiro_nome into NomesClientes from cliente;

select * from NomesClientes


if(10 = 11) print 'ola mundo' else print 'batata';








use curso
 select a.BusinessEntityID codpessoa,
	    a.FirstName nome,
		a.LastName sobrenome,
		cast('' as varchar(100)) nomecompleto
        into clifor
  from AdventureWorks2017.person.person a
--verifcando dados carregado sem nome completo
select * from clifor
--drop table clifor;

--Inicio cursor (Declara Variavies)
DECLARE @codpessoa   INT, 
        @primeironome VARCHAR(50), 
        @sobrenome    VARCHAR(50), 
        @nomecompleto VARCHAR(100) 
-- Cursor para percorrer os registros 
DECLARE cursor1 CURSOR FOR 
  SELECT codpessoa, 
         nome, 
         sobrenome 
  FROM   clifor 

--Abrindo Cursor 
OPEN cursor1 

-- Lendo a próxima linha 
FETCH next FROM cursor1 INTO @codpessoa, @primeironome, @sobrenome 

-- Percorrendo linhas do cursor (enquanto houverem) 
WHILE @@FETCH_STATUS = 0 
  BEGIN 
      -- Executando as rotinas desejadas manipulando o registro 
      UPDATE clifor 
      SET    nomecompleto =@primeironome+' '+@sobrenome 
      WHERE  codpessoa = @codpessoa 

      -- Lendo a próxima linha 
      FETCH next FROM cursor1 INTO @codpessoa, @primeironome, @sobrenome 
  END 

-- Fechando Cursor para leitura 
CLOSE cursor1 

-- Finalizado o cursor 
DEALLOCATE cursor1 ;
alter table clifor add constraint pk_id1 primary key (codpessoa);


----------------------------------------------------------


select a.BusinessEntityID as Codigo,a.FirstName as Nome,a.MiddleName as Sobrenome,a.LastName as UltimoNome,cast('' as varchar(200)) as Nomecompleto into teste from AdventureWorks2017.Person.Person a;
select * from teste
alter table teste add constraint pk_teste primary key (Codigo);
drop table teste;

Declare @Codigo INT,
@primeironome varchar(100),
@segundonome VARCHAR(100),
@ultimonome varchar(100),
@completo varchar(100)

declare CursorTeste CURSOR FOR SELECT Codigo,Nome,Sobrenome,UltimoNome from teste;

open CursorTeste
FETCH NEXT FROM CursorTeste INTO @Codigo, @primeironome, @segundonome, @ultimonome

WHILE @@FETCH_STATUS = 0 
Begin

	Update teste set NomeCompleto = @primeironome+' '+isnull(@segundonome,'SemSobrenome')+' '+@ultimonome,Sobrenome = isnull(@segundonome,'SemSobrenome') where @Codigo = Codigo;

	FETCH NEXT FROM CursorTeste INTO @Codigo, @primeironome, @segundonome, @ultimonome

	  END 
close CursorTeste

deallocate CursorTeste

-----------------------------------------------------------

use curso


select * from alunos;


declare @minhavariavel varchar(100)

declare meu_cursor
CURSOR local FOR SELECT nome FROM alunos

open meu_cursor

FETCH next FROM meu_cursor INTO @minhavariavel

WHILE(@@FETCH_STATUS = 0)
begin 
print @minhavariavel+' FETCH STATUS-> '+cast(@@FETCH_STATUS As varchar(10))

FETCH next FROM meu_cursor INTO @minhavariavel
end

print 'FETCH'+CAST(@@FETCH_STATUS as varchar(10))

close meu_cursor

deallocate meu_cursor

Create function FN_Trima(@st varchar(1000))
returns varchar(1000)
begin 
return (Ltrim(Rtrim(Trim(@st))))
end;

Create function FN_TrimTudo(@st varchar(1000))
returns varchar(1000)
begin 
return Replace(@st,' ', '')
end;

select DBO.FN_Trima(a.NomeCompleto) from teste a;

select DBO.FN_TrimTudo('ola todos');

CREATE FUNCTION FN_SOMA(@NUM1 int, @NUM2 int)
RETURNS int
	begin 
	return @NUM1 + @NUM2
	END;

print DBO.FN_SOMA(10,10)


create table #tabelateste
(
	valor1 int NOT NULL,
	valor2 int NOT NULL, )

insert into #tabelateste (valor1,valor2) values (20,50);
insert into #tabelateste (valor1,valor2) values (24,52);
insert into #tabelateste (valor1,valor2) values (2,5);
insert into #tabelateste (valor1,valor2) values (7,40);
insert into #tabelateste (valor1,valor2) values (8,4);
insert into #tabelateste (valor1,valor2) values (12,10);
insert into #tabelateste (valor1,valor2) values (17,59);
insert into #tabelateste (valor1,valor2) values (50,25);

select valor1,valor2,dbo.FN_SOMA(valor1,valor2) as Resultado_Soma from #tabelateste

create table Saldos(
	idConta int Identity(1,1),
	ValorInicial int,
	ValorFinal int )


insert into Saldos (ValorInicial,ValorFinal) values (50,20)
insert into Saldos (ValorInicial,ValorFinal) values (20,50);
insert into Saldos (ValorInicial,ValorFinal) values (24,52);
insert into Saldos (ValorInicial,ValorFinal) values (2,5);
insert into Saldos (ValorInicial,ValorFinal) values (7,40);
insert into Saldos (ValorInicial,ValorFinal) values (8,4);
insert into Saldos (ValorInicial,ValorFinal) values (12,10);
insert into Saldos (ValorInicial,ValorFinal) values (17,59);
insert into Saldos (ValorInicial,ValorFinal) values (50,25);
select * from Saldos

CREATE FUNCTION FN_Saldo (@Numero int)
returns decimal
begin
	Declare @Saldo Decimal
	Select @saldo = ValorFinal - ValorInicial from Saldos where idConta = @Numero
	RETURN @Saldo
END;

select ValorInicial,ValorFinal, dbo.FN_SALDO(idConta) as ResultadoFinal from Saldos;


create function SelecionarCidade(@UF varchar(2))
returns Table as
return(select a.nome_mun,a.uf from senso a where a.uf = @UF)

select * from dbo.SelecionarCidade('sc');

create function SelecionarPeloCodigo(@UF int)
returns Table
return(select a.nome_mun,a.cod_uf from senso a where a.cod_uf = @UF)

select * from dbo.SelecionarPeloCodigo(11)

use curso;

select * from senso


create procedure TESTEOla(@Valor varchar(20))
as
begin
	select @Valor
	END


Execute dbo.TESTEOla 'ola mundo'


create procedure MensagemBomDia(@nome varchar(20))
as 
begin 
	if(DATEPART(hour,getdate()) > 4 and DATEPART(hour,getdate()) < 12)
	select @nome+' Bom dia'
	if(DATEPART(hour,getdate()) >= 12 and DATEPART(hour,getdate()) < 18)
	select @nome+' Boa tarde'
		if(DATEPART(hour,getdate()) >= 18 and DATEPART(hour,getdate()) < 4)
		select @nome+' Boa noite'
	end

execute MensagemBomDia 'Amarildo'




print(datepart(hour,getdate()))


create procedure CalcularIMC6(@peso decimal(10,2), @altura decimal(10,2))
as 
begin
declare @soma decimal(10,2), @resultado decimal(10,2) 
set @soma = @altura*@altura
set @resultado = @peso/@soma

if(@resultado >= 18.99 and @resultado <= 24.99)
begin
print('Você esta com normal: '+ cast(@resultado as varchar(20)))
end


else if(@resultado >= 25.99 and @resultado <= 30.99)
begin
print('Você esta com sobrepeso: '+ cast(@resultado as varchar(20)))
end


else if(@resultado > 30.99)
begin
print('Você esta acima: '+ cast(@resultado as varchar(20)))
end
else
begin
print('nao sei')
end
End

Execute CalcularIMC6 80.50,1.80


select * from AdventureWorks2017.Person.EmailAddress

select * from teste;

create view ViewTeste as select g.Nome, g.Sobrenome, g.UltimoNome,(select EmailAddress from AdventureWorks2017.Person.EmailAddress a where a.BusinessEntityID = g.Codigo) as Email,(select C.BusinessEntityID from AdventureWorks2017.Person.Person C where C.BusinessEntityID = g.Codigo) as id from teste g

select * from ViewTeste




create table CRUDTabel(
id int identity(1,1) not null,
nome varchar(40) not null,
sobrenome varchar(40) not null,
idade int not null)


select * from CRUDTabel

create procedure CRUD5 (@op char(1),@id int,@nome varchar(40),@sobrenome varchar(40),@idade int)
as 
begin
if(@op = 'I' or @op = 'i')
begin
insert into CRUDTabel (nome,sobrenome,idade) values (@nome,@sobrenome,@idade)
print('Inserido com sucesso')
end
else if(@op = 'D' or @op = 'd')
begin
delete from CRUDTabel where id = @id
print('Deletado com sucesso')
end
else if(@op = 'U' or @op = 'u')
begin
update CRUDtabel set nome = @nome, sobrenome = @sobrenome, idade = @idade where id = @id
print('Atualizado com sucesso')
end
else if(@op = 'R' or @op = 'r')
begin 
select * from CRUDtabel
end
end

CRUD5 'r',2,'Amaarildo','asas',20

select * from CRUdtabel