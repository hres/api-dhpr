using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Route
    {
        public int id { get; set; }
		public int pharm_form_id { get; set; }
		public String route_of_admin { get; set; }
		public DateTime? route_inactive_date { get; set; }

    }


}