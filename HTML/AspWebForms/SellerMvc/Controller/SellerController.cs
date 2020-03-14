using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SellerMvc.models;
namespace SellerMvc.Controllers
{
    public class SellerController:Controller
    {
        // SellerRepositories se = new SellerRepository();
        private readonly SellerRepositories sr;
        public SellerController(SellerRepositories sre)
        {
            sr = sre;
        }
        public IActionResult search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller ss = sr.GetSeller(ID);

            //ViewData["id"] = ss.id;
            //ViewData["name"] = ss.name;
            //ViewData["pass"] = ss.pass;
            //ViewData["phn"] = ss.phn;
            //ViewData["email"] = ss.email;


            //ViewBag.id = ss.id;
            //ViewBag.name = ss.name;
            //ViewBag.pass = ss.pass;
            //ViewBag.phn = ss.phn;
            //ViewBag.email = ss.email;

            ViewData["Seller"] = ss;

            return View();

            //if (ss!= null)
            //{
            //    return Content(ss.id +"\n"+ ss.name + "\n" + ss.pass + "\n" + ss.phn + "\n" + ss.email);
            //}
            //return Content("Employee Does NotExist");
        }
        public IActionResult Index()
        {
            List<Seller> slist = sr.display();
            return View(slist);
        }

        //public string Index()
        //{
        //    return "hellooooo";
        //}
    }
}