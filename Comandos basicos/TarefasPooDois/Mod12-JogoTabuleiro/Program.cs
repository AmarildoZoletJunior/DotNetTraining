using Mod12_JogoTabuleiro;
using Mod12_JogoTabuleiro.Tabuleiro;
using Mod12_JogoTabuleiro.Xadrez;
using System;

namespace ProgramaTeste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Tabuleiroa tab = new Tabuleiroa(8, 8);
            tab.ColocarPeca(new Torre(tab,Enum.Parse<Cor>("Vermelho")),new Posicao(1,2));
            tab.ColocarPeca(new Rei(tab, Enum.Parse<Cor>("Vermelho")), new Posicao(1, 3));
            Tela.ImprimirTabuleiro(tab);
        }
    }
}