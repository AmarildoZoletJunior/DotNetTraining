using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePost.Entidades
{
    class Post
    {
        public DateTime horarioPost { get; set; }
        public string titulo { get; set; }

        public string corpo { get; set; }
        public int like { get; set; }

        public List<Comentario> comentario { get; set; } = new List<Comentario>();

        public Post(string Titulo, string Corpo)
        {
            horarioPost = DateTime.Now;
            titulo = Titulo;
            corpo = Corpo;
        }

        public void FazerComentario(Comentario Comentario)
        {
            comentario.Add(Comentario);
        }
        public  string ListarPost()
        {
            string texto;
            texto = $"Horario que foi postado:{horarioPost}\n";
            texto += $"Titulo do post:{titulo}\n";
            texto += $"Corpo: {corpo}\n";
            texto += $"Quantidade de like:{like}\n";
            texto += "-------------------------------\n";
            texto += "Comentarios:";
            foreach(Comentario Comentario in comentario)
            {
                texto += $"{Comentario.text}\n";
            }
            return texto;
        }

        public int Like()
        {
            return like += 1;
        }
    }
}
