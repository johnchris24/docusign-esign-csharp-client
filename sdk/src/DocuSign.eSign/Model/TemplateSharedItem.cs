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
    /// Information about shared templates.
    /// </summary>
    [DataContract]
    public partial class TemplateSharedItem :  IEquatable<TemplateSharedItem>, IValidatableObject
    {
        public TemplateSharedItem()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSharedItem" /> class.
        /// </summary>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Owner">Information about the user who owns the template..</param>
        /// <param name="Password">Password.</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        /// <param name="SharedGroups">SharedGroups.</param>
        /// <param name="SharedUsers">SharedUsers.</param>
        /// <param name="TemplateId">The unique identifier of the template. If this is not provided, DocuSign will generate a value. .</param>
        /// <param name="TemplateName">TemplateName.</param>
        public TemplateSharedItem(ErrorDetails ErrorDetails = default(ErrorDetails), UserInfo Owner = default(UserInfo), string Password = default(string), string Shared = default(string), List<MemberGroupSharedItem> SharedGroups = default(List<MemberGroupSharedItem>), List<UserSharedItem> SharedUsers = default(List<UserSharedItem>), string TemplateId = default(string), string TemplateName = default(string))
        {
            this.ErrorDetails = ErrorDetails;
            this.Owner = Owner;
            this.Password = Password;
            this.Shared = Shared;
            this.SharedGroups = SharedGroups;
            this.SharedUsers = SharedUsers;
            this.TemplateId = TemplateId;
            this.TemplateName = TemplateName;
        }
        
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Information about the user who owns the template.
        /// </summary>
        /// <value>Information about the user who owns the template.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserInfo Owner { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// Gets or Sets SharedGroups
        /// </summary>
        [DataMember(Name="sharedGroups", EmitDefaultValue=false)]
        public List<MemberGroupSharedItem> SharedGroups { get; set; }
        /// <summary>
        /// Gets or Sets SharedUsers
        /// </summary>
        [DataMember(Name="sharedUsers", EmitDefaultValue=false)]
        public List<UserSharedItem> SharedUsers { get; set; }
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value. 
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value. </value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets TemplateName
        /// </summary>
        [DataMember(Name="templateName", EmitDefaultValue=false)]
        public string TemplateName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSharedItem {\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  SharedGroups: ").Append(SharedGroups).Append("\n");
            sb.Append("  SharedUsers: ").Append(SharedUsers).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
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
            return this.Equals(obj as TemplateSharedItem);
        }

        /// <summary>
        /// Returns true if TemplateSharedItem instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateSharedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSharedItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.SharedGroups == other.SharedGroups ||
                    this.SharedGroups != null &&
                    this.SharedGroups.SequenceEqual(other.SharedGroups)
                ) && 
                (
                    this.SharedUsers == other.SharedUsers ||
                    this.SharedUsers != null &&
                    this.SharedUsers.SequenceEqual(other.SharedUsers)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.TemplateName == other.TemplateName ||
                    this.TemplateName != null &&
                    this.TemplateName.Equals(other.TemplateName)
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
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.SharedGroups != null)
                    hash = hash * 59 + this.SharedGroups.GetHashCode();
                if (this.SharedUsers != null)
                    hash = hash * 59 + this.SharedUsers.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null)
                    hash = hash * 59 + this.TemplateName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
