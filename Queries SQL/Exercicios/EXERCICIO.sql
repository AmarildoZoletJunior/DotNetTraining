/*
EXERC�CIO 1 
Crie o banco de dados treino com as tabelas conforme diagrama.
*/
--CRIAR TABELA UNIDADE 1

-- DROP TABLE UNIDADE
CREATE TABLE UNIDADE
(
ID_UNIDADE VARCHAR(3) NOT NULL,
DESC_UNIDADE VARCHAR(25) NOT NULL,
CONSTRAINT PK_UNI1 PRIMARY KEY (ID_UNIDADE)
)

--DROP TABLE CATEGORIA
--CRIAR TABELA CATEGORIA 2
CREATE TABLE CATEGORIA
(
ID_CATEGORIA INT IDENTITY(1,1) NOT NULL,
NOME_CATEGORIA VARCHAR(20) NOT NULL,
CONSTRAINT PK_CAT1 PRIMARY KEY (ID_CATEGORIA)
)


--DROP TABLE PRODUTO
--CRIAR TABELA PRODUTO 3
CREATE TABLE PRODUTO
(
ID_PROD INT IDENTITY(1,1) NOT NULL,
NOME_PROD VARCHAR(50) NOT NULL,
ID_CATEGORIA INT NOT NULL,
ID_UNIDADE VARCHAR(3) NOT NULL,
PRECO DECIMAL(10,2) NOT NULL,
CONSTRAINT FK_PROD1 FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIA(ID_CATEGORIA),
CONSTRAINT FK_PROD2 FOREIGN KEY (ID_UNIDADE) REFERENCES UNIDADE(ID_UNIDADE),
CONSTRAINT PK_PROD1 PRIMARY KEY (ID_PROD)
)


--DROP TABLE VENDA_ITENS
--CRIAR TABELA VENDA_ITENS 6
CREATE TABLE VENDA_ITENS
(
NUM_VEN INT NOT NULL,
NUM_SE INT NOT NULL,
ID_PROD INT NOT NULL,
QTDE DECIMAL(10,2),
VAL_UNIT DECIMAL (10,2) NOT NULL,
VAL_TOTA DECIMAL (10,2),
CONSTRAINT PK_VI1 PRIMARY KEY (NUM_VEN,NUM_SE),
CONSTRAINT FK_VI1 FOREIGN KEY (NUM_VEN) REFERENCES VENDAS(NUM_VEND),
CONSTRAINT FK_VI2 FOREIGN KEY (ID_PROD) REFERENCES PRODUTO(ID_PROD)
)


--DROP TABLE VENDAS
--CRIAR TABELA VENDAS 5
CREATE TABLE VENDAS
(
NUM_VEND INT IDENTITY(1,1) NOT NULL,
DATA_VEND DATETIME NOT NULL,
ID_CLIENTE INT NOT NULL,
ID_VENDEDOR INT NOT NULL,
STATUS CHAR(1) NOT NULL DEFAULT('N'),
CONSTRAINT PK_VENDA1 PRIMARY KEY (NUM_VEND),
CONSTRAINT FK_VENDA1 FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE),
CONSTRAINT FK_VENDA2 FOREIGN KEY (ID_VENDEDOR) REFERENCES VENDEDORES(ID_VENDEDOR)
)


--DROP TABLE VENDEDORES
--CRIAR TABELA VENDEDORES  4
CREATE TABLE VENDEDORES
(
ID_VENDEDOR INT IDENTITY(1,1) NOT NULL,
NOME_VENDEDOR VARCHAR(60) NOT NULL,
SALARIO DECIMAL(10,2) NOT NULL,
CONSTRAINT PK_VEN1 PRIMARY KEY (ID_VENDEDOR)
)

--DROP TABLE CLIENTE
--CRIAR TABELA CLIENTE
CREATE TABLE CLIENTE
(
ID_CLIENTE INT IDENTITY(1,1) NOT NULL,
NOME_CLIENTE VARCHAR(60) NOT NULL,
ENDERECO VARCHAR(60) NOT NULL,
NUMERO VARCHAR(10) NOT NULL,
ID_CIDADE INT NOT NULL,
CEP VARCHAR(9),
CONSTRAINT PK_CLI1 PRIMARY KEY (ID_CLIENTE),
CONSTRAINT FK_CLI1 FOREIGN KEY (ID_CIDADE) REFERENCES CIDADE(ID_CIDADE)
)


--DROP TABLE CIDADE
--CRIAR TABELA CIDADE
CREATE TABLE CIDADE
(
ID_CIDADE INT IDENTITY(1,1) NOT NULL,
NOME_CIDADE VARCHAR(60) NOT NULL,
UF VARCHAR(2) NOT NULL,
CONSTRAINT PK_CID1 PRIMARY KEY (ID_CIDADE)
)



/*
EXERC�CIO 2 
Restaurar o arquivo  treino.bak no banco de dados criado.
*/
USE MASTER
RESTORE DATABASE TREINO FROM DISK =N'C:\Users\amarildojunior_frwk\TREINO.BAK' WITH REPLACE
/*
EXERC�CIO 3 
Liste todos os clientes com seus nomes e com suas respectivas cidade e estados
*/
USE TREINO

SELECT * FROM CLIENTE
SELECT * FROM CIDADE
SELECT A.NOME_CLIENTE,A.ID_CIDADE,A.CEP,B.UF,B.NOME_CIDADE,A.ENDERECO FROM cliente A inner join cidade B on B.ID_CIDADE = A.ID_CIDADE

/*
EXERC�CIO 4 
Liste o c�digo do produto, descri��o do produto e descri��o das categorias dos produtos que tenham o valor unit�rio na 
faixa de R$ 10,00 a R$ 1500
*/

SELECT * FROM PRODUTOS
SELECT * FROM CATEGORIA
SELECT B.NOME_CATEGORIA,A.ID_PROD,A.NOME_PRODUTO,A.PRECO FROM PRODUTOS A INNER JOIN CATEGORIA B ON B.ID_CATEGORIA = A.ID_CATEGORIA WHERE A.PRECO >= 10.00 AND A.PRECO <= 1500.00 ORDER BY A.PRECO

/*
EXERC�CIO 5 
Liste o c�digo do produto, descri��o do produto e descri��o da categorias dos produtos, e tamb�m apresente uma coluna condicional  com o  nome de "faixa de pre�o" 
Com os seguintes crit�rios
�	pre�o< 500 : valor da coluna ser�  igual  "pre�o abaixo de 500"
�	pre�o  >= 500 e <=1000 valor da coluna ser� igual  "pre�o entre 500 e 1000"
�	pre�o  > 1000 : valor da coluna ser� igual  "pre�o acima de 1000".
*/
SELECT B.NOME_CATEGORIA,A.ID_PROD,A.NOME_PRODUTO,A.PRECO,
(CASE WHEN A.PRECO < 500 THEN 'Pre�o abaixo de 500' ELSE 
(CASE WHEN A.PRECO >= 500 AND A.PRECO <= 1000 THEN 'Preco entre 500 a 1000' ELSE
(CASE WHEN A.PRECO > 1000 THEN 'Preco maior que 1000' END)END)END) AS FaixaDePreco FROM PRODUTOS A INNER JOIN CATEGORIA B ON B.ID_CATEGORIA = A.ID_CATEGORIA ORDER BY PRECO

/*
EXERC�CIO  6
Adicione a coluna faixa_salario na tabela vendedor tipo char(1)
*/
BEGIN TRANSACTION
ALTER TABLE VENDEDORES ADD FAIXA_SALARIO char(1)
SELECT * FROM VENDEDORES

COMMIT 
/*
EXERC�CIO 7 
Atualize o valor do campo faixa_salario da tabela vendedor com um update condicional .
Com os seguintes crit�rios
�	salario <1000 ,atualizar faixa = c
�	salario >=1000  and <2000 , atualizar faixa = b
�	salario >=2000  , atualizar faixa = a

**VERIFIQUE SE OS VALORES FORAM ATUALIZADOS CORRETAMENTE
*/
-- CONDI��O
UPDATE VENDEDORES set FAIXA_SALARIO = CASE WHEN SALARIO < 1000 THEN 'C' WHEN SALARIO >= 1000 AND SALARIO < 2000 THEN 'B' WHEN SALARIO >= 2000 THEN 'A' END  


--VERIFICANDO SE FICOU CERTO
select * from vendedores

/*
EXERC�CIO 8
Listar em ordem alfab�tica os vendedores e seus respectivos sal�rios, mais uma coluna, simulando aumento de 12% em seus sal�rios.
*/
SELECT *,((A.SALARIO * 0.12) + A.SALARIO) AS Aplicacao FROM VENDEDORES A order by A.NOME_VENDEDOR

/*EXERC�CIO 9
Listar os nome dos vendedores, sal�rio atual , coluna calculada com salario novo + reajuste de 18% sobre o sal�rio atual, calcular  a coluna acr�scimo e calcula uma coluna salario novo+ acresc.
Crit�rios
Se o vendedor for  da faixa �C�, aplicar  R$ 120 de acr�scimo , outras faixas de salario acr�scimo igual a 0(Zero )
*/

SELECT A.NOME_VENDEDOR,A.SALARIO,((A.SALARIO * 0.18) + A.SALARIO) AS Reajuste,(CASE WHEN A.FAIXA_SALARIO = 'C' THEN 120 WHEN A.FAIXA_SALARIO != 'C' THEN 0 END) as Acrescimo,(CASE WHEN A.FAIXA_SALARIO = 'C' THEN (A.SALARIO + 120)+(A.SALARIO * 0.18) WHEN A.FAIXA_SALARIO != 'C' THEN (A.SALARIO + (A.SALARIO * 0.18)) END) as SalarioNovo from VENDEDORES A

/*
EXERC�CIO 10
Listar o nome e sal�rios do vendedor com menor salario.
*/
SELECT top 1 * FROM VENDEDORES A order by A.SALARIO asc
/*
EXERC�CIO 11
Quantos vendedores ganham acima de R$ 2.000,00 de sal�rio fixo?
*/
select count(*) from VENDEDORES a where a.SALARIO > 2000.00
select * from vendedores
/*
EXERC�CIO 12
Adicione o campo valor_total tipo decimal(10,2) na tabela venda.
*/
alter table VENDAS add valor_total decimal(10,2)
select * from vendas
/*
EXERC�CIO 13
Atualize o campo valor_tota da tabela venda, com a soma dos produtos das respectivas vendas.
*/
select * from VENDA_ITENS
select * from vendas
update vendas set valor_total = (select sum(a.VAL_TOTAL) from venda_itens a where a.NUM_VENDA = vendas.NUM_VENDA)
/*
EXERC�CIO 14
Realize a conferencia do exerc�cio anterior, certifique-se que o valor  total de cada venda e igual ao valor total da soma dos  produtos da venda, listar as vendas em que ocorrer diferen�a.
*/

select * from vendas
select * from venda_itens
--Selecionado
select a.NUM_VENDA,a.VALOR_TOTAL,SUM(B.VAL_TOTAL)total_itens from vendas a inner join venda_itens b on a.num_venda = b.num_venda group by a.num_venda,a.valor_total having a.valor_total = sum(b.val_total)

/*
EXERC�CIO 15
Listar o n�mero de produtos existentes, valor total , m�dia do valor unit�rio referente ao m�s 07/2018 agrupado por venda.
*/
select * from vendas where month(vendas.data_venda) = 7
select * from venda_itens
select * from vendas
select A.NUM_VENDA,A.VALOR_TOTAL,COUNT(B.NUM_SEQ) QTD_PRODS,SUM(B.QTDE) QTDE,AVG(B.VAL_UNIT) AS VALOR_MEDIO from vendas a inner join venda_itens b on a.NUM_VENDA = B.NUM_VENDA WHERE Month(a.DATA_VENDA) = 7 AND YEAR(A.DATA_VENDA) = 2018 GROUP BY A.NUM_VENDA,A.VALOR_TOTAL
/*
EXERC�CIO 16
Listar o n�mero de vendas, Valor do ticket m�dio, menor ticket e maior ticket referente ao m�s 07/2017.
*/
SELECT COUNT(*) NUMERO_VENDAS,AVG(A.VALOR_TOTAL) AS VALOR_MEDIO,MIN(A.VALOR_TOTAL),MAX(A.VALOR_TOTAL) FROM VENDAS A WHERE MONTH(A.DATA_VENDA) = 7 AND YEAR(A.DATA_VENDA) = 2017


/*
EXERC�CIO 17
Atualize o status das notas abaixo de normal(N) para cancelada (C)
--15,34,80,104,130,159,180,240,350,420,422,450,480,510,530,560,600,640,670,714
*/
SELECT * FROM VENDAS
UPDATE VENDAS SET VENDAS.STATUS = 'C' WHERE NUM_VENDA IN (15,34,80,104,130,159,180,240,350,420,422,450,480,510,530,560,600,640,670,714)

/*
EXERC�CIO 18
Quais clientes realizaram mais de 70 compras?
*/
SELECT COUNT(A.ID_CLIENTE) AS QUANTIDADE_COMPRA,A.ID_CLIENTE FROM VENDAS A GROUP BY A.ID_CLIENTE ORDER BY QUANTIDADE_COMPRA DESC
/*EXERC�CIO 19
Listar os produtos que est�o inclu�dos em vendas que a quantidade total de produtos seja superior a 100 unidades.
*/
SELECT * FROM VENDAS
SELECT * FROM VENDA_ITENS
SELECT SUM(QTDE) AS QUANTIDADE,A.NUM_VENDA FROM VENDA_ITENS A GROUP BY A.NUM_VENDA HAVING SUM(QTDE) > 100
/*
EXERC�CIO 20
Trazer total de vendas do ano 2017 por categoria e apresentar total geral
*/
SELECT * FROM VENDA_ITENS
SELECT * FROM VENDAS
SELECT * FROM CATEGORIA
SELECT * FROM PRODUTOS
SELECT ISNULL(B.NOME_CATEGORIA,'TOTAL'),COUNT(A.ID_PROD) AS TOTAL_VENDA,SUM(A.VAL_TOTAL) AS QUANTIDADE_TOTAL_POR_CATEGORIA FROM VENDA_ITENS A INNER JOIN PRODUTOS C ON C.ID_PROD = A.ID_PROD INNER JOIN CATEGORIA B ON B.ID_CATEGORIA = C.ID_CATEGORIA INNER JOIN VENDAS D ON D.NUM_VENDA = A.NUM_VENDA WHERE YEAR(D.DATA_VENDA) = 2017 GROUP BY ROLLUP (B.NOME_CATEGORIA)
/*
EXERC�CIO 21
Listar total de vendas do ano 2017 por categoria e m�s a m�s apresentar subtotal dos meses e total geral ano.
*/
SELECT 
/*
EXERC�CIO 22
Listar total de vendas por vendedores referente ao ano 2017, m�s a m�s apresentar subtotal do m�s e total geral.
*/

/*
EXERC�CIO 23
Listar os top 10 produtos mais vendidos por valor total de venda com suas respectivas categorias
*/

/*
EXERC�CIO 24
Listar os top 10 produtos mais vendidos por valor total de venda com suas respectivas categorias, calcular seu percentual de participa��o com rela��o ao total geral.
*/

/*
EXERC�CIO 25
Listar apenas o produto mais vendido de cada M�s com seu  valor total referente ao ano de 2017.
*/

/*
EXERC�CIO 26
Lista o cliente e a data da �ltima compra de cada cliente.
*/

/*
EXERC�CIO 27
Lista o a data da �ltima venda de cada produto.
*/
