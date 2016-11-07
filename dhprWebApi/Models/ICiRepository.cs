using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface ICiRepository
    {
        IEnumerable<Ci> GetAll();
        Ci Get(int id);
    }
}