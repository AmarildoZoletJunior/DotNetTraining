using System;


namespace teste
{
    class programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Pagamento.Calcular(Pagamento.Salario.valor,Pagamento.Salario.imposto));
            Console.WriteLine(Pagamento.Salario.salarioLiquido());
        }
    }
}