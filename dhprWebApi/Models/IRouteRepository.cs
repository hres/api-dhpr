using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IRouteRepository
    {
        IEnumerable<Route> GetAll(string lang);
        Route Get(int id, string lang);
    }
}