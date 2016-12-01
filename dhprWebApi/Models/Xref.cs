using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Xref
    {
        public int id { get; set; }
        public string cvp_name { get; set; }
        public string dhpr_name { get; set; }
        public DateTime? submit_date { get; set; }


    }


}
