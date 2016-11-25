using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class CiRepository : ICiRepository
    {
       
        private List<Ci> cis = new List<Ci>();
        private Ci ci = new Ci();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<Ci> GetAll()
        {
            cis = dbConnection.GetAllCi();

            return cis;
        }

        public Ci Get(int id)
        {
            ci = dbConnection.GetCiById(id);
            return ci;
        }
    }
}