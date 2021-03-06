/*
 * Machine Readable Framework for Learning Standards and Competencies Service OpenAPI (JSON) Definition
 *
 * The Machine Readable Framework for Learning Standards and Competencies Service enables the exchange of data between a Competency Records Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Specification development approach: this being the Platform Specific Model (PSM) of the service.
 *
 * OpenAPI spec version: 1.0
 * Contact: lmattson@imsglobal.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace com.eLumen.CF.Service.Models
{
    /// <summary>
    /// This is the container for a collection of CFDocuments. There must be at least one CFDocument.
    /// </summary>
    [DataContract]
    public partial class CFRubricCriterionLevelSetType :  IEquatable<CFRubricCriterionLevelSetType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSetType" /> class.
        /// </summary>
        /// <param name="CFCriterionLevels">CFCriterionLevels (required).</param>
        public CFRubricCriterionLevelSetType(List<CFRubricCriterionLevelType> CFCriterionLevels = null)
        {
            // to ensure "CFDocuments" is required (not null)
            if (CFCriterionLevels == null)
            {
                throw new InvalidDataException("CFDocuments is a required property for CFDocumentSetType and cannot be null");
            }
            else
            {
                this.CFCriterionLevels = CFCriterionLevels;
            }
            
        }

        /// <summary>
        /// Gets or Sets CFDocuments
        /// </summary>
        [DataMember(Name= "CFCriterionLevels")]
        public List<CFRubricCriterionLevelType> CFCriterionLevels { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CFRubricCriterionLevelSetType {\n");
            sb.Append("  CFCriterionLevels: ").Append(CFCriterionLevels).Append("\n");
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
            return Equals((CFDocumentSetType)obj);
        }

        /// <summary>
        /// Returns true if CFDocumentSetType instances are equal
        /// </summary>
        /// <param name="other">Instance of CFDocumentSetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFRubricCriterionLevelSetType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CFCriterionLevels == other.CFCriterionLevels ||
                    this.CFCriterionLevels != null &&
                    this.CFCriterionLevels.SequenceEqual(other.CFCriterionLevels)
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
                    if (this.CFCriterionLevels != null)
                    hash = hash * 59 + this.CFCriterionLevels.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CFRubricCriterionLevelSetType left, CFRubricCriterionLevelSetType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CFRubricCriterionLevelSetType left, CFRubricCriterionLevelSetType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
