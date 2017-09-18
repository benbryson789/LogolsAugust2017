using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training11.Models;

namespace Training11.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }
    }
}