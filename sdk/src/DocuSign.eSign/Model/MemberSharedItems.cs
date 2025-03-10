/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Information about shared items.
    /// </summary>
    [DataContract]
    public partial class MemberSharedItems :  IEquatable<MemberSharedItems>, IValidatableObject
    {
        public MemberSharedItems()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberSharedItems" /> class.
        /// </summary>
        /// <param name="Envelopes">Envelopes.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Folders">Folders.</param>
        /// <param name="Templates">Templates.</param>
        /// <param name="User">Information about the user requesting sharing information..</param>
        public MemberSharedItems(List<SharedItem> Envelopes = default(List<SharedItem>), ErrorDetails ErrorDetails = default(ErrorDetails), List<FolderSharedItem> Folders = default(List<FolderSharedItem>), List<TemplateSharedItem> Templates = default(List<TemplateSharedItem>), UserInfo User = default(UserInfo))
        {
            this.Envelopes = Envelopes;
            this.ErrorDetails = ErrorDetails;
            this.Folders = Folders;
            this.Templates = Templates;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets Envelopes
        /// </summary>
        [DataMember(Name="envelopes", EmitDefaultValue=false)]
        public List<SharedItem> Envelopes { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Folders
        /// </summary>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<FolderSharedItem> Folders { get; set; }
        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        public List<TemplateSharedItem> Templates { get; set; }
        /// <summary>
        /// Information about the user requesting sharing information.
        /// </summary>
        /// <value>Information about the user requesting sharing information.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserInfo User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberSharedItems {\n");
            sb.Append("  Envelopes: ").Append(Envelopes).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MemberSharedItems);
        }

        /// <summary>
        /// Returns true if MemberSharedItems instances are equal
        /// </summary>
        /// <param name="other">Instance of MemberSharedItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberSharedItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Envelopes == other.Envelopes ||
                    this.Envelopes != null &&
                    this.Envelopes.SequenceEqual(other.Envelopes)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Folders == other.Folders ||
                    this.Folders != null &&
                    this.Folders.SequenceEqual(other.Folders)
                ) && 
                (
                    this.Templates == other.Templates ||
                    this.Templates != null &&
                    this.Templates.SequenceEqual(other.Templates)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Envelopes != null)
                    hash = hash * 59 + this.Envelopes.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Folders != null)
                    hash = hash * 59 + this.Folders.GetHashCode();
                if (this.Templates != null)
                    hash = hash * 59 + this.Templates.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
