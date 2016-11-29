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

		public IEnumerable<AerSerious> GetAllAerSerious(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerSerious GetAerSeriousById(int id, string lang)
		{
			AerSerious aerserious = databasePlaceholder.Get(id, lang);
			if (aerserious == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerserious;
		}

	}
}
