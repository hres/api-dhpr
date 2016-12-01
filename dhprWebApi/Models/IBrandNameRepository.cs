using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IBrandNameRepository
    {
        IEnumerable<BrandName> GetAll();
        BrandName Get(int id);
    }
}