using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerSourceRepository
    {
        IEnumerable<AerSource> GetAll(string lang);
        AerSource Get(int id, string lang);
    }
}