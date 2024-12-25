using HumanResourcesApp.Data;
using HumanResourcesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesApp.Controllers
{
    public class DepartmentController : Controller
    {
        private AppDbContext _dbContext;

        // Passing DbContext to the Controller here
        public DepartmentController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        // Show all departments in the Departments table
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _dbContext.Departments
                .OrderBy(dep => dep.DepartmentName)      // Sort alphabetically A-Z
                .ToList();
            return View(departments);
        }

        // Create or add a new department - Call the Create View
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // Add the created new department above from Create - [HttpGet] to the Departments table
        [HttpPost]
        public IActionResult Create(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _dbContext.Departments.Where(dept => dept.Id == id).FirstOrDefault();

            return View("Create", model);  // View(ViewName, Object)
        }
        public IActionResult Edit(int id, Department department)
        {
            var model = _dbContext.Departments.Where(dept => dept.Id == id).FirstOrDefault();

            model.DepartmentName = department.DepartmentName;
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Remove a Department
        [HttpGet]
        public IActionResult Delete(int id, Department department)
        {
            var model = _dbContext.Departments.Where(dept => dept.Id == id).FirstOrDefault();

            if (model != null)
            {
                _dbContext.Departments.Remove(model);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
