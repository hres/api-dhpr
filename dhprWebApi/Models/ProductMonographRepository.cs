using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class ProductMonographRepository : IProductMonographRepository
    {
       
        private List<ProductMonograph> productmonographs = new List<ProductMonograph>();
        private ProductMonograph productmonograph = new ProductMonograph();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<ProductMonograph> GetAll()
        {
            productmonographs = dbConnection.GetAllProductMonograph();

            return productmonographs;
        }

        public ProductMonograph Get(int id)
        {
            productmonograph = dbConnection.GetProductMonographById(id);
            return productmonograph;
        }
    }
}