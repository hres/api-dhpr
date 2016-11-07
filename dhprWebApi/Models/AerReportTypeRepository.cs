using System.Collections.Generic;

namespace dhprWebApi.Models
{
    public class AerReportTypeRepository : IAerReportTypeRepository
    {
       
        private List<AerReportType> aerreporttypes = new List<AerReportType>();
        private AerReportType aerreporttype = new AerReportType();

        DBConnection dbConnection = new DBConnection("en");


        public IEnumerable<AerReportType> GetAll()
        {
            aerreporttypes = dbConnection.GetAllAerReportType();

            return aerreporttypes;
        }

        public AerReportType Get(int id)
        {
            aerreporttype = dbConnection.GetAerReportTypeById(id);
            return aerreporttype;
        }
    }
}