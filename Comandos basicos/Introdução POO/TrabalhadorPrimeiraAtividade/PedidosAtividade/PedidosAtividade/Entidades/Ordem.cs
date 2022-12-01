using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosAtividade.Entidades
{
    class Ordem
    {
        public DateTime Data { get; set; }
        public OrdemStatus Status { get; set; }

        public List<OrdemItem> Itens { get; set; } = new List<OrdemItem>();

        public Cliente Cliente { get; set; }

        public Ordem(OrdemStatus status, Cliente cliente)
        {
            Data = DateTime.Now;
            Status = status;
            Cliente = cliente;
        }   

        public void AdicionarItem(OrdemItem ordem)
        {
            Itens.Add(ordem);
        }
        public void RemoverItem(OrdemItem ordem)
        {
            Itens.Remove(ordem);
        }
        public double Total()
        {
            double soma = 0;
            foreach(OrdemItem ordem in Itens)
            {
                soma += ordem.preco;
            }
            return soma;
        }
        public override string ToString()
        {
            double Soma = 0;
            string total;
            total = "\nOrdem de pedido\n";
            total += $"Data de pedido:{Data}\n";
            total += $"Status do pedido: {Status}\n";
            total += $"Cliente: {Cliente.Nome} - {Cliente.Email}\n";
            total += $"Itens desta Ordem:\n";
            foreach(OrdemItem ordem in Itens)
            {
                total += $"{ordem.produto.nome}, R$ {ordem.preco}, Quantidade: {ordem.Quantidade}, Total: {ordem.TotalCompra()}\n";
            }
            foreach(OrdemItem ordem in Itens)
            {
                Soma += ordem.TotalCompra();
            }
            total += $"Total do pedido:{Soma}\n";
            return total;
        }
    }
}
