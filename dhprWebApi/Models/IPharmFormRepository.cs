using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IPharmFormRepository
    {
        IEnumerable<PharmForm> GetAll(string lang);
        PharmForm Get(int id, string lang);
    }
}