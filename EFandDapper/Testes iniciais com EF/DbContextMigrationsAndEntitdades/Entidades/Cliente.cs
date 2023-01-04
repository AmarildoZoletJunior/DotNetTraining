using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextMigrationsAndEntitdades.Entidades
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
