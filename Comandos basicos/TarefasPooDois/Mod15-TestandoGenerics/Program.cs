using Mod15_TestandoGenerics.Entidades;
using System;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Mamiferos n1 = new Mamiferos(50, "Masculino");
            Mamiferos n2 = new Mamiferos(25, "Masculino");
            Classificados teste = new Classificados();
            teste.Correr("Amarildo","Camile");

        }
    }
}