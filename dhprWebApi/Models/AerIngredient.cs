using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerIngredient
    {
        public int id { get; set; }
		public int drug_product_id { get; set; }
		public String drug_name { get; set; }
		public int ingredient_id { get; set; }
		public String ingredient_name { get; set; }
		public String language { get; set; }

    }


}
