using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerRepository
    {
        IEnumerable<Aer> GetAll(string lang);
        Aer Get(int id, string lang);
    }
}