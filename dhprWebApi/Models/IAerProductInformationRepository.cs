using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerProductInformationRepository
    {
        IEnumerable<AerProductInformation> GetAll(string lang);
        AerProductInformation Get(int id, string lang);
    }
}