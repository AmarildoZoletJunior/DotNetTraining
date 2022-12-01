using Mod12_JogoTabuleiro.Tabuleiro;
using System;


namespace Mod12_JogoTabuleiro
{
     class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiroa tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0;j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
