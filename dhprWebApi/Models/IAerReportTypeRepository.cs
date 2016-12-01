using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerReportTypeRepository
    {
        IEnumerable<AerReportType> GetAll(string lang);
        AerReportType Get(int id, string lang);
    }
}