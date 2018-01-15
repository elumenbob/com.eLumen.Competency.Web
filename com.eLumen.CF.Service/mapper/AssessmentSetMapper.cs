/*
using System;
using System.Collections.Generic;

namespace com.eLumen.CF.Service.Mapper
{
    /// <summary>h
    /// 
    /// </summary>
    public class AssessmentSetMapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentSetType" /> class.
        /// </summary>
        /// <param name="inputs">List of courses serving as competency contexts</param>
        /// <returns></returns>
        public static AssessmentSetType Map(List<Assessment> inputs)
        {
            var contexts = new List<AssessmentType>();

            foreach (var input in inputs)
            {
                AssessmentType def = Map(input);
                contexts.Add(def);
            }

            AssessmentSetType type = new Models.AssessmentSetType(contexts);
            return type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentSetType" /> class.
        /// </summary>
        /// <param name="input">List of programs serving as competency contexts</param>
        /// <returns></returns>
        public static AssessmentType Map(Assessment input)
        {
            AssessmentType def = new AssessmentType(Guid.NewGuid(), string.Format("ASSESSMENT.{0}", input.asmt_id))
            {
                Description = input.ActivityDescription,
                Title = input.AssessmentName,
                ActivityType = input.ActivityType,
                ActivityName = input.ActivityName,
                Date = input.ModifiedDate,
                PassingScore = input.passing_score,
            };

            var rubric = RubricSetMapper.Map(input.Rubric);
            def.Criteria = rubric.Criteria;
            def.CriteriaLevels = rubric.CriteriaLevels;
            return def;
        }
    }
}
*/