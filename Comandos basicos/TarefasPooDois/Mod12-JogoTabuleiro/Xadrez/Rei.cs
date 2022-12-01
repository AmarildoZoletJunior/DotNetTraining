using Mod12_JogoTabuleiro.Tabuleiro;
using System;


namespace Mod12_JogoTabuleiro.Xadrez
{
     class Rei : Peca
    {
        public Rei(Tabuleiroa tab, Cor cor) : base(cor,tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }

    }
}
