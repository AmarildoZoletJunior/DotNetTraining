using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasAlugadas.Entidades
{
    class Dono
    {
        public int QuantidadeDeCasa { get; set; }
        public string Nome { get; set; }

        public Regiao local { get; set; } 

        List<Aluguel> Aluguel { get; set; } = new List<Aluguel>();

        public Dono()
        {

        }

        public Dono(int quantidadeDeCasa, string nome, Regiao Local)
        {
            QuantidadeDeCasa = quantidadeDeCasa;
            Nome = nome;
            local = Local;
        }

        public void AlugarCasa(Aluguel contrato)
        {
            Aluguel.Add(contrato);
        }
        public void RemoverAluguel(Aluguel contrato)
        {
            Aluguel.Remove(contrato);
        }
        public double GanhoTemporada()
        {
            double soma = 0;
            foreach(Aluguel contrato in Aluguel)
            {
                if(contrato.Data.Month == 12 || contrato.Data.Month == 01 || contrato.Data.Month == 02 || contrato.Data.Month == 3 || contrato.Data.Month == 4)
                {
                    soma += contrato.ValorTotal() + 250;
                }
            }
            return soma;
        }
        public  double GanhoSemTemporada()
        {
            double soma = 0;
            foreach (Aluguel contrato in Aluguel)
            {
                if (contrato.Data.Month >  4 &&  contrato.Data.Month <= 11)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
