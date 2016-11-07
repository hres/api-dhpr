using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerOutcome
    {
        public int id { get; set; }
		public int code { get; set; }
		public String outcome { get; set; }
		public String language { get; set; }	

    }


}