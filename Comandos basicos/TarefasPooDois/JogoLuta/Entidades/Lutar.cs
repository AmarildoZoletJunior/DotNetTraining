using JogoLuta.Camada_Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JogoLuta.Entidades
{
    class Lutar
    {
        public LeituraBanco leitura { get; set; }
        public string Caminho { get; set; }
        public bool Autorizacao { get; set; }
        public Lutar(string Caminho, LeituraBanco leitura)
        {
            this.Caminho = Caminho;
            this.leitura = leitura;
        }
        public void ValidarLuta()
        {
            Autorizacao = true;
            leitura.ListarLutadores();
            Console.Write("Digite o nome do lutador numero 1:");
            string l11 = Console.ReadLine();
            Lutador l1 = leitura.listaLutadores.Find(x => x.NomeLutador == l11);
            Console.WriteLine();
            Console.WriteLine(l1);
            Console.Write("Digite o nome do lutador numero 2:");
            string l12 = Console.ReadLine();
            Lutador l2 = leitura.listaLutadores.Find(x => x.NomeLutador == l12);
            Console.WriteLine();
            Console.WriteLine(l2);
            if (l1.Peso.Equals(l2.Peso))
            {
                Autorizacao = true;
                Console.Write("Deseja iniciar a luta?(S/N):");
                char decisao = char.Parse(Console.ReadLine());
                if(decisao == 'S' || decisao == 's')
                {    
                    IniciarLuta(l1, l2);
                    Autorizacao = false;
                }
                else
                {
                    Autorizacao = false;
                    Console.WriteLine("Terá que fazer novamente a validação.");
                    Console.ReadKey();
                    Console.Clear();
                    VoltarMenu.PrimeiroMenu();
                } 
            }
            else
            {
                Autorizacao = false;
                Console.WriteLine("O Peso dos lutadore estão desbalanceados.");
                Console.ReadKey();
                Console.Clear();
                VoltarMenu.PrimeiroMenu();
            }
        }
        public void IniciarLuta(Lutador lutador1, Lutador lutador2)
        {
            if(Autorizacao)
            {
            Console.WriteLine(lutador1);
                Random rnd = new Random();
                while(lutador1.Vida > 0 && lutador2.Vida > 0)
                {
                    int dice = rnd.Next(1, 10);
                    switch (dice)
                    {
                        case 1:
                            Console.WriteLine($"Jogador 1 Acertou um golpe normal. Jogador 2 com {lutador2.Vida} de vida");
                            lutador2.Vida -= lutador1.AtaqueNormal();
                            break;
                        case 2:
                            Console.WriteLine($"Jogador 1 Acertou um golpe critico. Jogador 2 com {lutador2.Vida} de vida");
                            lutador2.Vida -= lutador1.AtaqueCritico();
                            break;
                        default:
                            Console.WriteLine("Jogador 2 Defendeu");
                            break;
                    }
                    switch(dice)
                    {
                        case 1:
                            Console.WriteLine($"Jogador 2 Acertou um golpe normal. Jogador 1 com {lutador1.Vida} de vida");
                            lutador1.Vida -= lutador1.AtaqueNormal();
                            break;
                        case 2:
                            Console.WriteLine($"Jogador 2 Acertou um golpe normal. Jogador 1 com {lutador1.Vida} de vida");
                            lutador1.Vida -= lutador1.AtaqueCritico();
                            break;
                        default:
                            Console.WriteLine("Jogador 1 Defendeu");
                            break;
                    }
                }
                if(lutador1.Vida <= 0)
                {
                    Console.WriteLine("Jogador 2 Ganhou");
                }
                if( lutador2.Vida <= 0)
                {
                    Console.WriteLine("Jogador 1 Ganhou");
                }
                }
            }
          }
    }
