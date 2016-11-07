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

		public IEnumerable<AerReactionTerms> GetAllAerReactionTerms()
		{

			return databasePlaceholder.GetAll();
		}


		public AerReactionTerms GetAerReactionTermsById(int id)
		{
			AerReactionTerms aerreactionterms = databasePlaceholder.Get(id);
			if (aerreactionterms == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerreactionterms;
		}

	}
}
