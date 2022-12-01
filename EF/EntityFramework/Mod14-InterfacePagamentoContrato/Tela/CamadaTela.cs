using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Tela
{
    static class CamadaTela
    {
        public static void DecisaoContrato()
        {
            Console.WriteLine("Escolha um serviço");
            Console.WriteLine("1-Paypal(1% ao mês + 2% por pagamento)");
            Console.WriteLine("2-Nubank(3% ao mês + 2% por pagamento)");
            Console.Write("R:");
        }
    }
}
