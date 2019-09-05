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
            AnimeList.Add(new AnimeModel { AnimeName = "Hunter X Hunter", Genre1 = "Adventure", Genre2 = "Action", SeasonCount = 1, EpisodeCount = 146 });
            AnimeList.Add(new AnimeModel { AnimeName = "Food Wars", Genre1 = "Comedy", Genre2 = "School", SeasonCount = 3, EpisodeCount = 48 });
            AnimeList.Add(new AnimeModel { AnimeName = "The Devil Is A Part Timer", Genre1 = "Comedy", Genre2 = "Action", SeasonCount = 1, EpisodeCount = 13 });

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