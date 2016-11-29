using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerIngredientRepository : IAerIngredientRepository
    {
       
        private List<AerIngredient> aeringredients = new List<AerIngredient>();
        private AerIngredient aeringredient = new AerIngredient();
        
        public IEnumerable<AerIngredient> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aeringredients = dbConnection.GetAllAerIngredient();

            return aeringredients;
        }

        public AerIngredient Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aeringredient = dbConnection.GetAerIngredientById(id);
            return aeringredient;
        }
    }
}