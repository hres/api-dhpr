using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerSourceRepository : IAerSourceRepository
    {
       
        private List<AerSource> aersources = new List<AerSource>();
        private AerSource aersource = new AerSource();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerSource> GetAll()
        {
            aersources = dbConnection.GetAllAerSource();

            return aersources;
        }

        public AerSource Get(int id)
        {
            aersource = dbConnection.GetAerSourceById(id);
            return aersource;
        }
    }
}