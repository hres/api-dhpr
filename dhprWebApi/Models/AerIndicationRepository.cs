using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerIndicationRepository : IAerIndicationRepository
    {
       
        private List<AerIndication> aerindications = new List<AerIndication>();
        private AerIndication aerindication = new AerIndication();

        public IEnumerable<AerIndication> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerindications = dbConnection.GetAllAerIndication();

            return aerindications;
        }

        public AerIndication Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerindication = dbConnection.GetAerIndicationById(id);
            return aerindication;
        }
    }
}