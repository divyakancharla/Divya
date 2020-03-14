using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Employee2.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}