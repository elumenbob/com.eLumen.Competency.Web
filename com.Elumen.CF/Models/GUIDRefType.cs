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

namespace com.eLumen.CF.Models
{
    /// <summary>
    /// The data-type that defines a reference to a GUID (there is NO requirement for the definition of the GUID to occur within the same data payload).
    /// </summary>
    [DataContract]
    public partial class GUIDRefType :  IEquatable<GUIDRefType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GUIDRefType" /> class.
        /// </summary>
        /// <param name="LinkType">LinkType (required).</param>
        /// <param name="SourcedId">SourcedId (required).</param>
        public GUIDRefType(string LinkType = null, GUIDType SourcedId = null)
        {
            // to ensure "LinkType" is required (not null)
            if (LinkType == null)
            {
                throw new InvalidDataException("LinkType is a required property for GUIDRefType and cannot be null");
            }
            else
            {
                this.LinkType = LinkType;
            }
            // to ensure "SourcedId" is required (not null)
            if (SourcedId == null)
            {
                throw new InvalidDataException("SourcedId is a required property for GUIDRefType and cannot be null");
            }
            else
            {
                this.SourcedId = SourcedId;
            }
            
        }

        /// <summary>
        /// Gets or Sets LinkType
        /// </summary>
        [DataMember(Name="linkType")]
        public string LinkType { get; set; }

        /// <summary>
        /// Gets or Sets SourcedId
        /// </summary>
        [DataMember(Name="sourcedId")]
        public GUIDType SourcedId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GUIDRefType {\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  SourcedId: ").Append(SourcedId).Append("\n");
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
            return Equals((GUIDRefType)obj);
        }

        /// <summary>
        /// Returns true if GUIDRefType instances are equal
        /// </summary>
        /// <param name="other">Instance of GUIDRefType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GUIDRefType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.LinkType == other.LinkType ||
                    this.LinkType != null &&
                    this.LinkType.Equals(other.LinkType)
                ) && 
                (
                    this.SourcedId == other.SourcedId ||
                    this.SourcedId != null &&
                    this.SourcedId.Equals(other.SourcedId)
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
                    if (this.LinkType != null)
                    hash = hash * 59 + this.LinkType.GetHashCode();
                    if (this.SourcedId != null)
                    hash = hash * 59 + this.SourcedId.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GUIDRefType left, GUIDRefType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GUIDRefType left, GUIDRefType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
