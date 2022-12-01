using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_IComparable.Entidades
{
    class Funcionario : IComparable<Funcionario>
    {
        public string nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            Salario = salario;
        }

        public int CompareTo(Funcionario func)
        {
            if(Salario > func.Salario)
            {
                return 1;
            }
            else if(Salario == func.Salario)
            {
                return -1;
            }else
            {
                return 0;
            }
        }

    }
}
