using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Range(0.01, 100000, ErrorMessage = "Preço maior que zero.")]
        public decimal Preco { get; set; }

        [Range(1, 100000, ErrorMessage = "Informe uma quantidade maior que zero.")]
        public int Quantidade { get; set; }
    }
}
