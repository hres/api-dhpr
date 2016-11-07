using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class ActiveIngredient
    {
        public int id { get; set; }
		public int pharm_form_id { get; set; }
		public String ingredient_prefix { get; set; }
		public String ingredient { get; set; }
		public String ingredient_supplied_ind { get; set; }
		public String strength { get; set; }
		public String strength_unit { get; set; }
		public String strength_type { get; set; }
		public String dosage_value { get; set; }
		//public String base { get; set; }
		public String dosage_unit { get; set; }
		public String notes { get; set; }

    }


}