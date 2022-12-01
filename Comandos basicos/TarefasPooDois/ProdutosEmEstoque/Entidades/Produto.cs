using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosEmEstoque.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public void Adicionar(int Quantidade)
        {
            this.Quantidade += Quantidade;
        }

        public void Remover(int Quantidade)
        {
            this.Quantidade -= Quantidade;
        }

        public override string ToString()
        {
            return $"Nome do produto:{Nome}, Quantidade:{Quantidade},Preço Unitario:R${Preco},Valor total:{ValorTotal()}";
        }
    }
}
