using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace com.eLumen.Competency.Domain
{
    public class Organization
    {
        public Organization()
        {
            this.sloes = new HashSet<SLO>();
        }

        public int org_entity_id { get; set; }
        public string org_type_name { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string mission { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public Nullable<int> inactive_flag { get; set; }
        public Nullable<int> parent_org_entity_id { get; set; }
        public Nullable<int> assigned_course_grp_id { get; set; }
        public int slo_count { get; set; }
        public virtual ICollection<SLO> sloes { get; set; }

        internal static Organization Create(MySqlDataReader dr)
        {
            Organization cred = new Organization();

            for (int i = 0; i < dr.VisibleFieldCount; i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;

                var field = dr.GetName(i);

                switch (field)
                {
                    case "org_entity_id":
                        cred.org_entity_id = dr.GetInt32(i);
                        break;
                    case "name":
                        cred.name = dr.GetString(i);
                        break;
                    case "description":
                        cred.description = dr.GetString(i);
                        break;
                    case "inactive_flag":
                        cred.inactive_flag = dr.GetInt32(i);
                        break;
                    case "parent_org_entity_id":
                        cred.parent_org_entity_id = dr.GetInt32(i);
                        break;
                    case "mission":
                        cred.mission = dr.GetString(i);
                        break;
                    case "org_type_name":
                        cred.org_type_name = dr.GetString(i);
                        break;
                    case "assigned_course_grp_id":
                        cred.assigned_course_grp_id = dr.GetInt32(i);
                        break;
                    case "slo_count":
                        cred.slo_count = dr.GetInt32(i);
                        break;
                }
            }

            return cred;
        }
    }
}
