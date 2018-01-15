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
    /// The container for the definition of a criterion level which is addressed by the competency framework.
    /// </summary>
    [DataContract]
    public partial class CFRubricCriterionLevelType :  IEquatable<CFRubricCriterionLevelType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRubricCriterionLevelType" /> class.
        /// </summary>
        /// <param name="Identifier">Identifier (required).</param>
        /// <param name="Uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="Description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Quality">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="Score">Model Primitive Datatype &#x3D; Float.</param>
        /// <param name="Feedback">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Position">Model Primitive Datatype &#x3D; Integer.</param>
        /// <param name="RubricCriterionId">RubricCriterionId.</param>
        /// <param name="LastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFRubricCriterionLevelType(GUIDType Identifier = null, string Uri = null, string Description = null, string Quality = null, float? Score = null, string Feedback = null, int? Position = null, GUIDType RubricCriterionId = null, DateTime? LastChangeDateTime = null)
        {
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for CFRubricCriterionLevelType and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for CFRubricCriterionLevelType and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            // to ensure "LastChangeDateTime" is required (not null)
            if (LastChangeDateTime == null)
            {
                throw new InvalidDataException("LastChangeDateTime is a required property for CFRubricCriterionLevelType and cannot be null");
            }
            else
            {
                this.LastChangeDateTime = LastChangeDateTime;
            }
            this.Description = Description;
            this.Quality = Quality;
            this.Score = Score;
            this.Feedback = Feedback;
            this.Position = Position;
            this.RubricCriterionId = RubricCriterionId;
            
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
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Float
        /// </summary>
        /// <value>Model Primitive Datatype = Float</value>
        [DataMember(Name="score")]
        public float? Score { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        [DataMember(Name="feedback")]
        public string Feedback { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Integer
        /// </summary>
        /// <value>Model Primitive Datatype = Integer</value>
        [DataMember(Name="position")]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or Sets RubricCriterionId
        /// </summary>
        [DataMember(Name="rubricCriterionId")]
        public GUIDType RubricCriterionId { get; set; }

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
            sb.Append("class CFRubricCriterionLevelType {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  RubricCriterionId: ").Append(RubricCriterionId).Append("\n");
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
            return Equals((CFRubricCriterionLevelType)obj);
        }

        /// <summary>
        /// Returns true if CFRubricCriterionLevelType instances are equal
        /// </summary>
        /// <param name="other">Instance of CFRubricCriterionLevelType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFRubricCriterionLevelType other)
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
                    if (this.LastChangeDateTime != null)
                    hash = hash * 59 + this.LastChangeDateTime.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CFRubricCriterionLevelType left, CFRubricCriterionLevelType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CFRubricCriterionLevelType left, CFRubricCriterionLevelType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
