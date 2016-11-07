using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerRepository
    {
        IEnumerable<Aer> GetAll();
        Aer Get(int id);
    }
}