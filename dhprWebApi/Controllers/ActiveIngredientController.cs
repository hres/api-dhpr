using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
    public class ActiveIngredientController : ApiController
	{
		static readonly IActiveIngredientRepository databasePlaceholder = new ActiveIngredientRepository();

		public IEnumerable<ActiveIngredient> GetAllActiveIngredient()
		{

			return databasePlaceholder.GetAll();
		}


		public ActiveIngredient GetActiveIngredientById(int id)
		{
			ActiveIngredient activeingredient = databasePlaceholder.Get(id);
			if (activeingredient == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return activeingredient;
		}

	}
}
