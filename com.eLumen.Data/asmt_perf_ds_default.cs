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
    
    public partial class asmt_perf_ds_default
    {
        public int asmt_perf_ds_default_id { get; set; }
        public string name { get; set; }
        public int asmt_score_level_id { get; set; }
        public Nullable<int> slo_id { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public int lst_mod_user_id { get; set; }
        public int client_id { get; set; }
    
        public virtual asmt_score_level asmt_score_level { get; set; }
        public virtual slo slo { get; set; }
    }
}