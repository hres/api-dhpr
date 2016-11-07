using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerSeriousRepository : IAerSeriousRepository
    {
       
        private List<AerSerious> aerseriouss = new List<AerSerious>();
        private AerSerious aerserious = new AerSerious();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerSerious> GetAll()
        {
            aerseriouss = dbConnection.GetAllAerSerious();

            return aerseriouss;
        }

        public AerSerious Get(int id)
        {
            aerserious = dbConnection.GetAerSeriousById(id);
            return aerserious;
        }
    }
}