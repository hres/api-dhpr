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

		public IEnumerable<Xref> GetAllXref()
		{
            return databasePlaceholder.GetAll();
		}


		public Xref GetXrefById(int id)
		{
			Xref xref = databasePlaceholder.Get(id);
			if (xref == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return xref;
		}

	}
}
