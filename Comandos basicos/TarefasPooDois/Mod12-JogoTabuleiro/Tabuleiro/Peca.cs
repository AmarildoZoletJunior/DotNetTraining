using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12_JogoTabuleiro.Tabuleiro
{
     class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiroa tab { get; set; }

        public Peca(Cor cor, Tabuleiroa tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.QteMovimentos = 0;
        }

    }
}
