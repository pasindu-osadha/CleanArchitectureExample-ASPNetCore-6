using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureExample.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetAllProduts();
            return View(model);
        }
    }
}
