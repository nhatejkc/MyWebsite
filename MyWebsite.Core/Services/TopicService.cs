using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class TopicService : BaseService<Topic>
    {
        public TopicService(IGenericRepository<Topic> genericRepository) : base(genericRepository)
        {
        }
    }
}
