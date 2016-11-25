using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerOutcomeController : ApiController
	{
		static readonly IAerOutcomeRepository databasePlaceholder = new AerOutcomeRepository();

		public IEnumerable<AerOutcome> GetAllAerOutcome()
		{

			return databasePlaceholder.GetAll();
		}


		public AerOutcome GetAerOutcomeById(int id)
		{
			AerOutcome aeroutcome = databasePlaceholder.Get(id);
			if (aeroutcome == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aeroutcome;
		}

	}
}