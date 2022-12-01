using Mod12_JogoTabuleiro.Tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12_JogoTabuleiro.Xadrez
{
    internal class Torre : Peca
    {
            public Torre(Tabuleiroa tab, Cor cor) : base(cor, tab)
            {
            }
            public override string ToString()
            {
                return "T";
            }

        }
    }
