using System;
using Volo.Abp.Application.Dtos;

namespace MyABPApp.Products;

public class ProductDto : EntityDto<Guid>
{
    public string Name { get; set; } = default!;

    public decimal Price { get; set; }

    public string? Description { get; set; }
}