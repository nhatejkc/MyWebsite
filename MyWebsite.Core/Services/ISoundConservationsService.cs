using System.Collections.Generic;
using MyWebsite.Core.Models;

namespace MyWebsite.Core.Services
{
    public interface ISoundConservationsService
    {
        List<SoundConservation> GetSoundConservationsByLession(int id);
    }
}