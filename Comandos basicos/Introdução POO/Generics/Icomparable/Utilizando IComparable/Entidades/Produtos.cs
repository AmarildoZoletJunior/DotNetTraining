using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_IComparable.Entidades
{
     class Produtos : IComparable
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Produtos(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"Nome: {NomeProduto}, Preço: {Preco}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produtos))
            {
                throw new Exception("Erro");
            }
            Produtos outro = obj as Produtos;

           return Preco.CompareTo(outro.Preco);
        }

        public override int GetHashCode()
        {
            return Preco.GetHashCode();
        }
    }
}
