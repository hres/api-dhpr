using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DhprWebApi.Models;
namespace DhprWebApi.Controllers
{
	public class AerGenderController : ApiController
	{
		static readonly IAerGenderRepository databasePlaceholder = new AerGenderRepository();

		public IEnumerable<AerGender> GetAllAerGender()
		{

			return databasePlaceholder.GetAll();
		}


		public AerGender GetAerGenderById(int id)
		{
			AerGender aergender = databasePlaceholder.Get(id);
			if (aergender == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aergender;
		}

	}
}
