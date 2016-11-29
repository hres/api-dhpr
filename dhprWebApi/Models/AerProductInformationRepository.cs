using System.Collections.Generic;
using dhprWebApi.AppCode;

namespace dhprWebApi.Models
{
    public class AerProductInformationRepository : IAerProductInformationRepository
    {
       
        private List<AerProductInformation> aerproductinformations = new List<AerProductInformation>();
        private AerProductInformation aerproductinformation = new AerProductInformation();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerProductInformation> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerproductinformations = dbConnection.GetAllAerProductInformation();

            return aerproductinformations;
        }

        public AerProductInformation Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerproductinformation = dbConnection.GetAerProductInformationById(id);
            return aerproductinformation;
        }
    }
}