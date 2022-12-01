using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalhador.Entities.Enums;

namespace Trabalhador.Entities
{
    class Trabalho
    {
        public string NomeTrabalhador { get; set; }
        public Nivel Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();

        public Trabalho()
        {

        }
        public Trabalho(string nomeTrabalhador, Nivel level, double salarioBase, Departamento departamento)
        {
            NomeTrabalhador = nomeTrabalhador;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void Adicionar(HorasContrato contratos)
        {
            Contratos.Add(contratos);
        }
        public void Remover(HorasContrato contratos)
        {
            Contratos.Remove(contratos);
        }
        public double Ganho(int year,int month)
        {
            double somar = SalarioBase;
            foreach(HorasContrato contrato in Contratos)
            {
                if(contrato.data.Year == year && contrato.data.Month == month)
                {
                    somar += contrato.TotalValor();
                }
            }
            return somar;
        }
    }
}
