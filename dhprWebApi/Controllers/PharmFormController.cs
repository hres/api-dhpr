using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class PharmFormController : ApiController
	{
		static readonly IPharmFormRepository databasePlaceholder = new PharmFormRepository();

		public IEnumerable<PharmForm> GetAllPharmForm()
		{

			return databasePlaceholder.GetAll();
		}


		public PharmForm GetPharmFormById(int id)
		{
			PharmForm pharmform = databasePlaceholder.Get(id);
			if (pharmform == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return pharmform;
		}

	}
}
