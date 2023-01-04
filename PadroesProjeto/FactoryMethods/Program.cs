using FactoryMethods.Factories;
using FactoryMethods.Vehicles;

internal class Program
{
    private static void Main(string[] args)
    {
        Transport transport;
        if(args.Length > 0 && args[0] == "uber")
        {
            transport = new CarTransport();
            transport.StartTransport();
        }else if(args.Length > 0 && args[0] == "log")
        {
            transport = new MotorcycleTransport();
            transport.StartTransport();
        }else if (args.Length > 0 && args[0] == "eats")
        {
            transport = new bicycleTransport();
            transport.StartTransport();
        }
        else
        {
            Console.WriteLine("Selecione o serviço");
        }
    }
}