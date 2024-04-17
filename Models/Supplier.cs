using System.ComponentModel.DataAnnotations;

namespace PrimerExamen.Models
{
    public class Supplier
    {
        [Display(Name = " ID")]
        public int SupplierId { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        [Display(Name = " Nombre")]
        public string CompanyName { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = " Nombre de contacto")]
        public string ContactName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = " Titulo")]
        public string ContactTitle { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        [Display(Name = " Direccion")]
        public string Address { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        [Display(Name = " Ciudad")]
        public string City { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = " Region")]
        public string Region { get; set; }


        [Range(1, 99999)]
        [Display(Name = " Codigo")]
        public string PostalCode { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = " Pais")]
        public string Country { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [StringLength(9)]
        [Required]

        [Display(Name = " Telefono")]
        public string Phone { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [StringLength(9)]
        [Required]

        [Display(Name = " FAX")]
        public string Fax { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = " Home")]
        public string HomePage { get; set; }
    }
}
