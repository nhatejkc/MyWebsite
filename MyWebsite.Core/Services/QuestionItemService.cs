using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class QuestionItemService : BaseService<QuestionItem>
    {
        private readonly MyWebsiteDbContext _context = new MyWebsiteDbContext();
        public QuestionItemService(IGenericRepository<QuestionItem> genericRepository) : base(genericRepository)
        {
        }
        public List<QuestionItem> GetQuestionItemByQuestionId(int id)
        {
            return _context.QuestionItems.Where(x => x.QuestionId == id).ToList();
        }
    }
}
