using dhpr;
using System.Collections.Generic;

namespace DhprWebApi.Models
{
    public class AerGenderRepository : IAerGenderRepository
    {
       
        private List<AerGender> aergenders = new List<AerGender>();
        private AerGender aergender = new AerGender();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerGender> GetAll()
        {
            aergenders = dbConnection.GetAllAerGender();

            return aergenders;
        }

        public AerGender Get(int id)
        {
            aergender = dbConnection.GetAerGenderById(id);
            return aergender;
        }
    }
}
