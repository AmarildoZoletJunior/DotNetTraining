using System;


namespace Banco
{
	 class Class1
	{

		public int numeroConta { get; private set; }
		public string nomeTitular { get; private set; }
		private double _saldoConta;

		public  double SaldoConta
		{
			get { return _saldoConta; }
			set
			{
				if (value > 0)
				{
					_saldoConta = value;
				}
			}
		}
		public void Cadastro()
		{
			int numero;
			string nome;

			Console.Write("Entre com o numero da conta\nR:");
			numero = int.Parse(Console.ReadLine());
			if(numero != null)
			{
				numeroConta = numero;
			}
			else
			{
                Console.WriteLine("Digite somente números sem vírgula");
            }
			Console.Write("Digite o nome do titular da conta\nR:");
			nome = Console.ReadLine();
			if(nome != null)
			{
				nomeTitular = nome;
			}
			else
			{
                Console.WriteLine("Nome invalido");
            }
			Console.WriteLine("Tera deposito inicial?(Sim/Não)");
			string decisao = Console.ReadLine();
			if(decisao == "Sim")
			{
				decisao = "a";
			}
			else if( decisao == "Nao" || decisao == "Não")
			{
				decisao = "b";
			} 

			switch (decisao)
			{
				case "a":
					Console.Write("Qual valor para deposito?\n:");
					double novoValor = double.Parse(Console.ReadLine());
					if(novoValor > 0)
					{
                        Console.WriteLine("Depositado com sucesso");
                        _saldoConta = novoValor;
					}
					else
					{
						Console.WriteLine("Valor negativo, Impossivel depositar");
                        _saldoConta = 0;
					}
					break;
				case "b":
                    _saldoConta = 0;
                    Console.WriteLine("Conta não consta deposito inicial");
                    break;
					default:
					Console.WriteLine("Resposta Indefinida, Conta não consta deposito inicial");
					break;
			}
		}

		public void AdicionarQuantia()
		{
			Console.Write("Digite o valor de deposito\nR:");
			double valor = double.Parse(Console.ReadLine());
			if (valor > 0)
			{
				_saldoConta += valor;
			}
		}

		public  void RemoverQuantia(double quantidade)
		{
            Console.Write("Digite o valor de retirada\nR:");
			double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
			{
				_saldoConta -= valor - 5;
			}
		}

		public override string ToString()
		{
			return $"Conta {numeroConta}, Titular: {nomeTitular}, Saldo:{SaldoConta}";
		}
	}
}