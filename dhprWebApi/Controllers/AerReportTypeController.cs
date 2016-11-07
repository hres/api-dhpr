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

		public IEnumerable<AerReportType> GetAllAerReportType()
		{

			return databasePlaceholder.GetAll();
		}


		public AerReportType GetAerReportTypeById(int id)
		{
			AerReportType aerreporttype = databasePlaceholder.Get(id);
			if (aerreporttype == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return aerreporttype;
		}

	}
}
