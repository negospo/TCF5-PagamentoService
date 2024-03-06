using Infrastructure.Persistence;
using RabbitMQ.Client;
using System.Text;

namespace Infrastructure.RabbitMQ
{
    public class Connection
    {
        public static void SendMessage(string queueName, string message)
        {
            var factory = new ConnectionFactory() { HostName = Settings.RabbitMQConnectionString };
            using (var conn = factory.CreateConnection())
            {
                using (var channel = conn.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(exchange: "",
                                routingKey: queueName,
                                basicProperties: null,
                                body: body);
                }
            }
        }
    }
}
