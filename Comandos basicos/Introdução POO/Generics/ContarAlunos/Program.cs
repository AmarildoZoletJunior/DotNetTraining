using ContarAlunos.Entidade;
using System;

namespace teste
{
    class Progrmaa
    {
        public static void Main(string[] args)
        {
            HashSet<Aluno> totalAlunos = new HashSet<Aluno>();
            Console.Write("Digite quantos alunos são do Curso A\nR:");
            int AlunosA = int.Parse(Console.ReadLine());
            for(int i = 0; i < AlunosA; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if(numero is int)
                {
                    totalAlunos.Add(new Aluno(numero));
                }
            }
            Console.Write("\nDigite quantos alunos são do Curso B\nR:");
            int AlunosB = int.Parse(Console.ReadLine());
            for (int i = 0; i < AlunosB; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero is int)
                {
                    totalAlunos.Add(new Aluno(numero));
                }
            }
            Console.Write("\nDigite quantos alunos são do Curso C\nR:");
            int AlunosC = int.Parse(Console.ReadLine());
            for (int i = 0; i < AlunosC; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero is int)
                {
                    totalAlunos.Add(new Aluno(numero));
                }
            }
            Console.WriteLine(totalAlunos.Count);
        }
    }
}