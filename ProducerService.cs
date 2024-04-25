using Confluent.Kafka;
using System.Text.Json;

namespace Kafka.Producer.API
{
    public class ProducerService
    {
        private readonly IConfiguration _configuration;
        private readonly ProducerConfig _producerConfig;
        private readonly ILogger<ProducerService> _logger;

        public ProducerService(IConfiguration configuration, ILogger<ProducerService> logger)
        {
            _configuration = configuration;
            _logger = logger;

            var boostrap = _configuration.GetSection("KafkaConfig:BootstrapServers").Value;
            _producerConfig = new ProducerConfig
            {
                BootstrapServers = boostrap
            };
            _logger = logger;
        }

        public async Task<string> SendMessage(TemplateRequest template)
        {
            var topic = _configuration.GetSection("KafkaConfig:TopicName").Value;
            try
            {
                using var producer = new ProducerBuilder<Null, string>(_producerConfig).Build();
                var message = JsonSerializer.Serialize(template);
                var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
                var mensagem = "Status:" + result.Status + " Message:" + message;
                _logger.LogInformation(mensagem);

                return mensagem;
            }
            catch (ProduceException<Null, string> e)
            {
                var erroMensagem = $"Entrega Falhou: {e.Error.Reason}";
                _logger.LogError(e, erroMensagem);
                return erroMensagem;
            }
        }
    }
}