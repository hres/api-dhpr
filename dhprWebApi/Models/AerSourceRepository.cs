using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerSourceRepository : IAerSourceRepository
    {
       
        private List<AerSource> aersources = new List<AerSource>();
        private AerSource aersource = new AerSource();

       


        public IEnumerable<AerSource> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aersources = dbConnection.GetAllAerSource();

            return aersources;
        }

        public AerSource Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aersource = dbConnection.GetAerSourceById(id);
            return aersource;
        }
    }
}