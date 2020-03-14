using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOnMvcValidation.Models;
using AssignmentOnMvcValidation.Repositories;
namespace AssignmentOnMvcValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(Employee em)
        {
            EmployeRepository er = new EmployeRepository();
            er.register(em);
            return RedirectToAction("login");
        }
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }
        public IActionResult login(int eid,string pass)
        {
            EmployeRepository e = new EmployeRepository();
            Employee en = e.validate(eid, pass);
            if (en != null)
            {
                return View("greet",en);
            }
            else
            {
                ViewData["invalid"] = "Inavalid User";
                return View();
            }
        }
        public IActionResult NewUser(Employee item)
        {
            return View(item);
        }
        public IActionResult greet(Employee item)
        {
            return View(item);
        }
    }
}