using System;
using Trabalhador.Entities;
using Trabalhador.Entities.Enums;

namespace Programa
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento\nR:");
            string nome = Console.ReadLine();
            Console.Write("Digite os dados do trabalhador:\n\n");
            Console.Write("Nome do funcionario\nR:");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Qual nivel de experiência?(Junior,Pleno,Senior)\nR:");
            Nivel os = Enum.Parse<Nivel>(Console.ReadLine());
            Console.Write("Digite o salario base deste funcionario\nR:");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento dept = new Departamento(nome);
            Trabalho trabalho = new Trabalho(nomeFuncionario,os,salarioBase,dept);

            Console.Write("Digite a quantidade de contratos\nR:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite as informações do {i+1} Contrato:");
                Console.Write("Digite a data(DD/MM/YYYY)\nR:");
                DateTime dataContrato = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite o valor ganho por hora\nR:");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de horas trabalhadas\nR:");
                int horas = int.Parse(Console.ReadLine());
                HorasContrato contrato = new HorasContrato(dataContrato, valorHora, horas);
                trabalho.Adicionar(contrato);
                Console.WriteLine("----------------------------------");
            }
            Console.Write("Digite o mes e ano no formato(mm/yyyy)\nR:");
            string MesAno = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Nome do trabalhador: " + trabalho.NomeTrabalhador);
            Console.WriteLine("Departamento: " + trabalho.Departamento.Nome);
            Console.WriteLine($"Ganhou no periodo: {mes}/{ano}: {trabalho.Ganho(ano,mes)}");
            Console.WriteLine("----------------------------------");
        }
    }
}