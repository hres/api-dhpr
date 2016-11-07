using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhprWebApi.Models
{
    interface IAerReactionTermsRepository
    {
        IEnumerable<AerReactionTerms> GetAll();
        AerReactionTerms Get(int id);
    }
}