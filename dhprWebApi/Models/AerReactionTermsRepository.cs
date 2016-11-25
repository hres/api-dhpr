using dhprWebApi.AppCode;
using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerReactionTermsRepository : IAerReactionTermsRepository
    {
       
        private List<AerReactionTerms> aerreactiontermss = new List<AerReactionTerms>();
        private AerReactionTerms aerreactionterms = new AerReactionTerms();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerReactionTerms> GetAll()
        {
            aerreactiontermss = dbConnection.GetAllAerReactionTerms();

            return aerreactiontermss;
        }

        public AerReactionTerms Get(int id)
        {
            aerreactionterms = dbConnection.GetAerReactionTermsById(id);
            return aerreactionterms;
        }
    }
}