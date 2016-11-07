using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerReportTypeRepository
    {
        IEnumerable<AerReportType> GetAll();
        AerReportType Get(int id);
    }
}