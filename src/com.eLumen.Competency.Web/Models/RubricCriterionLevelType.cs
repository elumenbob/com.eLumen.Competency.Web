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

namespace com.eLumen.Competency.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RubricCriterionLevelType :  IEquatable<RubricCriterionLevelType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubricCriterionLevelType" /> class.
        /// </summary>
        /// <param name="RubricCriterionLevel">RubricCriterionLevel (required).</param>
        /// <param name="Description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Quality">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="Score">Model Primitive Datatype &#x3D; Float.</param>
        /// <param name="Feedback">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Position">Model Primitive Datatype &#x3D; Integer.</param>
        public RubricCriterionLevelType(Guid RubricCriterionLevel, string Description = null, string Quality = null, float? Score = null, string Feedback = null, int? Position = null)
        {
            // to ensure "RubricCriterionLevel" is required (not null)
            if (RubricCriterionLevel == null)
            {
                throw new InvalidDataException("RubricCriterionLevel is a required property for RubricCriterionLevelType and cannot be null");
            }
            else
            {
                this.RubricCriterionLevel = RubricCriterionLevel;
            }
            this.Description = Description;
            this.Quality = Quality;
            this.Score = Score;
            this.Feedback = Feedback;
            this.Position = Position;
            this.RubricCriterionId = RubricCriterionId;
            
        }

        /// <summary>
        /// Gets or Sets RubricCriterionLevel
        /// </summary>
        public Guid RubricCriterionLevel { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        public string Quality { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        /// <value>Model Primitive Datatype = Float</value>
        public float? Score { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        public string Feedback { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        /// <value>Model Primitive Datatype = Integer</value>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets RubricCriterionId
        /// </summary>
        public Guid RubricCriterionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RubricCriterionLevelType {\n");
            sb.Append("  RubricCriterionLevel: ").Append(RubricCriterionLevel).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  Quality: ").Append(Quality).Append("\n");
sb.Append("  Score: ").Append(Score).Append("\n");
sb.Append("  Feedback: ").Append(Feedback).Append("\n");
sb.Append("  Position: ").Append(Position).Append("\n");
sb.Append("  RubricCriterionId: ").Append(RubricCriterionId).Append("\n");
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
            return Equals((RubricCriterionLevelType)obj);
        }

        /// <summary>
        /// Returns true if RubricCriterionLevelType instances are equal
        /// </summary>
        /// <param name="other">Instance of RubricCriterionLevelType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RubricCriterionLevelType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.RubricCriterionLevel == other.RubricCriterionLevel ||
                    this.RubricCriterionLevel != null &&
                    this.RubricCriterionLevel.Equals(other.RubricCriterionLevel)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Quality == other.Quality ||
                    this.Quality != null &&
                    this.Quality.Equals(other.Quality)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.Feedback == other.Feedback ||
                    this.Feedback != null &&
                    this.Feedback.Equals(other.Feedback)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.RubricCriterionId == other.RubricCriterionId ||
                    this.RubricCriterionId != null &&
                    this.RubricCriterionId.Equals(other.RubricCriterionId)
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
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Quality != null)
                    hash = hash * 59 + this.Quality.GetHashCode();
                    if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                    if (this.Feedback != null)
                    hash = hash * 59 + this.Feedback.GetHashCode();
                    if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                    if (this.RubricCriterionId != null)
                    hash = hash * 59 + this.RubricCriterionId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RubricCriterionLevelType left, RubricCriterionLevelType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RubricCriterionLevelType left, RubricCriterionLevelType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
