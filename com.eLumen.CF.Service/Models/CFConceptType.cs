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
    /// The container for the definition of a concept which is addressed by the competency frammework.
    /// </summary>
    [DataContract]
    public partial class CFConceptType :  IEquatable<CFConceptType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFConceptType" /> class.
        /// </summary>
        /// <param name="Identifier">Identifier (required).</param>
        /// <param name="Uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="Title">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="Keywords">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="HierarchyCode">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="Description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="LastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFConceptType(GUIDType Identifier = null, string Uri = null, string Title = null, string Keywords = null, string HierarchyCode = null, string Description = null, DateTime? LastChangeDateTime = null)
        {
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for CFConceptType and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for CFConceptType and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for CFConceptType and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "HierarchyCode" is required (not null)
            if (HierarchyCode == null)
            {
                throw new InvalidDataException("HierarchyCode is a required property for CFConceptType and cannot be null");
            }
            else
            {
                this.HierarchyCode = HierarchyCode;
            }
            // to ensure "LastChangeDateTime" is required (not null)
            if (LastChangeDateTime == null)
            {
                throw new InvalidDataException("LastChangeDateTime is a required property for CFConceptType and cannot be null");
            }
            else
            {
                this.LastChangeDateTime = LastChangeDateTime;
            }
            this.Keywords = Keywords;
            this.Description = Description;
            
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier")]
        public GUIDType Identifier { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        /// <value>Model Primitive Datatype = AnyURI</value>
        [DataMember(Name="uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="hierarchyCode")]
        public string HierarchyCode { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        /// <value>Model Primitive Datatype = DateTime</value>
        [DataMember(Name="lastChangeDateTime")]
        public DateTime? LastChangeDateTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CFConceptType {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  HierarchyCode: ").Append(HierarchyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
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
            return Equals((CFConceptType)obj);
        }

        /// <summary>
        /// Returns true if CFConceptType instances are equal
        /// </summary>
        /// <param name="other">Instance of CFConceptType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFConceptType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.Equals(other.Keywords)
                ) && 
                (
                    this.HierarchyCode == other.HierarchyCode ||
                    this.HierarchyCode != null &&
                    this.HierarchyCode.Equals(other.HierarchyCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.LastChangeDateTime == other.LastChangeDateTime ||
                    this.LastChangeDateTime != null &&
                    this.LastChangeDateTime.Equals(other.LastChangeDateTime)
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
                    if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                    if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                    if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                    if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                    if (this.HierarchyCode != null)
                    hash = hash * 59 + this.HierarchyCode.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.LastChangeDateTime != null)
                    hash = hash * 59 + this.LastChangeDateTime.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CFConceptType left, CFConceptType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CFConceptType left, CFConceptType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
