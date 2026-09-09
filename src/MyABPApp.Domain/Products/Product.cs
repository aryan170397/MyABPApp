using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MyABPApp.Products;

public class Product : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; private set; }

    public decimal Price { get; private set; }

    public string? Description { get; private set; }

    private Product()
    {
        // For EF Core
    }

    public Product( Guid id, string name, decimal price, string? description = null) : base(id)
    {
        Name = name;
        Price = price;
        Description = description;
    }

    public void Update( string name, decimal price, string? description = null)
    {
        Name = name;
        Price = price;
        Description = description;
    }
}