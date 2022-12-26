
using Confluent.Kafka;
using Messenger.Contracts;
using System.Runtime.CompilerServices;

Console.WriteLine("The producer has been initialized!");

var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

using var producer = new ProducerBuilder<string, string>(config).Build();

while (true)
{
    Console.WriteLine("New message to send: ");
    var rawLine = Console.ReadLine();

    if (string.IsNullOrEmpty(rawLine)) break;

    var contract = new MessageContract(rawLine);

    var message = new Message<string, string>
    {
        Key = contract.Id,
        Value = contract.Content
    };

    await producer.ProduceAsync(MessageContract.Topic, message);
}

Console.WriteLine("The producer has been finished!");
