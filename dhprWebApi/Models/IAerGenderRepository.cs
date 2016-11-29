using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerGenderRepository
    {
        IEnumerable<AerGender> GetAll(string lang);
        AerGender Get(int id, string lang);
    }
}