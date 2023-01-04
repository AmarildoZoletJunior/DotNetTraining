using AbstractFactory.App;
using AbstractFactory.Factorys;

internal class Program
{
    static Application ConfigureApplication()
    {
        Application app;

        ITransportFactory transportFactory;
        string company = "Lime";
        
        if(company == "Uber")
        {
            transportFactory = new UberTransport();
        }
        else if(company == "NineNine")
        {
            transportFactory = new NineNineTransport();
        }
        else
        {
            transportFactory = new LimeTransport();
        }
        app = new Application(transportFactory);
        return app;
    }
    private static void Main(string[] args)
    {

        Application app = ConfigureApplication();
        app.StartRoute();

        Console.ReadLine();
    }
}