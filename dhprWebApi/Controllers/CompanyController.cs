using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dhprWebApi.Models;
namespace dhprWebApi.Controllers
{
	public class CompanyController : ApiController
	{
		static readonly ICompanyRepository databasePlaceholder = new CompanyRepository();

		public IEnumerable<Company> GetAllCompany()
		{

			return databasePlaceholder.GetAll();
		}


		public Company GetCompanyById(int id)
		{
			Company company = databasePlaceholder.Get(id);
			if (company == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
			return company;
		}

	}
}
