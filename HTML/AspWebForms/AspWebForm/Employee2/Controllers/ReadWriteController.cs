using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee2.Controllers
{
    public class ReadWriteController : Controller
    {
        // GET: ReadWrite
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReadWrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReadWrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReadWrite/Create
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

        // GET: ReadWrite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReadWrite/Edit/5
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

        // GET: ReadWrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReadWrite/Delete/5
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
    }
}