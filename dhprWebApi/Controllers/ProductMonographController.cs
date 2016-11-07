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

		public IEnumerable<ProductMonograph> GetAllProductMonograph()
		{

			return databasePlaceholder.GetAll();
		}


		public ProductMonograph GetProductMonographById(int id)
		{
			ProductMonograph productmonograph = databasePlaceholder.Get(id);
			if (productmonograph == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return productmonograph;
		}

	}
}
