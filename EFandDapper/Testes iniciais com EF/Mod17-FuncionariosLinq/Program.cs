using Mod17_FuncionariosLinq.Entidades;
using Mod17_FuncionariosLinq.Tela;
using System;
using System.Linq;

namespace Programa
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\amarildojunior_frwk\Desktop\Repositório c#\EstudosRec\Módulo 1 POO\PASTABLOCODENOTAS\FuncionariosLinq.txt";
            Banco banco = new Banco(path);
            Decisao inicioPrograma = new Decisao(path);
            inicioPrograma.MenuEscolha();
        }
    }
}