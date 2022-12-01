using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosAtividade.Entidades
{
     class Cliente
    {
       public string Nome { get; set; }
       public string Email { get; set; }
       public DateTime Aniversario { get; set; }

        public Cliente(string nome, string email, DateTime aniversario)
        {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }

    }
}
