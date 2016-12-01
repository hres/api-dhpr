using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IProductMonographRepository
    {
        IEnumerable<ProductMonograph> GetAll(string lang);
        ProductMonograph Get(int id, string lang);
    }
}