using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerSourceRepository
    {
        IEnumerable<AerSource> GetAll();
        AerSource Get(int id);
    }
}