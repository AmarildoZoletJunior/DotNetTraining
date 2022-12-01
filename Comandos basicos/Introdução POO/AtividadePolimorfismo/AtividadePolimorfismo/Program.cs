using System;
using AtividadePolimorfismo.Entidades;


namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
        List<funcionario> list = new List<funcionario>();
            string texto = "Pagamentos\n";
        Console.Write("Digite a quantidade de funcionarios que serão adicionados\nR:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Funcionario numero {i+1}\n");
                Console.Write("Ele é tercerizado?(s/n)\nR:");
                char decisao = char.Parse(Console.ReadLine());
                if(decisao == 's') {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine(); 
                    Console.Write("Horas\nR:");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora\nR:");
                    double valorHora = double.Parse(Console.ReadLine());
                    Console.Write("Quanto de adicional\nR:");
                    double adicional = double.Parse(Console.ReadLine());
                    funcionario func = new FuncionarioTercerizado(nome, horas, valorHora, adicional);
                    list.Add(func);
                }
                if(decisao == 'n')
                {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();
                    Console.Write("Horas\nR:");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora\nR:");
                    double valorHora = double.Parse(Console.ReadLine());
                    funcionario func = new funcionario(nome, horas, valorHora);
                    list.Add(func);
                }
                if(decisao != 'n' && decisao != 's')
                {
                    Console.WriteLine("Ok, sem cadastro para este usuario");
                }
            }
            foreach(funcionario lista in list)
            {
                texto += $"{lista.Nome} - R$ {lista.Pagamento()}\n";
            }
            Console.Write(texto);

        }
    }
}