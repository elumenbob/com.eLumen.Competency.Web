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
    
    public partial class asmt_score_level
    {
        public asmt_score_level()
        {
            this.asmt_perf_description = new HashSet<asmt_perf_description>();
            this.asmt_perf_ds_default = new HashSet<asmt_perf_ds_default>();
        }
    
        public int asmt_score_level_id { get; set; }
        public string name { get; set; }
        public string ds { get; set; }
        public Nullable<int> value { get; set; }
        public Nullable<int> asmt_mastery_level_id { get; set; }
        public Nullable<decimal> points { get; set; }
        public Nullable<int> asmt_scored_id { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public int client_id { get; set; }
        public int asmt_scale_id { get; set; }
        public Nullable<int> lst_mod_user_id { get; set; }
        public string not_applicable { get; set; }
        public string default_perf_ds { get; set; }
        public Nullable<int> C_src_scale_default_rubric_interp_id { get; set; }
    
        public virtual asmt_mastery_level asmt_mastery_level { get; set; }
        public virtual ICollection<asmt_perf_description> asmt_perf_description { get; set; }
        public virtual ICollection<asmt_perf_ds_default> asmt_perf_ds_default { get; set; }
        public virtual asmt_scale asmt_scale { get; set; }
    }
}
