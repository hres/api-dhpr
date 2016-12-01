using System.Collections.Generic;

namespace dhprWebApi.Models
{
    interface IXrefRepository
    {
        IEnumerable<Xref> GetAll();
        Xref Get(int id);
    }
}