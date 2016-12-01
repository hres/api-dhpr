using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IActiveIngredientRepository
    {
        IEnumerable<ActiveIngredient> GetAll(string lang);
        ActiveIngredient Get(int id, string lang);
    }
}