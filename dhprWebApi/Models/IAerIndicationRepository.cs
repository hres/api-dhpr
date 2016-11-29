using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerIndicationRepository
    {
        IEnumerable<AerIndication> GetAll(string lang);
        AerIndication Get(int id, string lang);
    }
}