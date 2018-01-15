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
    /// The container for the set of definitions used for the competency framework i.e. the set of CFSubjects, CFConcepts, CFItemTypes, CFAssociationGroupings and CFLicenses.
    /// </summary>
    [DataContract]
    public partial class CFDefinitionType :  IEquatable<CFDefinitionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDefinitionType" /> class.
        /// </summary>
        /// <param name="CFConcepts">CFConcepts.</param>
        /// <param name="CFSubjects">CFSubjects.</param>
        /// <param name="CFLicenses">CFLicenses.</param>
        /// <param name="CFItemTypes">CFItemTypes.</param>
        /// <param name="CFAssociationGroupings">CFAssociationGroupings.</param>
        public CFDefinitionType(List<CFConceptType> CFConcepts = null, List<CFSubjectType> CFSubjects = null, List<CFLicenseType> CFLicenses = null, List<CFItemTypeType> CFItemTypes = null, List<CFAssociationGroupingType> CFAssociationGroupings = null)
        {
            this.CFConcepts = CFConcepts;
            this.CFSubjects = CFSubjects;
            this.CFLicenses = CFLicenses;
            this.CFItemTypes = CFItemTypes;
            this.CFAssociationGroupings = CFAssociationGroupings;
            
        }

        /// <summary>
        /// Gets or Sets CFConcepts
        /// </summary>
        [DataMember(Name="CFConcepts")]
        public List<CFConceptType> CFConcepts { get; set; }

        /// <summary>
        /// Gets or Sets CFSubjects
        /// </summary>
        [DataMember(Name="CFSubjects")]
        public List<CFSubjectType> CFSubjects { get; set; }

        /// <summary>
        /// Gets or Sets CFLicenses
        /// </summary>
        [DataMember(Name="CFLicenses")]
        public List<CFLicenseType> CFLicenses { get; set; }

        /// <summary>
        /// Gets or Sets CFItemTypes
        /// </summary>
        [DataMember(Name="CFItemTypes")]
        public List<CFItemTypeType> CFItemTypes { get; set; }

        /// <summary>
        /// Gets or Sets CFAssociationGroupings
        /// </summary>
        [DataMember(Name="CFAssociationGroupings")]
        public List<CFAssociationGroupingType> CFAssociationGroupings { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CFDefinitionType {\n");
            sb.Append("  CFConcepts: ").Append(CFConcepts).Append("\n");
            sb.Append("  CFSubjects: ").Append(CFSubjects).Append("\n");
            sb.Append("  CFLicenses: ").Append(CFLicenses).Append("\n");
            sb.Append("  CFItemTypes: ").Append(CFItemTypes).Append("\n");
            sb.Append("  CFAssociationGroupings: ").Append(CFAssociationGroupings).Append("\n");
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
            return Equals((CFDefinitionType)obj);
        }

        /// <summary>
        /// Returns true if CFDefinitionType instances are equal
        /// </summary>
        /// <param name="other">Instance of CFDefinitionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFDefinitionType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CFConcepts == other.CFConcepts ||
                    this.CFConcepts != null &&
                    this.CFConcepts.SequenceEqual(other.CFConcepts)
                ) && 
                (
                    this.CFSubjects == other.CFSubjects ||
                    this.CFSubjects != null &&
                    this.CFSubjects.SequenceEqual(other.CFSubjects)
                ) && 
                (
                    this.CFLicenses == other.CFLicenses ||
                    this.CFLicenses != null &&
                    this.CFLicenses.SequenceEqual(other.CFLicenses)
                ) && 
                (
                    this.CFItemTypes == other.CFItemTypes ||
                    this.CFItemTypes != null &&
                    this.CFItemTypes.SequenceEqual(other.CFItemTypes)
                ) && 
                (
                    this.CFAssociationGroupings == other.CFAssociationGroupings ||
                    this.CFAssociationGroupings != null &&
                    this.CFAssociationGroupings.SequenceEqual(other.CFAssociationGroupings)
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
                    if (this.CFConcepts != null)
                    hash = hash * 59 + this.CFConcepts.GetHashCode();
                    if (this.CFSubjects != null)
                    hash = hash * 59 + this.CFSubjects.GetHashCode();
                    if (this.CFLicenses != null)
                    hash = hash * 59 + this.CFLicenses.GetHashCode();
                    if (this.CFItemTypes != null)
                    hash = hash * 59 + this.CFItemTypes.GetHashCode();
                    if (this.CFAssociationGroupings != null)
                    hash = hash * 59 + this.CFAssociationGroupings.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CFDefinitionType left, CFDefinitionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CFDefinitionType left, CFDefinitionType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
