using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerOutcomeRepository : IAerOutcomeRepository
    {
       
        private List<AerOutcome> aeroutcomes = new List<AerOutcome>();
        private AerOutcome aeroutcome = new AerOutcome();

        public IEnumerable<AerOutcome> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aeroutcomes = dbConnection.GetAllAerOutcome();

            return aeroutcomes;
        }

        public AerOutcome Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aeroutcome = dbConnection.GetAerOutcomeById(id);
            return aeroutcome;
        }
    }
}