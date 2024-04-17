namespace PrimerExamen.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




public class Product
{
    [Display(Name = " ID")]
    public int ProductId { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    [Display(Name =" Nombre")]
    public string ProductName { get; set; }

    
   [Range(1, 100)]
    [Required]
    
    [Display(Name = "Proveedor")]
    public int SupplierId { get; set; }

    [Range(1, 100)]
    [Display(Name = "Categoria")]
    public string CategoryID { get; set; }

    [Range(1, 100)]

    [Display(Name = "Cantidad")]
    public string QuantityPerUnit { get; set; }

    [Range(1, 100000000)]
    [Display(Name = "Precio")]
    public int UnitPrice { get; set; }

    [Range(1, 100)]

    [Display(Name = " Existencia")]
    public int UnitsInStock { get; set; }

    [Range(1, 100)]

    [Display(Name = " Unidades en orden")]
    public int UnitsOnOrder { get; set; }

    [Range(1, 100)]

    [Display(Name = " Nivel de reorden")]
    public string ReorderLevel { get; set; }

    [Range(1, 100)]

    [Display(Name = " Descontinuado")]
    public string Discontinued { get; set; }
}
