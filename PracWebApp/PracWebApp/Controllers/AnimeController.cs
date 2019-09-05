using PracWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracWebApp.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        static List<AnimeModel> AnimeList = new List<AnimeModel>();
        public ActionResult Index()
        {
            return View(AnimeList);
        }

        public ActionResult AddAnime()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAnime(AnimeModel a)
        {
            if (ModelState.IsValid)
            {
                AnimeList.Add(a);
                return RedirectToAction("Index");
            };

            return View("AddAnime");
            
            
        }

        
    }
}