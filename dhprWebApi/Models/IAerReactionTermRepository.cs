using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerReactionTermRepository
    {
        IEnumerable<AerReactionTerm> GetAll(string lang);
        AerReactionTerm Get(int id, string lang);
    }
}