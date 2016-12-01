using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IDrugProductRepository
    {
        IEnumerable<DrugProduct> GetAll(string lang);
        DrugProduct Get(int id, string lang);
    }
}