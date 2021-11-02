using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo descrição é obrigatório")]
        public string Description { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "O Campo quantidade é obrigatório")]
        public int Quantity { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O Campo quantidade é obrigatório")]
        public int CategoryId { get; set; }

        [Display(Name = "Categoria")]
        public Category Category { get; set; }
    }
}
