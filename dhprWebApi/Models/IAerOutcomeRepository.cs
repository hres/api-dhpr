using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerOutcomeRepository
    {
        IEnumerable<AerOutcome> GetAll(string lang);
        AerOutcome Get(int id, string lang);
    }
}