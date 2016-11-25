using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class AerLinkRepository : IAerLinkRepository
    {
       
        private List<AerLink> aerlinks = new List<AerLink>();
        private AerLink aerlink = new AerLink();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerLink> GetAll()
        {
            aerlinks = dbConnection.GetAllAerLink();

            return aerlinks;
        }

        public AerLink Get(int id)
        {
            aerlink = dbConnection.GetAerLinkById(id);
            return aerlink;
        }
    }
}