using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerGenderController : ApiController
	{
		static readonly IAerGenderRepository databasePlaceholder = new AerGenderRepository();

		public IEnumerable<AerGender> GetAllAerGender(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerGender GetAerGenderById(int id, string lang)
		{
			AerGender aergender = databasePlaceholder.Get(id, lang);
			if (aergender == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aergender;
		}

	}
}
