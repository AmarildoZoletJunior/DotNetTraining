using Aluguel2.Entidades;
using System;
using System.Collections.Generic;


namespace Aluguel2.Servico
{
    class TaxaBrasil : ITaxa
    {

        public double CalcularTaxaBrasil(double quantidade)
        {
            if(quantidade <= 100)
            {
                return quantidade * 0.2;
            }
            else
            {
                return quantidade * 0.15;
            }
        }
    }
}
