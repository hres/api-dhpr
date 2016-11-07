using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerRepository : IAerRepository
    {
       
        private List<Aer> aers = new List<Aer>();
        private Aer aer = new Aer();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<Aer> GetAll()
        {
            aers = dbConnection.GetAllAer();

            return aers;
        }

        public Aer Get(int id)
        {
            aer = dbConnection.GetAerById(id);
            return aer;
        }
    }
}