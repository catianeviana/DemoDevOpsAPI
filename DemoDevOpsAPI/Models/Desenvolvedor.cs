using System.ComponentModel.DataAnnotations;

namespace DemoDevOpsAPI.Models
{
    public class Desenvolvedor
    {
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public decimal Salario { get; set; }
        public string? Nivel { get; set; }
    }
}
