using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePost.Entidades
{
    class Comentario
   {
      public string text { get; set; }

        public Comentario(string texto)
        {
            text = texto;
        }
    }
}
