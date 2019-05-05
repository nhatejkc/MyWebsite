using MyWebsite.Core;
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
        private readonly MyWebsiteDbContext _dbContext;

        public HomeController(LessionService lessionService,GrammarService grammarService,SoundConservationsService soundConservations, MyWebsiteDbContext dbContext)
        {
            _lessionService = lessionService;
            _gramarService = grammarService;
            _soundConservations = soundConservations;
            _dbContext = dbContext;
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
        [HttpPost]
        public ActionResult CreateComment(Comment comment,int id)
        {
            comment.CommentTime = DateTime.Now;
            comment.LessionId = id;
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        public JsonResult GetComments(int id)
        {
            var comments = _dbContext.Comments.Where(x=>x.LessionId==id);
            return Json(comments, JsonRequestBehavior.AllowGet);
        }
    }
}