using ListTestes;
using System;

namespace ProgramaLista
{
    class TesteListas
    {
        public static void Main(string[] args)
        {

            List<string> alunos = new List<string>();
            alunos.Add("Amarildo");
            alunos.Add("Joao");
            alunos.Add("Maria");
            alunos.Add("Arnaldo");
            alunos.Add("Abigail");
            alunos.Add("Marco");
            alunos.Add("Marcia");
            alunos.Add("Wesley");
            alunos.Add("Thalia");
            List<string> selecionados = alunos.FindAll(x => x[0] == 'A');
            alunos.RemoveAll(x => x.Length > 4);
            List<Pessoa> sele = new List<Pessoa>();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Pessoa pessoa = new Pessoa(Console.ReadLine());
                sele.Add(pessoa);
            }
            List<Pessoa> newSele = sele.FindAll(x => x.Nome[0] == 'A');
            newSele.RemoveRange(0,2);
            foreach (Pessoa pessoa in newSele)
            {
                Console.WriteLine(pessoa.Nome);
            }
            newSele.
        }
    }
}