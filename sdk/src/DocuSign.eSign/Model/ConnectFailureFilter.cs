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
    /// A list of failed envelope IDs to retry.
    /// </summary>
    [DataContract]
    public partial class ConnectFailureFilter :  IEquatable<ConnectFailureFilter>, IValidatableObject
    {
        public ConnectFailureFilter()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectFailureFilter" /> class.
        /// </summary>
        /// <param name="EnvelopeIds">EnvelopeIds.</param>
        /// <param name="Synchronous">Synchronous.</param>
        public ConnectFailureFilter(List<string> EnvelopeIds = default(List<string>), string Synchronous = default(string))
        {
            this.EnvelopeIds = EnvelopeIds;
            this.Synchronous = Synchronous;
        }
        
        /// <summary>
        /// Gets or Sets EnvelopeIds
        /// </summary>
        [DataMember(Name="envelopeIds", EmitDefaultValue=false)]
        public List<string> EnvelopeIds { get; set; }
        /// <summary>
        /// Gets or Sets Synchronous
        /// </summary>
        [DataMember(Name="synchronous", EmitDefaultValue=false)]
        public string Synchronous { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectFailureFilter {\n");
            sb.Append("  EnvelopeIds: ").Append(EnvelopeIds).Append("\n");
            sb.Append("  Synchronous: ").Append(Synchronous).Append("\n");
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
            return this.Equals(obj as ConnectFailureFilter);
        }

        /// <summary>
        /// Returns true if ConnectFailureFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectFailureFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectFailureFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeIds == other.EnvelopeIds ||
                    this.EnvelopeIds != null &&
                    this.EnvelopeIds.SequenceEqual(other.EnvelopeIds)
                ) && 
                (
                    this.Synchronous == other.Synchronous ||
                    this.Synchronous != null &&
                    this.Synchronous.Equals(other.Synchronous)
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
                if (this.EnvelopeIds != null)
                    hash = hash * 59 + this.EnvelopeIds.GetHashCode();
                if (this.Synchronous != null)
                    hash = hash * 59 + this.Synchronous.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
