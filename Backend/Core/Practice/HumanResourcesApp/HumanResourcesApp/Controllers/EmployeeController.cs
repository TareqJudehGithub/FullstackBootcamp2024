using HumanResourcesApp.Data;
using HumanResourcesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace HumanResourcesApp.Controllers
{
    public class EmployeeController : Controller
    {
        private AppDbContext _dbContext;

        public EmployeeController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        // Show all Employees in the Employees table
        public IActionResult Index()
        {
            var employees = _dbContext.Employees.Include(emp => emp.Department);  // map/join Employees props with Department.

            return View(employees);
        }

        // Create or add a new employee - Call the Create View
        [HttpGet]
        public IActionResult Create()
        {
            // Department dropdown menu
            ViewBag.DepartmentList = _dbContext.Departments.ToList();
            return View();
        }

        // Add the created employee above from Create - [HttpGet] to the Employees table
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee != null)
            {
                // Setting default Hiring Date to today's date
                employee.HiringDate = DateTime.Now;

                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // Call the Edit Employee View
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.DepartmentList = _dbContext.Departments.ToList();
            var model = _dbContext.Employees.Where(emp => emp.Id == id).FirstOrDefault();

            return View(model);
        }
        // Update edited employee information from Edit- HttpGet and save them in the DB.
        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            var emp = _dbContext.Employees.Where(emp => emp.Id == id).FirstOrDefault();

            emp.EmployeeName = employee.EmployeeName;
            emp.DepartmentId = employee.DepartmentId;
            emp.EmployeeEmail = employee.EmployeeEmail;
            emp.BasicSalary = employee.BasicSalary;
            emp.HiringDate = employee.HiringDate;
            emp.BasicSalary = employee.BasicSalary;

            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // Remove selected employee from Employee table in the DB
        [HttpGet]
        public IActionResult Delete(int id, Employee employee)
        {
            var model = _dbContext.Employees.Where(emp => emp.Id == id).FirstOrDefault();
            if (model != null)
            {
                _dbContext.Employees.Remove(model);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
