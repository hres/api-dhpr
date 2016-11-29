using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
    public class ActiveIngredientController : ApiController
	{
		static readonly IActiveIngredientRepository databasePlaceholder = new ActiveIngredientRepository();

		public IEnumerable<ActiveIngredient> GetAllActiveIngredient(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public ActiveIngredient GetActiveIngredientById(int id, string lang)
		{
			ActiveIngredient activeingredient = databasePlaceholder.Get(id, lang);
			if (activeingredient == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return activeingredient;
		}

	}
}
