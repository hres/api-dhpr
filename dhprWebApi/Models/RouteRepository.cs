using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class RouteRepository : IRouteRepository
    {
       
        private List<Route> routes = new List<Route>();
        private Route route = new Route();

        public IEnumerable<Route> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            routes = dbConnection.GetAllRoute();

            return routes;
        }

        public Route Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            route = dbConnection.GetRouteById(id);
            return route;
        }
    }
}