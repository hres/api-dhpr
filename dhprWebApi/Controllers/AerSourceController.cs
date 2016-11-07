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

		public IEnumerable<AerSource> GetAllAerSource()
		{

			return databasePlaceholder.GetAll();
		}


		public AerSource GetAerSourceById(int id)
		{
			AerSource aersource = databasePlaceholder.Get(id);
			if (aersource == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aersource;
		}

	}
}
