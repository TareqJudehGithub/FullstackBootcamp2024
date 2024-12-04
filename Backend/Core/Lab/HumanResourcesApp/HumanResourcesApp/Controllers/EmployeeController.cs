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
            // Relation between Employees and Departments
            //var employees = (
            //    from emp in _dbContext.Employees
            //    join dep in _dbContext.Departments
            //    on emp.DepartmentId equals dep.Id

            //    select new Employee
            //    {
            //        Id = emp.Id,
            //        EmployeeName = emp.EmployeeName,
            //        EmployeeEmail = emp.EmployeeEmail,
            //        HiringDate = emp.HiringDate,
            //        DepartmentId = emp.DepartmentId,
            //        Department = dep
            //    }
            //    ).ToList();


            var employees = _dbContext.Employees.Include(emp => emp.Department);  // map Employees props with Department.



            return View(employees);
        }

        // Create or add a new employee - Call the Create View
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DepartmentList = _dbContext.Departments.ToList();
            return View();
        }
        // Add the created employee above from Create - [HttpGet] to the Employees table
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee != null)
            {
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();

                return RedirectToAction("index");
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
            emp.Department = employee.Department;
            emp.HiringDate = employee.HiringDate;

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
