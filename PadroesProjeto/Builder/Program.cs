
using Builder.Builders;
using Builder.Directors;
using Builder.Products;

internal class Program
{
    private static void Main(string[] args)
    {
        Builder.Builders.Builder builder = new Builder.Builders.Builder();
        Director diretor = new Director(builder);

        diretor.ConstructSedan();

        Vehicle sedan = builder.GetVehicle();
        Console.WriteLine($"Foi feito um carro do tipo: {sedan.TipoCarro}, ele tem airbags? {sedan.AirBags}");

        diretor.ConstrutorSUV();

        Vehicle SUV = builder.GetVehicle();
        Console.WriteLine($"Construido um carro do tipo: {SUV.TipoCarro}, ele tem airbags? {SUV.AirBags}");
    }
}