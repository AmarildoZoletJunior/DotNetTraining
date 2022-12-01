using Mod17_FuncionariosLinq.Entidades;


namespace Mod17_FuncionariosLinq.Tela
{
    internal class Decisao : Banco
    {
        public string Path { get; set; }
        public Decisao(string path) : base(path)
        {
            Path = @path;
        }
        public void MenuEscolha()
        {
            Console.Clear();
            Camada_Tela.EscolhaInicial();
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    ListarFuncionarios();
                    Console.WriteLine("Pressione qualquer tecla para Voltar ao Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Id do funcionario\nR:");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome do funcionario\nR:");
                    string Nome = Console.ReadLine();
                    Console.Write("Salario do funcionario\nR:");
                    double salario = double.Parse(Console.ReadLine());
                    Console.Write("Email do funcionario\nR:");
                    string email = Console.ReadLine();
                    AdicionarNoBloco(new Funcionario(Nome,email,salario,id));
                    Console.WriteLine("Pressione qualquer tecla para Voltar ao Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Digite o id do Funcionario\nR:");
                    int idExcluir = int.Parse(Console.ReadLine());
                    ExcluirNoBloco(idExcluir);
                    Console.WriteLine("Pressione qualquer tecla para Voltar ao Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Digite o id do funcionario que deseja editar\nR:");
                    int idEditar = int.Parse(Console.ReadLine());
                    Console.Write("Digite o novo salario do funcionario\nR:");
                    double NovoSalario = double.Parse(Console.ReadLine());
                    EditarFuncionario(idEditar, NovoSalario);
                    Console.WriteLine("Pressione qualquer tecla para Voltar ao Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;
                case 5:
                    LimparLista();
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;
                default:
                    Console.WriteLine("Pressione qualquer tecla para Voltar ao Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Camada_Tela.EscolhaInicial();
                    MenuEscolha();
                    break;

            }
        }
    }
}
