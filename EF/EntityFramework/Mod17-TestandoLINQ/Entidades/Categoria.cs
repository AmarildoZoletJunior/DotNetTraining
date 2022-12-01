using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_TestandoLINQ.Entidades
{
     class Categoria
    {
        public string NomeCategoria { get; set; }
        public int Id { get; set; }


        public Categoria(string nomeCategoria, int id)
        {
            NomeCategoria = nomeCategoria;
            Id = id;
        }
    }
}
