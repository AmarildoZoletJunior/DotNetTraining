using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosUsandoHeranca.Entidades
{
    class Produto
    {
       public string Nome { get; protected set; }
       public double Valor { get;protected set; }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public virtual string Tag()
        {
            return $"{Nome}, R$ {Valor}\n";
        }
    }
}
