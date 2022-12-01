using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeFuncionarioLista.Entidades
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void Aumento(double quantidade)
        {
            Salario += ((quantidade / 100) * Salario);
        }
        public override string ToString()
        {
            return $"Id:{Id}, Nome:{Nome}, Salario: {Salario}";
        }
    }
}
