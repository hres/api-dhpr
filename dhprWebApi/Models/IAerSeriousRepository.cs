using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerSeriousRepository
    {
        IEnumerable<AerSerious> GetAll(string lang);
        AerSerious Get(int id, string lang);
    }
}