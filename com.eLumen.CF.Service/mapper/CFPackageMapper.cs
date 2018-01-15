using com.eLumen.Competency.Domain;
using com.eLumen.CF.Service.Models;
using System;
using System.Collections.Generic;

namespace com.eLumen.CF.Service.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CFPackageMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="CFDocument">Course serving as competency context</param>
        /// <param name="CFItems">Course serving as competency context</param>
        /// <param name="CFAssociations">Course serving as competency context</param>
        /// <param name="CFDefinitions">Course serving as competency context</param>
        /// <param name="CFRubricParts">Course serving as competency context</param>
        /// <returns></returns>
        public static CFPackageType Map(CFDocumentType CFDocument, List<CFItemType> CFItems, List<CFAssociationType> CFAssociations = null, CFDefinitionType CFDefinitions = null, CFRubricPartType CFRubricParts = null)
        {
            //CFPackageType def = new CFPackageType(new GUIDType(string.Format("COURSE.{0}", input.new_course_id)), input.code)
            //{
            //    AdoptionStatus = "Active",
            //    CFPackageURI = "ogdenville.courses",
            //    Creator = input.org_name,
            //    Description = input.ds,
            //    Language = "EN",
            //    LastChangeDateTime = input.approved_date,
            //    Notes = input.course_outline_free_text,
            //    Publisher = "Ogdenville College",
            //    StatusStartDate = input.lst_mod_dt,
            //    Title = input.short_title,
            //    Version = input.course_control_number
            //};

            //def.CFDocument.CFRubricParts..CFItems

            //if (input.sloes != null)
            //{
            //    def.CompetencyList = new List<CompetencyDefinitionType>();

            //    foreach (SLO s in input.sloes)
            //    {
            //        def.CompetencyList.Add(CompetencyDefinitionSetMapper.Map(s));
            //    }
            //}

            return new CFPackageType(CFDocument, CFItems);
        }      
    }
}
