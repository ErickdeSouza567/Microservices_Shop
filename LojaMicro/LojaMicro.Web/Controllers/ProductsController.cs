using LojaMicro.Web.Models;
using LojaMicro.Web.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMicro.Web.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productsService;

    public ProductsController(IProductService productsService)
    {
        _productsService = productsService;
    }

    public async Task<ActionResult<IEnumerable<ProductViewModel>>> Index()
    {
        var result = await _productsService.GetAllProducts();

        if (result is null)
        {
            return View("Error");
        }

        return View(result);
    }
}
