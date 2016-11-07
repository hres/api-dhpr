using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class RouteRepository : IRouteRepository
    {
       
        private List<Route> routes = new List<Route>();
        private Route route = new Route();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<Route> GetAll()
        {
            routes = dbConnection.GetAllRoute();

            return routes;
        }

        public Route Get(int id)
        {
            route = dbConnection.GetRouteById(id);
            return route;
        }
    }
}