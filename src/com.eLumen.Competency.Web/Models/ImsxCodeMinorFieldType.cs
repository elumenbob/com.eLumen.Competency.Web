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
    public partial class ImsxCodeMinorFieldType :  IEquatable<ImsxCodeMinorFieldType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImsxCodeMinorFieldType" /> class.
        /// </summary>
        /// <param name="ImsxCodeMinorFieldName">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="ImsxCodeMinorFieldValue">ImsxCodeMinorFieldValue (required).</param>
        public ImsxCodeMinorFieldType(string ImsxCodeMinorFieldName = null, string ImsxCodeMinorFieldValue = null)
        {
            // to ensure "ImsxCodeMinorFieldName" is required (not null)
            if (ImsxCodeMinorFieldName == null)
            {
                throw new InvalidDataException("ImsxCodeMinorFieldName is a required property for ImsxCodeMinorFieldType and cannot be null");
            }
            else
            {
                this.ImsxCodeMinorFieldName = ImsxCodeMinorFieldName;
            }
            // to ensure "ImsxCodeMinorFieldValue" is required (not null)
            if (ImsxCodeMinorFieldValue == null)
            {
                throw new InvalidDataException("ImsxCodeMinorFieldValue is a required property for ImsxCodeMinorFieldType and cannot be null");
            }
            else
            {
                this.ImsxCodeMinorFieldValue = ImsxCodeMinorFieldValue;
            }
            
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        public string ImsxCodeMinorFieldName { get; set; }

        /// <summary>
        /// Gets or Sets ImsxCodeMinorFieldValue
        /// </summary>
        public string ImsxCodeMinorFieldValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImsxCodeMinorFieldType {\n");
            sb.Append("  ImsxCodeMinorFieldName: ").Append(ImsxCodeMinorFieldName).Append("\n");
sb.Append("  ImsxCodeMinorFieldValue: ").Append(ImsxCodeMinorFieldValue).Append("\n");
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
            return Equals((ImsxCodeMinorFieldType)obj);
        }

        /// <summary>
        /// Returns true if ImsxCodeMinorFieldType instances are equal
        /// </summary>
        /// <param name="other">Instance of ImsxCodeMinorFieldType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImsxCodeMinorFieldType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ImsxCodeMinorFieldName == other.ImsxCodeMinorFieldName ||
                    this.ImsxCodeMinorFieldName != null &&
                    this.ImsxCodeMinorFieldName.Equals(other.ImsxCodeMinorFieldName)
                ) && 
                (
                    this.ImsxCodeMinorFieldValue == other.ImsxCodeMinorFieldValue ||
                    this.ImsxCodeMinorFieldValue != null &&
                    this.ImsxCodeMinorFieldValue.Equals(other.ImsxCodeMinorFieldValue)
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
                    if (this.ImsxCodeMinorFieldName != null)
                    hash = hash * 59 + this.ImsxCodeMinorFieldName.GetHashCode();
                    if (this.ImsxCodeMinorFieldValue != null)
                    hash = hash * 59 + this.ImsxCodeMinorFieldValue.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ImsxCodeMinorFieldType left, ImsxCodeMinorFieldType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImsxCodeMinorFieldType left, ImsxCodeMinorFieldType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}