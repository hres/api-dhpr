using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class BrandNameRepository : IBrandNameRepository
    {
       
        private List<BrandName> brandnames = new List<BrandName>();
        private BrandName brandname = new BrandName();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<BrandName> GetAll()
        {
            brandnames = dbConnection.GetAllBrandName();

            return brandnames;
        }

        public BrandName Get(int id)
        {
            brandname = dbConnection.GetBrandNameById(id);
            return brandname;
        }
    }
}