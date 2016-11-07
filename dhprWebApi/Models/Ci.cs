using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Ci
    {
        public int id { get; set; }
		public String ci_usedfor { get; set; }
		public String ci_whatitdoes { get; set; }
		public String ci_whennotused { get; set; }
		public String ci_medicinalingredients { get; set; }
		public String ci_nonmedicinalingredients { get; set; }
		public String ci_dosage { get; set; }
		public String ci_warnings { get; set; }
		public String ci_interactions { get; set; }
		public String ci_properuse { get; set; }
		public String ci_sideeffects { get; set; }
		public String ci_storage { get; set; }
		public String ci_reportingsideeffects { get; set; }
		public String ci_moreinfo { get; set; }
		public String ci_language { get; set; }
		public int ci_id { get; set; }
		public int product_monograph_id { get; set; }
		

    }


}