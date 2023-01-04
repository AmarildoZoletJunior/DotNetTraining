using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mod17_FuncionariosLinq.Entidades
{
     class Banco
    {
        public string Path { get; set; }

        List<Funcionario> Funcionarios = new List<Funcionario>();
        public Banco(string path)
        {
            Path = @path;
        }

        public void AdicionarNoBloco(Funcionario Func)
        {
            using(StreamWriter fs = File.AppendText(Path))
            {
                    fs.WriteLine($"{Func.Nome},{Func.Salario},{Func.Email},{Func.Id}");
            }
        }
        public void ExcluirNoBloco(int id)
        {
            using(StreamWriter fs = File.CreateText(Path))
            {
                var func = Funcionarios.Where(x => x.Id != id).ToList();

                foreach(Funcionario funcionario in func)
                {
                    fs.WriteLine($"{funcionario.Nome},{funcionario.Salario},{funcionario.Email},{funcionario.Id}");
                }
            }
        }
        public void EditarFuncionario(int id,double Salario)
        {
            AtualizarLista();
            using (StreamWriter fs = File.CreateText(Path))
            {
                var func = Funcionarios.Find(x => x.Id == id);
                func.Salario = Salario;
                 foreach (Funcionario funcionario in Funcionarios)
                {
                    fs.WriteLine($"{funcionario.Nome},{funcionario.Salario},{funcionario.Email},{funcionario.Id}");
                }
            } 
        }
        public void ListarFuncionarios()
        {
            using (StreamReader fs = File.OpenText(Path))
            {
                if (fs.EndOfStream)
                {
                    Console.WriteLine("Lista vazia, adicione funcionarios.");
                }
                while (!fs.EndOfStream)
                {
                    string[] lista = fs.ReadLine().Split(",");
                        Console.WriteLine($"Id do funcionario: {lista[3]}\nNome do funcionario:{lista[0]}\nSalario:R${lista[1]}\nEmail:{lista[2]}\n");
                        AtualizarLista();
                }
            }
        }
        public void AtualizarLista()
        {
            using (StreamReader fs = File.OpenText(Path))
            {
                Funcionarios.Clear();
                while (!fs.EndOfStream)
                {
                    string[] lista = fs.ReadLine().Split(",");
                    Funcionarios.Add(new Funcionario(lista[0], lista[2], double.Parse(lista[1]), int.Parse(lista[3])));
                }
            }
        }
        public void LimparLista()
        {
            Funcionarios.Clear();
        }
    }
}
