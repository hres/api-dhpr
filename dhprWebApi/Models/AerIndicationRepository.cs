using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerIndicationRepository : IAerIndicationRepository
    {
       
        private List<AerIndication> aerindications = new List<AerIndication>();
        private AerIndication aerindication = new AerIndication();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerIndication> GetAll()
        {
            aerindications = dbConnection.GetAllAerIndication();

            return aerindications;
        }

        public AerIndication Get(int id)
        {
            aerindication = dbConnection.GetAerIndicationById(id);
            return aerindication;
        }
    }
}