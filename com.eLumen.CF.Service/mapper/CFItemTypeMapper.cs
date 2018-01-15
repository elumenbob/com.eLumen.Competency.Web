using com.eLumen.Competency.Domain;
using com.eLumen.CF.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.eLumen.CF.Service.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CFItemTypeMapper
    {
        private static CFItemType MapBase(SLO input)
        {
            return new CFItemType(new GUIDType(string.Format("SLO.{0}", input.slo_id)),
                string.Format("SLO.{0}.{1}", input.org_name, input.slo_id),
                string.Format("SLO.{0}.{1}", input.org_name, input.slo_id),
                input.lst_mod_dt,
                string.Format("SLO.{0}.{1}", input.org_name, input.slo_id),
                string.Format("SLO.{0}.{1}", input.org_name, input.slo_id))
            {
                CompetencyEffectiveDate = input.lst_mod_dt,
                CompetencyLabel = "Outcome",
                AbbreviatedStatement = input.name,
                CFItemTypeType = "OUTCOME",
                CFItemTypeURI = null,
                //CompetencyEffectiveDate = CompetencyEffectiveDate,
                //CompetencyTerminationDate = CompetencyTerminationDate,
                //FullStatement = FullStatement,
                //CompetencyLabel = CompetencyLabel,
                //CFItemType = CFItemType,
                //CompetencyAssociationSet = CompetencyAssociationSet,
                //CompetencyReferenceHierarchy = CompetencyReferenceHierarchy,
                //HumanCodingScheme = HumanCodingScheme,
                //ListEnumeration = ListEnumeration,
                //AbbreviatedStatement = AbbreviatedStatement,
                //ConceptKeywords = ConceptKeywords,
                //ConceptKeywordsURI = ConceptKeywordsURI,
                //Notes = Notes,
                //Language = Language,
                //EducationLevel = EducationLevel,
                //CFItemTypeURI = CFItemTypeURI,
                //License = License,
                //LicenseURI = LicenseURI
            };
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFItemType" /> class.
        /// </summary>
        /// <param name="input">Courses serving as competency contexts</param>
        /// <returns></returns>
        public static CFItemType Map(SLO input)
        {
            var contexts = new List<CFItemType>();

            CFItemType def = MapBase(input);
            return def;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CFItemTypeType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        //public static CFItemTypeType Map(List<SLO> inputs)
        //{
        //    var contexts = new List<CFItemType>();

        //    foreach (var input in inputs)
        //    {
        //        CFItemType def = MapBase(input);

        //        contexts.Add(def);
        //    }

        //    CFItemTypeType type = new Models.CFItemTypeType(contexts);
        //    return type;
        //}
    }
}
