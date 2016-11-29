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

		public IEnumerable<PharmForm> GetAllPharmForm(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public PharmForm GetPharmFormById(int id, string lang)
		{
			PharmForm pharmform = databasePlaceholder.Get(id, lang);
			if (pharmform == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return pharmform;
		}

	}
}
