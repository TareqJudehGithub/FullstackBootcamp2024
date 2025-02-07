using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.Dashboard.Controllers
{

    [Area("Dashboard")]
    public class CategoryController : Controller
    {

        #region Fields
        private AppDbContext _dbContex;
        #endregion

        #region Constructors
        public CategoryController(AppDbContext appDbContext)
        {
            this._dbContex = appDbContext;
        }
        #endregion

        #region Action Methods

        public IActionResult Index()
        {
            var categories = _dbContex.Categories.ToList();
            return View(categories);
        }
        #endregion
    }

}
