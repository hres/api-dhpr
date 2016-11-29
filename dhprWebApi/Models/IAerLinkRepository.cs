using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerLinkRepository
    {
        IEnumerable<AerLink> GetAll(string lang);
        AerLink Get(int id, string lang);
    }
}