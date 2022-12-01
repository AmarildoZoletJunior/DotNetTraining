using Mod11_AtividadeErroContaBanco.Entidade;
using System;

namespace Programa
{
    class ProgramaErro
    {
        public static void Main(string[] args)
        {
            try
            {
                ClasseConta conta1 = new ClasseConta("Amarildo", 250, 2500);
                Console.WriteLine(conta1);
                conta1.Sacar(2600);
                Console.WriteLine(conta1);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}