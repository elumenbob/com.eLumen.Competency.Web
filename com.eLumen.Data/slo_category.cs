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
    
    public partial class slo_category
    {
        public slo_category()
        {
            this.sloes = new HashSet<slo>();
            this.slo_category1 = new HashSet<slo_category>();
        }
    
        public int slo_category_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public Nullable<int> owner_org_entity_id { get; set; }
        public int client_id { get; set; }
        public int lst_mod_user_id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public Nullable<int> slo_outcome_level_id { get; set; }
        public Nullable<int> slo_class_id { get; set; }
        public Nullable<int> C_src_bm_id { get; set; }
        public Nullable<int> seq { get; set; }
    
        public virtual ICollection<slo> sloes { get; set; }
        public virtual ICollection<slo_category> slo_category1 { get; set; }
        public virtual slo_category slo_category2 { get; set; }
        public virtual slo_class slo_class { get; set; }
    }
}
