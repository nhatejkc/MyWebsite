using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MyWebsite.Core;
using MyWebsite.Core.Models;
using MyWebsite.Core.Services;
using MyWebsite.Presentation.Models;
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

        public IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public HomeController(LessionService lessionService,GrammarService grammarService,SoundConservationsService soundConservations, MyWebsiteDbContext dbContext)
        {
             
            _lessionService = lessionService;
            _gramarService = grammarService;
            _soundConservations = soundConservations;
            _dbContext = dbContext;
          
        }
        
        // GET: Post
        public ActionResult Index(int? request)
        {
            if(request==null)
            {

            }
            else
            {
                AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                return RedirectToAction("Index", "Home");
            }
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
            TempData["lessionid"] = id;
            return View(lessionDetails);
        }
        public ActionResult GetAllLession()
        {
            var lessions = _lessionService.GetAll(); 
            return PartialView("_ListLession",lessions);
        }
        public ActionResult Comment(string user,string content,int id)
        {
            if (user!=null&& content!=null)
            {
                Comment cm = new Comment();
                cm.UserComment = user;
                cm.CommentContent = content;
                cm.CommentTime = DateTime.Now;
                cm.LessionId = id;
                _dbContext.Comments.Add(cm);
                _dbContext.SaveChanges();
            }
           
            return PartialView(_dbContext.Comments.Where(x=>x.LessionId== id).ToList());
        }
    }
}