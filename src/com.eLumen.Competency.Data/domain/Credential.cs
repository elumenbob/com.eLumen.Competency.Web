using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace com.eLumen.Competency.Domain
{
    public class Credential
    {
        public Credential()
        {
            this.sloes = new HashSet<SLO>();
        }

        public int credential_id { get; set; }
        public Nullable<bool> current_flag { get; set; }
        public sbyte is_latest { get; set; }
        public string credential_type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public Nullable<int> active_flag { get; set; }
        public string org_name { get; set; }
        public Nullable<int> transferability_id { get; set; }
        public string program_mode { get; set; }
        public string top_code { get; set; }
        public virtual ICollection<SLO> sloes { get; set; }
        public string credential_name { get; private set; }

        internal static Credential Create(MySqlDataReader dr)
        {
            Credential cred = new Credential();

            for (int i = 0; i< dr.VisibleFieldCount;i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;

                var field = dr.GetName(i);

                switch (field)
                {
                    case "credential_id":
                        cred.credential_id = dr.GetInt32(i);
                        break;
                    case "current_flag":
                        cred.current_flag = dr.GetBoolean(i);
                        break;
                    case "is_latest":
                        cred.is_latest = dr.GetSByte(i);
                        break;
                    case "program_type":
                        cred.credential_type = dr.GetString(i);
                        break;
                    case "credential_name":
                        cred.credential_name = dr.GetString(i);
                        break;
                    case "org_name":
                        cred.org_name = dr.GetString(i);
                        break;
                    case "active_flag":
                        cred.active_flag = dr.GetInt32(i);
                        break;
                    case "transferability_id":
                        cred.transferability_id = dr.GetInt32(i);
                        break;
                    case "program_mode":
                        cred.program_mode = dr.GetString(i);
                        break;
                    case "top_code":
                        cred.top_code = dr.GetString(i);
                        break;
                    case "description":
                        cred.description = dr.GetString(i);
                        break;
                }
            }

            return cred;
        }
    }
}
