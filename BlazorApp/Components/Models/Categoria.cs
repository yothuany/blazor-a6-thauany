using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Components.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = "";

        [Range(1, 100000, ErrorMessage = "Informe uma quantidade maior que zero.")]
        public int Quantidade { get; set; }
    }
}