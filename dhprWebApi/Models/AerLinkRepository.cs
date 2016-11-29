using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerLinkRepository : IAerLinkRepository
    {
       
        private List<AerLink> aerlinks = new List<AerLink>();
        private AerLink aerlink = new AerLink();

        public IEnumerable<AerLink> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerlinks = dbConnection.GetAllAerLink();

            return aerlinks;
        }

        public AerLink Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerlink = dbConnection.GetAerLinkById(id);
            return aerlink;
        }
    }
}