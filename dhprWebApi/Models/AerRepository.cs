using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerRepository : IAerRepository
    {
       
        private List<Aer> aers = new List<Aer>();
        private Aer aer = new Aer();
        
        public IEnumerable<Aer> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aers = dbConnection.GetAllAer();

            return aers;
        }

        public Aer Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aer = dbConnection.GetAerById(id);
            return aer;
        }
    }
}