using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CookiesndSessions.Models;
namespace CookiesndSessions.Controllers
{
    [Route("[action]")]
    public class CookieSessionController : Controller
    {
       
        public readonly UserAccountContext _context;
        public CookieSessionController(UserAccountContext context)
        {
            this._context = context;
        }
       //
       // [Route("Cook")]
        // GET: CookieSession
        [Route("")]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount u)
        {
            try
            {
                _context.Add(u);
                _context.SaveChanges();
                ViewBag.Message = u.UserName + " " + "Successfully Registered";
                return View("Login");
            }
            catch(Exception e)
            {
                ViewBag.Message = u.UserName + " " + "Registration Failed";
            }
            return View();

        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserAccount us)
        {
            var loguser = _context.userAccounts.Where(e => e.UserName == us.UserName && e.Password == us.Password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.Message = "Invalid User";
                return View();
            }
            else
                HttpContext.Session.SetString("Uname", us.UserName);
            HttpContext.Session.SetString("lastlogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
        }
        public IActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("Uname") != null)
            {
                ViewBag.dat = HttpContext.Session.GetString("lastlogin");
                ViewBag.name = HttpContext.Session.GetString("Uname").ToString();
                if (Request.Cookies["lastlogin"] != null)

                    ViewBag.lldt = Request.Cookies["lastlogin"].ToString();
            }
                return View();

            
        }
        public IActionResult Logout1()
        {
            Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // GET: CookieSession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookieSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookieSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}