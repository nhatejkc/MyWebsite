using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class QuestionService : BaseService<Question>
    {
        public readonly MyWebsiteDbContext _context = new MyWebsiteDbContext();
        public QuestionService(IGenericRepository<Question> genericRepository) : base(genericRepository)
        {
        }
        public List<Question> GetQuestionByTopic(int id)
        {
            return _context.Questions.Where(x => x.TopicId == id).ToList();
        }
    }
}
