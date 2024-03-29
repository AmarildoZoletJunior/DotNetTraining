﻿using System;


namespace Aluguel2.Entidades
{
    class AluguelCarro
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public Veiculo Veiculo { get; set; }

        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime start, DateTime finish, Veiculo veiculo)
        {
            Start = start;
            Finish = finish;
            Veiculo = veiculo;
        }

    }
}
