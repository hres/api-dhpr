using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerReactionTerms
    {
        public int id { get; set; }
		public int report_id { get; set; }
		public String adverse_reaction_terms { get; set; }
		public String meddra_system_organ_class_soc { get; set; }
		public int reaction_duration { get; set; }
		public String reaction_duration_unit { get; set; }
		public String meddra_version { get; set; }
		public String language { get; set; }

    }


}
