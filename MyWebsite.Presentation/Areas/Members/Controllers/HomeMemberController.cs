using MyWebsite.Core;
using MyWebsite.Core.Models;
using MyWebsite.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        [HttpPost]
        public ActionResult QuizTest(List<Question> resultQuiz)
        {
            List<Question> finalResultQuiz = new List<Question>();

            foreach (Question answser in resultQuiz)
            {
                Question result = _dbContext.Questions.Where(a => a.Answer == answser.Answer).Select(a => new Question
                {
                    Id = a.Id,
                    Answer = a.Answer,
                    //isCorrect = (answser.Answer.ToLower().Equals(a.AnswerText.ToLower()))

                }).FirstOrDefault();

                finalResultQuiz.Add(result);
            }

            return Json(new { result = finalResultQuiz }, JsonRequestBehavior.AllowGet);
        }
    }
}