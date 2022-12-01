using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetSortedSet.Entidade
{
    struct  ProdutoStruct
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public ProdutoStruct(string nome,double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
