// Ignore Spelling: App

using HumanResourcesApp.Data;
using HumanResourcesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;  // for using ViewBag
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesApp.Controllers
{
    public class PayrollController : Controller
    {
        #region Fields
        private AppDbContext _dbContext;
        #endregion

        #region Constructors 
        public PayrollController(AppDbContext appDbContext)
        {
            this._dbContext = appDbContext;
        }
        #endregion

        #region Action Methods

        #endregion
        public IActionResult Index()
        {
            var payroll = _dbContext.Payrolls
                .Include(pay => pay.Employee);

            return View(payroll);

            //var payroll = _dbContext.Payrolls.Include(pay => pay.Employee);
            //return View(payroll);

        }

        [HttpGet]
        public IActionResult Create()
        {
            // Employees List drop-menu in Create View
            ViewBag.EmployeesList = new SelectList
                (
               _dbContext.Employees.ToList(),
               "Id",
               "EmployeeName"
               );
            return View();
        }
        [HttpPost]
        public IActionResult Create(Payroll payroll)
        {
            //   payroll.BasicSalary = GetBasicSalary(payroll.EmployeeID);
            payroll.CreatedBy = "Admin";
            payroll.TS = DateTime.Now;

            _dbContext.Payrolls.Add(payroll);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.EmployeesList = new SelectList
                (
                    _dbContext.Employees.ToList(),
                    "Id", "EmployeeName"
                );

            var model = _dbContext.Payrolls.Where(pay => pay.Id == id).FirstOrDefault();

            return View("Create", model);
        }
        [HttpPost]
        public IActionResult Edit(int id, Payroll payroll)
        {
            var model = _dbContext.Payrolls.Where(payroll => payroll.Id == id).FirstOrDefault();

            model.EmployeeID = payroll.EmployeeID;
            model.PayrollDate = payroll.PayrollDate;
            model.Bonus = payroll.Bonus;
            model.SocialSecurityAmount = payroll.SocialSecurityAmount;
            model.Leaves = payroll.Leaves;
            model.NetSalary = payroll.NetSalary;
            model.Employee = payroll.Employee;

            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id, Payroll payroll)
        {
            var model = _dbContext.Payrolls.Where(emp => emp.Id == id).FirstOrDefault();
            if (model != null)
            {
                _dbContext.Payrolls.Remove(model);
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult<decimal> GetBasicSalary(int employeeId)
        {


            var basicSalary = _dbContext.Employees.FirstOrDefault(emp => emp.Id == employeeId).BasicSalary;

            return basicSalary;



        }
    }
}
