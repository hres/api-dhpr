using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
    }
}