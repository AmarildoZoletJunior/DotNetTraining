using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Entidades
{
    internal class Candidato
    {
        public string Nome { get; set; }
        public int Id { get; set; }

        public Candidato(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }


    }
}
