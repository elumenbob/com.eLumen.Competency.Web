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
    public partial class ImsxStatusInfoType :  IEquatable<ImsxStatusInfoType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImsxStatusInfoType" /> class.
        /// </summary>
        /// <param name="ImsxCodeMajor">ImsxCodeMajor (required).</param>
        /// <param name="ImsxSeverity">ImsxSeverity (required).</param>
        /// <param name="ImsxMessageRefIdentifier">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="ImsxOperationRefIdentifier">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="ImsxDescription">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="ImsxCodeMinor">ImsxCodeMinor.</param>
        public ImsxStatusInfoType(string ImsxCodeMajor = null, string ImsxSeverity = null, string ImsxMessageRefIdentifier = null, string ImsxOperationRefIdentifier = null, string ImsxDescription = null, ImsxCodeMinorType ImsxCodeMinor = null)
        {
            // to ensure "ImsxCodeMajor" is required (not null)
            if (ImsxCodeMajor == null)
            {
                throw new InvalidDataException("ImsxCodeMajor is a required property for ImsxStatusInfoType and cannot be null");
            }
            else
            {
                this.ImsxCodeMajor = ImsxCodeMajor;
            }
            // to ensure "ImsxSeverity" is required (not null)
            if (ImsxSeverity == null)
            {
                throw new InvalidDataException("ImsxSeverity is a required property for ImsxStatusInfoType and cannot be null");
            }
            else
            {
                this.ImsxSeverity = ImsxSeverity;
            }
            // to ensure "ImsxMessageRefIdentifier" is required (not null)
            if (ImsxMessageRefIdentifier == null)
            {
                throw new InvalidDataException("ImsxMessageRefIdentifier is a required property for ImsxStatusInfoType and cannot be null");
            }
            else
            {
                this.ImsxMessageRefIdentifier = ImsxMessageRefIdentifier;
            }
            this.ImsxOperationRefIdentifier = ImsxOperationRefIdentifier;
            this.ImsxDescription = ImsxDescription;
            this.ImsxCodeMinor = ImsxCodeMinor;
            
        }

        /// <summary>
        /// Gets or Sets ImsxCodeMajor
        /// </summary>
        public string ImsxCodeMajor { get; set; }

        /// <summary>
        /// Gets or Sets ImsxSeverity
        /// </summary>
        public string ImsxSeverity { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        public string ImsxMessageRefIdentifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        public string ImsxOperationRefIdentifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        public string ImsxDescription { get; set; }

        /// <summary>
        /// Gets or Sets ImsxCodeMinor
        /// </summary>
        public ImsxCodeMinorType ImsxCodeMinor { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImsxStatusInfoType {\n");
            sb.Append("  ImsxCodeMajor: ").Append(ImsxCodeMajor).Append("\n");
sb.Append("  ImsxSeverity: ").Append(ImsxSeverity).Append("\n");
sb.Append("  ImsxMessageRefIdentifier: ").Append(ImsxMessageRefIdentifier).Append("\n");
sb.Append("  ImsxOperationRefIdentifier: ").Append(ImsxOperationRefIdentifier).Append("\n");
sb.Append("  ImsxDescription: ").Append(ImsxDescription).Append("\n");
sb.Append("  ImsxCodeMinor: ").Append(ImsxCodeMinor).Append("\n");
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
            return Equals((ImsxStatusInfoType)obj);
        }

        /// <summary>
        /// Returns true if ImsxStatusInfoType instances are equal
        /// </summary>
        /// <param name="other">Instance of ImsxStatusInfoType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImsxStatusInfoType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ImsxCodeMajor == other.ImsxCodeMajor ||
                    this.ImsxCodeMajor != null &&
                    this.ImsxCodeMajor.Equals(other.ImsxCodeMajor)
                ) && 
                (
                    this.ImsxSeverity == other.ImsxSeverity ||
                    this.ImsxSeverity != null &&
                    this.ImsxSeverity.Equals(other.ImsxSeverity)
                ) && 
                (
                    this.ImsxMessageRefIdentifier == other.ImsxMessageRefIdentifier ||
                    this.ImsxMessageRefIdentifier != null &&
                    this.ImsxMessageRefIdentifier.Equals(other.ImsxMessageRefIdentifier)
                ) && 
                (
                    this.ImsxOperationRefIdentifier == other.ImsxOperationRefIdentifier ||
                    this.ImsxOperationRefIdentifier != null &&
                    this.ImsxOperationRefIdentifier.Equals(other.ImsxOperationRefIdentifier)
                ) && 
                (
                    this.ImsxDescription == other.ImsxDescription ||
                    this.ImsxDescription != null &&
                    this.ImsxDescription.Equals(other.ImsxDescription)
                ) && 
                (
                    this.ImsxCodeMinor == other.ImsxCodeMinor ||
                    this.ImsxCodeMinor != null &&
                    this.ImsxCodeMinor.Equals(other.ImsxCodeMinor)
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
                    if (this.ImsxCodeMajor != null)
                    hash = hash * 59 + this.ImsxCodeMajor.GetHashCode();
                    if (this.ImsxSeverity != null)
                    hash = hash * 59 + this.ImsxSeverity.GetHashCode();
                    if (this.ImsxMessageRefIdentifier != null)
                    hash = hash * 59 + this.ImsxMessageRefIdentifier.GetHashCode();
                    if (this.ImsxOperationRefIdentifier != null)
                    hash = hash * 59 + this.ImsxOperationRefIdentifier.GetHashCode();
                    if (this.ImsxDescription != null)
                    hash = hash * 59 + this.ImsxDescription.GetHashCode();
                    if (this.ImsxCodeMinor != null)
                    hash = hash * 59 + this.ImsxCodeMinor.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ImsxStatusInfoType left, ImsxStatusInfoType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImsxStatusInfoType left, ImsxStatusInfoType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
