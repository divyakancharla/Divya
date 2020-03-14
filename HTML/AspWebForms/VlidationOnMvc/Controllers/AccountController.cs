using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationOnMvc.Models;

namespace ValidationOnMvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login item)
        {
            if (ModelState.IsValid)//modelstate validates Models
            {
                return RedirectToAction("Index");
            }
            else

                return View();
        }

        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Employee item)
        {
            if (ModelState.IsValid)//modelstate validates Models
            {
                return RedirectToAction("Index");
            }
            else

                return View();
        }
    }
}