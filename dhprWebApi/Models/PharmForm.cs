using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dhprWebApi.Models
{
    public class PharmForm
    {
        public int id { get; set; }
        public int drug_product_id { get; set; }
        public String pharm_form { get; set; }
        public DateTime? form_inactive_date{ get; set; }
        public String drug_identification_number { get; set; }
    }


}