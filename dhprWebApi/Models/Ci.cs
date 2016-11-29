using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Ci
    {
        public int id { get; set; }
		public String ci_used_for { get; set; }
		public String ci_what_it_does { get; set; }
		public String ci_when_not_used { get; set; }
		public String ci_medicinal_ingredients { get; set; }
		public String ci_nonmedicinal_ingredients { get; set; }
		public String ci_dosage { get; set; }
		public String ci_warnings { get; set; }
		public String ci_interactions { get; set; }
		public String ci_proper_use { get; set; }
		public String ci_side_effects { get; set; }
		public String ci_storage { get; set; }
		public String ci_reporting_side_effects { get; set; }
		public String ci_more_info { get; set; }
		public String ci_language { get; set; }
		public int ci_id { get; set; }
		public int product_monograph_id { get; set; }
		

    }


}
