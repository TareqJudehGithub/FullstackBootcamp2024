// Ignore Spelling: acc
// Ignore Spelling: App

using HumanResourcesApp.Areas.Accounting.Models;
using HumanResourcesApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesApp.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    public class AccPayrollController : Controller
    {
        #region Fields
        private AppDbContext _dbContex;
        #endregion

        #region Constructors
        public AccPayrollController(AppDbContext appDbContext)
        {
            this._dbContex = appDbContext;
        }
        #endregion

        #region Action Methods

        public IActionResult Index()
        {
            var model = _dbContex.AccPayrolls.ToList();
            return View(model);
        }
        #region Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AccPayroll accPayroll)
        {
            accPayroll.TS = DateTime.Now;
            _dbContex.AccPayrolls.Add(accPayroll);
            _dbContex.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _dbContex.AccPayrolls
                .FirstOrDefault(acc => acc.Id == id);

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id, AccPayroll accPayroll)
        {
            var model = _dbContex.AccPayrolls
                .FirstOrDefault(acc => acc.Id == id);

            if (model != null)
            {
                model.PayrollAmount = accPayroll.PayrollAmount;
                model.TS = accPayroll.TS;
                _dbContex.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(accPayroll);
        }
        #endregion

        #region Delete
        public ActionResult Delete()
        {
            var model = _dbContex.AccPayrolls.FirstOrDefault();
            _dbContex.AccPayrolls.Remove(model);
            _dbContex.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #endregion
    }
}
