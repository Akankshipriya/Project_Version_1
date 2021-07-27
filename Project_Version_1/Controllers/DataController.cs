using Project_Version_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Version_1.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult index()
        {
            database_testEntities2 obj = new database_testEntities2();
            return View(obj.displayData());
        }
    }
}