using Microsoft.AspNetCore.Mvc;
using MyABPApp.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Authorization;

namespace MyABPApp.Web.Pages.Products;

public class IndexModel : AbpPageModel
{
    private readonly IProductAppService _productAppService;

    public List<ProductDto> Products { get; set; } = [];

    public IndexModel(IProductAppService productAppService)
    {
        _productAppService = productAppService;
    }

    public string? ErrorMessage { get; set; }

    public async Task OnGetAsync()
    {
        try
        {
            Products = await _productAppService.GetListAsync();
        }
        catch (AbpAuthorizationException)
        {
            ErrorMessage = "Please login to access Products.";
        }
    }

    public async Task<IActionResult> OnPostCreateAsync( string name, decimal price, string? description)
    {
        await _productAppService.CreateAsync(
            new CreateUpdateProductDto
            {
                Name = name,
                Price = price,
                Description = description
            });

        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(Guid id)
    {
        await _productAppService.DeleteAsync(id);

        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostUpdateAsync( Guid id, string name,decimal price,string? description)
    {
        await _productAppService.UpdateAsync(
            id,
            new CreateUpdateProductDto
            {
                Name = name,
                Price = price,
                Description = description
            });

        return RedirectToPage();
    }
}