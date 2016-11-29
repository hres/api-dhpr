using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerIndication
    {
        public int id { get; set; }
		public int report_id { get; set; }
		public int drug_product_id { get; set; }
		public String drug_name { get; set; }
		public String indication { get; set; }
		public String language { get; set; }

    }


}
