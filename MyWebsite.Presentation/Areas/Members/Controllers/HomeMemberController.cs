using Microsoft.AspNet.Identity;
using MyWebsite.Core;
using MyWebsite.Core.Models;
using MyWebsite.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyWebsite.Presentation.Areas.Members.Controllers
{
    public class HomeMemberController : Controller
    {
        private readonly TopicService _topicSevice;
        private readonly QuestionService _questionService;
        private readonly QuestionItemService _questionItemService;
        private readonly MyWebsiteDbContext _dbContext;
        
        public HomeMemberController(TopicService topicService, QuestionItemService questionItemService, QuestionService questionService, MyWebsiteDbContext dbContext)
        {
            _topicSevice = topicService;
            _questionItemService = questionItemService;
            _questionService = questionService;
            _dbContext = dbContext;
        }
        // GET: Members/Home
        public ActionResult Index()
        {
            var topic = _topicSevice.GetAll();
            return View(topic);
        }
        public ActionResult GetQuestionByTopic(int id)
        {
            return PartialView("_ListQuestion", _questionService.GetQuestionByTopic(id));
        }
        public ActionResult GetQuestionItemByQuestionId(int id)
        {
            return PartialView("_ListQuestionItem", _questionItemService.GetQuestionItemByQuestionId(id));
        }
        public ActionResult TopicDetails(int id)
        {
            var topicDetails = _topicSevice.GetById(id);
            return View(topicDetails);
        }
        public ActionResult GetAll()
        {
            var topic = _topicSevice.GetAll();
            return PartialView("_ListTopic",topic);
        }
        public ActionResult Comment(string user, string content, int id)
        {
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = _dbContext.Users.FirstOrDefault(x => x.Id == currentUserId);
            if (user != null && content != null)
            {
                Comment cm = new Comment();
                cm.UserComment = currentUser.UserName.ToString();
                cm.CommentContent = content;
                cm.CommentTime = DateTime.Now;
                cm.TopicId = id;
                _dbContext.Comments.Add(cm);
                _dbContext.SaveChanges();
            }

            return PartialView(_dbContext.Comments.Where(x => x.TopicId == id).ToList());
        }

        [HttpPost]
        public ActionResult QuizTest(List<QuizAnswersVM> resultQuiz)
        {
            List<QuizAnswersVM> finalResultQuiz = new List<QuizAnswersVM>();

            foreach (QuizAnswersVM answser in resultQuiz)
            {
                QuizAnswersVM result = _dbContext.Questions.Where(a => a.Id == answser.QuestionID).Select(a => new QuizAnswersVM
                {
                    QuestionID = a.Id,
                    AnswerQ = a.Answer,
                    isCorrect = (answser.AnswerQ.ToLower().Equals(a.Answer.ToLower()))

                }).FirstOrDefault();

                finalResultQuiz.Add(result);
            }

            return Json(new { result = finalResultQuiz }, JsonRequestBehavior.AllowGet);
        }
    }
}