using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class Aer
    {
        public int id { get; set; }
		public int reportid { get; set; }
		public int latestaerversionnumber { get; set; }
		public String marketauthorizationholderaernumber { get; set; }
		public DateTime? initialreceiveddate { get; set; }
		public DateTime? latestreceiveddate { get; set; }
		public String typeofreport { get; set; }
		public int seriousreport { get; set; }
		public String agegroup { get; set; }
		public int age { get; set; }
		public String ageunit { get; set; }
		public long age_years { get; set; }
		public int gender { get; set; }
		public int weight { get; set; }
		public String weightunit { get; set; }
		public int height { get; set; }
		public String heightunit { get; set; }
		public String reportoutcome { get; set; }
		public String reportertype { get; set; }
		public String sourceofreport { get; set; }
		public short death { get; set; }
		public short disability { get; set; }
		public short congenitalanomaly { get; set; }
		public short lifethreatening { get; set; }
		public short hospitalization { get; set; }
		public String othermedicallyimportantconditions { get; set; }
		public String recordtype { get; set; }
		public String linkaernumber { get; set; }
		public String language { get; set; }

    }


}
