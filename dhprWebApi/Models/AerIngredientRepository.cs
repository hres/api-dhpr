using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerIngredientRepository : IAerIngredientRepository
    {
       
        private List<AerIngredient> aeringredients = new List<AerIngredient>();
        private AerIngredient aeringredient = new AerIngredient();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerIngredient> GetAll()
        {
            aeringredients = dbConnection.GetAllAerIngredient();

            return aeringredients;
        }

        public AerIngredient Get(int id)
        {
            aeringredient = dbConnection.GetAerIngredientById(id);
            return aeringredient;
        }
    }
}