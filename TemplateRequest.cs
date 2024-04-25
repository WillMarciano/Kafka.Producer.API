using System.ComponentModel.DataAnnotations;

namespace Kafka.Producer.API
{
    public class TemplateRequest
    {
        [Required(ErrorMessage = "O campo 'De' é obrigatório.")]
        public required string De { get; set; }

        [Required(ErrorMessage = "O campo 'Para' é obrigatório.")]
        public required string Para { get; set; }

        [Required(ErrorMessage = "O campo 'Assunto' é obrigatório.")]
        public required string Assunto { get; set; }
    }
}
