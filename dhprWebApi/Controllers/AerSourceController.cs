using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerSourceController : ApiController
	{
		static readonly IAerSourceRepository databasePlaceholder = new AerSourceRepository();

		public IEnumerable<AerSource> GetAllAerSource(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerSource GetAerSourceById(int id, string lang)
		{
			AerSource aersource = databasePlaceholder.Get(id, lang);
			if (aersource == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aersource;
		}

	}
}
