using System.Collections.Generic;
using dhprWebApi.AppCode;
namespace dhprWebApi.Models
{
    public class XrefRepository : IXrefRepository
    {
       
        private List<Xref> xrefs = new List<Xref>();
        private Xref xref = new Xref();
        DBConnection dbConnection = new DBConnection("en");
        public IEnumerable<Xref> GetAll()
        {
           xrefs = dbConnection.GetAllXref();

            return xrefs;
        }

        public Xref Get(int id)
        {

            xref = dbConnection.GetXrefById(id);
            return xref;
        }
    }
}
