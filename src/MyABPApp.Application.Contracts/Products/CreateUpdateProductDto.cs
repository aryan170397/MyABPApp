using System.ComponentModel.DataAnnotations;

namespace MyABPApp.Products;

public class CreateUpdateProductDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = default!;

    public decimal Price { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
}