using dhprWebApi.AppCode;
using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerReportTypeRepository : IAerReportTypeRepository
    {
       
        private List<AerReportType> aerreporttypes = new List<AerReportType>();
        private AerReportType aerreporttype = new AerReportType();

        public IEnumerable<AerReportType> GetAll(string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreporttypes = dbConnection.GetAllAerReportType();

            return aerreporttypes;
        }

        public AerReportType Get(int id, string lang)
        {
            DBConnection dbConnection = new DBConnection(lang);
            aerreporttype = dbConnection.GetAerReportTypeById(id);
            return aerreporttype;
        }
    }
}