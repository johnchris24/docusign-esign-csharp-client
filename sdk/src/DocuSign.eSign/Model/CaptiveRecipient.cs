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
    /// This object contains details about a captive (embedded) recipient.
    /// </summary>
    [DataContract]
    public partial class CaptiveRecipient :  IEquatable<CaptiveRecipient>, IValidatableObject
    {
        public CaptiveRecipient()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptiveRecipient" /> class.
        /// </summary>
        /// <param name="ClientUserId">Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. .</param>
        /// <param name="Email">Specifies the email address associated with the captive recipient..</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="UserName">Specifies the user name associated with the captive recipient..</param>
        public CaptiveRecipient(string ClientUserId = default(string), string Email = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string UserName = default(string))
        {
            this.ClientUserId = ClientUserId;
            this.Email = Email;
            this.ErrorDetails = ErrorDetails;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. 
        /// </summary>
        /// <value>Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters. </value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
        /// <summary>
        /// Specifies the email address associated with the captive recipient.
        /// </summary>
        /// <value>Specifies the email address associated with the captive recipient.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Specifies the user name associated with the captive recipient.
        /// </summary>
        /// <value>Specifies the user name associated with the captive recipient.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptiveRecipient {\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(obj as CaptiveRecipient);
        }

        /// <summary>
        /// Returns true if CaptiveRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of CaptiveRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptiveRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
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
                if (this.ClientUserId != null)
                    hash = hash * 59 + this.ClientUserId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
