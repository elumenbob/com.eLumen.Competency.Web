using com.eLumen.Competency.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.Competency.Data
{
    public class OutcomeData
    {
        private string _connectionString;

        public OutcomeData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SLO> GetCredentialOutcomes(string credential_id)
        {
            List<SLO> outcomes = new List<SLO>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT credential.credential_id, slo_class.name AS ClassName, slo.slo_id, slo.name AS slo_name, slo.slo_outcome_level_id, slo.seq AS slo_sequence, slo.current_flag, org_entity.name AS org_name, org_entity.ds AS org_description, slo.lst_mod_dt, slo_category.name AS category_name, slo_category.description AS category_desc
FROM  credential INNER JOIN
         slo_class ON credential.credential_id = slo_class.owner_credential INNER JOIN
         slo_class_slo_rel ON slo_class.slo_class_id = slo_class_slo_rel.slo_class_id INNER JOIN
         slo ON slo_class_slo_rel.slo_id = slo.slo_id LEFT OUTER JOIN
         org_entity ON slo.owner_org_entity_id = org_entity.org_entity_id LEFT OUTER JOIN
         slo_category ON slo.slo_category_id = slo_category.slo_category_id AND org_entity.org_entity_id = slo_category.owner_org_entity_id
WHERE (credential.credential_id = {0}) AND (credential.current_flag = 1)";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, credential_id), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        SLO nextCred = SLO.CreateFromCredential(dr);
                        outcomes.Add(nextCred);
                    }
                }
            }

            return outcomes;
        }

        public List<SLO> GetCourseOutcomes(string courseId)
        {
            List<SLO> outcomes = new List<SLO>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT slo.slo_id, slo.name AS slo_name, slo.slo_outcome_level_id, slo.seq AS slo_sequence, slo.current_flag, org_entity.name AS org_name, org_entity.ds AS org_description, slo.lst_mod_dt, slo_category.name AS category_name, slo_category.description AS category_desc, slo.new_course_id, slo.slo_category_id
FROM  slo LEFT OUTER JOIN
         org_entity ON slo.owner_org_entity_id = org_entity.org_entity_id LEFT OUTER JOIN
         slo_category ON slo.slo_category_id = slo_category.slo_category_id
WHERE (new_course_id = {0})";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, courseId), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        SLO nextCred = SLO.CreateFromCredential(dr);
                        outcomes.Add(nextCred);
                    }
                }
            }

            return outcomes;
        }


        public List<Organization> GetOrganizations()
        {
            List<Organization> credentials = new List<Organization>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT org_entity.org_entity_id, org_entity.name, org_entity.ds AS description, org_entity.lst_mod_dt, org_entity.inactive_flag, org_entity.parent_org_entity_id, org_entity.mission, org_type.ds AS org_type_name, org_entity.assigned_course_grp_id, COUNT(slo.slo_id) AS slo_count
FROM  org_entity INNER JOIN
         org_type ON org_entity.org_type_id = org_type.org_type_id LEFT OUTER JOIN
         slo ON org_entity.org_entity_id = slo.owner_org_entity_id
GROUP BY org_entity.org_entity_id";

            using (MySqlCommand cmd = new MySqlCommand(SQL, connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Organization nextCred = Organization.Create(dr);
                        credentials.Add(nextCred);
                    }
                }
            }

            return credentials;
        }
    }
}

/*
 * SELECT org_entity.org_entity_id, org_entity.org_type_id, org_entity.name, org_entity.ds, org_entity.lst_mod_user_id, org_entity.lst_mod_dt, org_entity.client_id, org_entity.inactive_flag, org_entity.parent_org_entity_id, org_entity.locked_flag, org_entity.subst_org_entity_id, org_entity.allow_child_type, org_entity.assigned_course_grp_id, org_entity.assigned_parent_org_id, org_entity.has_coordinator, org_entity.coordinator_manage_courses, 
         org_entity.coordinator_manage_evaluators, org_entity.coordinator_manage_collective, org_entity.mission, org_entity.use_category, org_entity.non_academic_type_id, org_entity.default_object_type, slo.slo_id, slo.slo_atid, slo.previous_slo_id, slo.current_flag, slo.is_latest, slo.name AS Expr4, slo.performance, slo.starting_term_id, slo.lst_mod_user_id AS Expr5, slo.lst_mod_dt AS Expr6, slo.client_id AS Expr7, slo.owner_org_entity_id, slo.slo_type_id, 
         slo.slo_outcome_level_id, slo.slo_category_id, slo.new_course_id, slo.seq AS Expr8, slo.status_id, slo._src_aa_id, slo._src_ag_id, slo._src_bmg_id, slo._src_bm_id, slo._src_bmc_id, slo._src_ca_id, slo._src_cip_id, org_type.ds AS Expr9
FROM  org_entity INNER JOIN
         org_type ON org_entity.org_type_id = org_type.org_type_id INNER JOIN
         slo ON org_entity.org_entity_id = slo.owner_org_entity_id
*/