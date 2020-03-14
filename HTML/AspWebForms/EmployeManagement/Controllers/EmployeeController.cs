using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeManagement.Models;
namespace EmployeManagement.Controllers
{
   
    public class EmployeeController:Controller
    {
        // IEmployeeRepositories emprep = new EmployeeRepositories();
       private readonly  IEmployeeRepositories emprep;
        //dependency Injected Object
       public EmployeeController(IEmployeeRepositories emp)
        {
            emprep = emp;
            
        }
        public IActionResult search(int? id)
        {
            int ID=(int)((id == null)? 1 : id);
           MyEmployee my=emprep.GetEmployee(ID);
            //if (my != null)
            //{
            //    return Content(my.Id + my.Name + my.Email + my.Dept);
            //}
            //return Content("Employee Does NotExist");


            //Retrieving DAta USing View Data

            //ViewData["id"] = my.Id;
            //ViewData["name"] = my.Name;
            //ViewData["Dept"] = my.Dept;
            //ViewData["Email"] = my.Email;

            //Retrieving Data Using ViewBAG
            //ViewBag.id = my.Id;
            //ViewBag.name = my.Name;
            //ViewBag.dept = my.Dept;
            //ViewBag.email = my.Email;
            ViewData["Employee"] = my;
      
            return View();
        }
        public IActionResult Index()
        {
            List<MyEmployee> elist = emprep.display();
            return View(elist);
        }
        
        //public string Index()
        //{
        //    return "Hello World";
        //}
        //public JsonResult About()
        //{
        //    return Json("{id:2;name:hell}");
        //}
        public ViewResult About()
        {
            MyEmployee emp = emprep.GetEmployee(2);
            ViewBag.ProjectName = "HiFive";
            return View(emp);
        }
        public ViewResult AboutEmp()
        {
            MyEmployee emp = emprep.GetEmployee(2);
            //ViewBag.ProjectName = "HiFive";
            EmployeProjViewModel epm = new EmployeProjViewModel();
            epm.employee = emp;
            epm.projectName = "HiFive";
            return View(epm);
        }
        public IActionResult GetAllEmployees()
        {
            List<MyEmployee> elist = emprep.display().Where(e => e.dept==Dept.IT).ToList();
            return View("Index",elist);
        }
        [HttpGet]
        public IActionResult Ui()
        {
            return View();
            //MyEmployee emo = emprep.GetEmployee(2);
            //return View(emo);
        }
        [HttpPost]
        public IActionResult Ui(MyEmployee e)
        {
            if (ModelState.IsValid)
            {
                emprep.AddEmployee(e);
                return RedirectToAction("Index");
            }
           
                return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<MyEmployee> elist = emprep.display();
            return View(elist);
        }
        public IActionResult Register(MyEmployee emp)
        {
            bool res = emprep.AddEmployee(emp);
            return RedirectToAction("Index");
        }
        public bool IsExist(string email)
        {
            var result = (emprep.display()).Find(r => r.Email == email);
            if (result == null)
            {
                return true;
            }
            return false;
        }
       [AcceptVerbs("Get","Post")]
       public IActionResult IsEmailExist(string email)
        {
            var result = (emprep.display()).Find(r => r.Email == email);
            
                return (result == null) ? Json(true) : Json("Email eXists");
        }
        public IActionResult _partialView()
        {
            return View();
        }

    }
}