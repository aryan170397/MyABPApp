using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace MyABPApp.Products;

public class ProductAppService : ApplicationService, IProductAppService
{
    private readonly IRepository<Product, Guid> _productRepository;

    public ProductAppService(
        IRepository<Product, Guid> productRepository)
    {
        _productRepository = productRepository;
    }

    [Authorize(ProductPermissions.Products.Default)]
    public async Task<ProductDto> GetAsync(Guid id)
    {
        var product = await _productRepository.GetAsync(id);

        return MapToDto(product);
    }

    [Authorize(ProductPermissions.Products.Default)]
    public async Task<List<ProductDto>> GetListAsync()
    {
        var products = await _productRepository.GetListAsync();

        return products
            .Select(MapToDto)
            .ToList();
    }

    [Authorize(ProductPermissions.Products.Create)]
    public async Task<ProductDto> CreateAsync( CreateUpdateProductDto input)
    {
        var product = new Product(
            GuidGenerator.Create(),
            input.Name,
            input.Price,
            input.Description);

        await _productRepository.InsertAsync(
            product,
            autoSave: true);

        return MapToDto(product);
    }

    [Authorize(ProductPermissions.Products.Update)]
    public async Task<ProductDto> UpdateAsync( Guid id, CreateUpdateProductDto input)
    {
        var product = await _productRepository.GetAsync(id);

        product.Update(
            input.Name,
            input.Price,
            input.Description);

        await _productRepository.UpdateAsync(
            product,
            autoSave: true);

        return MapToDto(product);
    }

    [Authorize(ProductPermissions.Products.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _productRepository.DeleteAsync(
            id,
            autoSave: true);
    }
    private static ProductDto MapToDto(Product product)
    {
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description
        };
    }
}