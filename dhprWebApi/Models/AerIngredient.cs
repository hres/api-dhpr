using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerIngredient
    {
        public int id { get; set; }
		public int drugproductid { get; set; }
		public String drugname { get; set; }
		public int ingredientid { get; set; }
		public String ingredientname { get; set; }
		public String language { get; set; }

    }


}