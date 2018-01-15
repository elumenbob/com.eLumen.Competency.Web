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
    /// This is the container for the CFItem data. This is the content that either describes a specific competency (learning objective) or describes a grouping of competencies within the taxonomy of a Competency Framework Document. 
    /// </summary>
    [DataContract]
    public partial class CFItemType :  IEquatable<CFItemType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Models.CFItemType" /> class.
        /// </summary>
        /// <param name="Identifier">Identifier (required).</param>
        /// <param name="CFDocumentURI">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="OrganizationCompetencyCode">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="CompetencyEffectiveDate">Model Primitive Datatype &#x3D; DateTime.</param>
        /// <param name="CompetencyTerminationDate">Model Primitive Datatype &#x3D; DateTime.</param>
        /// <param name="FullStatement">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="CompetencyLabel">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="CFItemType">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="CompetencyAssociationSet">CompetencyAssociationSet.</param>
        /// <param name="CompetencyReferenceHierarchy">CompetencyReferenceHierarchy.</param>
        /// <param name="Uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="HumanCodingScheme">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="ListEnumeration">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="AbbreviatedStatement">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="ConceptKeywords">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="ConceptKeywordsURI">ConceptKeywordsURI.</param>
        /// <param name="Notes">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="Language">Model Primitive Datatype &#x3D; Language.</param>
        /// <param name="EducationLevel">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="CFItemTypeURI">CFItemTypeURI.</param>
        /// <param name="License">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="LicenseURI">LicenseURI.</param>
        /// <param name="LastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        /// <param name="CFItemAssociationURI">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        public CFItemType(GUIDType Identifier = null, string CFDocumentURI = null, string OrganizationCompetencyCode = null, DateTime? CompetencyEffectiveDate = null, DateTime? CompetencyTerminationDate = null, string FullStatement = null, string CompetencyLabel = null, string CFItemType = null, CFAssociationSetType CompetencyAssociationSet = null, List<GUIDType> CompetencyReferenceHierarchy = null, string Uri = null, string HumanCodingScheme = null, string ListEnumeration = null, string AbbreviatedStatement = null, List<string> ConceptKeywords = null, LinkURIType ConceptKeywordsURI = null, string Notes = null, string Language = null, List<string> EducationLevel = null, LinkURIType CFItemTypeURI = null, string License = null, LinkURIType LicenseURI = null, DateTime? LastChangeDateTime = null, string CFItemAssociationURI = null)
        {
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            // to ensure "CFDocumentURI" is required (not null)
            if (CFDocumentURI == null)
            {
                throw new InvalidDataException("CFDocumentURI is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.CFDocumentURI = CFDocumentURI;
            }
            // to ensure "OrganizationCompetencyCode" is required (not null)
            if (OrganizationCompetencyCode == null)
            {
                throw new InvalidDataException("OrganizationCompetencyCode is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.OrganizationCompetencyCode = OrganizationCompetencyCode;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            // to ensure "LastChangeDateTime" is required (not null)
            if (LastChangeDateTime == null)
            {
                throw new InvalidDataException("LastChangeDateTime is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.LastChangeDateTime = LastChangeDateTime;
            }
            // to ensure "CFItemAssociationURI" is required (not null)
            if (CFItemAssociationURI == null)
            {
                throw new InvalidDataException("CFItemAssociationURI is a required property for CFItemType and cannot be null");
            }
            else
            {
                this.CFItemAssociationURI = CFItemAssociationURI;
            }
            this.CompetencyEffectiveDate = CompetencyEffectiveDate;
            this.CompetencyTerminationDate = CompetencyTerminationDate;
            this.FullStatement = FullStatement;
            this.CompetencyLabel = CompetencyLabel;
            this.CFItemTypeType = CFItemType;
            this.CompetencyAssociationSet = CompetencyAssociationSet;
            this.CompetencyReferenceHierarchy = CompetencyReferenceHierarchy;
            this.HumanCodingScheme = HumanCodingScheme;
            this.ListEnumeration = ListEnumeration;
            this.AbbreviatedStatement = AbbreviatedStatement;
            this.ConceptKeywords = ConceptKeywords;
            this.ConceptKeywordsURI = ConceptKeywordsURI;
            this.Notes = Notes;
            this.Language = Language;
            this.EducationLevel = EducationLevel;
            this.CFItemTypeURI = CFItemTypeURI;
            this.License = License;
            this.LicenseURI = LicenseURI;
            
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
        [DataMember(Name="CFDocumentURI")]
        public string CFDocumentURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="organizationCompetencyCode")]
        public string OrganizationCompetencyCode { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        /// <value>Model Primitive Datatype = DateTime</value>
        [DataMember(Name="competencyEffectiveDate")]
        public DateTime? CompetencyEffectiveDate { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        /// <value>Model Primitive Datatype = DateTime</value>
        [DataMember(Name="competencyTerminationDate")]
        public DateTime? CompetencyTerminationDate { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="fullStatement")]
        public string FullStatement { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="competencyLabel")]
        public string CompetencyLabel { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="CFItemType")]
        public string CFItemTypeType { get; set; }

        /// <summary>
        /// Gets or Sets CompetencyAssociationSet
        /// </summary>
        [DataMember(Name="competencyAssociationSet")]
        public CFAssociationSetType CompetencyAssociationSet { get; set; }

        /// <summary>
        /// Gets or Sets CompetencyReferenceHierarchy
        /// </summary>
        [DataMember(Name="competencyReferenceHierarchy")]
        public List<GUIDType> CompetencyReferenceHierarchy { get; set; }

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
        [DataMember(Name="humanCodingScheme")]
        public string HumanCodingScheme { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="listEnumeration")]
        public string ListEnumeration { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="abbreviatedStatement")]
        public string AbbreviatedStatement { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="conceptKeywords")]
        public List<string> ConceptKeywords { get; set; }

        /// <summary>
        /// Gets or Sets ConceptKeywordsURI
        /// </summary>
        [DataMember(Name="conceptKeywordsURI")]
        public LinkURIType ConceptKeywordsURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = String
        /// </summary>
        /// <value>Model Primitive Datatype = String</value>
        [DataMember(Name="notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Model Primitive Datatype = Language
        /// </summary>
        /// <value>Model Primitive Datatype = Language</value>
        [DataMember(Name="language")]
        public string Language { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="educationLevel")]
        public List<string> EducationLevel { get; set; }

        /// <summary>
        /// Gets or Sets CFItemTypeURI
        /// </summary>
        [DataMember(Name="CFItemTypeURI")]
        public LinkURIType CFItemTypeURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = NormalizedString
        /// </summary>
        /// <value>Model Primitive Datatype = NormalizedString</value>
        [DataMember(Name="license")]
        public string License { get; set; }

        /// <summary>
        /// Gets or Sets LicenseURI
        /// </summary>
        [DataMember(Name="licenseURI")]
        public LinkURIType LicenseURI { get; set; }

        /// <summary>
        /// Model Primitive Datatype = DateTime
        /// </summary>
        /// <value>Model Primitive Datatype = DateTime</value>
        [DataMember(Name="lastChangeDateTime")]
        public DateTime? LastChangeDateTime { get; set; }

        /// <summary>
        /// Model Primitive Datatype = AnyURI
        /// </summary>
        /// <value>Model Primitive Datatype = AnyURI</value>
        [DataMember(Name="CFItemAssociationURI")]
        public string CFItemAssociationURI { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CFItemType {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  CFDocumentURI: ").Append(CFDocumentURI).Append("\n");
            sb.Append("  OrganizationCompetencyCode: ").Append(OrganizationCompetencyCode).Append("\n");
            sb.Append("  CompetencyEffectiveDate: ").Append(CompetencyEffectiveDate).Append("\n");
            sb.Append("  CompetencyTerminationDate: ").Append(CompetencyTerminationDate).Append("\n");
            sb.Append("  FullStatement: ").Append(FullStatement).Append("\n");
            sb.Append("  CompetencyLabel: ").Append(CompetencyLabel).Append("\n");
            sb.Append("  CFItemType: ").Append(CFItemTypeType).Append("\n");
            sb.Append("  CompetencyAssociationSet: ").Append(CompetencyAssociationSet).Append("\n");
            sb.Append("  CompetencyReferenceHierarchy: ").Append(CompetencyReferenceHierarchy).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  HumanCodingScheme: ").Append(HumanCodingScheme).Append("\n");
            sb.Append("  ListEnumeration: ").Append(ListEnumeration).Append("\n");
            sb.Append("  AbbreviatedStatement: ").Append(AbbreviatedStatement).Append("\n");
            sb.Append("  ConceptKeywords: ").Append(ConceptKeywords).Append("\n");
            sb.Append("  ConceptKeywordsURI: ").Append(ConceptKeywordsURI).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  EducationLevel: ").Append(EducationLevel).Append("\n");
            sb.Append("  CFItemTypeURI: ").Append(CFItemTypeURI).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  LicenseURI: ").Append(LicenseURI).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
            sb.Append("  CFItemAssociationURI: ").Append(CFItemAssociationURI).Append("\n");
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
            return Equals((CFItemType)obj);
        }

        /// <summary>
        /// Returns true if CFItemType instances are equal
        /// </summary>
        /// <param name="other">Instance of CFItemType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFItemType other)
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
                    this.CFDocumentURI == other.CFDocumentURI ||
                    this.CFDocumentURI != null &&
                    this.CFDocumentURI.Equals(other.CFDocumentURI)
                ) && 
                (
                    this.OrganizationCompetencyCode == other.OrganizationCompetencyCode ||
                    this.OrganizationCompetencyCode != null &&
                    this.OrganizationCompetencyCode.Equals(other.OrganizationCompetencyCode)
                ) && 
                (
                    this.CompetencyEffectiveDate == other.CompetencyEffectiveDate ||
                    this.CompetencyEffectiveDate != null &&
                    this.CompetencyEffectiveDate.Equals(other.CompetencyEffectiveDate)
                ) && 
                (
                    this.CompetencyTerminationDate == other.CompetencyTerminationDate ||
                    this.CompetencyTerminationDate != null &&
                    this.CompetencyTerminationDate.Equals(other.CompetencyTerminationDate)
                ) && 
                (
                    this.FullStatement == other.FullStatement ||
                    this.FullStatement != null &&
                    this.FullStatement.Equals(other.FullStatement)
                ) && 
                (
                    this.CompetencyLabel == other.CompetencyLabel ||
                    this.CompetencyLabel != null &&
                    this.CompetencyLabel.Equals(other.CompetencyLabel)
                ) && 
                (
                    this.CFItemTypeType == other.CFItemTypeType ||
                    this.CFItemTypeType != null &&
                    this.CFItemTypeType.Equals(other.CFItemTypeType)
                ) && 
                (
                    this.CompetencyAssociationSet == other.CompetencyAssociationSet ||
                    this.CompetencyAssociationSet != null &&
                    this.CompetencyAssociationSet.Equals(other.CompetencyAssociationSet)
                ) && 
                (
                    this.CompetencyReferenceHierarchy == other.CompetencyReferenceHierarchy ||
                    this.CompetencyReferenceHierarchy != null &&
                    this.CompetencyReferenceHierarchy.SequenceEqual(other.CompetencyReferenceHierarchy)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.HumanCodingScheme == other.HumanCodingScheme ||
                    this.HumanCodingScheme != null &&
                    this.HumanCodingScheme.Equals(other.HumanCodingScheme)
                ) && 
                (
                    this.ListEnumeration == other.ListEnumeration ||
                    this.ListEnumeration != null &&
                    this.ListEnumeration.Equals(other.ListEnumeration)
                ) && 
                (
                    this.AbbreviatedStatement == other.AbbreviatedStatement ||
                    this.AbbreviatedStatement != null &&
                    this.AbbreviatedStatement.Equals(other.AbbreviatedStatement)
                ) && 
                (
                    this.ConceptKeywords == other.ConceptKeywords ||
                    this.ConceptKeywords != null &&
                    this.ConceptKeywords.SequenceEqual(other.ConceptKeywords)
                ) && 
                (
                    this.ConceptKeywordsURI == other.ConceptKeywordsURI ||
                    this.ConceptKeywordsURI != null &&
                    this.ConceptKeywordsURI.Equals(other.ConceptKeywordsURI)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.EducationLevel == other.EducationLevel ||
                    this.EducationLevel != null &&
                    this.EducationLevel.SequenceEqual(other.EducationLevel)
                ) && 
                (
                    this.CFItemTypeURI == other.CFItemTypeURI ||
                    this.CFItemTypeURI != null &&
                    this.CFItemTypeURI.Equals(other.CFItemTypeURI)
                ) && 
                (
                    this.License == other.License ||
                    this.License != null &&
                    this.License.Equals(other.License)
                ) && 
                (
                    this.LicenseURI == other.LicenseURI ||
                    this.LicenseURI != null &&
                    this.LicenseURI.Equals(other.LicenseURI)
                ) && 
                (
                    this.LastChangeDateTime == other.LastChangeDateTime ||
                    this.LastChangeDateTime != null &&
                    this.LastChangeDateTime.Equals(other.LastChangeDateTime)
                ) && 
                (
                    this.CFItemAssociationURI == other.CFItemAssociationURI ||
                    this.CFItemAssociationURI != null &&
                    this.CFItemAssociationURI.Equals(other.CFItemAssociationURI)
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
                    if (this.CFDocumentURI != null)
                    hash = hash * 59 + this.CFDocumentURI.GetHashCode();
                    if (this.OrganizationCompetencyCode != null)
                    hash = hash * 59 + this.OrganizationCompetencyCode.GetHashCode();
                    if (this.CompetencyEffectiveDate != null)
                    hash = hash * 59 + this.CompetencyEffectiveDate.GetHashCode();
                    if (this.CompetencyTerminationDate != null)
                    hash = hash * 59 + this.CompetencyTerminationDate.GetHashCode();
                    if (this.FullStatement != null)
                    hash = hash * 59 + this.FullStatement.GetHashCode();
                    if (this.CompetencyLabel != null)
                    hash = hash * 59 + this.CompetencyLabel.GetHashCode();
                    if (this.CFItemTypeType != null)
                    hash = hash * 59 + this.CFItemTypeType.GetHashCode();
                    if (this.CompetencyAssociationSet != null)
                    hash = hash * 59 + this.CompetencyAssociationSet.GetHashCode();
                    if (this.CompetencyReferenceHierarchy != null)
                    hash = hash * 59 + this.CompetencyReferenceHierarchy.GetHashCode();
                    if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                    if (this.HumanCodingScheme != null)
                    hash = hash * 59 + this.HumanCodingScheme.GetHashCode();
                    if (this.ListEnumeration != null)
                    hash = hash * 59 + this.ListEnumeration.GetHashCode();
                    if (this.AbbreviatedStatement != null)
                    hash = hash * 59 + this.AbbreviatedStatement.GetHashCode();
                    if (this.ConceptKeywords != null)
                    hash = hash * 59 + this.ConceptKeywords.GetHashCode();
                    if (this.ConceptKeywordsURI != null)
                    hash = hash * 59 + this.ConceptKeywordsURI.GetHashCode();
                    if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                    if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                    if (this.EducationLevel != null)
                    hash = hash * 59 + this.EducationLevel.GetHashCode();
                    if (this.CFItemTypeURI != null)
                    hash = hash * 59 + this.CFItemTypeURI.GetHashCode();
                    if (this.License != null)
                    hash = hash * 59 + this.License.GetHashCode();
                    if (this.LicenseURI != null)
                    hash = hash * 59 + this.LicenseURI.GetHashCode();
                    if (this.LastChangeDateTime != null)
                    hash = hash * 59 + this.LastChangeDateTime.GetHashCode();
                    if (this.CFItemAssociationURI != null)
                    hash = hash * 59 + this.CFItemAssociationURI.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CFItemType left, CFItemType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CFItemType left, CFItemType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
