using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderEntry_Bundle.Models;
namespace OrderEntry_Bundle.Areas.HR.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: HR/Employee
        public ActionResult Employees()
        {
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }

        public ActionResult Delete(int id)
        {
            var deleted = db.Employees.Find(id);
            db.Employees.Remove(deleted);
            db.SaveChanges();
            return RedirectToAction("Employees");
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Employees");
        }
    }
}