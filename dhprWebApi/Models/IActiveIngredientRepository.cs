using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IActiveIngredientRepository
    {
        IEnumerable<ActiveIngredient> GetAll(string lang);
        ActiveIngredient Get(int id, string lang);
    }
}