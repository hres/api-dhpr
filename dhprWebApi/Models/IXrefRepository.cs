using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class XrefRepository : IXrefRepository
    {
       
        private List<Xref> xrefs = new List<Xref>();
        private Xref xref = new Xref();
        
        public IEnumerable<Xref> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            xrefs = dbConnection.GetAllXref();

            return xrefs;
        }

        public Xref Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            xref = dbConnection.GetXrefById(id);
            return xref;
        }
    }
}
