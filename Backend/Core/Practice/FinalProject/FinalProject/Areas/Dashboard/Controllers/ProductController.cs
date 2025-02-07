using FinalProject.Areas.Dashboard.Models;
using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        #region Fields
        private AppDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironmnt;
        #endregion

        #region Constructors
        public ProductController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            this._dbContext = appDbContext;
            this._webHostEnvironmnt = webHostEnvironment;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            var model = _dbContext.Products.ToList();

            return View(model);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(
                _dbContext.Categories.ToList(),
                "Id",
                "Name"
                );

            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile Image)
        {
            if (Image == null)
            {
                ModelState.AddModelError("", "Image is empty");
                return View(product);
            }
            // Build image file path
            string folder = "Images/ProductsImages";
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(Image.FileName);
            string filePath = Path.Combine(_webHostEnvironmnt.WebRootPath, folder, fileName);

            // Copy the image built to its designated folder
            using (var stream = new FileStream(path: filePath, mode: FileMode.Create))
            {
                Image.CopyTo(stream);
            }

            // Save file path to DB
            product.ImagePath = Path.Combine(folder, filePath);

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion


    }
}
