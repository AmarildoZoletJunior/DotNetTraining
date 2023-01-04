using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextMigrationsAndEntitdades.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }
        public Cliente Clientes { get; set; }
        public string Nome { get; set; }


    }
}
