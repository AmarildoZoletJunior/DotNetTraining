using Mod10_AtividadePessoaFJ.Entidades;
using System;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            try
            {
                PessoaFisica PessoaNumUm = new PessoaFisica("asdsad", 25000, 2500.00);
                PessoaJuridica PessoaJuridicaUm = new PessoaJuridica("Framework", 25000, -5);
                Console.WriteLine(PessoaNumUm.CalcularImposto());
                Console.WriteLine(PessoaJuridicaUm.CalcularImposto());
            }
            catch(ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}