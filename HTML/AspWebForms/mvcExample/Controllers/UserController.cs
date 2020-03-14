using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcExample.Repositories;
using mvcExample.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace mvcExample.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult create()
        {
            //ViewBag.Country = ;
            return View();
        }
       
        public IActionResult create(User item)
        {
            UserRepositories rep = new UserRepositories();
            rep.Add(item);
            if (ModelState.IsValid)
            {
                return RedirectToAction("login");
            }
            else
                return View();

        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(string uname,string pwd)
        {
            UserRepositories repositories = new UserRepositories();
            User user = repositories.validate(uname,pwd);
            if (user != null)
            {
                return RedirectToAction("Details",user);
            }
            else
            { 
                ViewData["err"] = "invalid Credentials";
            return View();
                }
             
        }
        public IActionResult Details([Bind(include:"Name")] User item)
        {
            return View(item);
        }

    }
}