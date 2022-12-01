using System;

namespace Arrays
{
	class Arrays
	{

        public void ContasMedia()
    {
        Console.Write("Digite o tamanho do array\nR:");
        int n = int.Parse(Console.ReadLine());
        double[] vect = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor da posição {i + 1}\nR:");
            vect[i] = double.Parse(Console.ReadLine());
        }
        double soma = 0.0;
        for (int i = 0; i < n; i++)
        {
            soma += vect[i];
        }
        double total = soma / n;

        Console.WriteLine("Média: " + total);
        Console.Read();
    }
        
    }
}
