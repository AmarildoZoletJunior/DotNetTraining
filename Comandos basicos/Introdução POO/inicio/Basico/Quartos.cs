using System;

namespace Quartos
{
	class Aluguel
	{
		public string nome { get; set; }	
		public string email { get; set; }	
		public int NumeroQuarto { get; set; }




		public override string ToString()
		{
			return $"Nº Quarto: {NumeroQuarto}\nNome do Estudante: {nome}\nEmail: {email}\n";
		}
	}
}

/*  Aluguel[] Alugueis = new Aluguel[10];
            Console.Write("Digite a quantidade de alunos que irão alugar quartos\nR:");
            int alunos = int.Parse(Console.ReadLine());
            if(alunos < 10)
            {
                  for(int i = 0; i <  alunos; i++)
            {
                Console.Write("Digite o nome do aluno\nR:");
                string Nome = Console.ReadLine();
                Console.Write("Digite o email do aluno\nR:");
                    string Email = Console.ReadLine();
                    Console.Write("Digite o quarto que o aluno irá ficar(0,9)\nR:");
                    int Numero = int.Parse(Console.ReadLine());
                    if(Numero < 10 && Numero >= 0)
                    {
            
                          Alugueis[Numero] = new Aluguel {nome = Nome, email = Email, NumeroQuarto = Numero };
                  
                    }
                    else
                    {
                        return;
                    }

            }
                  for(int i = 0; i < Alugueis.Length; i++)
                {
                    Console.WriteLine(Alugueis[i]);
                }
           Console.Read();
            }
            else
            {
                return;
            }
         */