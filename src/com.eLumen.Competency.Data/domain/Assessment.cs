using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace com.eLumen.Competency.Domain
{
    public class Assessment
    {
        public Assessment()
        {
            this.sloes = new HashSet<SLO>();
            this.Rubric = new Rubric();
        }

        public virtual ICollection<SLO> sloes { get; set; }
        public Rubric Rubric { get; set; }
        public int asmt_id { get; private set; }
        public string ActivityDescription { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public string ActivityType { get; private set; }
        public string ActivityName { get; private set; }
        public string AssessmentName { get; private set; }
        public decimal passing_score { get; private set; }

        internal static Assessment Create(MySqlDataReader dr)
        {
            Assessment assess = new Assessment();

            for (int i = 0; i < dr.VisibleFieldCount; i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;

                var field = dr.GetName(i);

                switch (field)
                {
                    case "AssessmentID":
                        assess.asmt_id = dr.GetInt32(i);
                        break;
                    case "ActivityDescription":
                        assess.ActivityDescription = dr.GetString(i);
                        break;
                    case "ModifiedDate":
                        assess.ModifiedDate = dr.GetDateTime(i);
                        break;
                    case "ActivityType":
                        assess.ActivityType = dr.GetString(i);
                        break;
                    case "new_activity_name":
                        assess.ActivityName = dr.GetString(i);
                        break;
                    case "AssessmentName":
                        assess.AssessmentName = dr.GetString(i);
                        break;
                    case "passing_score":
                        assess.passing_score = dr.GetDecimal(i);
                        break;
                    case "RubricName":
                        assess.Rubric.RubricName= dr.GetString(i);
                        break;
                }
            }

            assess.Rubric.Criteria.Add(RubricCriteria.Create(dr));
            return assess;
        }
    }
}
