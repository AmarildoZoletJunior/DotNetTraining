using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_FuncionariosLinq.Entidades
{
    internal class Funcionario
    {
        Random rnd = new Random();
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
        public int Id { get; set; }
        public Funcionario(string nome, string email, double salario,int id)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
            Id = id;
        }
    }
}
