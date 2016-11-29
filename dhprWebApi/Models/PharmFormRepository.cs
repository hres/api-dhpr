using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class PharmFormRepository : IPharmFormRepository
    {
       
        private List<PharmForm> pharmforms = new List<PharmForm>();
        private PharmForm pharmform = new PharmForm();

        public IEnumerable<PharmForm> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            pharmforms = dbConnection.GetAllPharmForm();

            return pharmforms;
        }

        public PharmForm Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            pharmform = dbConnection.GetPharmFormById(id);
            return pharmform;
        }
    }
}