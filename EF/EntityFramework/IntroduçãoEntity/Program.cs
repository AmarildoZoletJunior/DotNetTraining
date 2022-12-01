using Microsoft.EntityFrameworkCore;
using System;

namespace EFGetStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {

                Console.WriteLine($"DataBasePath: {db.DbPath}");

                //Criando blog


                db.Blogs.Add(new Blog { Url = "www.youtube.com" });
                db.SaveChanges();

                //Selecionando blog
                var BlogUm = db.Blogs.Where(x => x.Url == "www.youtube.com").First();
    
                //Criar o post dps de selecionar o blog
                BlogUm.Posts.Add(new Post { Title = "Ola a todos isto é um teste", Content = "Corpo do post" });
                db.SaveChanges();


                //Criando um Comentario para o post selecionado, para criar este comentario teremos que filtrar pelo db
                var PostNumeroUm = db.Posts.Where(x => x.BlogId == 6).First();
                PostNumeroUm.Comentarios.Add(new Comentarios { Corpo = "ajsndjassa" });
                db.SaveChanges();

            }
        }
    }
}