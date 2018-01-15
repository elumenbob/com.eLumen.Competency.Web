using com.eLumen.Competency.Domain;
using com.eLumen.CF.Service.Models;
using System;
using System.Collections.Generic;

namespace com.eLumen.CF.Service.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CFDocumentSetMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="input">Course serving as competency context</param>
        /// <returns></returns>
        public static CFDocumentType Map(Course input)
        {
            CFDocumentType def = new CFDocumentType(new GUIDType(string.Format("COURSE.{0}", input.new_course_id)),
    string.Format("/courses/{0}", input.new_course_id),
    input.org_name,
    input.name == null ? input.code : input.name,
    input.lst_mod_dt,
    "/courses")
            {
                AdoptionStatus = input.current_flag.Value == 1 ? "Active" : "Inactive",
                Description = input.ds,
                Language = "EN",
                Notes = "[none]",
                Publisher = "Ogdenville College",
                StatusStartDate = input.lst_mod_dt,
                Subject = new List<string>() { input.top_code },
                Version = input.is_latest.ToString()
            };

            //if (input.sloes != null)
            //{
            //    def.CompetencyList = new List<CompetencyDefinitionType>();

            //    foreach (SLO s in input.sloes)
            //    {
            //        def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
            //    }
            //}

            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        public static CFDocumentSetType Map(List<Course> inputs)
        {
            var contexts = new List<CFDocumentType>();

            foreach (var input in inputs)
            {
                CFDocumentType def = Map(input);
                contexts.Add(def);
            }

            CFDocumentSetType type = new Models.CFDocumentSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CFDocumentType Map(Credential input)
        {
            CFDocumentType def = new CFDocumentType(new GUIDType(string.Format("PROGRAM.{0}", input.credential_id)),
                string.Format("/credential/{1}", input.credential_id),
                input.org_name,
                input.credential_name,
                input.lst_mod_dt,
                "/programs")
            {
                AdoptionStatus = input.current_flag.Value ? "Active" : "Inactive",
                Description = input.description,
                Language = "EN",
                Notes = "[none]",
                Publisher = "Ogdenville College",
                StatusStartDate = input.lst_mod_dt,
                Version = input.is_latest.ToString()
            };

            //if (input.sloes != null)
            //{
            //    def.CompetencyList = new List<CompetencyDefinitionType>();

            //    foreach (SLO s in input.sloes)
            //    {
            //        def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
            //    }
            //}

            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CFDocumentSetType Map(List<Credential> inputs)
        {
            var contexts = new List<CFDocumentType>();

            foreach (var input in inputs)
            {
                CFDocumentType def = Map(input);
                contexts.Add(def);
            }

            CFDocumentSetType type = new Models.CFDocumentSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CFDocumentType Map(Organization input)
        {
            CFDocumentType def = new CFDocumentType(new GUIDType(string.Format("ORGANIZATION.{0}", input.org_entity_id)),
                string.Format("/organization/{1}", input.org_entity_id),
                input.name,
                input.name,
                input.lst_mod_dt,
                "/organizations")
            {
                AdoptionStatus = input.inactive_flag.Value == 0 ? "Active" : "Inactive",
                Description = input.description,
                Language = "EN",
                Notes = "[none]",
                Publisher = "Ogdenville College",
                StatusStartDate = input.lst_mod_dt,
                Version = "1.0"
            };

            //if (input.sloes != null)
            //{
            //    def.CompetencyList = new List<CompetencyDefinitionType>();

            //    foreach (SLO s in input.sloes)
            //    {
            //        def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
            //    }
            //}

            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of organizations serving as competency contexts</param>
        /// <returns></returns>
        public static CFDocumentSetType Map(List<Organization> inputs)
        {
            var contexts = new List<CFDocumentType>();

            foreach (var input in inputs)
            {
                var def = Map(input);
                contexts.Add(def);
            }

            CFDocumentSetType type = new Models.CFDocumentSetType(contexts);
            return type;
        }
    }
}
