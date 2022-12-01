using System;

namespace funcionarios{
	class func
	{
		public int id { get; set; }
		public string nome { get; set; }
		public double salario { get; set; }




		public void aumento(double porcentagem)
		{
			salario += salario * porcentagem / 100.0;
		}

		public override string ToString()
		{
			return $"Nome: {nome}\nId: {id}\nSalario: {salario}";
		}
	}
}
