using AtividadePost.Entidades;
using System;

namespace teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Digite o titulo da postagem\nR:");
            string title = Console.ReadLine();
            Console.Write("Digite aqui sua publicação\nR:");
            string body = Console.ReadLine();
            Post post1 = new Post(title,body);

            Console.Write("Digite seu comentário\nR:");
            string comment = Console.ReadLine();
            Comentario comentario1 = new Comentario(comment);
            post1.FazerComentario(comentario1);
            post1.Like();
            Console.Write(post1.ListarPost());
            Console.Read();
        }
    }
}