using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IPharmFormRepository
    {
        IEnumerable<PharmForm> GetAll(string lang);
        PharmForm Get(int id, string lang);
    }
}