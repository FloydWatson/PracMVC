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

        
        // actions are what direct us around the web app.
        public ActionResult PracView()
        {
            //data can be transfered inside viewbags, think of them like taking a bag to shit to the view
            ViewBag.Message = "Your contact page.";
            // giving us the view, can add parameters if needed
            return View();
        }

        // POST is our HHTP request type. validation is just a extra form of validation given to us by .net
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PracView(PracModel pracModel )
        {

            if (ModelState.IsValid)
            {

                prac.PracFunctionCall(pracModel);
                // going back to index if form was filled out correctly
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}