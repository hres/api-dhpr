using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerIngredientController : ApiController
	{
		static readonly IAerIngredientRepository databasePlaceholder = new AerIngredientRepository();

		public IEnumerable<AerIngredient> GetAllAerIngredient()
		{

			return databasePlaceholder.GetAll();
		}


		public AerIngredient GetAerIngredientById(int id)
		{
			AerIngredient aeringredient = databasePlaceholder.Get(id);
			if (aeringredient == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aeringredient;
		}

	}
}
