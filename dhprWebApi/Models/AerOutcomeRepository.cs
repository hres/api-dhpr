using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerOutcomeRepository : IAerOutcomeRepository
    {
       
        private List<AerOutcome> aeroutcomes = new List<AerOutcome>();
        private AerOutcome aeroutcome = new AerOutcome();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerOutcome> GetAll()
        {
            aeroutcomes = dbConnection.GetAllAerOutcome();

            return aeroutcomes;
        }

        public AerOutcome Get(int id)
        {
            aeroutcome = dbConnection.GetAerOutcomeById(id);
            return aeroutcome;
        }
    }
}