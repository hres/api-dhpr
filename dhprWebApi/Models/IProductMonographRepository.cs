using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IProductMonographRepository
    {
        IEnumerable<ProductMonograph> GetAll(string lang);
        ProductMonograph Get(int id, string lang);
    }
}