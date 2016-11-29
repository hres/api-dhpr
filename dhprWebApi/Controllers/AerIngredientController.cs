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

		public IEnumerable<AerIngredient> GetAllAerIngredient(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerIngredient GetAerIngredientById(int id, string lang)
		{
			AerIngredient aeringredient = databasePlaceholder.Get(id, lang);
			if (aeringredient == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aeringredient;
		}

	}
}
