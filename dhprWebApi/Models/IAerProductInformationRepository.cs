using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerProductInformationRepository
    {
        IEnumerable<AerProductInformation> GetAll(string lang);
        AerProductInformation Get(int id, string lang);
    }
}