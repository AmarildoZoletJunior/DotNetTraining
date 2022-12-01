using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposto
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Imposto { get; set; }
        public double SalarioBruto { get; set; }


        public double SalarioLiquido()
        {
        return SalarioBruto - Imposto;
        }
        public void AumentarSalario(int i)
        {
            SalarioBruto = SalarioBruto *  (i / 100);
        }

        public override string ToString()
        {
            return $"Nome do funcionario: {Nome}, Salario Liquido: R$ {SalarioLiquido()}";
        }
    }
}
