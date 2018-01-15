using com.eLumen.Competency.Domain;
using com.eLumen.CF.Service.Models;
using System.Collections.Generic;

namespace com.eLumen.CF.Service.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class CFRubricMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRubricType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static CFRubricType Map(Rubric input)
        {
            CFRubricType def = new CFRubricType(new GUIDType(), string.Format("Rubric.{0}", input.ID))
            {
                Title = input.RubricName
            };

            List<CFRubricCriterionType> criteriaList = new List<CFRubricCriterionType>();
            List<CFRubricCriterionLevelType> criteriaLevels = new List<CFRubricCriterionLevelType>();

            CFRubricCriterionType ctype = null;

            foreach (var criteria in input.Criteria)
            {
                if (ctype == null)
                {
                    ctype = new CFRubricCriterionType(new GUIDType())
                    {
                        Category = criteria.CriteriaName,
                        Description = "Category Description",
                        Position = criteria.Sequence,
                        Weight = (float)criteria.Weight,
                    };
                }
                else if (ctype.Category != criteria.CriteriaName)
                {
                    criteriaList.Add(ctype);

                    ctype = new CFRubricCriterionType(new GUIDType())
                    {
                        Category = criteria.CriteriaName,
                        Description = "Category Description",
                        Position = criteria.Sequence,
                        Weight = (float)criteria.Weight,
                    };
                }
                else
                {
                    criteriaLevels.Add(new CFRubricCriterionLevelType(new GUIDType())
                    {
                        Description = criteria.LevelName,
                        Position = criteria.MasteryLevelID,
                        Score = (float)criteria.Score,
                        Quality = criteria.MasteryLevel,
                        Feedback = criteria.Points.ToString(),
                        RubricCriterionId = ctype.Identifier
                    });
                }
            }

            def.Criteria = new CFRubricCriterionSetType(criteriaList);
            def.CriteriaLevels = new CFRubricCriterionLevelSetType(criteriaLevels);

            return def;
        }
    }
}
