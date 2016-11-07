using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class DrugProduct
    {
        public int id { get; set; }
		public int product_monograph_id { get; set; }
		public int drug_code { get; set; }
		public int brand_name_id { get; set; }
		public String sbd_link { get; set; }
		public String rds_link { get; set; }
		public String ssr_link { get; set; }

    }


}