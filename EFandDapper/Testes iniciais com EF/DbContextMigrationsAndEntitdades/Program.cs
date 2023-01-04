using DbContextMigrationsAndEntitdades.Entidades;
using DbContextMigrationsAndEntitdades.Erros;
using DbContextMigrationsAndEntitdades.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Xml.Linq;

namespace ProgramaInicial
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            using (var BaseBanco = new MeuBanco())
            {
                try
                {
                    //Cadastrar Cliente
                    //AdicionarCliente(BaseBanco, "Amarildo");


                    //Cadastrar Produto
                    //AdicionarProduto(BaseBanco, 20, new Produto { Nome = "Amaciante"});


                    //Listar Clientes
                    //ListarClientes(BaseBanco);

                    //Listar Produtos por cliente
                    VerPedidoCliente(BaseBanco, "asdasd");

                    //Modificar Nome Cliente
                    //EditarCliente(BaseBanco, "Amarildo", "Amarildo Junior");

                    //Modificar Nome Produto de Cliente
                    //EditarProdutoCliente(BaseBanco, 2, "Amarildo Junior", "Amaciante Cheiroso");

                    //Remover Produto de cliente
                    //RemoverProdutoCliente(BaseBanco, "Amarildo Junior", "Amaciante Cheiroso");


                    //Remover Cliente
                    //RemoverCliente(BaseBanco, "Amarildo Junior");
                }
                catch(Erros e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //Cadastro
        static void AdicionarCliente(MeuBanco banco, Cliente cliente)
        {
            banco.Clientes.Add(cliente);
            banco.SaveChanges();
        }
        static void AdicionarProduto(MeuBanco banco,int IdCliente,Produto produto)
        {
            var pesquisa = banco.Clientes.Where(x => x.Id == IdCliente).First();
            pesquisa.Produtos.Add(produto);
            banco.SaveChanges();
        }



        //Listar
        static void VerPedidoCliente(MeuBanco banco, string nome)
        {
            Console.WriteLine("Pedido do Cliente:\n\n");
            var pesquisa = banco.Clientes.Where(x => x.Nome == nome).Include(x => x.Produtos).FirstOrDefault();
            if(pesquisa == null)
            {
                throw new Erros("Cliente não encontrado");
            }
            if(pesquisa.Produtos.Count() == 0)
            {
                throw new Erros("Este cliente não tem produtos cadastrados");
            }
            foreach (var produtos in pesquisa.Produtos)
            {
                Console.WriteLine($"Nome produto: {produtos.Nome}\nNome do cliente:{produtos.Clientes.Nome}\n");
            }
        }
        static void ListarClientes(MeuBanco banco)
        {
            if(banco.Clientes.Count() == 0)
            {
                throw new Erros("Não existe clientes cadastrados");
            }
            Console.WriteLine("Lista de cliente cadastrados:\n\n");
            foreach(var bancoClientes in banco.Clientes)
            {
                Console.WriteLine(bancoClientes.Nome);
            }
        }



        //Editar
        static void EditarCliente(MeuBanco banco, string nomeAntigo,string novoNome)
        {
            var pesquisa = banco.Clientes.Where(x => x.Nome == nomeAntigo).FirstOrDefault();
            if (pesquisa == null)
            {
                throw new Erros("Cliente não encontrado");
            }
            pesquisa.Nome = novoNome;
            banco.SaveChanges();
        }
        static void EditarProdutoCliente(MeuBanco banco, int id, string NomeCliente,string NovoProdutoNome)
        {
            var pesquisa = banco.Clientes.Where(x => x.Id == 1).Include(x => x.Produtos).FirstOrDefault();
            if (pesquisa == null)
            {
                throw new Erros("Cliente não encontrado");
            }
            var PesquisaProduto = pesquisa.Produtos.Where(x => x.Id == id).FirstOrDefault();
            if (PesquisaProduto == null)
            {
                throw new Erros("Produto não encontrado");
            }
            PesquisaProduto.Nome = NovoProdutoNome;
            banco.SaveChanges();
        }



        //Remover
        static void RemoverCliente(MeuBanco banco, string NomeCliente)
        {
            var pesquisa = banco.Clientes.Where(x => x.Nome == NomeCliente).FirstOrDefault();
            if (pesquisa == null)
            {
                throw new Erros("Cliente não encontrado");
            }
            banco.Remove(pesquisa);
            banco.SaveChanges();
        }
        static void RemoverProdutoCliente(MeuBanco banco,string NomeCliente,string NomeProduto)
        {
            var pesquisa = banco.Clientes.Where(x => x.Nome == NomeCliente).Include(x => x.Produtos).FirstOrDefault();
            if (pesquisa == null)
            {
                throw new Erros("Cliente não encontrado");
            }
            var produtoespecifico = pesquisa.Produtos.Where(x => x.Nome == NomeProduto).FirstOrDefault();
            if (produtoespecifico == null)
            {
                throw new Erros("Produto não encontrado");
            }
            pesquisa.Produtos.Remove(produtoespecifico);
            banco.SaveChanges();
        }
    }
}