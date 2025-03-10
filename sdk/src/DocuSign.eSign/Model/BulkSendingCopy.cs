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
    /// This object contains the details to use for a specific copy, or instance, of the envelope. When you send an envelope by using a bulk send list, you can customize these properties for each instance.
    /// </summary>
    [DataContract]
    public partial class BulkSendingCopy :  IEquatable<BulkSendingCopy>, IValidatableObject
    {
        public BulkSendingCopy()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingCopy" /> class.
        /// </summary>
        /// <param name="CustomFields">An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters..</param>
        /// <param name="DocGenFormFields">DocGenFormFields.</param>
        /// <param name="EmailBlurb">EmailBlurb.</param>
        /// <param name="EmailSubject">Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject..</param>
        /// <param name="Recipients">An array of powerform recipients..</param>
        public BulkSendingCopy(List<BulkSendingCopyCustomField> CustomFields = default(List<BulkSendingCopyCustomField>), List<BulksendingCopyDocGenFormField> DocGenFormFields = default(List<BulksendingCopyDocGenFormField>), string EmailBlurb = default(string), string EmailSubject = default(string), List<BulkSendingCopyRecipient> Recipients = default(List<BulkSendingCopyRecipient>))
        {
            this.CustomFields = CustomFields;
            this.DocGenFormFields = DocGenFormFields;
            this.EmailBlurb = EmailBlurb;
            this.EmailSubject = EmailSubject;
            this.Recipients = Recipients;
        }
        
        /// <summary>
        /// An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.
        /// </summary>
        /// <value>An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<BulkSendingCopyCustomField> CustomFields { get; set; }
        /// <summary>
        /// Gets or Sets DocGenFormFields
        /// </summary>
        [DataMember(Name="docGenFormFields", EmitDefaultValue=false)]
        public List<BulksendingCopyDocGenFormField> DocGenFormFields { get; set; }
        /// <summary>
        /// Gets or Sets EmailBlurb
        /// </summary>
        [DataMember(Name="emailBlurb", EmitDefaultValue=false)]
        public string EmailBlurb { get; set; }
        /// <summary>
        /// Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.
        /// </summary>
        /// <value>Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=false)]
        public string EmailSubject { get; set; }
        /// <summary>
        /// An array of powerform recipients.
        /// </summary>
        /// <value>An array of powerform recipients.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<BulkSendingCopyRecipient> Recipients { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingCopy {\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  DocGenFormFields: ").Append(DocGenFormFields).Append("\n");
            sb.Append("  EmailBlurb: ").Append(EmailBlurb).Append("\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
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
            return this.Equals(obj as BulkSendingCopy);
        }

        /// <summary>
        /// Returns true if BulkSendingCopy instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingCopy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingCopy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.DocGenFormFields == other.DocGenFormFields ||
                    this.DocGenFormFields != null &&
                    this.DocGenFormFields.SequenceEqual(other.DocGenFormFields)
                ) && 
                (
                    this.EmailBlurb == other.EmailBlurb ||
                    this.EmailBlurb != null &&
                    this.EmailBlurb.Equals(other.EmailBlurb)
                ) && 
                (
                    this.EmailSubject == other.EmailSubject ||
                    this.EmailSubject != null &&
                    this.EmailSubject.Equals(other.EmailSubject)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
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
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                if (this.DocGenFormFields != null)
                    hash = hash * 59 + this.DocGenFormFields.GetHashCode();
                if (this.EmailBlurb != null)
                    hash = hash * 59 + this.EmailBlurb.GetHashCode();
                if (this.EmailSubject != null)
                    hash = hash * 59 + this.EmailSubject.GetHashCode();
                if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
