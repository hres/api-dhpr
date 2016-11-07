using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerIndication
    {
        public int id { get; set; }
		public int reportid { get; set; }
		public int drugproductid { get; set; }
		public String drugname { get; set; }
		public String indication { get; set; }
		public String language { get; set; }

    }


}