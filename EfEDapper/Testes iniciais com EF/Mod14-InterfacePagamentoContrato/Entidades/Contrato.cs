using Mod14_InterfacePagamentoContrato.Erros;
using Mod14_InterfacePagamentoContrato.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Entidades
{
    class Contrato
    {
        public int NumeroContrato { get; private set; }
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }
        public double ValorTotal { get; set; }


        ITaxa taxaValorTotal;

        List<Parcela> ListaParcela = new List<Parcela>();
        public Contrato(int numeroContrato, DateTime inicio, DateTime fim, double valorTotal, ITaxa taxa)
        {
            NumeroContrato = numeroContrato;
            if(valorTotal < 0)
            {
                throw new Errors("O valor do contrato não pode ser menor que R$150,00");
            }
            this.ValorTotal = valorTotal;
            taxaValorTotal = taxa;
           AdicionarParcelas(inicio, fim);
           ValidarData(inicio, fim);

        }
        public Contrato()
        {

        }
        public void AdicionarParcelas(DateTime Inicio,DateTime Fim)
        {
            TimeSpan TempoCorrido = Fim.Subtract(Inicio);
            int TotalMeses = TempoCorrido.Days / 30;
            double DivididoMes = ValorTotal / TotalMeses;
            for (int i = 0; i < TotalMeses; i++)
            {
                double ValorTotal = taxaValorTotal.CalculoTotal(i+1, DivididoMes);
                ListaParcela.Add(new Parcela(Inicio.AddMonths(i+1), ValorTotal));
            }
        }
        public void ValidarData(DateTime inicio, DateTime fim)
        {
            if (fim > inicio)
            {
                Inicio = inicio;
                Fim = fim;
            }
            else
            {
                throw new Errors("A data final não pode ser antes da inicial");
            }
        }
        public override string ToString()
        {
            string texto = "";
            texto += "Lista de contrato\n";
            foreach(Parcela contratos in ListaParcela)
            {
                texto += $"Data: {contratos.DataMes}\nValor a pagar: R$ {contratos.TotalMes.ToString("F2")}\n";
            }
            return texto;
        }
    }
}
