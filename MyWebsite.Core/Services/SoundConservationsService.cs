using MyWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Services
{
    public class SoundConservationsService : BaseService<SoundConservation>, ISoundConservationsService
    {
        public readonly MyWebsiteDbContext _context= new MyWebsiteDbContext();
        public SoundConservationsService(IGenericRepository<SoundConservation> genericRepository) : base(genericRepository)
        {
        }
        public List<SoundConservation> GetSoundConservationsByLession(int id)
        {
            return _context.SoundConservations.Where(x => x.Lession.Id == id).ToList();
        }
    }
}
