using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerSeriousRepository : IAerSeriousRepository
    {
       
        private List<AerSerious> aerseriouss = new List<AerSerious>();
        private AerSerious aerserious = new AerSerious();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerSerious> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerseriouss = dbConnection.GetAllAerSerious();

            return aerseriouss;
        }

        public AerSerious Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerserious = dbConnection.GetAerSeriousById(id);
            return aerserious;
        }
    }
}