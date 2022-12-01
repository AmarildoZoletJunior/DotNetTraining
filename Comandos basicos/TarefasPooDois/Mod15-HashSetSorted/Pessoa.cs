using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod15_HashSetSorted
{
     class Pessoa : IComparable
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public Pessoa(int idade,string nome)
        {
            Idade = idade;
            Nome = nome;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Pessoa))
            {
                throw new Exception("Erro");
            }
            Pessoa pessoa = obj as Pessoa;
            return Nome.Equals(pessoa.Nome);
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Pessoa))
            {
                throw new Exception("Erro");
            }
            Pessoa pessoa = obj as Pessoa;
            return Nome.CompareTo(pessoa.Nome);
        }
    }
}
