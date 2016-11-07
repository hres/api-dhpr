using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class CompanyRepository : ICompanyRepository
    {
       
        private List<Company> companys = new List<Company>();
        private Company company = new Company();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<Company> GetAll()
        {
            companys = dbConnection.GetAllCompany();

            return companys;
        }

        public Company Get(int id)
        {
            company = dbConnection.GetCompanyById(id);
            return company;
        }
    }
}