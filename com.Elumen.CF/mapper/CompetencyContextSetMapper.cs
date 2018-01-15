using com.eLumen.Competency.Domain;
using com.eLumen.CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.CF.Web.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CompetencyContextSetMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyContextType Map(Course input)
        {
            CompetencyContextType def = new CompetencyContextType(Guid.NewGuid(), input.org_name)
            {
                ContextId = string.Format("COURSE.{0}", input.new_course_id),
                ContextEffectiveDate = input.lst_mod_dt,
                ContextLabel = input.ds,
                ContextTitle = input.code,
                ContextType = "COURSE"
            };

            if (input.sloes != null)
            {
                def.CompetencyList = new List<CompetencyDefinitionType>();

                foreach (SLO s in input.sloes)
                {
                    def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
                }
            }

            return def;
        }

        public static CompetencyContextSetType Map(List<Course> inputs)
        {
            var contexts = new List<CompetencyContextType>();

            foreach (var input in inputs)
            {
                CompetencyContextType def = Map(input);
                contexts.Add(def);
            }

            CompetencyContextSetType type = new Models.CompetencyContextSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyContextType Map(Credential input)
        {
            CompetencyContextType def = new CompetencyContextType(Guid.NewGuid(), input.org_name)
            {
                ContextId = string.Format("CREDENTIAL.{0}", input.credential_id),
                ContextEffectiveDate = input.lst_mod_dt,
                ContextLabel = input.org_name,
                ContextTitle = input.credential_name,
                ContextType = "CREDENTIAL"
            };

            if (input.sloes != null)
            {
                def.CompetencyList = new List<CompetencyDefinitionType>();

                foreach (SLO s in input.sloes)
                {
                    def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
                }
            }

            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyContextSetType Map(List<Credential> inputs)
        {
            var contexts = new List<CompetencyContextType>();

            foreach (var input in inputs)
            {
                CompetencyContextType def = Map(input);
                contexts.Add(def);
            }

            CompetencyContextSetType type = new Models.CompetencyContextSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyContextType Map(Organization input)
        {
            CompetencyContextType def = new CompetencyContextType(Guid.NewGuid(), input.name)
            {
                ContextId = string.Format("ORGANIZATION.{0}", input.org_entity_id),
                ContextEffectiveDate = input.lst_mod_dt,
                ContextLabel = input.org_type_name,
                ContextTitle = string.IsNullOrEmpty(input.mission) ? input.description : input.description,
                ContextType = "ORGANIZATION"
            };

            if (input.sloes != null)
            {
                def.CompetencyList = new List<CompetencyDefinitionType>();

                foreach (SLO s in input.sloes)
                {
                    def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
                }
            }

            return def;
        }
        public static CompetencyContextSetType Map(List<Organization> inputs)
        {
            var contexts = new List<CompetencyContextType>();

            foreach (var input in inputs)
            {
                var def = Map(input);
                contexts.Add(def);
            }

            CompetencyContextSetType type = new Models.CompetencyContextSetType(contexts);
            return type;
        }
    }
}
