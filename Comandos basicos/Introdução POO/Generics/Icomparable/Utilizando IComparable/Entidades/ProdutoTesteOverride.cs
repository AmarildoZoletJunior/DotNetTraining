using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_IComparable.Entidades
{
    internal class ProdutoTesteOverride
    {
        public string Nome;
        public double Preco;

        public ProdutoTesteOverride(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is ProdutoTesteOverride))
            {
                return false;
            }
            ProdutoTesteOverride other = obj as ProdutoTesteOverride;

            return Preco.Equals(other.Preco);
        }
    }
}
