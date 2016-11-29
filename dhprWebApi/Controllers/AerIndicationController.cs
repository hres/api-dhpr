using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerIndicationController : ApiController
	{
		static readonly IAerIndicationRepository databasePlaceholder = new AerIndicationRepository();

		public IEnumerable<AerIndication> GetAllAerIndication(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerIndication GetAerIndicationById(int id, string lang)
		{
			AerIndication aerindication = databasePlaceholder.Get(id, lang);
			if (aerindication == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerindication;
		}

	}
}
