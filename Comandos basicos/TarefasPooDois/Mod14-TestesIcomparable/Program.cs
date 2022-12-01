using Mod14_TestesIcomparable.Entidades;
using System;

namespace ProgramaComparar
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario(2500, "Amarildo"));
            funcionarios.Add(new Funcionario(1500, "Maria"));
            funcionarios.Add(new Funcionario(5000, "Wesley"));
            funcionarios.Add(new Funcionario(2300, "Joao"));
            funcionarios.Sort();
            foreach(Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}