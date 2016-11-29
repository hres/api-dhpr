using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerLinkController : ApiController
	{
		static readonly IAerLinkRepository databasePlaceholder = new AerLinkRepository();

		public IEnumerable<AerLink> GetAllAerLink(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerLink GetAerLinkById(int id, string lang)
		{
			AerLink aerlink = databasePlaceholder.Get(id, lang);
			if (aerlink == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerlink;
		}

	}
}
