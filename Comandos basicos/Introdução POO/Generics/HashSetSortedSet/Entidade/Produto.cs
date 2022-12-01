using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetSortedSet.Entidade
{
     class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        public override int GetHashCode()
        {
            return Preco.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Produto))
            {
                return false;
            }
            Produto produto = obj as Produto;

            return Nome.Equals(produto.Nome) && Preco.Equals(produto.Preco);
        }
    }
}
