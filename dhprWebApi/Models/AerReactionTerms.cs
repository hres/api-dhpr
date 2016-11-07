using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class AerReactionTerms
    {
        public int id { get; set; }
		public int reportid { get; set; }
		public String adversereactionterms { get; set; }
		public String meddrasystemorganclasssoc { get; set; }
		public int reactionduration { get; set; }
		public String reactiondurationunit { get; set; }
		public String meddraversion { get; set; }
		public String language { get; set; }

    }


}