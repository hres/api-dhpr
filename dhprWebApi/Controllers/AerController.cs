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

		public IEnumerable<Aer> GetAllAer()
		{

			return databasePlaceholder.GetAll();
		}


		public Aer GetAerById(int id)
		{
			Aer aer = databasePlaceholder.Get(id);
			if (aer == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aer;
		}

	}
}
