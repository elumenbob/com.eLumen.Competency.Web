using com.eLumen.Competency.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.Competency.Data
{
    public class CompetencyDefinitionData
    {
        private string _connectionString;

        public CompetencyDefinitionData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SLO> GetLearningOutcomes(int offset, int limit)
        {
            List<SLO> credentials = new List<SLO>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT slo.slo_id, asmt.asmt_id, slo.current_flag, slo.is_latest, slo.name, slo.performance, slo.lst_mod_dt, org_entity.name AS org_name, slo.slo_outcome_level_id, slo.slo_category_id, slo.new_course_id, slo.seq, slo.status_id, slo_category.name AS slo_category
FROM  slo LEFT OUTER JOIN
         org_entity ON slo.owner_org_entity_id = org_entity.org_entity_id LEFT OUTER JOIN
         slo_category ON slo.slo_category_id = slo_category.slo_category_id AND org_entity.org_entity_id = slo_category.owner_org_entity_id LEFT OUTER JOIN
         asmt_slo_rel ON slo.slo_id = asmt_slo_rel.slo_id LEFT OUTER JOIN
         asmt ON asmt_slo_rel.asmt_id = asmt.asmt_id
LIMIT {0}, {1}";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, offset, limit), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        SLO nextCred = SLO.CreateFromCredential(dr);
                        credentials.Add(nextCred);
                    }
                }
            }

            return credentials;
        }

        public SLO GetLearningOutcome(string sourcedId)
        {
            SLO nextOutcome = null;
            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT slo.slo_id, asmt.asmt_id, slo.current_flag, slo.is_latest, slo.name, slo.performance, slo.lst_mod_dt, org_entity.name AS org_name, slo.slo_outcome_level_id, slo.slo_category_id, slo.new_course_id, slo.seq, slo.status_id, slo_category.name AS slo_category
FROM  slo LEFT OUTER JOIN
         org_entity ON slo.owner_org_entity_id = org_entity.org_entity_id LEFT OUTER JOIN
         slo_category ON slo.slo_category_id = slo_category.slo_category_id AND org_entity.org_entity_id = slo_category.owner_org_entity_id LEFT OUTER JOIN
         asmt_slo_rel ON slo.slo_id = asmt_slo_rel.slo_id LEFT OUTER JOIN
         asmt ON asmt_slo_rel.asmt_id = asmt.asmt_id
WHERE slo.slo_id = '{0}'";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, sourcedId), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nextOutcome = SLO.CreateFromCredential(dr);
                    }
                }
            }

            return nextOutcome;
        }
    }
}
