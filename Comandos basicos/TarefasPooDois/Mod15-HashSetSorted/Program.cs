using Mod15_HashSetSorted;
using System;

namespace ProgramaTeste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");   
            set.Add("d");   
            set.Add("e");
            set.Add("f");
            set.Add("g");

            HashSet<string> set2 = new HashSet<string>();
            set2.Add("a");
            set2.Add("b");
            set2.Add("c");
            set2.Add("w");
            Console.WriteLine(set2.Contains("a"));
            Console.WriteLine();
            HashSet<string> set3 = new HashSet<string>();
            set2.ExceptWith(set);
            
            foreach(string s in set2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Pessoa pessoaTeste = new Pessoa(15, "Amarildo");
            SortedSet<Pessoa> a = new SortedSet<Pessoa>();
        SortedSet<Pessoa> ints = new SortedSet<Pessoa>();

            a.Add(new Pessoa(20,"Amarildo"));
            a.Add(new Pessoa(50, "Wesley"));
            a.Add(new Pessoa(18,"Fabio"));
            foreach(Pessoa p in a)
            {
                Console.WriteLine(p.Nome);
            }
            Console.WriteLine();
            Console.WriteLine( "Aqui é o teste com o SortedSet: " +  a.Contains(pessoaTeste));
            Console.WriteLine();
            HashSet<Pessoa> c = new HashSet<Pessoa>();
            HashSet<Pessoa> d = new HashSet<Pessoa>();

            c.Add(new Pessoa(20, "Amarildo"));
            c.Add(new Pessoa(50, "Wesley"));
            c.Add(new Pessoa(18, "Fabio"));
            foreach(Pessoa teste in c)
            {
                Console.WriteLine(teste.Nome);
            }
            Console.WriteLine();
            HashSet<Pessoa> f = new HashSet<Pessoa>();

            f.Add(new Pessoa(20, "Amarildo"));
            f.Add(new Pessoa(50, "Wesley"));
            f.Add(new Pessoa(18, "Fabio"));
            foreach (Pessoa teste in c)
            {
                Console.WriteLine(teste.Nome);
            }
      

            Console.WriteLine("Teste com HashSet" + f.Contains(pessoaTeste));

            // SortedSet<int> un = new SortedSet<int>();
            // un.UnionWith(ints);
            // foreach(int s in un)
            //{
            //  Console.WriteLine(s);
            //}
        }
    }
}