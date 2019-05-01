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

        public HomeMemberController(TopicService topicService, QuestionItemService questionItemService, QuestionService questionService)
        {
            _topicSevice = topicService;
            _questionItemService = questionItemService;
            _questionService = questionService;
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
    }
}