using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class PharmFormRepository : IPharmFormRepository
    {
       
        private List<PharmForm> pharmforms = new List<PharmForm>();
        private PharmForm pharmform = new PharmForm();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<PharmForm> GetAll()
        {
            pharmforms = dbConnection.GetAllPharmForm();

            return pharmforms;
        }

        public PharmForm Get(int id)
        {
            pharmform = dbConnection.GetPharmFormById(id);
            return pharmform;
        }
    }
}