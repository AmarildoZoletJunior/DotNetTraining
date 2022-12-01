using NovoPrograma;
using System;
using Quartos;
using System.Collections.Generic;
using funcionarios;

namespace Teste
{
    class Program
    {
          static void Main(string[] args)
        {
            List<func> lista = new List<func>();
            Console.Write("Digite quantos funcionarios quer cadastrar\nR:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do funcionario\nR:");
                string Nome = Console.ReadLine();
                Console.Write("Digite o id deste usuario\nR:");   
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Digite o salario deste funcionario\nR:");
                double Valor = double.Parse(Console.ReadLine());
                lista.Add(new func() { nome = Nome,id = Id, salario = Valor });
            }
            Console.Write("Digite o id do usuario que deseja aumentar o salario\nR:");
            int idUsuario = int.Parse(Console.ReadLine());
            func f = lista.Find(x => x.id == idUsuario);
            if(f != null)
            {
                Console.Write("Digite a porcentagem\nR:");
                double porce = double.Parse(Console.ReadLine());
                f.aumento(porce);
            }
            else
            {
                Console.Write("Nenhum id foi encontrado");
            }
            Console.WriteLine();
            foreach (func obj in lista)
            {
                Console.WriteLine(obj);
            }
     Console.Read();
           
    }
}
    }
   