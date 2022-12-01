using PessoaMaisVelha.Entidades;
using System;
using System.Globalization;

namespace ProgramaPrincipal
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da primeira pessoa:");
            Console.WriteLine("Digite o nome:");
            string nomeUm = Console.ReadLine(); 
            Console.WriteLine("Digite a idade:");
            int idadeUm = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite os dados da segunda pessoa:");
            Console.WriteLine("Digite o nome:");
            string nomeDois = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            int idadeDois = int.Parse(Console.ReadLine());

            Pessoa PessoaUm = new Pessoa(nomeUm,idadeUm);
            Pessoa PessoaDois = new Pessoa(nomeDois, idadeDois);
            if(PessoaUm.Idade > PessoaDois.Idade)
            {
                Console.WriteLine($"{PessoaUm.Nome} é mais velho(a).");
            }
            else
            {
                Console.WriteLine($"{PessoaDois.Nome} é mais velho(a).");
            }



            //Salario funcionario
            Console.WriteLine();
            Console.WriteLine("Média salario");
            Console.WriteLine("Digite os dados da primeira pessoa:");
            Console.WriteLine("Digite o nome:");
            string NomeFuncUm = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            double SalarioUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Digite os dados da segunda pessoa:");
            Console.WriteLine("Digite o nome:");
            string NomeFuncDois = Console.ReadLine();
            Console.WriteLine("Digite o salario:");
            double SalarioDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario FuncUm = new Funcionario(NomeFuncUm, SalarioUm);
            Funcionario FuncDois = new Funcionario(NomeFuncDois, SalarioDois);
            Console.WriteLine("Média é: " + (SalarioUm+SalarioDois) / 2);
        }
    }
}