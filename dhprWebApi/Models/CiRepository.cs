using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class CiRepository : ICiRepository
    {
       
        private List<Ci> cis = new List<Ci>();
        private Ci ci = new Ci();

        public IEnumerable<Ci> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            cis = dbConnection.GetAllCi();

            return cis;
        }

        public Ci Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            ci = dbConnection.GetCiById(id);
            return ci;
        }
    }
}