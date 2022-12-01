using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosUsandoHeranca.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime data { get; set; }

        public ProdutoUsado(string nome, double valor,DateTime Date) : base(nome, valor)
        {
            data = Date;
        }
        public override string Tag()
        {
            return $"{Nome} (Usado), Preço: R$ {Valor} (Manufaturado data: {data})\n";
        }
    }
}
