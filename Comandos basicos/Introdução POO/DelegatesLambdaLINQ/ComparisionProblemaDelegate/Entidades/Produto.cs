using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionProblemaDelegate.Entidades
{
    public class Produto
    {
        public string Nome { get; set; }
        public double valor { get; set; }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"{Nome}, Valor:{valor}";
        }
    }
}
