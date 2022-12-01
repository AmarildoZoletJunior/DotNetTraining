using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisEstimação.Entidades
{
    class Animais
    {
        public string NomeAnimal { get; private set; }
        public int Idade { get; private set; }
        public string Tipo { get; private set; }

        public Animais(string nomeAnimal, int idade,string Tipo)
        {
            NomeAnimal = nomeAnimal;
            Idade = idade;
            if(Tipo == "Cachorro")
            {
                this.Tipo = Tipo;
            }else
            if (Tipo == "Gato")
            {
                this.Tipo = Tipo;
            }else
            if (Tipo == "Peixe")
            {
                this.Tipo = Tipo;
            }
            else
            {
                this.Tipo = "Peixe";
            }
        }

        public string Comer()
        {
            return "Estou comendo";
        }
        public override string ToString()
        {
            return $"Tipo:{Tipo}\nNome do animal: {NomeAnimal}\n Idade:{Idade}";
        }

    }
}
