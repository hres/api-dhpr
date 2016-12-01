using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerReactionTermRepository
    {
        IEnumerable<AerReactionTerm> GetAll(string lang);
        AerReactionTerm Get(int id, string lang);
    }
}