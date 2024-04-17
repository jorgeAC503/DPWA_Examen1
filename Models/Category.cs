using System.ComponentModel.DataAnnotations;

namespace PrimerExamen.Models
{
    public class Category
    {
        [Display(Name = " ID")]
        public int CategoryId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = " Nombre")]        
        public string CategoryName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        [Display(Name = " Descripcion")]
        public string Description { get; set; }


        [Display(Name = " Imagen")]
        public Char picture { get; set; }
    }
}
