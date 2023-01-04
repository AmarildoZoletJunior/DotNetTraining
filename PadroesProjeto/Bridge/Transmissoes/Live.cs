using Bridge.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    public class Live : ITransmissao
    {
        protected IPlataform plataforma;
        public Live(IPlataform plataform)
        {
            plataforma = plataform;
        }
  
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na  {plataforma}");
        }

        public void Result()
        {
            Console.WriteLine("Entrando no ar, On **************");
        }
    }
}
