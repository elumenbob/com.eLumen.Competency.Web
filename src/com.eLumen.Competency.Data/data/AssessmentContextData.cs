using com.eLumen.Competency.Domain;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace com.eLumen.Competency.Data
{
    public class AssessmentContextData
    {
        private string _connectionString;

        public AssessmentContextData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Assessment> GetAssessments()
        {
            List<Assessment> credentials = new List<Assessment>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT ass.asmt_id AS AssessmentID, ass.lst_mod_dt as ModifiedDate, ass.new_activity_ds as ActivityDescription, nat.name as ActivityType, ass.new_activity_name, ass.name as AssessmentName, ass.passing_score, b.name AS CriteriaName, b.weight, b.display_seq, c.name AS RubricName, d.name AS RubricCriteriaLevelName, e.value as ScoreValue, e.asmt_mastery_level_id, e.points, aml.name as MasteryLevel
FROM  asmt_scored a INNER JOIN
         asmt ass ON a.asmt_id = ass.asmt_id LEFT OUTER JOIN
         asmt_criteria b ON a.asmt_scored_id = b.asmt_scored_id LEFT OUTER JOIN
         asmt_rubric_type c ON a.asmt_rubric_type_id = c.asmt_rubric_type_id LEFT OUTER JOIN
         asmt_perf_description d ON b.asmt_criteria_id = d.asmt_criteria_id LEFT OUTER JOIN
         asmt_score_level e ON d.asmt_score_level_id = e.asmt_score_level_id
         left outer join elumen.new_activity_type nat on ass.new_activity_type_id = nat.new_activity_type_id
         left join elumen.asmt_mastery_level aml on e.asmt_mastery_level_id = aml.asmt_mastery_level_id
WHERE (b.asmt_criteria_id IS NOT NULL)
order by a.asmt_id, display_seq, asmt_mastery_level_id";

            using (MySqlCommand cmd = new MySqlCommand(SQL, connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    Assessment assess = null;

                    while (dr.Read())
                    {
                        Assessment tempassess = Assessment.Create(dr);

                        if (assess == null)
                        {
                            assess = tempassess;
                        }
                        else if (tempassess.asmt_id == assess.asmt_id)
                        {
                            assess.Rubric.Criteria.Add(RubricCriteria.Create(dr));
                        }
                        else
                        {
                            credentials.Add(assess);
                            assess = tempassess;
                        }
                    }
                }
            }

            return credentials;
        }

        public Assessment GetAssessment(string sourceId)
        {
            Assessment assess = null;

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT ass.asmt_id AS AssessmentID, ass.lst_mod_dt as ModifiedDate, ass.new_activity_ds as ActivityDescription, nat.name as ActivityType, ass.new_activity_name, ass.name as AssessmentName, ass.passing_score, b.name AS CriteriaName, b.weight, b.display_seq, c.name AS RubricName, d.name AS RubricCriteriaLevelName, e.value as ScoreValue, e.asmt_mastery_level_id, e.points, aml.name as MasteryLevel
FROM  asmt_scored a INNER JOIN
         asmt ass ON a.asmt_id = ass.asmt_id LEFT OUTER JOIN
         asmt_criteria b ON a.asmt_scored_id = b.asmt_scored_id LEFT OUTER JOIN
         asmt_rubric_type c ON a.asmt_rubric_type_id = c.asmt_rubric_type_id LEFT OUTER JOIN
         asmt_perf_description d ON b.asmt_criteria_id = d.asmt_criteria_id LEFT OUTER JOIN
         asmt_score_level e ON d.asmt_score_level_id = e.asmt_score_level_id
         left outer join elumen.new_activity_type nat on ass.new_activity_type_id = nat.new_activity_type_id
         left join elumen.asmt_mastery_level aml on e.asmt_mastery_level_id = aml.asmt_mastery_level_id
WHERE a.asmt_id = {0}
order by a.asmt_id, display_seq, asmt_mastery_level_id";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, sourceId), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Assessment tempassess = Assessment.Create(dr);

                        if (assess == null)
                        {
                            assess = tempassess;
                        }
                        else if (tempassess.asmt_id == assess.asmt_id)
                        {
                            assess.Rubric.Criteria.Add(RubricCriteria.Create(dr));
                        }
                        else
                        {
                            //credentials.Add(assess);
                            //assess = tempassess;
                        }
                    }
                }
            }

            return assess;
        }

        public List<Assessment> GetAssessmentBySLO(string sloID)
        {
            List<Assessment> credentials = new List<Assessment>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT a.* FROM elumen.asmt a left join elumen.asmt_slo_rel b on a.asmt_id = b.asmt_id where b.slo_id in ({0})";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, sloID), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Assessment nextCred = Assessment.Create(dr);
                        credentials.Add(nextCred);
                    }
                }
            }

            return credentials;
        }
    }
}
