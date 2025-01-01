using Microsoft.AspNetCore.Mvc;
using LojaMicro.Web.Services.Contracts;

namespace LojaMicro.Web.Controllers
{
    public class CartController : Controller
    {

        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
