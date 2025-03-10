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
    /// Describes which account management capabilities a user has.
    /// </summary>
    [DataContract]
    public partial class UserAccountManagementGranularInformation :  IEquatable<UserAccountManagementGranularInformation>, IValidatableObject
    {
        public UserAccountManagementGranularInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountManagementGranularInformation" /> class.
        /// </summary>
        /// <param name="CanManageAccountSecuritySettings">CanManageAccountSecuritySettings.</param>
        /// <param name="CanManageAccountSecuritySettingsMetadata">CanManageAccountSecuritySettingsMetadata.</param>
        /// <param name="CanManageAccountSettings">CanManageAccountSettings.</param>
        /// <param name="CanManageAccountSettingsMetadata">CanManageAccountSettingsMetadata.</param>
        /// <param name="CanManageAdmins">CanManageAdmins.</param>
        /// <param name="CanManageAdminsMetadata">Metadata that indicates whether the &#x60;canManageAdmins&#x60; property is editable. .</param>
        /// <param name="CanManageConnect">CanManageConnect.</param>
        /// <param name="CanManageConnectMetadata">CanManageConnectMetadata.</param>
        /// <param name="CanManageDocumentRetention">CanManageDocumentRetention.</param>
        /// <param name="CanManageDocumentRetentionMetadata">CanManageDocumentRetentionMetadata.</param>
        /// <param name="CanManageEnvelopeTransfer">CanManageEnvelopeTransfer.</param>
        /// <param name="CanManageEnvelopeTransferMetadata">CanManageEnvelopeTransferMetadata.</param>
        /// <param name="CanManageGroupsButNotUsers">CanManageGroupsButNotUsers.</param>
        /// <param name="CanManageGroupsButNotUsersMetadata">CanManageGroupsButNotUsersMetadata.</param>
        /// <param name="CanManageJointAgreements">CanManageJointAgreements.</param>
        /// <param name="CanManageJointAgreementsMetadata">CanManageJointAgreementsMetadata.</param>
        /// <param name="CanManageReporting">CanManageReporting.</param>
        /// <param name="CanManageReportingMetadata">CanManageReportingMetadata.</param>
        /// <param name="CanManageSharing">CanManageSharing.</param>
        /// <param name="CanManageSharingMetadata">Metadata that indicates whether the &#x60;canManageSharing&#x60; property is editable. .</param>
        /// <param name="CanManageSigningGroups">CanManageSigningGroups.</param>
        /// <param name="CanManageSigningGroupsMetadata">CanManageSigningGroupsMetadata.</param>
        /// <param name="CanManageStamps">CanManageStamps.</param>
        /// <param name="CanManageStampsMetadata">CanManageStampsMetadata.</param>
        /// <param name="CanManageUsers">CanManageUsers.</param>
        /// <param name="CanManageUsersMetadata">Metadata that indicates whether the &#x60;canManageUsers&#x60; property is editable. .</param>
        /// <param name="CanViewUsers">CanViewUsers.</param>
        public UserAccountManagementGranularInformation(string CanManageAccountSecuritySettings = default(string), SettingsMetadata CanManageAccountSecuritySettingsMetadata = default(SettingsMetadata), string CanManageAccountSettings = default(string), SettingsMetadata CanManageAccountSettingsMetadata = default(SettingsMetadata), string CanManageAdmins = default(string), SettingsMetadata CanManageAdminsMetadata = default(SettingsMetadata), string CanManageConnect = default(string), SettingsMetadata CanManageConnectMetadata = default(SettingsMetadata), string CanManageDocumentRetention = default(string), SettingsMetadata CanManageDocumentRetentionMetadata = default(SettingsMetadata), string CanManageEnvelopeTransfer = default(string), SettingsMetadata CanManageEnvelopeTransferMetadata = default(SettingsMetadata), string CanManageGroupsButNotUsers = default(string), SettingsMetadata CanManageGroupsButNotUsersMetadata = default(SettingsMetadata), string CanManageJointAgreements = default(string), SettingsMetadata CanManageJointAgreementsMetadata = default(SettingsMetadata), string CanManageReporting = default(string), SettingsMetadata CanManageReportingMetadata = default(SettingsMetadata), string CanManageSharing = default(string), SettingsMetadata CanManageSharingMetadata = default(SettingsMetadata), string CanManageSigningGroups = default(string), SettingsMetadata CanManageSigningGroupsMetadata = default(SettingsMetadata), string CanManageStamps = default(string), SettingsMetadata CanManageStampsMetadata = default(SettingsMetadata), string CanManageUsers = default(string), SettingsMetadata CanManageUsersMetadata = default(SettingsMetadata), string CanViewUsers = default(string))
        {
            this.CanManageAccountSecuritySettings = CanManageAccountSecuritySettings;
            this.CanManageAccountSecuritySettingsMetadata = CanManageAccountSecuritySettingsMetadata;
            this.CanManageAccountSettings = CanManageAccountSettings;
            this.CanManageAccountSettingsMetadata = CanManageAccountSettingsMetadata;
            this.CanManageAdmins = CanManageAdmins;
            this.CanManageAdminsMetadata = CanManageAdminsMetadata;
            this.CanManageConnect = CanManageConnect;
            this.CanManageConnectMetadata = CanManageConnectMetadata;
            this.CanManageDocumentRetention = CanManageDocumentRetention;
            this.CanManageDocumentRetentionMetadata = CanManageDocumentRetentionMetadata;
            this.CanManageEnvelopeTransfer = CanManageEnvelopeTransfer;
            this.CanManageEnvelopeTransferMetadata = CanManageEnvelopeTransferMetadata;
            this.CanManageGroupsButNotUsers = CanManageGroupsButNotUsers;
            this.CanManageGroupsButNotUsersMetadata = CanManageGroupsButNotUsersMetadata;
            this.CanManageJointAgreements = CanManageJointAgreements;
            this.CanManageJointAgreementsMetadata = CanManageJointAgreementsMetadata;
            this.CanManageReporting = CanManageReporting;
            this.CanManageReportingMetadata = CanManageReportingMetadata;
            this.CanManageSharing = CanManageSharing;
            this.CanManageSharingMetadata = CanManageSharingMetadata;
            this.CanManageSigningGroups = CanManageSigningGroups;
            this.CanManageSigningGroupsMetadata = CanManageSigningGroupsMetadata;
            this.CanManageStamps = CanManageStamps;
            this.CanManageStampsMetadata = CanManageStampsMetadata;
            this.CanManageUsers = CanManageUsers;
            this.CanManageUsersMetadata = CanManageUsersMetadata;
            this.CanViewUsers = CanViewUsers;
        }
        
        /// <summary>
        /// Gets or Sets CanManageAccountSecuritySettings
        /// </summary>
        [DataMember(Name="canManageAccountSecuritySettings", EmitDefaultValue=false)]
        public string CanManageAccountSecuritySettings { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAccountSecuritySettingsMetadata
        /// </summary>
        [DataMember(Name="canManageAccountSecuritySettingsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAccountSecuritySettingsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAccountSettings
        /// </summary>
        [DataMember(Name="canManageAccountSettings", EmitDefaultValue=false)]
        public string CanManageAccountSettings { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAccountSettingsMetadata
        /// </summary>
        [DataMember(Name="canManageAccountSettingsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAccountSettingsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageAdmins
        /// </summary>
        [DataMember(Name="canManageAdmins", EmitDefaultValue=false)]
        public string CanManageAdmins { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;canManageAdmins&#x60; property is editable. 
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;canManageAdmins&#x60; property is editable. </value>
        [DataMember(Name="canManageAdminsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageAdminsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageConnect
        /// </summary>
        [DataMember(Name="canManageConnect", EmitDefaultValue=false)]
        public string CanManageConnect { get; set; }
        /// <summary>
        /// Gets or Sets CanManageConnectMetadata
        /// </summary>
        [DataMember(Name="canManageConnectMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageConnectMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageDocumentRetention
        /// </summary>
        [DataMember(Name="canManageDocumentRetention", EmitDefaultValue=false)]
        public string CanManageDocumentRetention { get; set; }
        /// <summary>
        /// Gets or Sets CanManageDocumentRetentionMetadata
        /// </summary>
        [DataMember(Name="canManageDocumentRetentionMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageDocumentRetentionMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageEnvelopeTransfer
        /// </summary>
        [DataMember(Name="canManageEnvelopeTransfer", EmitDefaultValue=false)]
        public string CanManageEnvelopeTransfer { get; set; }
        /// <summary>
        /// Gets or Sets CanManageEnvelopeTransferMetadata
        /// </summary>
        [DataMember(Name="canManageEnvelopeTransferMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageEnvelopeTransferMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageGroupsButNotUsers
        /// </summary>
        [DataMember(Name="canManageGroupsButNotUsers", EmitDefaultValue=false)]
        public string CanManageGroupsButNotUsers { get; set; }
        /// <summary>
        /// Gets or Sets CanManageGroupsButNotUsersMetadata
        /// </summary>
        [DataMember(Name="canManageGroupsButNotUsersMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageGroupsButNotUsersMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageJointAgreements
        /// </summary>
        [DataMember(Name="canManageJointAgreements", EmitDefaultValue=false)]
        public string CanManageJointAgreements { get; set; }
        /// <summary>
        /// Gets or Sets CanManageJointAgreementsMetadata
        /// </summary>
        [DataMember(Name="canManageJointAgreementsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageJointAgreementsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageReporting
        /// </summary>
        [DataMember(Name="canManageReporting", EmitDefaultValue=false)]
        public string CanManageReporting { get; set; }
        /// <summary>
        /// Gets or Sets CanManageReportingMetadata
        /// </summary>
        [DataMember(Name="canManageReportingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageReportingMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSharing
        /// </summary>
        [DataMember(Name="canManageSharing", EmitDefaultValue=false)]
        public string CanManageSharing { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;canManageSharing&#x60; property is editable. 
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;canManageSharing&#x60; property is editable. </value>
        [DataMember(Name="canManageSharingMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageSharingMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSigningGroups
        /// </summary>
        [DataMember(Name="canManageSigningGroups", EmitDefaultValue=false)]
        public string CanManageSigningGroups { get; set; }
        /// <summary>
        /// Gets or Sets CanManageSigningGroupsMetadata
        /// </summary>
        [DataMember(Name="canManageSigningGroupsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageSigningGroupsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageStamps
        /// </summary>
        [DataMember(Name="canManageStamps", EmitDefaultValue=false)]
        public string CanManageStamps { get; set; }
        /// <summary>
        /// Gets or Sets CanManageStampsMetadata
        /// </summary>
        [DataMember(Name="canManageStampsMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageStampsMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanManageUsers
        /// </summary>
        [DataMember(Name="canManageUsers", EmitDefaultValue=false)]
        public string CanManageUsers { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;canManageUsers&#x60; property is editable. 
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;canManageUsers&#x60; property is editable. </value>
        [DataMember(Name="canManageUsersMetadata", EmitDefaultValue=false)]
        public SettingsMetadata CanManageUsersMetadata { get; set; }
        /// <summary>
        /// Gets or Sets CanViewUsers
        /// </summary>
        [DataMember(Name="canViewUsers", EmitDefaultValue=false)]
        public string CanViewUsers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountManagementGranularInformation {\n");
            sb.Append("  CanManageAccountSecuritySettings: ").Append(CanManageAccountSecuritySettings).Append("\n");
            sb.Append("  CanManageAccountSecuritySettingsMetadata: ").Append(CanManageAccountSecuritySettingsMetadata).Append("\n");
            sb.Append("  CanManageAccountSettings: ").Append(CanManageAccountSettings).Append("\n");
            sb.Append("  CanManageAccountSettingsMetadata: ").Append(CanManageAccountSettingsMetadata).Append("\n");
            sb.Append("  CanManageAdmins: ").Append(CanManageAdmins).Append("\n");
            sb.Append("  CanManageAdminsMetadata: ").Append(CanManageAdminsMetadata).Append("\n");
            sb.Append("  CanManageConnect: ").Append(CanManageConnect).Append("\n");
            sb.Append("  CanManageConnectMetadata: ").Append(CanManageConnectMetadata).Append("\n");
            sb.Append("  CanManageDocumentRetention: ").Append(CanManageDocumentRetention).Append("\n");
            sb.Append("  CanManageDocumentRetentionMetadata: ").Append(CanManageDocumentRetentionMetadata).Append("\n");
            sb.Append("  CanManageEnvelopeTransfer: ").Append(CanManageEnvelopeTransfer).Append("\n");
            sb.Append("  CanManageEnvelopeTransferMetadata: ").Append(CanManageEnvelopeTransferMetadata).Append("\n");
            sb.Append("  CanManageGroupsButNotUsers: ").Append(CanManageGroupsButNotUsers).Append("\n");
            sb.Append("  CanManageGroupsButNotUsersMetadata: ").Append(CanManageGroupsButNotUsersMetadata).Append("\n");
            sb.Append("  CanManageJointAgreements: ").Append(CanManageJointAgreements).Append("\n");
            sb.Append("  CanManageJointAgreementsMetadata: ").Append(CanManageJointAgreementsMetadata).Append("\n");
            sb.Append("  CanManageReporting: ").Append(CanManageReporting).Append("\n");
            sb.Append("  CanManageReportingMetadata: ").Append(CanManageReportingMetadata).Append("\n");
            sb.Append("  CanManageSharing: ").Append(CanManageSharing).Append("\n");
            sb.Append("  CanManageSharingMetadata: ").Append(CanManageSharingMetadata).Append("\n");
            sb.Append("  CanManageSigningGroups: ").Append(CanManageSigningGroups).Append("\n");
            sb.Append("  CanManageSigningGroupsMetadata: ").Append(CanManageSigningGroupsMetadata).Append("\n");
            sb.Append("  CanManageStamps: ").Append(CanManageStamps).Append("\n");
            sb.Append("  CanManageStampsMetadata: ").Append(CanManageStampsMetadata).Append("\n");
            sb.Append("  CanManageUsers: ").Append(CanManageUsers).Append("\n");
            sb.Append("  CanManageUsersMetadata: ").Append(CanManageUsersMetadata).Append("\n");
            sb.Append("  CanViewUsers: ").Append(CanViewUsers).Append("\n");
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
            return this.Equals(obj as UserAccountManagementGranularInformation);
        }

        /// <summary>
        /// Returns true if UserAccountManagementGranularInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountManagementGranularInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountManagementGranularInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CanManageAccountSecuritySettings == other.CanManageAccountSecuritySettings ||
                    this.CanManageAccountSecuritySettings != null &&
                    this.CanManageAccountSecuritySettings.Equals(other.CanManageAccountSecuritySettings)
                ) && 
                (
                    this.CanManageAccountSecuritySettingsMetadata == other.CanManageAccountSecuritySettingsMetadata ||
                    this.CanManageAccountSecuritySettingsMetadata != null &&
                    this.CanManageAccountSecuritySettingsMetadata.Equals(other.CanManageAccountSecuritySettingsMetadata)
                ) && 
                (
                    this.CanManageAccountSettings == other.CanManageAccountSettings ||
                    this.CanManageAccountSettings != null &&
                    this.CanManageAccountSettings.Equals(other.CanManageAccountSettings)
                ) && 
                (
                    this.CanManageAccountSettingsMetadata == other.CanManageAccountSettingsMetadata ||
                    this.CanManageAccountSettingsMetadata != null &&
                    this.CanManageAccountSettingsMetadata.Equals(other.CanManageAccountSettingsMetadata)
                ) && 
                (
                    this.CanManageAdmins == other.CanManageAdmins ||
                    this.CanManageAdmins != null &&
                    this.CanManageAdmins.Equals(other.CanManageAdmins)
                ) && 
                (
                    this.CanManageAdminsMetadata == other.CanManageAdminsMetadata ||
                    this.CanManageAdminsMetadata != null &&
                    this.CanManageAdminsMetadata.Equals(other.CanManageAdminsMetadata)
                ) && 
                (
                    this.CanManageConnect == other.CanManageConnect ||
                    this.CanManageConnect != null &&
                    this.CanManageConnect.Equals(other.CanManageConnect)
                ) && 
                (
                    this.CanManageConnectMetadata == other.CanManageConnectMetadata ||
                    this.CanManageConnectMetadata != null &&
                    this.CanManageConnectMetadata.Equals(other.CanManageConnectMetadata)
                ) && 
                (
                    this.CanManageDocumentRetention == other.CanManageDocumentRetention ||
                    this.CanManageDocumentRetention != null &&
                    this.CanManageDocumentRetention.Equals(other.CanManageDocumentRetention)
                ) && 
                (
                    this.CanManageDocumentRetentionMetadata == other.CanManageDocumentRetentionMetadata ||
                    this.CanManageDocumentRetentionMetadata != null &&
                    this.CanManageDocumentRetentionMetadata.Equals(other.CanManageDocumentRetentionMetadata)
                ) && 
                (
                    this.CanManageEnvelopeTransfer == other.CanManageEnvelopeTransfer ||
                    this.CanManageEnvelopeTransfer != null &&
                    this.CanManageEnvelopeTransfer.Equals(other.CanManageEnvelopeTransfer)
                ) && 
                (
                    this.CanManageEnvelopeTransferMetadata == other.CanManageEnvelopeTransferMetadata ||
                    this.CanManageEnvelopeTransferMetadata != null &&
                    this.CanManageEnvelopeTransferMetadata.Equals(other.CanManageEnvelopeTransferMetadata)
                ) && 
                (
                    this.CanManageGroupsButNotUsers == other.CanManageGroupsButNotUsers ||
                    this.CanManageGroupsButNotUsers != null &&
                    this.CanManageGroupsButNotUsers.Equals(other.CanManageGroupsButNotUsers)
                ) && 
                (
                    this.CanManageGroupsButNotUsersMetadata == other.CanManageGroupsButNotUsersMetadata ||
                    this.CanManageGroupsButNotUsersMetadata != null &&
                    this.CanManageGroupsButNotUsersMetadata.Equals(other.CanManageGroupsButNotUsersMetadata)
                ) && 
                (
                    this.CanManageJointAgreements == other.CanManageJointAgreements ||
                    this.CanManageJointAgreements != null &&
                    this.CanManageJointAgreements.Equals(other.CanManageJointAgreements)
                ) && 
                (
                    this.CanManageJointAgreementsMetadata == other.CanManageJointAgreementsMetadata ||
                    this.CanManageJointAgreementsMetadata != null &&
                    this.CanManageJointAgreementsMetadata.Equals(other.CanManageJointAgreementsMetadata)
                ) && 
                (
                    this.CanManageReporting == other.CanManageReporting ||
                    this.CanManageReporting != null &&
                    this.CanManageReporting.Equals(other.CanManageReporting)
                ) && 
                (
                    this.CanManageReportingMetadata == other.CanManageReportingMetadata ||
                    this.CanManageReportingMetadata != null &&
                    this.CanManageReportingMetadata.Equals(other.CanManageReportingMetadata)
                ) && 
                (
                    this.CanManageSharing == other.CanManageSharing ||
                    this.CanManageSharing != null &&
                    this.CanManageSharing.Equals(other.CanManageSharing)
                ) && 
                (
                    this.CanManageSharingMetadata == other.CanManageSharingMetadata ||
                    this.CanManageSharingMetadata != null &&
                    this.CanManageSharingMetadata.Equals(other.CanManageSharingMetadata)
                ) && 
                (
                    this.CanManageSigningGroups == other.CanManageSigningGroups ||
                    this.CanManageSigningGroups != null &&
                    this.CanManageSigningGroups.Equals(other.CanManageSigningGroups)
                ) && 
                (
                    this.CanManageSigningGroupsMetadata == other.CanManageSigningGroupsMetadata ||
                    this.CanManageSigningGroupsMetadata != null &&
                    this.CanManageSigningGroupsMetadata.Equals(other.CanManageSigningGroupsMetadata)
                ) && 
                (
                    this.CanManageStamps == other.CanManageStamps ||
                    this.CanManageStamps != null &&
                    this.CanManageStamps.Equals(other.CanManageStamps)
                ) && 
                (
                    this.CanManageStampsMetadata == other.CanManageStampsMetadata ||
                    this.CanManageStampsMetadata != null &&
                    this.CanManageStampsMetadata.Equals(other.CanManageStampsMetadata)
                ) && 
                (
                    this.CanManageUsers == other.CanManageUsers ||
                    this.CanManageUsers != null &&
                    this.CanManageUsers.Equals(other.CanManageUsers)
                ) && 
                (
                    this.CanManageUsersMetadata == other.CanManageUsersMetadata ||
                    this.CanManageUsersMetadata != null &&
                    this.CanManageUsersMetadata.Equals(other.CanManageUsersMetadata)
                ) && 
                (
                    this.CanViewUsers == other.CanViewUsers ||
                    this.CanViewUsers != null &&
                    this.CanViewUsers.Equals(other.CanViewUsers)
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
                if (this.CanManageAccountSecuritySettings != null)
                    hash = hash * 59 + this.CanManageAccountSecuritySettings.GetHashCode();
                if (this.CanManageAccountSecuritySettingsMetadata != null)
                    hash = hash * 59 + this.CanManageAccountSecuritySettingsMetadata.GetHashCode();
                if (this.CanManageAccountSettings != null)
                    hash = hash * 59 + this.CanManageAccountSettings.GetHashCode();
                if (this.CanManageAccountSettingsMetadata != null)
                    hash = hash * 59 + this.CanManageAccountSettingsMetadata.GetHashCode();
                if (this.CanManageAdmins != null)
                    hash = hash * 59 + this.CanManageAdmins.GetHashCode();
                if (this.CanManageAdminsMetadata != null)
                    hash = hash * 59 + this.CanManageAdminsMetadata.GetHashCode();
                if (this.CanManageConnect != null)
                    hash = hash * 59 + this.CanManageConnect.GetHashCode();
                if (this.CanManageConnectMetadata != null)
                    hash = hash * 59 + this.CanManageConnectMetadata.GetHashCode();
                if (this.CanManageDocumentRetention != null)
                    hash = hash * 59 + this.CanManageDocumentRetention.GetHashCode();
                if (this.CanManageDocumentRetentionMetadata != null)
                    hash = hash * 59 + this.CanManageDocumentRetentionMetadata.GetHashCode();
                if (this.CanManageEnvelopeTransfer != null)
                    hash = hash * 59 + this.CanManageEnvelopeTransfer.GetHashCode();
                if (this.CanManageEnvelopeTransferMetadata != null)
                    hash = hash * 59 + this.CanManageEnvelopeTransferMetadata.GetHashCode();
                if (this.CanManageGroupsButNotUsers != null)
                    hash = hash * 59 + this.CanManageGroupsButNotUsers.GetHashCode();
                if (this.CanManageGroupsButNotUsersMetadata != null)
                    hash = hash * 59 + this.CanManageGroupsButNotUsersMetadata.GetHashCode();
                if (this.CanManageJointAgreements != null)
                    hash = hash * 59 + this.CanManageJointAgreements.GetHashCode();
                if (this.CanManageJointAgreementsMetadata != null)
                    hash = hash * 59 + this.CanManageJointAgreementsMetadata.GetHashCode();
                if (this.CanManageReporting != null)
                    hash = hash * 59 + this.CanManageReporting.GetHashCode();
                if (this.CanManageReportingMetadata != null)
                    hash = hash * 59 + this.CanManageReportingMetadata.GetHashCode();
                if (this.CanManageSharing != null)
                    hash = hash * 59 + this.CanManageSharing.GetHashCode();
                if (this.CanManageSharingMetadata != null)
                    hash = hash * 59 + this.CanManageSharingMetadata.GetHashCode();
                if (this.CanManageSigningGroups != null)
                    hash = hash * 59 + this.CanManageSigningGroups.GetHashCode();
                if (this.CanManageSigningGroupsMetadata != null)
                    hash = hash * 59 + this.CanManageSigningGroupsMetadata.GetHashCode();
                if (this.CanManageStamps != null)
                    hash = hash * 59 + this.CanManageStamps.GetHashCode();
                if (this.CanManageStampsMetadata != null)
                    hash = hash * 59 + this.CanManageStampsMetadata.GetHashCode();
                if (this.CanManageUsers != null)
                    hash = hash * 59 + this.CanManageUsers.GetHashCode();
                if (this.CanManageUsersMetadata != null)
                    hash = hash * 59 + this.CanManageUsersMetadata.GetHashCode();
                if (this.CanViewUsers != null)
                    hash = hash * 59 + this.CanViewUsers.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
