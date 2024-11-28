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
    private readonly ICategoryService _categoryService;
    public ProductsController(IProductService productsService, ICategoryService categoryService)
    {
        _productsService = productsService;
        _categoryService = categoryService;
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

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductViewModel productVM)
    {
        if (ModelState.IsValid)
        {
            var result = await _productsService.CreateProduct(productVM);

            if (result != null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.CategoryId = new SelectList(await _categoryService.GetAllCategories(), "CategoryId", "Name");
            }
            return View(productVM);
        }
    }
}
