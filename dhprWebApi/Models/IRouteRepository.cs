using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IRouteRepository
    {
        IEnumerable<Route> GetAll();
        Route Get(int id);
    }
}