using JogoLuta.Entidades;
using JogoLuta.Erros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLuta.Camada_Tela
{
    internal class Decisoes
    {
        public LeituraBanco leituraBanco { get; set; }

        public Lutar luta { get; set; }
        public string CaminhoArquivo { get; set; }

        
        public Decisoes(LeituraBanco banco,Lutar luta)
        {
            this.luta = luta;
            this.leituraBanco = banco;
        }


        public void MenuPrincipal()
        {

            int decisaoMenu = int.Parse(Console.ReadLine());
            bool running = true;
            while (running)
            {
                switch (decisaoMenu)
                {
                    case 1:
                        running = false;
                        leituraBanco.AdicionarLutador();
                        break;
                    case 2:
                        running = false;
                        Console.Clear();
                        Console.WriteLine(leituraBanco.ListarLutadores());
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        Console.Clear();
                        VoltarMenu.PrimeiroMenu();
                        break;
                    case 3:
                        running = false;
                        Console.Clear();
                        luta.ValidarLuta();
                        break;
                    default:
                        Console.Clear();
                        running = false;
                        VoltarMenu.PrimeiroMenu();
                        MenuPrincipal();
                        break;
                }
            }
        }
    }
}
