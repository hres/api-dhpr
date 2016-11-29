
using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerGenderRepository : IAerGenderRepository
    {
       
        private List<AerGender> aergenders = new List<AerGender>();
        private AerGender aergender = new AerGender();
        
        public IEnumerable<AerGender> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aergenders = dbConnection.GetAllAerGender();

            return aergenders;
        }

        public AerGender Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aergender = dbConnection.GetAerGenderById(id);
            return aergender;
        }
    }
}