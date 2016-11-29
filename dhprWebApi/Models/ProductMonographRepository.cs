using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class ProductMonographRepository : IProductMonographRepository
    {
       
        private List<ProductMonograph> productmonographs = new List<ProductMonograph>();
        private ProductMonograph productmonograph = new ProductMonograph();
        
        public IEnumerable<ProductMonograph> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            productmonographs = dbConnection.GetAllProductMonograph();

            return productmonographs;
        }

        public ProductMonograph Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            productmonograph = dbConnection.GetProductMonographById(id);
            return productmonograph;
        }
    }
}