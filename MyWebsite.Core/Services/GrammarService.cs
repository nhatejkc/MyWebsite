using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class GrammarService : BaseService<Grammar>
    {
        public readonly MyWebsiteDbContext _context = new MyWebsiteDbContext();
        public GrammarService(IGenericRepository<Grammar> genericRepository) : base(genericRepository)
        {
        }
        public List<Grammar> GetGrammarByLessionId(int id)
        {
            return _context.Grammars.Where(x => x.Lession.Id == id).ToList();
        }
    }
}
