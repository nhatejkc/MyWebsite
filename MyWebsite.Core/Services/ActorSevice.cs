using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class ActorSevice : BaseService<Actor>
    {
        public ActorSevice(IGenericRepository<Actor> genericRepository) : base(genericRepository)
        {
        }
    }
}
