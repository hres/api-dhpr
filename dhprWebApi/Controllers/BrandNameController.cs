using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class BrandNameController : ApiController
	{
		static readonly IBrandNameRepository databasePlaceholder = new BrandNameRepository();

		public IEnumerable<BrandName> GetAllBrandName()
		{

			return databasePlaceholder.GetAll();
		}


		public BrandName GetBrandNameById(int id)
		{
			BrandName brandname = databasePlaceholder.Get(id);
			if (brandname == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return brandname;
		}

	}
}
