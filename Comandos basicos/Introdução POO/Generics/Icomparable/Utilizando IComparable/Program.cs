using Microsoft.VisualBasic;
using System;
using Utilizando_IComparable.Entidades;

namespace Teste { 

 class Teste1
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Amarildo", 1500);
            Funcionario funcionario2 = new Funcionario("Mario", 2500);
            CompareTeste comparacao = new CompareTeste();
            List<Produtos> teste = new List<Produtos>();

            teste.Add(new Produtos("Celular",1700));
            teste.Add(new Produtos("Notebook", 2500));
            teste.Add(new Produtos("TV", 1200));




            if(comparacao.Compare(funcionario1,funcionario2) == 1)
            {
                Console.WriteLine("Você ganha mais");
            }else if(comparacao.Compare(funcionario1, funcionario2) == 0)
            {
                Console.WriteLine("Ganham a mesma coisa");
            }
            else
            {
                Console.WriteLine("Você ganha menos");  
            }
            Console.WriteLine(funcionario1.Salario.Equals(funcionario2.Salario));

            FuncionarioComparable ola = new FuncionarioComparable();

            Produtos max = ola.Max(teste);
            Console.WriteLine(max);


            ProdutoTesteOverride teste5 = new ProdutoTesteOverride("Amarildo",2500);
            ProdutoTesteOverride teste3 = new ProdutoTesteOverride("Kawan", 2500);
            Console.WriteLine(teste5.Equals(teste3));

        }
    }
}