using dhprWebApi.AppCode;
using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerReactionTermsRepository : IAerReactionTermsRepository
    {
       
        private List<AerReactionTerms> aerreactiontermss = new List<AerReactionTerms>();
        private AerReactionTerms aerreactionterms = new AerReactionTerms();

        


        public IEnumerable<AerReactionTerms> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreactiontermss = dbConnection.GetAllAerReactionTerms();

            return aerreactiontermss;
        }

        public AerReactionTerms Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreactionterms = dbConnection.GetAerReactionTermsById(id);
            return aerreactionterms;
        }
    }
}