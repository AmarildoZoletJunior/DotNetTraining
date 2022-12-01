using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasAlugadas.Entidades
{
    class Aluguel
    {
        public DateTime Data { get; set; }
        public double ValorPorDia { get; set; }

        public int QuantidadeDia { get; set; }
        public Tamanho Tam { get; set; }


        public Aluguel()
        {

        }
        public Aluguel(DateTime data, double valorPorDia, int quantidadeDia, Tamanho tama)
        {
            Data = data;
            ValorPorDia = valorPorDia;
            QuantidadeDia = quantidadeDia;
            Tam = tama;
        }

        public double ValorTotal()
        {
  
           if(Tam == Tamanho.Pequena)
            {
                    return ValorPorDia * QuantidadeDia + 50;
                
            }
           if(Tam == Tamanho.Média)
            {
                return ValorPorDia * QuantidadeDia + 100;
            }
            
           if(Tam == Tamanho.Grande)
            {
   
                    return ValorPorDia * QuantidadeDia + 150;
            }
            return 1;
        }
    }
}
