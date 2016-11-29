using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerSourceRepository
    {
        IEnumerable<AerSource> GetAll(string lang);
        AerSource Get(int id, string lang);
    }
}