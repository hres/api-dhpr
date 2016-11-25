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
		public string marketauthorizationholderaernumber { get; set; }
		public DateTime? initialreceiveddate { get; set; }
		public DateTime? latestreceiveddate { get; set; }
		public string typeofreport { get; set; }
		public int seriousreport { get; set; }
		public string agegroup { get; set; }
		public int age { get; set; }
		public string ageunit { get; set; }
		public long age_years { get; set; }
		public int gender { get; set; }
		public int weight { get; set; }
		public string weightunit { get; set; }
		public int height { get; set; }
		public string heightunit { get; set; }
		public string reportoutcome { get; set; }
		public string reportertype { get; set; }
		public string sourceofreport { get; set; }
		public int death { get; set; }
		public int disability { get; set; }
		public int congenitalanomaly { get; set; }
		public int lifethreatening { get; set; }
		public int hospitalization { get; set; }
		public string othermedicallyimportantconditions { get; set; }
		public string recordtype { get; set; }
		public string linkaernumber { get; set; }
		public string language { get; set; }

    }


}