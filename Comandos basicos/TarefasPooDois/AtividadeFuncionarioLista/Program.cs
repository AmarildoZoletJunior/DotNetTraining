using AtividadeFuncionarioLista.Entidades;
using System;

namespace TesteFuncionario
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Funcionario> func = new List<Funcionario>();
            func.Add(new Funcionario("Amarildo",23,2500));
            func.Add(new Funcionario("Jonas", 25, 1700));
            func.Add(new Funcionario("Arnaldo", 26, 1500));
            func.Add(new Funcionario("Mario", 27, 2000));
            Funcionario pessoa = func.Find(x => x.Id == 23);
            if(pessoa != null)
            {
                pessoa.Aumento(10.0);
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada");
            }
           
            foreach(Funcionario f in func)
            {
                Console.WriteLine(f);
            }
                
            string teste = "ABC DCBF ASAFF- WQQDQ";
            string teste3 = "     ";
            bool teste2 = String.IsNullOrEmpty(teste3);
            Console.WriteLine(teste2);
            Console.WriteLine(teste);
        }
    }
}