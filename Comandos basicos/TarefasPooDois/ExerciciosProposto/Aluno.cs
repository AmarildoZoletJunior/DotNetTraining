using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposto
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double n3 { get; set; }

        public string CalcularNota()
        {
            double soma = (n1 + n2 + n3) / 3;
            const double media = 60.0;
            if(soma > 60.0)
            {
                return $"Nota Final = {soma}\n Aprovado.";
            }
            else
            {
                return $"Nota Final = {soma}\n Reprovado\nFaltou {soma - media} para passar.";
            }
        }
    }
}
