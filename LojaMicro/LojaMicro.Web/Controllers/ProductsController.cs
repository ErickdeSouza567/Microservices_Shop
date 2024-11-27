using LojaMicro.Web.Models;
using LojaMicro.Web.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductViewModel>>> Index()
    {
        var result = await _productsService.GetAllProducts();

        if (result is null)
        {
            return View("Error");
        }

        return View(result);
    }

    [HttpGet]
    public async Task<IActionResult> CreateProduct()
    {
        ViewBag.CategoryId = new SelectList(await _categoryService.GetAllCategories(), "CategoryId", "Name");

        return View();
    }
}
