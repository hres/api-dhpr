using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class RouteController : ApiController
	{
		static readonly IRouteRepository databasePlaceholder = new RouteRepository();

		public IEnumerable<Route> GetAllRoute(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public Route GetRouteById(int id, string lang)
		{
			Route route = databasePlaceholder.Get(id, lang);
			if (route == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return route;
		}

	}
}
