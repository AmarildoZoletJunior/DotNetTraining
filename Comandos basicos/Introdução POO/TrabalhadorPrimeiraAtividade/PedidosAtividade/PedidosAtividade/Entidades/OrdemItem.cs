using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosAtividade.Entidades
{
    class OrdemItem
    {
        public int Quantidade { get; set; }
        public double preco { get; set; }
        public Produto produto { get; set; }

        public OrdemItem(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            this.preco = produto.preco;
            this.produto = produto;
        }

        public double TotalCompra()
        {
            return preco * Quantidade;
        }

    }
}
