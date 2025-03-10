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
    /// RecipientTokenClientURLs
    /// </summary>
    [DataContract]
    public partial class RecipientTokenClientURLs :  IEquatable<RecipientTokenClientURLs>, IValidatableObject
    {
        public RecipientTokenClientURLs()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientTokenClientURLs" /> class.
        /// </summary>
        /// <param name="OnAccessCodeFailed">OnAccessCodeFailed.</param>
        /// <param name="OnCancel">OnCancel.</param>
        /// <param name="OnDecline">OnDecline.</param>
        /// <param name="OnException">OnException.</param>
        /// <param name="OnFaxPending">OnFaxPending.</param>
        /// <param name="OnIdCheckFailed">OnIdCheckFailed.</param>
        /// <param name="OnSessionTimeout">OnSessionTimeout.</param>
        /// <param name="OnSigningComplete">OnSigningComplete.</param>
        /// <param name="OnTTLExpired">OnTTLExpired.</param>
        /// <param name="OnViewingComplete">OnViewingComplete.</param>
        public RecipientTokenClientURLs(string OnAccessCodeFailed = default(string), string OnCancel = default(string), string OnDecline = default(string), string OnException = default(string), string OnFaxPending = default(string), string OnIdCheckFailed = default(string), string OnSessionTimeout = default(string), string OnSigningComplete = default(string), string OnTTLExpired = default(string), string OnViewingComplete = default(string))
        {
            this.OnAccessCodeFailed = OnAccessCodeFailed;
            this.OnCancel = OnCancel;
            this.OnDecline = OnDecline;
            this.OnException = OnException;
            this.OnFaxPending = OnFaxPending;
            this.OnIdCheckFailed = OnIdCheckFailed;
            this.OnSessionTimeout = OnSessionTimeout;
            this.OnSigningComplete = OnSigningComplete;
            this.OnTTLExpired = OnTTLExpired;
            this.OnViewingComplete = OnViewingComplete;
        }
        
        /// <summary>
        /// Gets or Sets OnAccessCodeFailed
        /// </summary>
        [DataMember(Name="onAccessCodeFailed", EmitDefaultValue=false)]
        public string OnAccessCodeFailed { get; set; }
        /// <summary>
        /// Gets or Sets OnCancel
        /// </summary>
        [DataMember(Name="onCancel", EmitDefaultValue=false)]
        public string OnCancel { get; set; }
        /// <summary>
        /// Gets or Sets OnDecline
        /// </summary>
        [DataMember(Name="onDecline", EmitDefaultValue=false)]
        public string OnDecline { get; set; }
        /// <summary>
        /// Gets or Sets OnException
        /// </summary>
        [DataMember(Name="onException", EmitDefaultValue=false)]
        public string OnException { get; set; }
        /// <summary>
        /// Gets or Sets OnFaxPending
        /// </summary>
        [DataMember(Name="onFaxPending", EmitDefaultValue=false)]
        public string OnFaxPending { get; set; }
        /// <summary>
        /// Gets or Sets OnIdCheckFailed
        /// </summary>
        [DataMember(Name="onIdCheckFailed", EmitDefaultValue=false)]
        public string OnIdCheckFailed { get; set; }
        /// <summary>
        /// Gets or Sets OnSessionTimeout
        /// </summary>
        [DataMember(Name="onSessionTimeout", EmitDefaultValue=false)]
        public string OnSessionTimeout { get; set; }
        /// <summary>
        /// Gets or Sets OnSigningComplete
        /// </summary>
        [DataMember(Name="onSigningComplete", EmitDefaultValue=false)]
        public string OnSigningComplete { get; set; }
        /// <summary>
        /// Gets or Sets OnTTLExpired
        /// </summary>
        [DataMember(Name="onTTLExpired", EmitDefaultValue=false)]
        public string OnTTLExpired { get; set; }
        /// <summary>
        /// Gets or Sets OnViewingComplete
        /// </summary>
        [DataMember(Name="onViewingComplete", EmitDefaultValue=false)]
        public string OnViewingComplete { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientTokenClientURLs {\n");
            sb.Append("  OnAccessCodeFailed: ").Append(OnAccessCodeFailed).Append("\n");
            sb.Append("  OnCancel: ").Append(OnCancel).Append("\n");
            sb.Append("  OnDecline: ").Append(OnDecline).Append("\n");
            sb.Append("  OnException: ").Append(OnException).Append("\n");
            sb.Append("  OnFaxPending: ").Append(OnFaxPending).Append("\n");
            sb.Append("  OnIdCheckFailed: ").Append(OnIdCheckFailed).Append("\n");
            sb.Append("  OnSessionTimeout: ").Append(OnSessionTimeout).Append("\n");
            sb.Append("  OnSigningComplete: ").Append(OnSigningComplete).Append("\n");
            sb.Append("  OnTTLExpired: ").Append(OnTTLExpired).Append("\n");
            sb.Append("  OnViewingComplete: ").Append(OnViewingComplete).Append("\n");
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
            return this.Equals(obj as RecipientTokenClientURLs);
        }

        /// <summary>
        /// Returns true if RecipientTokenClientURLs instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientTokenClientURLs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientTokenClientURLs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OnAccessCodeFailed == other.OnAccessCodeFailed ||
                    this.OnAccessCodeFailed != null &&
                    this.OnAccessCodeFailed.Equals(other.OnAccessCodeFailed)
                ) && 
                (
                    this.OnCancel == other.OnCancel ||
                    this.OnCancel != null &&
                    this.OnCancel.Equals(other.OnCancel)
                ) && 
                (
                    this.OnDecline == other.OnDecline ||
                    this.OnDecline != null &&
                    this.OnDecline.Equals(other.OnDecline)
                ) && 
                (
                    this.OnException == other.OnException ||
                    this.OnException != null &&
                    this.OnException.Equals(other.OnException)
                ) && 
                (
                    this.OnFaxPending == other.OnFaxPending ||
                    this.OnFaxPending != null &&
                    this.OnFaxPending.Equals(other.OnFaxPending)
                ) && 
                (
                    this.OnIdCheckFailed == other.OnIdCheckFailed ||
                    this.OnIdCheckFailed != null &&
                    this.OnIdCheckFailed.Equals(other.OnIdCheckFailed)
                ) && 
                (
                    this.OnSessionTimeout == other.OnSessionTimeout ||
                    this.OnSessionTimeout != null &&
                    this.OnSessionTimeout.Equals(other.OnSessionTimeout)
                ) && 
                (
                    this.OnSigningComplete == other.OnSigningComplete ||
                    this.OnSigningComplete != null &&
                    this.OnSigningComplete.Equals(other.OnSigningComplete)
                ) && 
                (
                    this.OnTTLExpired == other.OnTTLExpired ||
                    this.OnTTLExpired != null &&
                    this.OnTTLExpired.Equals(other.OnTTLExpired)
                ) && 
                (
                    this.OnViewingComplete == other.OnViewingComplete ||
                    this.OnViewingComplete != null &&
                    this.OnViewingComplete.Equals(other.OnViewingComplete)
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
                if (this.OnAccessCodeFailed != null)
                    hash = hash * 59 + this.OnAccessCodeFailed.GetHashCode();
                if (this.OnCancel != null)
                    hash = hash * 59 + this.OnCancel.GetHashCode();
                if (this.OnDecline != null)
                    hash = hash * 59 + this.OnDecline.GetHashCode();
                if (this.OnException != null)
                    hash = hash * 59 + this.OnException.GetHashCode();
                if (this.OnFaxPending != null)
                    hash = hash * 59 + this.OnFaxPending.GetHashCode();
                if (this.OnIdCheckFailed != null)
                    hash = hash * 59 + this.OnIdCheckFailed.GetHashCode();
                if (this.OnSessionTimeout != null)
                    hash = hash * 59 + this.OnSessionTimeout.GetHashCode();
                if (this.OnSigningComplete != null)
                    hash = hash * 59 + this.OnSigningComplete.GetHashCode();
                if (this.OnTTLExpired != null)
                    hash = hash * 59 + this.OnTTLExpired.GetHashCode();
                if (this.OnViewingComplete != null)
                    hash = hash * 59 + this.OnViewingComplete.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
