using Bridge.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    public class LiveAvancada : Live
    {
        public LiveAvancada(IPlataform plataforma) : base(plataforma)   
        {
        }
        public void Gravar()
        {
            Console.WriteLine($"Iniciando gravação na {plataforma}");
        }
        public void SubTitle()
        {
            Console.WriteLine("Legendas ativadas");
        }
        public void Comentarios()
        {
            Console.WriteLine("Comentários liberados na live");
        }
    }

}
