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

		public IEnumerable<Ci> GetAllCi(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public Ci GetCiById(int id, string lang)
		{
			Ci ci = databasePlaceholder.Get(id, lang);
			if (ci == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return ci;
		}

	}
}
