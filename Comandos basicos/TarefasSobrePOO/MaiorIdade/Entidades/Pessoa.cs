using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade.Entidades
{
     class Pessoa
    {
        public string Nome { private set; get; }
        public int Idade { private set; get; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public Pessoa() { }

        public override string ToString()
        {
            return $"Nome:{Nome}\nIdade:{Idade}";
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Pessoa)) return false;
            Pessoa pessoa = obj as Pessoa;
          if(Idade > pessoa.Idade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
