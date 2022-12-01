using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosUsandoHeranca.Entidades
{
    class ProdutoImportado : Produto
    {
        public double CustoFrete { get; set; }

        public ProdutoImportado(string nome, double valor, double custoFrete) : base(nome,valor)
        {
            CustoFrete = custoFrete;
        }
        public double PrecoTotal()
        {
            return Valor + CustoFrete;
        }
        public override string Tag()
        {
            return $"{Nome}, Preco:{PrecoTotal()} (Custo pelo frete: {CustoFrete})\n";
        }
    }
}
