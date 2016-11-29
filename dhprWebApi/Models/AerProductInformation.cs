using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerProductInformation
    {
        public int id { get; set; }
		public int report_drug_id { get; set; }
		public int report_id { get; set; }
		public int drug_product_id { get; set; }
		public String drug_name { get; set; }
		public String cvp_name { get; set; }
		public String dosage_form { get; set; }
		public String health_product_role { get; set; }
		public String route_of_administration { get; set; }
		public long amount { get; set; }
		public String amount_unit { get; set; }
		public int frequency { get; set; }
		public int frequency_time { get; set; }
		public String frequency_time_unit { get; set; }
		public String frequency_unit { get; set; }
		public int therapy_duration { get; set; }
		public String therapy_duration_unit { get; set; }
		public String language { get; set; }

    }


}
