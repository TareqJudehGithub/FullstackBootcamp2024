using Microsoft.AspNetCore.Mvc;
using HumanResourcesApp.Data;
using HumanResourcesApp.Areas.Accounting.Models;

namespace HumanResourcesApp.Areas.Accounting.Controllers
{
    [Area("Accounting")]  // Same as Model name in Area
    public class AccountingPayrollController : Controller
    {
        #region Fields
        private AppDbContext _dbContext;
        #endregion

        #region Constructors
        public AccountingPayrollController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        #endregion
        [HttpGet]
        public IActionResult Index()
        {
            var AccountingPayroll = _dbContext.AccountingPayrolls.ToList();
            return View(AccountingPayroll);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AccountingPayroll accountingPayroll)
        {
          
          
            accountingPayroll.TS = DateTime.Now;

            _dbContext.Add(accountingPayroll);
            _dbContext.SaveChanges();
           
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _dbContext.AccountingPayrolls.FirstOrDefault(acc => acc.Id == id);
          
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, AccountingPayroll accountingPayroll)
        {
            var model = _dbContext.AccountingPayrolls.FirstOrDefault(acc => acc.Id == id);

            if (model != null)
            {
                model.PayrollAmount = accountingPayroll.PayrollAmount;
                model.TS = DateTime.Now;

                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(accountingPayroll);
        }
    }
}
