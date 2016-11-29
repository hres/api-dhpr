using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhprWebApi.Models
{
    interface IAerGenderRepository
    {
        IEnumerable<AerGender> GetAll();
        AerGender Get(int id);
    }
}
