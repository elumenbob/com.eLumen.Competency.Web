using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace com.eLumen.Competency.Domain
{
    public class Course
    {
        public Course()
        {
            this.sloes = new HashSet<SLO>();
        }

        public int new_course_id { get; set; }
        public Nullable<sbyte> current_flag { get; set; }
        public sbyte is_latest { get; set; }
        public string name { get; set; }
        public string short_title { get; set; }
        public string ds { get; set; }
        public System.DateTime lst_mod_dt { get; set; }
        public string org_name { get; set; }
        public int status_id { get; set; }
        public string inactive_flag { get; set; }
        public string course_type { get; set; }
        public string num_credits { get; set; }
        public string course_outline_free_text { get; set; }
        public string methods_of_instruction { get; set; }
        public string object_type { get; set; }
        public string code { get; set; }
        public string course_subject { get; set; }
        public string course_number { get; set; }
        public string course_control_number { get; set; }
        public string top_code { get; set; }
        public string top_name { get; set; }
        public string cip_code { get; set; }
        public string cip_name { get; set; }
        public Nullable<int> sam_code_id { get; set; }
        public Nullable<System.DateTime> approved_date { get; set; }
        public string course_uuid { get; set; }
        public virtual ICollection<SLO> sloes { get; set; }
        internal static Course Create(MySqlDataReader dr)
        {
            Course cred = new Course();

            for (int i = 0; i < dr.VisibleFieldCount; i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;
                var field = dr.GetName(i);

                switch (field)
                {
                    case "new_course_id":
                        cred.new_course_id = dr.GetInt32(i);
                        break;
                    case "current_flag":
                        cred.current_flag = dr.GetSByte(i);
                        break;
                    case "is_latest":
                        cred.is_latest = dr.GetSByte(i);
                        break;
                    case "short_title":
                        cred.short_title = dr.GetString(i);
                        break;
                    case "name":
                        cred.name = dr.GetString(i);
                        break;
                    case "ds":
                        cred.ds = dr.GetString(i);
                        break;
                    case "org_name":
                        cred.org_name = dr.GetString(i);
                        break;
                    case "lst_mod_dt":
                        cred.lst_mod_dt = dr.GetDateTime(i);
                        break;
                    case "status_id":
                        cred.status_id = dr.GetInt32(i);
                        break;
                    case "inactive_flag":
                        cred.inactive_flag = dr.GetString(i);
                        break;
                    case "top_code":
                        cred.top_code = dr.GetString(i);
                        break;
                    case "course_type":
                        cred.course_type = dr.GetString(i);
                        break;
                    case "num_credits":
                        cred.num_credits = dr.GetString(i);
                        break;
                    case "code":
                        cred.code = dr.GetString(i);
                        break;
                    case "course_subject":
                        cred.course_subject = dr.GetString(i);
                        break;
                    case "course_number":
                        cred.course_number = dr.GetString(i);
                        break;
                    case "course_control_number":
                        cred.course_control_number = dr.GetString(i);
                        break;
                    case "top_name":
                        cred.top_name = dr.GetString(i);
                        break;
                    case "cip_code":
                        cred.cip_code = dr.GetString(i);
                        break;
                    case "cip_name":
                        cred.cip_name = dr.GetString(i);
                        break;
                    case "sam_code_id":
                        cred.sam_code_id = dr.GetInt32(i);
                        break;
                    case "approved_date":
                        cred.approved_date = dr.GetDateTime(i);
                        break;
                    case "course_uuid":
                        cred.course_uuid = dr.GetString(i);
                        break;
                }
            }

            return cred;
        }
    }
}
