using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftStore.Model.Models; 

[Table("Categories")]
public class Category
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Category name cannot be blank")]
    [StringLength(50, MinimumLength = 3)]
    [RegularExpression("[a-zA-Z0-9_,.]*")]
    public string Name { get; set; }

    public bool IsMain { get; set; }
    
    [Required]
    public int Order { get; set; }
}