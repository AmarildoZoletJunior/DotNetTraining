using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod17_FuncionariosLinq.Tela
{
    static class Camada_Tela
    {
        public static void EscolhaInicial()
        {
            Console.WriteLine("--------------Menu---------");
            Console.WriteLine("1-Listar funcionarios");
            Console.WriteLine("2-Adicionar novo funcionario");
            Console.WriteLine("3-Excluir Funcionario");
            Console.WriteLine("4-Editar funcionario");
        }
    }
}
