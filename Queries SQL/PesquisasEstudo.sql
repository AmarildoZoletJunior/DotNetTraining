

use AdventureWorks2017;

SELECT * FROM Person.person
SELECT * FROM Person.StateProvince
SELECT * FROM person.AddressType
SELECT * FROM person.BusinessEntityAddress
SELECT * FROM person.Address

-- criação de view para visualização rapida
create view V_PessoaCompleta as SELECT  b.AddressLine1,b.City,Concat(a.FirstName,' ',a.MiddleName,' ',a.LastName) as NameFULL FROM person.person a LEFT JOIN person.BusinessEntityAddress c on a.BusinessEntityID = c.BusinessEntityID INNER JOIN person.Address b on b.AddressID = c.AddressID

--Fazendo testes com isnull para campos nulos
SELECT  isnull(b.AddressLine1,'X'),isnull(b.City,'X'),Concat(a.FirstName,' ',a.MiddleName,' ',a.LastName) as NameFULL FROM person.person a FULL JOIN person.BusinessEntityAddress c on a.BusinessEntityID = c.BusinessEntityID FULL JOIN person.Address b on b.AddressID = c.AddressID



SELECT c.AddressID,count(c.AddressID),a.FirstName,a.LastName FROM person.BusinessEntityAddress c FULL JOIN person.Person a on a.BusinessEntityID = c.BusinessEntityID GROUP BY a.FirstName,a.LastName,c.AddressID


-- Visualizando a view criada
SELECT * FROM V_PessoaCompleta order BY AddressLine1


--Contagem de pessoas por endereco
SELECT a.FirstName,a.LastName,c.AddressLine1,count(a.FirstName) as QuantidadePessoas FROM person.person a INNER JOIN person.BusinessEntityAddress b on b.BusinessEntityID = a.BusinessEntityID INNER JOIN person.Address c on c.AddressID = b.AddressID GROUP BY c.AddressLine1,a.FirstName,a.LastName order BY c.AddressLine1




use crm;
SELECT * FROM montadora
SELECT * FROM carro_cliente
SELECT * FROM cliente
SELECT * FROM carro_montadora


--Visualizando a quantidade de carros por marca
SELECT count(b.nome_carro),a.nome_montadora FROM montadora a INNER JOIN carro_montadora b on b.id_montadora = a.id_montadora GROUP BY a.nome_montadora



--Inserindo nova coluna na tabela montadora, para armazenar a quantidade de carros que cada marca tem registrada
begin transaction 

alter table montadora add QuantidadeCarro int null;

commit

--Abrindo transação de inserção das quantidades nas respectivas marcas
begin transaction

update montadora set QuantidadeCarro = (SELECT count(*) as QuantidadeCarro FROM montadora a INNER JOIN carro_montadora b on b.id_montadora = a.id_montadora and montadora.id_montadora = a.id_montadora GROUP BY a.nome_montadora)

commit


--Visualizando inserção feita
SELECT * FROM montadora



--Visualizando uma tabela com nome do cliente, nome do carro e montadora
CREATE VIEW lista_carro_cliente AS SELECT  concat(a.primeiro_nome,' ',a.ultimo_nome) AS Nome_Completo, b.nome_carro, c.nome_montadora FROM cliente a INNER JOIN carro_cliente d ON d.id_cliente = a.id_cliente INNER JOIN carro_montadora b ON b.id_carro = d.id_carro INNER JOIN montadora c ON c.id_montadora = b.id_montadora


-- Visualizando a view criada 
SELECT * FROM lista_carro_cliente order BY nome_montadora

--Visualizando a quantidade de carros que repetem em clientes
SELECT c.nome_carro,count(a.primeiro_nome) FROM cliente a INNER JOIN carro_cliente b on b.id_cliente = a.id_cliente INNER JOIN carro_montadora c on c.id_carro = b.id_carro GROUP BY c.nome_carro


SELECT * FROM carro_montadora


--Selecionando clientes que possuem aquele carro igual SUBQUERY
SELECT a.primeiro_nome FROM cliente a where a.id_cliente in (SELECT b.id_cliente FROM carro_cliente b where b.id_carro  = '5') 


USE curso;

SELECT * FROM senso;
SELECT * FROM uf

-- fazendo subSELECT de um estado por extenso, e fazendo a soma de toda a população para exibir em tabela
SELECT (SELECT a.estado FROM uf a where a.cod_uf = b.cod_uf ) as estado,b.cod_uf,sum(b.populacao) FROM senso b GROUP BY b.cod_uf;


use AdventureWorks2017;

select * from person.person



--Criando tabela para testes com inserção em massa
CREATE TABLE ListaPessoas(
NomeCompleto varchar(60) not null
)

--Criando controle 
BEGIN TRANSACTION

--Inserção
INSERT INTO ListaPessoas SELECT CONCAT(a.FirstName,' ',a.LastName) FROM person.person a;
--Visualização
select * from ListaPessoas;

--Se ok, commit
commit


--Alterando tabela
BEGIN TRANSACTION

ALTER TABLE ListaPessoas add DataModificacao DateTime

commit



--Populando tabela na coluna criada recentemente
BEGIN TRANSACTION

update Teste set DataModificacao = p.ModifiedDate from ListaPessoas as Teste inner join person.person p on Teste.NomeCompleto = concat(p.FirstName,' ',p.LastName)

COMMIT


--Criando trigger que quando da update em um nome da lista ele da update para a data de modificação do nome
CREATE TRIGGER V1_TROCARData on ListaPessoas
AFTER UPDATE AS 
BEGIN 
UPDATE ListaPessoas SET DataModificacao = GetDate() from ListaPessoas b
inner join inserted i on b.NomeCompleto = i.NomeCompleto
END 
GO

select * from ListaPessoas;


--Testando trigger criado
update ListaPessoas set NomeCompleto = 'Marcus Allena' Where ListaPessoas.NomeCompleto = 'Marcus Allen'