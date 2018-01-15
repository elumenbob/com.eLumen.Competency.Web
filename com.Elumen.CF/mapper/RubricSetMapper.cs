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
    public class RubricSetMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubricSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        public static RubricSetType Map(List<Assessment> inputs)
        {
            var contexts = new List<RubricType>();

            foreach (var input in inputs)
            {
                RubricType def = Map(input.Rubric);
                contexts.Add(def);
            }

            RubricSetType type = new Models.RubricSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RubricSetType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static RubricType Map(Rubric input)
        {
            RubricType def = new RubricType(Guid.NewGuid(), string.Format("Rubric.{0}", input.ID))
            {
                Title = input.RubricName
            };

            List<RubricCriterionType> criteriaList = new List<RubricCriterionType>();
            List<RubricCriterionLevelType> criteriaLevels = new List<RubricCriterionLevelType>();

            RubricCriterionType ctype = null;

            foreach (var criteria in input.Criteria)
            {
                if (ctype == null)
                {
                    ctype = new RubricCriterionType(Guid.NewGuid())
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

                    ctype = new RubricCriterionType(Guid.NewGuid())
                    {
                        Category = criteria.CriteriaName,
                        Description = "Category Description",
                        Position = criteria.Sequence,
                        Weight = (float)criteria.Weight,
                    };
                }
                else
                {
                    criteriaLevels.Add(new RubricCriterionLevelType(Guid.NewGuid())
                    {
                        Description = criteria.LevelName,
                        Position = criteria.MasteryLevelID,
                        Score = (float)criteria.Score,
                        Quality = criteria.MasteryLevel,
                        Feedback = criteria.Points.ToString(),
                        RubricCriterionId = ctype.RubricCriterionId
                    });
                }
            }

            def.Criteria = new Models.RubricCriteriaSetType(criteriaList);
            def.CriteriaLevels = new RubricCriterionLevelSetType(criteriaLevels);

            return def;
        }
    }
}
