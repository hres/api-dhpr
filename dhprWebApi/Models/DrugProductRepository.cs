using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class DrugProductRepository : IDrugProductRepository
    {
       
        private List<DrugProduct> drugproducts = new List<DrugProduct>();
        private DrugProduct drugproduct = new DrugProduct();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<DrugProduct> GetAll()
        {
            drugproducts = dbConnection.GetAllDrugProduct();

            return drugproducts;
        }

        public DrugProduct Get(int id)
        {
            drugproduct = dbConnection.GetDrugProductById(id);
            return drugproduct;
        }
    }
}