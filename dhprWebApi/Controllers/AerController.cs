using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerController : ApiController
	{
		static readonly IAerRepository databasePlaceholder = new AerRepository();

		public IEnumerable<Aer> GetAllAer(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public Aer GetAerById(int id, string lang)
		{
			Aer aer = databasePlaceholder.Get(id, lang);
			if (aer == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aer;
		}

	}
}
