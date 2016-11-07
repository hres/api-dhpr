using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class CiController : ApiController
	{
		static readonly ICiRepository databasePlaceholder = new CiRepository();

		public IEnumerable<Ci> GetAllCi()
		{

			return databasePlaceholder.GetAll();
		}


		public Ci GetCiById(int id)
		{
			Ci ci = databasePlaceholder.Get(id);
			if (ci == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return ci;
		}

	}
}
