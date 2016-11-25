using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerIndicationRepository
    {
        IEnumerable<AerIndication> GetAll();
        AerIndication Get(int id);
    }
}