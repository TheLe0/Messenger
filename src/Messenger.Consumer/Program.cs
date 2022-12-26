using Confluent.Kafka;
using Messenger.Contracts;

Console.WriteLine("The Consumer has been started!");

var config = new ConsumerConfig { GroupId = "Messenger", BootstrapServers = "localhost:9092" };

using var consumer = new ConsumerBuilder<string, string>(config).Build();

consumer.Subscribe(MessageContract.Topic);

while (true)
{
    var result = consumer.Consume();

    Console.WriteLine(result.Message.Value);
}
