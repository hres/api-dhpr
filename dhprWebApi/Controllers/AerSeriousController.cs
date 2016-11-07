using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerSeriousController : ApiController
	{
		static readonly IAerSeriousRepository databasePlaceholder = new AerSeriousRepository();

		public IEnumerable<AerSerious> GetAllAerSerious()
		{

			return databasePlaceholder.GetAll();
		}


		public AerSerious GetAerSeriousById(int id)
		{
			AerSerious aerserious = databasePlaceholder.Get(id);
			if (aerserious == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerserious;
		}

	}
}
