// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using TesteMensagemRabbit;

var factory = new ConnectionFactory()
{
    HostName = "localhost"
};

using(var connection = factory.CreateConnection())


using (var channel = connection.CreateModel())
{
    channel.ExchangeDeclare
        (
        "testeExchange2",
        "topic",
        true
        );


    var consumer = new EventingBasicConsumer(channel);

    consumer.Received += (model, ea) =>
    {
        var body = ea.Body.ToArray();
        if(body.Length <= 0)
        {
            Console.WriteLine("Aconteceu um erro");
        }
       var message = Encoding.UTF8.GetString(body);
        var teste = JsonConvert.DeserializeObject<CepDto>(message);
        Console.WriteLine($"Recebida {teste.CodigoPostal}");
    };

    channel.BasicConsume
        (
        queue: "testeExchange",
        autoAck: true,
        consumer: consumer
        );
 

    Console.ReadLine();
}