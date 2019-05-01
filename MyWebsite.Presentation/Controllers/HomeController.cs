using MyWebsite.Core.Models;
using MyWebsite.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly LessionService _lessionService;
        private readonly GrammarService _gramarService;
        private readonly SoundConservationsService _soundConservations;
        public HomeController(LessionService lessionService,GrammarService grammarService,SoundConservationsService soundConservations)
        {
            _lessionService = lessionService;
            _gramarService = grammarService;
            _soundConservations = soundConservations;
        }
        // GET: Post
        public ActionResult Index()
        {
            var allLessions = _lessionService.GetAll();
            return View(allLessions);
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
        public ActionResult GetGrammarByLessionId(int id)
        {
            return PartialView("_ListGrammar",_gramarService.GetGrammarByLessionId(id));
        }
        public ActionResult GetSoundConservationByLessionId(int id)
        {
            return PartialView("_ListConservation", _soundConservations.GetSoundConservationsByLession(id));
        }
        public ActionResult LessionDetails(int id)
        {
            var lessionDetails = _lessionService.GetById(id);
            return View(lessionDetails);
        }
    }
}