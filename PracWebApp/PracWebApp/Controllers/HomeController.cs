using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracWebApp.Models;
using PracWebApp.Functions;


namespace PracWebApp.Controllers
{
    public class HomeController : Controller
    {

        PracFunctions prac = new PracFunctions();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        

        public ActionResult PracView()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PracView(PracModel pracModel )
        {

            if (ModelState.IsValid)
            {

                prac.PracFunctionCall(pracModel);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}