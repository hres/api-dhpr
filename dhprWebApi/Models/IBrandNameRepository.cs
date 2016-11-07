using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IBrandNameRepository
    {
        IEnumerable<BrandName> GetAll();
        BrandName Get(int id);
    }
}