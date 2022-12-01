using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_TestesIcomparable.Entidades
{
    internal class Funcionario : IComparable
    {
        public double Salario { get; set; }
        public string Nome { get; set; }

        public Funcionario(double salario, string nome)
        {
            Salario = salario;
            Nome = nome;
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new Exception("Erro, não é igual");
            }
            Funcionario funcionario = (Funcionario)obj;
            return Nome.CompareTo(funcionario.Nome);
        }
        public override string ToString()
        {
            return $"Nome: {Nome}   Salario: {Salario}";
        }

    }
}
