﻿using HumanResourcesApp.Data;
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
            var payroll = _dbContext.Payrolls.Include(pay => pay.Employee);
            return View(payroll);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Employee object drop-menu in Create View
            ViewBag.EmployeesList = new SelectList
                (
                    _dbContext.Employees.ToList(),
                    "Id", "EmployeeName"
                );

            return View();
        }
        [HttpPost]
        public IActionResult Create(Payroll payroll)
        {
            payroll.CreatedBy = "Admin";
            payroll.TS = DateTime.Now;
            CalculateNetSalary(payroll);

            _dbContext.Payrolls.Add(payroll);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public void CalculateNetSalary(Payroll payroll)
        {
            var employee = _dbContext.Employees.FirstOrDefault(emp => emp.Id == payroll.EmployeeID);

            if (employee != null)
            {
                payroll.BasicSalary = employee.BasicSalary;

                var leaves = Convert.ToDecimal(payroll.Leaves) * (employee.BasicSalary / 30 / 8);
                payroll.NetSalary = employee.BasicSalary + payroll.Bonus - payroll.SocialSecurityAmount - leaves;
            }
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

        // BasicSalary - Jquery: Ajax function url
        [HttpGet]
        public ActionResult<decimal> GetBasicSalary(int employeeId)
        {
            var basicSalary = _dbContext.Employees.FirstOrDefault(emp => emp.Id == employeeId).BasicSalary;

            return basicSalary;
        }
    }
}