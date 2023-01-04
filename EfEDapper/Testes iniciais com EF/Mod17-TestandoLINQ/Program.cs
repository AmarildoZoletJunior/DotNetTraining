using Mod17_TestandoLINQ.Entidades;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProgramaLinq
{
    class Programa
    {
 
        public static void Main(string[] args)
        {
            Categoria Ferramentas = new Categoria("Ferramentas", 1);
            Categoria Maquinas = new Categoria("Maquinas", 7);
            Categoria Tecnologia = new Categoria("Tecnologia", 2);
            Categoria Materias = new Categoria("Materias", 5);

            List<Produto> Lista = new List<Produto>();
            Lista.Add(new Produto(19, "Martelo", 1, Ferramentas));
            Lista.Add(new Produto(90, "Machado", 2, Ferramentas));
            Lista.Add(new Produto(50, "Picareta", 3, Ferramentas));
            Lista.Add(new Produto(50, "Foice", 4, Ferramentas));
            Lista.Add(new Produto(450, "Furadeira", 5, Maquinas));
            Lista.Add(new Produto(800, "MotoSerra", 6, Maquinas));
            Lista.Add(new Produto(280, "Esmerilhadeira", 7, Maquinas));
            Lista.Add(new Produto(330, "Serra Marmore", 8, Maquinas));
            Lista.Add(new Produto(9000, "Macbook", 9, Tecnologia));
            Lista.Add(new Produto(5100, "Dell g15", 10, Tecnologia));
            Lista.Add(new Produto(4600, "Nitro 5 Acer", 11 , Tecnologia));
            Lista.Add(new Produto(7000, "Avell rtx 3060", 12, Tecnologia));

            var WhereSolo = Lista.Where(x => x.categoria.NomeCategoria == "Ferramentas");
            Console.WriteLine("------------------Lista utilizando WhereSolo:------------------");
            foreach(var item in WhereSolo)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var WhereSelect = Lista.Where(x => x.categoria.NomeCategoria == "Tecnologia").Select(x => x.Preco += x.Preco * 0.10);
            Console.WriteLine("------------------Lista utilizando WhereSelect:------------------");
            foreach (var item in WhereSelect)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var WhereOrder = Lista.Where(x => x.categoria.NomeCategoria == "Maquinas").OrderBy(x => x.Preco);
            Console.WriteLine("------------------Lista utilizando WhereOrder:------------");
            foreach (var item in WhereOrder)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var WhereOrderByDescending = Lista.Where(x => x.categoria.NomeCategoria == "Maquinas").OrderByDescending(x => x.Preco);
            Console.WriteLine("------------------Lista utilizando WhereOrderByDescending:------------------");
            foreach (var item in WhereOrderByDescending)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var WhereThenBy = Lista.OrderBy(x => x.Preco).ThenByDescending(x => x.Id);
            Console.WriteLine("------------------Lista utilizando WhereThenBy:------------------");
            foreach (var item in WhereThenBy)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var Selected = Lista.Select(x => x.Id);
            Console.WriteLine("------------------Lista utilizando Seleted:------------------");
            foreach (var item in Selected)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var SkipTake = Lista.Where(x => x.categoria.NomeCategoria == "Ferramentas").OrderBy(x => x.Preco).Skip(1).Take(2);
            Console.WriteLine("------------------Lista utilizando SkipTake:------------------");
            foreach (var item in SkipTake)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var ListaPrecoParaMédio = Lista.Where(x => x.Preco > 510.0).Select(x => x.Preco);
            Console.WriteLine("------------------Lista utilizando ListaPrecoParaMédio:------------------");
            foreach (var item in ListaPrecoParaMédio)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var Average = Lista.Where(x => x.Preco > 510.0).Select(x => x.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("------------------Preço média com Average:------------------");
            Console.WriteLine("Preço média dos preços acima de 510 = " + Average);
            Console.WriteLine();
            var VoltarPrimeiro = Lista.FirstOrDefault();
            Console.WriteLine("------------------Lista utilizando VoltarPrimeiro:------------------");
            Console.WriteLine(VoltarPrimeiro);
            Console.WriteLine();

            var Grupos = Lista.GroupBy(x => x.categoria);
            Console.WriteLine("------------------Lista utilizando Grupos:------------------");
            foreach (IGrouping<Categoria, Produto> group in Grupos)
            {
                Console.WriteLine();
                Console.WriteLine(group.Key.NomeCategoria);
                Console.WriteLine();
                foreach(var groups in group)
                {
                    Console.WriteLine(groups);
                }
            }
            Console.WriteLine();
        }
    }
}
