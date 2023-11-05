using System;
using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using WaterMarkAppUI.RabbitMQEventModels;

namespace WaterMarkAppUI.Services
{
	public class RabbitMQProducer
	{
		private readonly RabbitMQClientService _rabbitMQClientService;

        public RabbitMQProducer(RabbitMQClientService rabbitMQClientService)
        {
            _rabbitMQClientService = rabbitMQClientService;
        }

        public void Publish(ProductImageCreatedEvent productImageCreatedEvent)
        {
            var channel = _rabbitMQClientService.Connect();

            var bodyString = JsonSerializer.Serialize(productImageCreatedEvent);

            var bodyByte = Encoding.UTF8.GetBytes(bodyString);

            var property = channel.CreateBasicProperties();
            property.Persistent = true;

            channel.BasicPublish(exchange:RabbitMQClientService.ExchangeName,routingKey: RabbitMQClientService.RoutingWatermark,basicProperties:property,body:bodyByte);
        }
    }
}

