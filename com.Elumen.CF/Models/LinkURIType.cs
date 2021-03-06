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
    /// A container for the information that is used to achieve the link data reference.
    /// </summary>
    [DataContract]
    public partial class LinkURIType :  IEquatable<LinkURIType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkURIType" /> class.
        /// </summary>
        /// <param name="Title">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="Identifier">Identifier (required).</param>
        /// <param name="Uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        public LinkURIType(string Title = null, GUIDType Identifier = null, string Uri = null)
        {
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for LinkURIType and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for LinkURIType and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for LinkURIType and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            
        }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="title")]
        public string Title { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkURIType {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return Equals((LinkURIType)obj);
        }

        /// <summary>
        /// Returns true if LinkURIType instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkURIType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkURIType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                    if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                    if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                    if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(LinkURIType left, LinkURIType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LinkURIType left, LinkURIType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
