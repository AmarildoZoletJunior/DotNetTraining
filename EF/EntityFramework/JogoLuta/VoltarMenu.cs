using JogoLuta.Camada_Tela;
using JogoLuta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLuta
{
    static class VoltarMenu
    {
        public static void PrimeiroMenu()
        {
            //Console.Write("Digite o local do banco(bloco de notas):");
            
            string ArquivoUrl = @"C:\Users\amarildojunior_frwk\Desktop\Repositório c#\EstudosRec\Módulo 1 POO\JogoLuta.txt";
            LeituraBanco leitura = new LeituraBanco(ArquivoUrl);
            Lutar luta = new Lutar(ArquivoUrl, leitura);
            Decisoes decisoes = new Decisoes(leitura, luta);
            Console.WriteLine("----------------Menu-------------");
            Console.WriteLine("1-Criar lutador");
            Console.WriteLine("2-Escolher lutador existente");
            Console.WriteLine("3-Iniciar uma luta");
            decisoes.MenuPrincipal();
        }
    }
}
