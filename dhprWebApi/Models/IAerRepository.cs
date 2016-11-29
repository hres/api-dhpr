using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerRepository
    {
        IEnumerable<Aer> GetAll(string lang);
        Aer Get(int id, string lang);
    }
}