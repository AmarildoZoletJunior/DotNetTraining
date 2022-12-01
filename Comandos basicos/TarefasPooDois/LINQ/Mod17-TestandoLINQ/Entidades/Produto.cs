using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_TestandoLINQ.Entidades
{
     class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public int Id { get; set; }
        public Categoria categoria { get; set; }
        public Produto(double preco, string nome, int id, Categoria categoria)
        {
            Preco = preco;
            Nome = nome;
            Id = id;
            this.categoria = categoria;
        }
        public override string ToString()
        {
            return $"Nome do produto: {Nome}\nPreço do produto: {Preco}\nId:{Id}\nCategoria:{categoria.NomeCategoria}";
        }
    }
}
