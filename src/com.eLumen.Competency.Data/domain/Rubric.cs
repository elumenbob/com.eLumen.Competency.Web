using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace com.eLumen.Competency.Domain
{
    public class Rubric
    {
        public Rubric()
        {
            Criteria = new List<RubricCriteria>();
        }

        public Rubric ID { get; set; }
        public string RubricName { get; set; }
        public List<RubricCriteria> Criteria { get; set; }
    }

    public class RubricCriteria
    {
        public string CriteriaName { get; private set; }
        public string LevelName { get; internal set; }
        public string MasteryLevel { get; internal set; }
        public int MasteryLevelID { get; internal set; }
        public decimal Points { get; internal set; }
        public int Score { get; internal set; }
        public int Sequence { get; private set; }
        public decimal Weight { get; private set; }

        public static RubricCriteria Create(MySqlDataReader dr)
        {
            RubricCriteria criteria = new RubricCriteria();

            for (int i = 0; i < dr.VisibleFieldCount; i++)
            {
                if (dr.GetValue(i) == DBNull.Value) continue;

                var field = dr.GetName(i);

                switch (field)
                {
                    case "RubricCriteriaLevelName":
                        criteria.LevelName = dr.GetString(i);
                        break;
                    case "ScoreValue":
                        criteria.Score = dr.GetInt32(i);
                        break;
                    case "asmt_mastery_level_id":
                        criteria.MasteryLevelID = dr.GetInt32(i);
                        break;
                    case "points":
                        criteria.Points = dr.GetDecimal(i);
                        break;
                    case "weight":
                        criteria.Weight = dr.GetDecimal(i);
                        break;
                    case "MasteryLevel":
                        criteria.MasteryLevel = dr.GetString(i);
                        break;
                    case "CriteriaName":
                        criteria.CriteriaName = dr.GetString(i);
                        break;
                    case "display_seq":
                        criteria.Sequence = dr.GetInt32(i);
                        break;
                }
            }
            return criteria;
        }
    }
}