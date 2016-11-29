using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerReportTypeRepository
    {
        IEnumerable<AerReportType> GetAll(string lang);
        AerReportType Get(int id, string lang);
    }
}