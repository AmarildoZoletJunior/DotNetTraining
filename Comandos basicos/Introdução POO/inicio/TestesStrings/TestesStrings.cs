using ConsoleApp3.Entities;
using ConsoleApp3.Entities.Enums;
using System;

namespace Strings
{
    class Teste
    {
        public static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = OrderStatus.PagamentoPendente,
            };

            string txt = order.Status.ToString();

            OrderStatus teste = Enum.Parse<OrderStatus>("Entregue");

            Console.WriteLine(teste);
        }
    }
}