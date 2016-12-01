using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IAerGenderRepository
    {
        IEnumerable<AerGender> GetAll(string lang);
        AerGender Get(int id, string lang);
    }
}