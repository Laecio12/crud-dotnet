using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CursoMVC.Models
{
    public class Category
    {
        public int Id{ get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo descrição é obrigatório")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
