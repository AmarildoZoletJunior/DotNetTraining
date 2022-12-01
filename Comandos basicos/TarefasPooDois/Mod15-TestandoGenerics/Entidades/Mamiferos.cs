using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod15_TestandoGenerics.Entidades
{
    internal class Mamiferos : IComparable
    {
        public int idade { get; set; }
        public string Genero { get; set; }

        public Mamiferos(int idade, string genero)
        {
            this.idade = idade;
            Genero = genero;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Mamiferos))
            {
                throw new Exception("Erro");
            }
            Mamiferos novo = obj as Mamiferos;
            return idade.CompareTo(novo.idade);
        }
        public override string ToString()
        {
            return $"Genero:{Genero}\nIdade:{idade}";
        }
    }
}
