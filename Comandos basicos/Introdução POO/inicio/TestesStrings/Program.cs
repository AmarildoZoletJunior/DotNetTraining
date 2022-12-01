/*
using System;

namespace Programa
{
    class ProgramaInicial
    {
        public static void Main(string[] args) {
            Console.Write("Digite o tamanho da sua matriz\nR:");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numeros = Console.ReadLine().Split(" ");
                for(int l = 0; l < n; l++)
                {
                    matriz[i, l] = int.Parse(numeros[l]);  
                }
            }
            Console.Write("Digite o número que deseja buscar\nR:");
            int numeroBusca = int.Parse(Console.ReadLine());
            string Resposta = "Dados:";
            for(int i = 0; i < n; i++)
            {
                for(int l = 0;l < n; l++)
                {
                    if (matriz[i,l] == numeroBusca)
                    {
                        Resposta += $"Numero esta na posição: {i},{l}\n";
                        //Console.Write($"Direita: {matriz[i++,l]}\nEsquerda: {matriz[i--,l]}\nAcima: {matriz[i,l--]}\nAbaixo: {matriz[i,l++]}");
                        if (l > 0)
                        {
                            Resposta += $"A esquerda: {matriz[i, l - 1]}\n";

                        }
                        if (i > 0)
                            {
                                Resposta += $"Acima: {matriz[i - 1, l]}\n";
                        }
                        if(i < matriz.Rank)
                        {
                            Resposta += $"Abaixo: {matriz[i + 1, l]}\n";
                        }
                        if(l < matriz.Rank)
                        {
                            Resposta += $"A direita: {matriz[i, l + 1]}\n";
                        }
                        
                        Resposta += "-----------------------"; 
                    }
                }
            }
            Console.Write(Resposta);
            Console.Read();
        }
    }
}
*/
