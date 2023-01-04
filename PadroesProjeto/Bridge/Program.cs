using Bridge.Plataforma;
using Bridge.Transmissoes;

internal class Program
{
    static void StartLive(IPlataform plataforma)
    {
        Console.WriteLine("Aguarde...");
        Live live = new Live(plataforma);

        live.Broadcasting();
        live.Result();
    }

    static void StartLiveAvancada(IPlataform plataforma)
    {
        Console.WriteLine("Aguarde a live avançada");
        LiveAvancada live = new LiveAvancada(plataforma);
        live.Comentarios();
        live.SubTitle();
    }
    private static void Main(string[] args)
    {
        //StartLive(new TwitchTv());
        //StartLiveAvancada(new Youtube());

        StartLiveAvancada(new DLive());
        Console.ReadLine();


    }
}