using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerProductInformationController : ApiController
	{
		static readonly IAerProductInformationRepository databasePlaceholder = new AerProductInformationRepository();

		public IEnumerable<AerProductInformation> GetAllAerProductInformation()
		{

			return databasePlaceholder.GetAll();
		}


		public AerProductInformation GetAerProductInformationById(int id)
		{
			AerProductInformation aerproductinformation = databasePlaceholder.Get(id);
			if (aerproductinformation == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerproductinformation;
		}

	}
}
