using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class XrefController : ApiController
	{
		static readonly IXrefRepository databasePlaceholder = new XrefRepository();

		public IEnumerable<Xref> GetAllXref(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public Xref GetXrefById(int id, string lang)
		{
			Xref xref = databasePlaceholder.Get(id, lang);
			if (xref == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return xref;
		}

	}
}
