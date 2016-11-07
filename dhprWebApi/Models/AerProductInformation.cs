using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerProductInformation
    {
        public int id { get; set; }
		public int reportdrugid { get; set; }
		public int reportid { get; set; }
		public int drugproductid { get; set; }
		public String drugname { get; set; }
		public String cvpname { get; set; }
		public String dosageform { get; set; }
		public String healthproductrole { get; set; }
		public String routeofadministration { get; set; }
		public long amount { get; set; }
		public String amountunit { get; set; }
		public int frequency { get; set; }
		public int frequencytime { get; set; }
		public String frequencytimeunit { get; set; }
		public String frequencyunit { get; set; }
		public int therapyduration { get; set; }
		public String therapydurationunit { get; set; }
		public String language { get; set; }

    }


}