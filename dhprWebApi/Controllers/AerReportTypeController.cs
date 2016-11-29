using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class AerReportTypeController : ApiController
	{
		static readonly IAerReportTypeRepository databasePlaceholder = new AerReportTypeRepository();

		public IEnumerable<AerReportType> GetAllAerReportType(string lang)
		{

			return databasePlaceholder.GetAll(lang);
		}


		public AerReportType GetAerReportTypeById(int id, string lang)
		{
			AerReportType aerreporttype = databasePlaceholder.Get(id, lang);
			if (aerreporttype == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerreporttype;
		}

	}
}
