using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod15_ComparisonAtividade
{
    internal class Cliente
    {
        public double Preco { get; set; }
        public string Nome { get; set; }

        public Cliente(double preco, string nome)
        {
            Preco = preco;
            Nome = nome;
        }
    }
}
