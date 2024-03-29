﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12_JogoTabuleiro.Tabuleiro
{
     class Tabuleiroa
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiroa(int linha, int colunas)
        {
            this.linhas = linha;
            this.colunas = colunas;
            pecas = new Peca[linha, colunas];
        }
        public Peca peca(int linha,int coluna)
        {
            return pecas[linha, coluna]; ;
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
