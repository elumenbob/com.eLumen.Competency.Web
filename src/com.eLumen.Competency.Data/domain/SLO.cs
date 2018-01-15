using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.Competency.Domain
{
    public class SLO
    {
        public SLO()
        {
            //this.asmt_slo_criteria = new HashSet<asmt_slo_criteria>();
//            this.asmts = new HashSet<Assessment>();
        }

        public int slo_id { get; set; }
        public Nullable<sbyte> current_flag { get; set; }
        public string name { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public string org_name { get; set; }
        public int slo_outcome_level_id { get; set; }
        public Nullable<int> seq { get; set; }
        public string slo_category { get; set; }
        public string org_description { get; private set; }

        internal static SLO CreateFromCredential(MySqlDataReader dr)
        {
            SLO cred = new SLO();

            for (int i = 0; i < dr.VisibleFieldCount; i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;

                var field = dr.GetName(i);

                switch (field)
                {
                    case "slo_id":
                        cred.slo_id = dr.GetInt32(i);
                        break;
                    case "slo_name":
                        cred.name = dr.GetString(i);
                        break;
                    case "slo_outcome_level_id":
                        cred.slo_outcome_level_id = dr.GetInt32(i);
                        break;
                    case "lst_mod_dt":
                        cred.lst_mod_dt = dr.GetDateTime(i);
                        break;
                    case "slo_sequence":
                        cred.seq = dr.GetInt32(i);
                        break;
                    case "current_flag":
                        cred.current_flag = dr.GetSByte(i);
                        break;
                    case "org_name":
                        cred.org_name = dr.GetString(i);
                        break;
                    case "org_description":
                        cred.org_description = dr.GetString(i);
                        break;
                    case "category_desc":
                        cred.slo_category = dr.GetString(i);
                        break;
                }
            }

            return cred;
        }
    }
}
