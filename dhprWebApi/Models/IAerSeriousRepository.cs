using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerSeriousRepository
    {
        IEnumerable<AerSerious> GetAll(string lang);
        AerSerious Get(int id, string lang);
    }
}