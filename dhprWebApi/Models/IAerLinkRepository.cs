using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerLinkRepository
    {
        IEnumerable<AerLink> GetAll(string lang);
        AerLink Get(int id, string lang);
    }
}