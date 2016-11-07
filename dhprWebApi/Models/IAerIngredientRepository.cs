using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerIngredientRepository
    {
        IEnumerable<AerIngredient> GetAll();
        AerIngredient Get(int id);
    }
}