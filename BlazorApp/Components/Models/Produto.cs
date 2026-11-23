using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Components.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Range(0.01, 100000, ErrorMessage = "Preço maior que zero.")]
        public decimal Preco { get; set; }

        [Range(1, 100000, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public int Quantidade { get; set; }
    }
}
