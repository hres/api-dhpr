using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Aer
    {
        public int id { get; set; }
		public int report_id { get; set; }
		public int latest_aer_version_number { get; set; }
		public string market_authorization_holder_aer_number { get; set; }
		public DateTime? initial_received_date { get; set; }
		public DateTime? latest_received_date { get; set; }
		public string type_of_report { get; set; }
		public int serious_report { get; set; }
		public string age_group { get; set; }
		public int age { get; set; }
		public string age_unit { get; set; }
		public long age_years { get; set; }
		public int gender { get; set; }
		public int weight { get; set; }
		public string weight_unit { get; set; }
		public int height { get; set; }
		public string height_unit { get; set; }
		public string report_outcome { get; set; }
		public string reporter_type { get; set; }
		public string source_of_report { get; set; }
		public int death { get; set; }
		public int disability { get; set; }
		public int congenital_anomaly { get; set; }
		public int life_threatening { get; set; }
		public int hospitalization { get; set; }
		public string other_medically_important_conditions { get; set; }
		public string record_type { get; set; }
		public string link_aer_number { get; set; }
		public string language { get; set; }

    }


}
