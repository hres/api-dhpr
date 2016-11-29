using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class ProductMonographController : ApiController
	{
		static readonly IProductMonographRepository databasePlaceholder = new ProductMonographRepository();

		public IEnumerable<ProductMonograph> GetAllProductMonograph(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public ProductMonograph GetProductMonographById(int id, string lang)
		{
			ProductMonograph productmonograph = databasePlaceholder.Get(id, lang);
			if (productmonograph == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return productmonograph;
		}

	}
}
