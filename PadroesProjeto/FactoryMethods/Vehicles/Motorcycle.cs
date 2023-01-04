namespace FactoryMethods.Vehicles
{
    public class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos as encomendas!");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
