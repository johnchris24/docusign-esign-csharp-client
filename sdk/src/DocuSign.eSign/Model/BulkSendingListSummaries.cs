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
    /// This complex type contains summaries that provide basic information about the bulk send lists that belong to the current user.
    /// </summary>
    [DataContract]
    public partial class BulkSendingListSummaries :  IEquatable<BulkSendingListSummaries>, IValidatableObject
    {
        public BulkSendingListSummaries()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingListSummaries" /> class.
        /// </summary>
        /// <param name="BulkListSummaries">BulkListSummaries.</param>
        public BulkSendingListSummaries(List<BulkSendingListSummary> BulkListSummaries = default(List<BulkSendingListSummary>))
        {
            this.BulkListSummaries = BulkListSummaries;
        }
        
        /// <summary>
        /// Gets or Sets BulkListSummaries
        /// </summary>
        [DataMember(Name="bulkListSummaries", EmitDefaultValue=false)]
        public List<BulkSendingListSummary> BulkListSummaries { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingListSummaries {\n");
            sb.Append("  BulkListSummaries: ").Append(BulkListSummaries).Append("\n");
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
            return this.Equals(obj as BulkSendingListSummaries);
        }

        /// <summary>
        /// Returns true if BulkSendingListSummaries instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingListSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingListSummaries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BulkListSummaries == other.BulkListSummaries ||
                    this.BulkListSummaries != null &&
                    this.BulkListSummaries.SequenceEqual(other.BulkListSummaries)
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
                if (this.BulkListSummaries != null)
                    hash = hash * 59 + this.BulkListSummaries.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
