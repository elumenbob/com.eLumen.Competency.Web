using com.eLumen.Competency.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.Competency.Data
{
    public class CompetencyContextData
    {
        private string _connectionString;

        public CompetencyContextData(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Credential GetCredential(string credentialId)
        {
            Credential nextCred = null;
            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = string.Format(@"SELECT credential_id, current_flag, is_latest, b.name as program_type, a.name as credential_name, a.ds as description, a.lst_mod_dt, active_flag, c.name as org_name, transferability_id, program_mode, _external_credential_id, top_code
FROM  credential a left join credential_type b on a.credential_type_id = b.credential_type_id 
left join org_entity c on a.org_entity_id = c.org_entity_id where credential_id = '{0}'", credentialId);

            using (MySqlCommand cmd = new MySqlCommand(SQL, connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        nextCred = Credential.Create(dr);
                        nextCred.sloes = (new OutcomeData(_connectionString)).GetCredentialOutcomes(credentialId);
                    }
                }
            }

            return nextCred;
        }

        public List<Credential> GetCredentials(int limit, int offset)
        {
            List<Credential> credentials = new List<Credential>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT credential_id, current_flag, is_latest, b.name as program_type, a.name as credential_name, a.ds as description, a.lst_mod_dt, active_flag, c.name as org_name, transferability_id, program_mode, _external_credential_id, top_code
FROM  credential a left join credential_type b on a.credential_type_id = b.credential_type_id 
left join org_entity c on a.org_entity_id = c.org_entity_id
LIMIT {0}, {1}";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, offset, limit), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Credential nextCred = Credential.Create(dr);
                        credentials.Add(nextCred);
                    }
                }
            }

            return credentials;
        }

        public List<Course> GetCourses(int limit, int offset)
        {
            List<Course> courses = new List<Course>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT new_course.new_course_id, new_course.current_flag, new_course.is_latest, new_course.name, new_course.short_title, new_course.ds, new_course.lst_mod_dt, org_entity.name AS org_name, new_course.status_id, new_course.inactive_flag, new_course.new_course_type_id, new_course.num_credits, new_course.code, new_course.course_subject, new_course.course_number, new_course.course_control_number, new_course.top_code, 
         new_course.top_name, new_course.cip_code, new_course.cip_name, new_course.sam_code_id, new_course.approved_date, new_course.course_uuid, new_course_type.name AS course_type
FROM  new_course INNER JOIN
         org_entity ON new_course.org_entity_id = org_entity.org_entity_id INNER JOIN
         new_course_type ON new_course.new_course_type_id = new_course_type.new_course_type_id
         LIMIT {0}, {1}";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, offset, limit), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Course nextCourse = Course.Create(dr);
                        courses.Add(nextCourse);
                    }
                }
            }

            return courses;
        }

        public List<Organization> GetOrganizations(int limit, int offset)
        {
            List<Organization> organizations = new List<Organization>();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT org_entity.org_entity_id, org_entity.name, org_entity.ds AS description, org_entity.lst_mod_dt, org_entity.inactive_flag, org_entity.parent_org_entity_id, org_entity.mission, org_type.ds AS org_type_name, org_entity.assigned_course_grp_id, COUNT(slo.slo_id) AS slo_count
FROM  org_entity INNER JOIN
         org_type ON org_entity.org_type_id = org_type.org_type_id LEFT OUTER JOIN
         slo ON org_entity.org_entity_id = slo.owner_org_entity_id
GROUP BY org_entity.org_entity_id
LIMIT {0}, {1}";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, offset, limit), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Organization nextOrg = Organization.Create(dr);
                        organizations.Add(nextOrg);
                    }
                }
            }

            return organizations;
        }

        public Course GetCourse(string courseID)
        {
            Course course = new Course();

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT new_course.new_course_id, new_course.current_flag, new_course.is_latest, new_course.name, new_course.short_title, new_course.ds, new_course.lst_mod_dt, org_entity.name AS org_name, new_course.status_id, new_course.inactive_flag, new_course.new_course_type_id, new_course.num_credits, new_course.code, new_course.course_subject, new_course.course_number, new_course.course_control_number, new_course.top_code, 
         new_course.top_name, new_course.cip_code, new_course.cip_name, new_course.sam_code_id, new_course.approved_date, new_course.course_uuid, new_course_type.name AS course_type
FROM  new_course INNER JOIN
         org_entity ON new_course.org_entity_id = org_entity.org_entity_id INNER JOIN
         new_course_type ON new_course.new_course_type_id = new_course_type.new_course_type_id
        where new_course_id = {0}";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, courseID), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        course = Course.Create(dr);
                        course.sloes = (new OutcomeData(_connectionString)).GetCourseOutcomes(courseID);
                    }
                }
            }

            return course;
        }

        public Organization GetOrganization(string orgID)
        {
            Organization org = null;

            MySql.Data.MySqlClient.MySqlConnection connection = (MySqlConnection)MySql.Data.MySqlClient.MySqlClientFactory.Instance.CreateConnection();
            connection.ConnectionString = _connectionString;
            connection.Open();

            string SQL = @"SELECT org_entity.org_entity_id, org_entity.name, org_entity.ds AS description, org_entity.lst_mod_dt, org_entity.inactive_flag, org_entity.parent_org_entity_id, org_entity.mission, org_type.ds AS org_type_name, org_entity.assigned_course_grp_id, COUNT(slo.slo_id) AS slo_count
FROM  org_entity INNER JOIN
         org_type ON org_entity.org_type_id = org_type.org_type_id LEFT OUTER JOIN
         slo ON org_entity.org_entity_id = slo.owner_org_entity_id
GROUP BY org_entity.org_entity_id
WHERE org_entity.org_entity_id = '{0}'";

            using (MySqlCommand cmd = new MySqlCommand(string.Format(SQL, orgID), connection))
            {
                using (MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        org = Organization.Create(dr);
                    }
                }
            }

            return org;
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