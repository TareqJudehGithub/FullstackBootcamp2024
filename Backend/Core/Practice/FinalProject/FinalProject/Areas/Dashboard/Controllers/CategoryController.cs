using FinalProject.Areas.Dashboard.Models;
using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        #region Fields
        private AppDbContext _dbContext;
        #endregion

        #region Constructor
        public CategoryController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            var model = _dbContext.Categories.ToList();
            return View(model);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}


