using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerProductInformationRepository
    {
        IEnumerable<AerProductInformation> GetAll();
        AerProductInformation Get(int id);
    }
}