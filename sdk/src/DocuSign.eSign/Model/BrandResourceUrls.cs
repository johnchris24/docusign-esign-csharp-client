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
    /// Brands use resource files to style the following experiences:   - Email - Sending - Signing - Captive (embedded) signing   You can modify these resource files to customize these experiences.
    /// </summary>
    [DataContract]
    public partial class BrandResourceUrls :  IEquatable<BrandResourceUrls>, IValidatableObject
    {
        public BrandResourceUrls()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandResourceUrls" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="Sending">Sending.</param>
        /// <param name="Signing">Signing.</param>
        /// <param name="SigningCaptive">SigningCaptive.</param>
        public BrandResourceUrls(string Email = default(string), string Sending = default(string), string Signing = default(string), string SigningCaptive = default(string))
        {
            this.Email = Email;
            this.Sending = Sending;
            this.Signing = Signing;
            this.SigningCaptive = SigningCaptive;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Sending
        /// </summary>
        [DataMember(Name="sending", EmitDefaultValue=false)]
        public string Sending { get; set; }
        /// <summary>
        /// Gets or Sets Signing
        /// </summary>
        [DataMember(Name="signing", EmitDefaultValue=false)]
        public string Signing { get; set; }
        /// <summary>
        /// Gets or Sets SigningCaptive
        /// </summary>
        [DataMember(Name="signingCaptive", EmitDefaultValue=false)]
        public string SigningCaptive { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandResourceUrls {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Sending: ").Append(Sending).Append("\n");
            sb.Append("  Signing: ").Append(Signing).Append("\n");
            sb.Append("  SigningCaptive: ").Append(SigningCaptive).Append("\n");
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
            return this.Equals(obj as BrandResourceUrls);
        }

        /// <summary>
        /// Returns true if BrandResourceUrls instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandResourceUrls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandResourceUrls other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Sending == other.Sending ||
                    this.Sending != null &&
                    this.Sending.Equals(other.Sending)
                ) && 
                (
                    this.Signing == other.Signing ||
                    this.Signing != null &&
                    this.Signing.Equals(other.Signing)
                ) && 
                (
                    this.SigningCaptive == other.SigningCaptive ||
                    this.SigningCaptive != null &&
                    this.SigningCaptive.Equals(other.SigningCaptive)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Sending != null)
                    hash = hash * 59 + this.Sending.GetHashCode();
                if (this.Signing != null)
                    hash = hash * 59 + this.Signing.GetHashCode();
                if (this.SigningCaptive != null)
                    hash = hash * 59 + this.SigningCaptive.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
