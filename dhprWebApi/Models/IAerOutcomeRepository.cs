using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerOutcomeRepository
    {
        IEnumerable<AerOutcome> GetAll();
        AerOutcome Get(int id);
    }
}