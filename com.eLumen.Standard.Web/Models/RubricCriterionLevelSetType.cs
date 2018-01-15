/*
 * Competency Service OpenAPI (JSON) Definition
 *
 * The Competency Service enables the exchange of data between a Competency Records Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Modelling approach: this being the Platform Specific Model (PSM) of the service.
 *
 * OpenAPI spec version: 1.0
 * Contact: lmattson@imsglobal.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace com.eLumen.Standard.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RubricCriterionLevelSetType :  IEquatable<RubricCriterionLevelSetType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubricCriterionLevelSetType" /> class.
        /// </summary>
        /// <param name="RubricCriterionLevel">RubricCriterionLevel (required).</param>
        public RubricCriterionLevelSetType(List<RubricCriterionLevelType> RubricCriterionLevel = null)
        {
            // to ensure "RubricCriterionLevel" is required (not null)
            if (RubricCriterionLevel == null)
            {
                throw new InvalidDataException("RubricCriterionLevel is a required property for RubricCriterionLevelSetType and cannot be null");
            }
            else
            {
                this.RubricCriterionLevel = RubricCriterionLevel;
            }
            
        }

        /// <summary>
        /// Gets or Sets RubricCriterionLevel
        /// </summary>
        public List<RubricCriterionLevelType> RubricCriterionLevel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RubricCriterionLevelSetType {\n");
            sb.Append("  RubricCriterionLevel: ").Append(RubricCriterionLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RubricCriterionLevelSetType)obj);
        }

        /// <summary>
        /// Returns true if RubricCriterionLevelSetType instances are equal
        /// </summary>
        /// <param name="other">Instance of RubricCriterionLevelSetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RubricCriterionLevelSetType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.RubricCriterionLevel == other.RubricCriterionLevel ||
                    this.RubricCriterionLevel != null &&
                    this.RubricCriterionLevel.SequenceEqual(other.RubricCriterionLevel)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                    if (this.RubricCriterionLevel != null)
                    hash = hash * 59 + this.RubricCriterionLevel.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RubricCriterionLevelSetType left, RubricCriterionLevelSetType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RubricCriterionLevelSetType left, RubricCriterionLevelSetType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
