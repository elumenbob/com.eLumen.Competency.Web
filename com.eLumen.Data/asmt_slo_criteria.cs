//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.eLumen.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class asmt_slo_criteria
    {
        public asmt_slo_criteria()
        {
            this.asmt_perf_description = new HashSet<asmt_perf_description>();
        }
    
        public int asmt_slo_criteria_id { get; set; }
        public int asmt_scored_id { get; set; }
        public int slo_id { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public int lst_mod_user_id { get; set; }
        public int client_id { get; set; }
        public Nullable<int> C_src_scale_id { get; set; }
        public Nullable<bool> C_was_unused_sa { get; set; }
    
        public virtual ICollection<asmt_perf_description> asmt_perf_description { get; set; }
        public virtual slo slo { get; set; }
    }
}
