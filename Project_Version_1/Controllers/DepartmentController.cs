using Project_Version_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Version_1.Controllers
{
    public class DepartmentController : Controller
    {
        database_testEntities2 dbObj = new database_testEntities2();
        // GET: Employee
        public ActionResult Department()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Department(Department model)
        {
            dbObj.Departments.Add(model);
            dbObj.SaveChanges();
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employee(Employee model)
        {
            dbObj.Employees.Add(model);
            dbObj.SaveChanges();
            return View();

        }
        public ActionResult DepartmentList()
        {
            var res = dbObj.Departments.ToList();
            return View(res);
        }
        public ActionResult DepartmentDelete(int id)
        {
            var res = dbObj.Departments.Where(x => x.DeptID == id).First();
            dbObj.Departments.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.Departments.ToList();
            return View("DepartmentList", list);
        }
        public ActionResult EmployeeList()
        {
            var res = dbObj.Employees.ToList();
            return View(res);
        }

        

    }
}