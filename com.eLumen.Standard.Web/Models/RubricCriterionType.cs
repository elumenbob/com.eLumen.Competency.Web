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
    public partial class RubricCriterionType :  IEquatable<RubricCriterionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubricCriterionType" /> class.
        /// </summary>
        /// <param name="RubricCriterionId">RubricCriterionId (required).</param>
        /// <param name="Category">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="Description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Weight">Model Primitive Datatype &#x3D; Float.</param>
        /// <param name="Position">Model Primitive Datatype &#x3D; Integer.</param>
        /// <param name="RubricId">RubricId.</param>
        public RubricCriterionType(GUIDType RubricCriterionId = null, string Category = null, string Description = null, float? Weight = null, int? Position = null, GUIDType RubricId = null)
        {
            // to ensure "RubricCriterionId" is required (not null)
            if (RubricCriterionId == null)
            {
                throw new InvalidDataException("RubricCriterionId is a required property for RubricCriterionType and cannot be null");
            }
            else
            {
                this.RubricCriterionId = RubricCriterionId;
            }
            this.Category = Category;
            this.Description = Description;
            this.Weight = Weight;
            this.Position = Position;
            this.RubricId = RubricId;
            
        }

        /// <summary>
        /// Gets or Sets RubricCriterionId
        /// </summary>
        public GUIDType RubricCriterionId { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        public string Category { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        /// <value>Model Primitive Datatype = Float</value>
        public float? Weight { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        /// <value>Model Primitive Datatype = Integer</value>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets RubricId
        /// </summary>
        public GUIDType RubricId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RubricCriterionType {\n");
            sb.Append("  RubricCriterionId: ").Append(RubricCriterionId).Append("\n");
sb.Append("  Category: ").Append(Category).Append("\n");
sb.Append("  Description: ").Append(Description).Append("\n");
sb.Append("  Weight: ").Append(Weight).Append("\n");
sb.Append("  Position: ").Append(Position).Append("\n");
sb.Append("  RubricId: ").Append(RubricId).Append("\n");
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
            return Equals((RubricCriterionType)obj);
        }

        /// <summary>
        /// Returns true if RubricCriterionType instances are equal
        /// </summary>
        /// <param name="other">Instance of RubricCriterionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RubricCriterionType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.RubricCriterionId == other.RubricCriterionId ||
                    this.RubricCriterionId != null &&
                    this.RubricCriterionId.Equals(other.RubricCriterionId)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.RubricId == other.RubricId ||
                    this.RubricId != null &&
                    this.RubricId.Equals(other.RubricId)
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
                    if (this.RubricCriterionId != null)
                    hash = hash * 59 + this.RubricCriterionId.GetHashCode();
                    if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                    if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                    if (this.RubricId != null)
                    hash = hash * 59 + this.RubricId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RubricCriterionType left, RubricCriterionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RubricCriterionType left, RubricCriterionType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
