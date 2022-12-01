using Herança_e_polimorfismo.Entidades;
using System;

namespace Teste
{
    class Teste
    {
        public static void Main(string[] args)
        {
            Conta conta1 = new ContaEmpresa(1052,"Amarildo",1500,2000);
            Conta conta2 = new ContaPoupanca(1024, "Asadasd", 1500, 1.50);
            conta1.Sacar(50);
            conta2.Sacar(50);
            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);


          
        }
    }
}