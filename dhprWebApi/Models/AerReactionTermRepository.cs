using dhprWebApi.AppCode;
using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerReactionTermRepository : IAerReactionTermRepository
    {
       
        private List<AerReactionTerm> aerreactiontermss = new List<AerReactionTerm>();
        private AerReactionTerm aerreactionterms = new AerReactionTerm();

        


        public IEnumerable<AerReactionTerm> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreactiontermss = dbConnection.GetAllAerReactionTerm();

            return aerreactiontermss;
        }

        public AerReactionTerm Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreactionterms = dbConnection.GetAerReactionTermById(id);
            return aerreactionterms;
        }
    }
}