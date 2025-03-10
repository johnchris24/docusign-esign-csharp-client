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
    /// ConnectDebugLog
    /// </summary>
    [DataContract]
    public partial class ConnectDebugLog :  IEquatable<ConnectDebugLog>, IValidatableObject
    {
        public ConnectDebugLog()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectDebugLog" /> class.
        /// </summary>
        /// <param name="ConnectConfig">ConnectConfig.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="EventDateTime">EventDateTime.</param>
        /// <param name="EventDescription">EventDescription.</param>
        /// <param name="Payload">Payload.</param>
        public ConnectDebugLog(string ConnectConfig = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string EventDateTime = default(string), string EventDescription = default(string), string Payload = default(string))
        {
            this.ConnectConfig = ConnectConfig;
            this.ErrorDetails = ErrorDetails;
            this.EventDateTime = EventDateTime;
            this.EventDescription = EventDescription;
            this.Payload = Payload;
        }
        
        /// <summary>
        /// Gets or Sets ConnectConfig
        /// </summary>
        [DataMember(Name="connectConfig", EmitDefaultValue=false)]
        public string ConnectConfig { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets EventDateTime
        /// </summary>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public string EventDateTime { get; set; }
        /// <summary>
        /// Gets or Sets EventDescription
        /// </summary>
        [DataMember(Name="eventDescription", EmitDefaultValue=false)]
        public string EventDescription { get; set; }
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectDebugLog {\n");
            sb.Append("  ConnectConfig: ").Append(ConnectConfig).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
            sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(obj as ConnectDebugLog);
        }

        /// <summary>
        /// Returns true if ConnectDebugLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectDebugLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectDebugLog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectConfig == other.ConnectConfig ||
                    this.ConnectConfig != null &&
                    this.ConnectConfig.Equals(other.ConnectConfig)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.EventDateTime == other.EventDateTime ||
                    this.EventDateTime != null &&
                    this.EventDateTime.Equals(other.EventDateTime)
                ) && 
                (
                    this.EventDescription == other.EventDescription ||
                    this.EventDescription != null &&
                    this.EventDescription.Equals(other.EventDescription)
                ) && 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
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
                if (this.ConnectConfig != null)
                    hash = hash * 59 + this.ConnectConfig.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.EventDateTime != null)
                    hash = hash * 59 + this.EventDateTime.GetHashCode();
                if (this.EventDescription != null)
                    hash = hash * 59 + this.EventDescription.GetHashCode();
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
