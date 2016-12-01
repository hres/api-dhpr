using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface ICiRepository
    {
        IEnumerable<Ci> GetAll(string lang);
        Ci Get(int id, string lang);
    }
}