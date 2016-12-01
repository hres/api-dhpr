using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerIngredientRepository
    {
        IEnumerable<AerIngredient> GetAll(string lang);
        AerIngredient Get(int id, string lang);
    }
}