using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class ActiveIngredientRepository : IActiveIngredientRepository
    {
       
        private List<ActiveIngredient> activeingredients = new List<ActiveIngredient>();
        private ActiveIngredient activeingredient = new ActiveIngredient();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<ActiveIngredient> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            activeingredients = dbConnection.GetAllActiveIngredient();

            return activeingredients;
        }

        public ActiveIngredient Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            activeingredient = dbConnection.GetActiveIngredientById(id);
            return activeingredient;
        }
    }
}