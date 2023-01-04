using Adapter.Pagamentos;
using Adapter.Pagamentos.Adapters;
using Adapter.Pagamentos.MercadoPagoClasse;
using Adapter.Pagamentos.PaypalClasse;
using Adapter.Pagamentos.VisaClasse;

internal class Program
{
    private static void Main(string[] args)
    {
        Paypal teste = new Paypal();
        teste.GerarToken();
        teste.FazerPagamento();
        teste.ReceberPagamento(1);

        Visa vis = new Visa();

        IPaypal teste2 = new AdapterVisaPaypal(vis);
        teste2.GerarToken();
        teste2.ReceberPagamento(2);
        teste2.FazerPagamento();

        IPaypal teste3 = new AdapterMercadoPaypal(new MercadoPago());
        teste3.GerarToken();
        teste3.ReceberPagamento(2);
        teste3.FazerPagamento();
    }
}