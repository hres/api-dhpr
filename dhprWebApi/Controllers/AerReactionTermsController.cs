using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerReactionTermsController : ApiController
	{
		static readonly IAerReactionTermsRepository databasePlaceholder = new AerReactionTermsRepository();

		public IEnumerable<AerReactionTerms> GetAllAerReactionTerms(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerReactionTerms GetAerReactionTermsById(int id, string lang)
		{
			AerReactionTerms aerreactionterms = databasePlaceholder.Get(id, lang);
			if (aerreactionterms == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerreactionterms;
		}

	}
}
