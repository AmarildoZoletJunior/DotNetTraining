using HashSetSortedSet.Entidade;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace teste
{
    class programa
    {
        public static void Main(string[] args)
        {

            //Utilizando alguns comandos de HashSet
            /* HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("teste");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Tablet"));

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            */

            //Inicio de uso de UnionWith,ExceptionWith,IntersectWith

            /*
            SortedSet<string> A = new SortedSet<string>();
            A.Add("ola");
            A.Add("teste123");
            A.Add("Udemy");

            SortedSet<string> B = new SortedSet<string>();
            B.Add("OlaMundo");
            B.Add("MundoOla");
            B.Add("ola");

            SortedSet<string> C = new SortedSet<string>(B);
            C.UnionWith(A);
            Console.WriteLine("tasdaasdasdas");

            foreach(string p in C)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine();
            SortedSet<string> D = new SortedSet<string>(A);
            //D.IntersectWith(B);

         

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            D.ExceptWith(B);
            PrintCollection(D);

            */

            //Usando contains para Realizar testes


            /* 
            HashSet<string> TesteContains = new HashSet<string>();
            HashSet<string> TesteClasse = new HashSet<string>();

            TesteContains.Add("teste123");
            TesteContains.Add("jasndandsan");
            TesteClasse.Add("teste123");

            Console.WriteLine(TesteContains.Contains("teste123"));


            */



            HashSet<Produto> teste = new HashSet<Produto>();

            teste.Add(new Produto("Note", 2500));
            teste.Add(new Produto("tv", 1500));

            HashSet<Produto> teste2 = new HashSet<Produto>();


            Produto teste42 = new Produto("Note", 2500);
            foreach(Produto p in teste)
            {
                Console.WriteLine(p.Preco.GetHashCode());
                Console.WriteLine("Teste Note " + teste42.Preco.GetHashCode());
               
            }
            List<Produto> teste43 = new List<Produto>();

            Console.WriteLine(teste.Contains(teste42));


            HashSet<ProdutoStruct> listaStruct = new HashSet<ProdutoStruct>();

            listaStruct.Add(new ProdutoStruct("Tablet", 2500));
            listaStruct.Add(new ProdutoStruct("TV", 2100));
            listaStruct.Add(new ProdutoStruct("Computador", 2700));

            ProdutoStruct produto = new ProdutoStruct("Tablet", 2500);

            listaStruct.Contains(produto);
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}