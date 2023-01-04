using Mod14_InterfacePagamentoContrato.Entidades;
using Mod14_InterfacePagamentoContrato.Erros;
using Mod14_InterfacePagamentoContrato.Servicos;
using Mod14_InterfacePagamentoContrato.Tela;
using System;

namespace ProgramaPrincipal
{
    class ProgramaSystem
    {
        public static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                PaypalService paypalService = new PaypalService();
                Nubank nubank = new Nubank();
                Contrato contratoMes = new Contrato();
                Console.Write("Digite a data inicial do contrato(dd/mm/yyyy)\nR:");
                DateTime Inicio = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite a data final do contrato(dd/mm/yyyy)\nR:");
                DateTime Final = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor total deste contrato?\nR:");
                double ValorTotal = double.Parse(Console.ReadLine());
                CamadaTela.DecisaoContrato();
                int decisao = int.Parse(Console.ReadLine());
                switch (decisao)
                {
                    case 1:
                        contratoMes = new Contrato(rand.Next(1, 2000), Inicio, Final, ValorTotal, paypalService);
                        break;
                    case 2:
                        contratoMes = new Contrato(rand.Next(1, 2000), Inicio, Final, ValorTotal, nubank);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Digite novamente");
                        Console.WriteLine();
                        CamadaTela.DecisaoContrato();
                        decisao = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine(contratoMes);
            }
            catch(Errors e)
            {
                Console.WriteLine(e.Message);    
            }
        }
    }
}