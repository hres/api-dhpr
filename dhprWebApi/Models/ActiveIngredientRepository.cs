using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class ActiveIngredientRepository : IActiveIngredientRepository
    {
       
        private List<ActiveIngredient> activeingredients = new List<ActiveIngredient>();
        private ActiveIngredient activeingredient = new ActiveIngredient();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<ActiveIngredient> GetAll()
        {
            activeingredients = dbConnection.GetAllActiveIngredient();

            return activeingredients;
        }

        public ActiveIngredient Get(int id)
        {
            activeingredient = dbConnection.GetActiveIngredientById(id);
            return activeingredient;
        }
    }
}