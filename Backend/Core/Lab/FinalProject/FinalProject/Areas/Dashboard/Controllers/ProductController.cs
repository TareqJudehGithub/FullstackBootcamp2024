using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        AppDbContext _dbContext;

        public ProductController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();

            return View(products);
        }
    }
}
