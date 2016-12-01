using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerReactionTermController : ApiController
	{
		static readonly IAerReactionTermRepository databasePlaceholder = new AerReactionTermRepository();

		public IEnumerable<AerReactionTerm> GetAllAerReactionTerm(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerReactionTerm GetAerReactionTermById(int id, string lang)
		{
			AerReactionTerm aerreactionterms = databasePlaceholder.Get(id, lang);
			if (aerreactionterms == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerreactionterms;
		}

	}
}
