using System;
using JogoLuta.Enum;
using JogoLuta.Erros;

namespace JogoLuta.Entidades
{
    
    class Lutador
    {
        public string NomeLutador { get; set; }
        public double Ataque { get; set; }
        public double Vida { get; set; }
        public ClassificacaoPeso Peso { get; set; }


        public Lutador(string nomeLutador, double ataque, double vida,double peso)
        {
            NomeLutador = nomeLutador;
            Ataque = ataque;
            Vida = vida;
            if (Ataque > 15)
            {
                Vida -= 50;
            }
            else
            {
                Vida += 50;
            }
            Peso = (ClassificacaoPeso)DefinicaoPeso(peso);
           
        }

        public double AtaqueNormal()
        {
            return Ataque;
        }
        public double AtaqueCritico()
        {
            return Ataque * 2;
        }
        public int DefinicaoPeso(double peso)
        {
            if(peso >= 40)
            {
                if(peso >= 40.0 && peso <= 80.0)
                {
                    return 1;
                }
                if(peso >= 80.0 && peso <= 120.0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"Nome:{NomeLutador}\nVida:{Vida}\nForça: {Ataque}\nAtaque bruto: {Ataque * 2}\nCategoria: {Peso}";
        }
    }
}
