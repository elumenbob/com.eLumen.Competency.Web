using com.eLumen.Competency.Domain;
using com.eLumen.Competency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.Competency.Web.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CompetencyDefinitionSetMapper
    {
        private static CompetencyDefinitionType MapBase(SLO input)
        {
            return new CompetencyDefinitionType(Guid.NewGuid(), string.Format("SLO.{0}", input.slo_id), string.Format("SLO.{0}.{1}", input.org_name, input.slo_id))
            {
                CompetencyEffectiveDate = input.lst_mod_dt,
                CompetencyLabel = input.name,
                CompetencyStatement = input.name,
                CompetencyType = "OUTCOME",
                CompetencyTerminationDate = null,
                CompetencyReferenceHierarchy = new List<Guid>()
                //, CompetencyRelationshipSet = new CompetencyRelationshipSetType()
            };
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="input">Courses serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyDefinitionType Map(SLO input)
        {
            var contexts = new List<CompetencyDefinitionType>();

            CompetencyDefinitionType def = MapBase(input);
            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetencyContextSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        public static CompetencyDefinitionSetType Map(List<SLO> inputs)
        {
            var contexts = new List<CompetencyDefinitionType>();

            foreach (var input in inputs)
            {
                CompetencyDefinitionType def = MapBase(input);

                contexts.Add(def);
            }

            CompetencyDefinitionSetType type = new Models.CompetencyDefinitionSetType(contexts);
            return type;
        }
    }
}
