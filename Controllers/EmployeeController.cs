using MVCEmployeeWithEF.Data;
using MVCEmployeeWithEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmployeeWithEF.Controllers
{
    public class EmployeeController:Controller
    {
        private EmployeeContext _context;
        public EmployeeController()
        {
            _context = new EmployeeContext();
        }
        [HttpGet]
        public ActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(employee);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return View(employee);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            var currentEmployee = _context.Employees.Find(employee.Id);
            currentEmployee.Name = employee.Name;
            currentEmployee.Email = employee.Email;
            _context.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(employee);
        }
        /*[HttpPost]
        public ActionResult Delete(Employee employee)
        {
            var currentEmployee = employees.Where(e => e.Id == employee.Id).FirstOrDefault();

            employees.Remove(currentEmployee);
            return View();
        }*/
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteRecord(int id)
        {
            var employee = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return View(employee);
        }
    }
}