using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class DrugProductController : ApiController
	{
		static readonly IDrugProductRepository databasePlaceholder = new DrugProductRepository();

		public IEnumerable<DrugProduct> GetAllDrugProduct()
		{

			return databasePlaceholder.GetAll();
		}


		public DrugProduct GetDrugProductById(int id)
		{
			DrugProduct drugproduct = databasePlaceholder.Get(id);
			if (drugproduct == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return drugproduct;
		}

	}
}
