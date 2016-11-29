using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerLink
    {
        public int id { get; set; }
		public int report_id { get; set; }
		public String type { get; set; }
		public int linked_aer_number { get; set; }
		public String language { get; set; }

    }


}
