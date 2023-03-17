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
    /// Contains account Information.
    /// </summary>
    [DataContract]
    public partial class AccountInformation :  IEquatable<AccountInformation>, IValidatableObject
    {
        public AccountInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInformation" /> class.
        /// </summary>
        /// <param name="AccountIdGuid">The GUID associated with the account ID..</param>
        /// <param name="AccountName">The name of the current account..</param>
        /// <param name="AccountSettings">The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden..</param>
        /// <param name="AllowTransactionRooms">When set to **true**, the transaction rooms feature exposed through the Workspaces API is enabled..</param>
        /// <param name="BillingPeriodDaysRemaining">Reserved: TBD.</param>
        /// <param name="BillingPeriodEndDate">Reserved: TBD.</param>
        /// <param name="BillingPeriodEnvelopesAllowed">Reserved: TBD.</param>
        /// <param name="BillingPeriodEnvelopesSent">Reserved: TBD.</param>
        /// <param name="BillingPeriodStartDate">Reserved: TBD.</param>
        /// <param name="BillingProfile">Reserved: TBD.</param>
        /// <param name="Brands">Brands.</param>
        /// <param name="CanUpgrade">When set to **true**, specifies that you can upgrade the account through the API..</param>
        /// <param name="ConnectPermission">ConnectPermission.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="CurrentPlanId">Identifies the plan that was used create this account..</param>
        /// <param name="DisplayApplianceStartUrl">DisplayApplianceStartUrl.</param>
        /// <param name="DisplayApplianceUrl">DisplayApplianceUrl.</param>
        /// <param name="DistributorCode">The code that identifies the billing plan groups and plans for the new account..</param>
        /// <param name="DocuSignLandingUrl">DocuSignLandingUrl.</param>
        /// <param name="DssValues">DssValues.</param>
        /// <param name="EnvelopeSendingBlocked">EnvelopeSendingBlocked.</param>
        /// <param name="EnvelopeUnitPrice">EnvelopeUnitPrice.</param>
        /// <param name="ExternalAccountId">ExternalAccountId.</param>
        /// <param name="ForgottenPasswordQuestionsCount"> A complex element that contains up to four Question/Answer pairs for forgotten password information for a user..</param>
        /// <param name="IsDowngrade">IsDowngrade.</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        /// <param name="PlanClassification">Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free..</param>
        /// <param name="PlanEndDate">The date that the current plan will end..</param>
        /// <param name="PlanName">The name of the Billing Plan..</param>
        /// <param name="PlanStartDate">The date that the Account started using the current plan..</param>
        /// <param name="RecipientDomains">RecipientDomains.</param>
        /// <param name="SeatsAllowed">SeatsAllowed.</param>
        /// <param name="SeatsInUse">SeatsInUse.</param>
        /// <param name="Status21CFRPart11">Status21CFRPart11.</param>
        /// <param name="SuspensionDate">SuspensionDate.</param>
        /// <param name="SuspensionStatus">SuspensionStatus.</param>
        /// <param name="UseDisplayAppliance">UseDisplayAppliance.</param>
        public AccountInformation(string AccountIdGuid = default(string), string AccountName = default(string), AccountSettingsInformation AccountSettings = default(AccountSettingsInformation), string AllowTransactionRooms = default(string), string BillingPeriodDaysRemaining = default(string), string BillingPeriodEndDate = default(string), string BillingPeriodEnvelopesAllowed = default(string), string BillingPeriodEnvelopesSent = default(string), string BillingPeriodStartDate = default(string), string BillingProfile = default(string), BrandsResponse Brands = default(BrandsResponse), string CanUpgrade = default(string), string ConnectPermission = default(string), string CreatedDate = default(string), string CurrencyCode = default(string), string CurrentPlanId = default(string), string DisplayApplianceStartUrl = default(string), string DisplayApplianceUrl = default(string), string DistributorCode = default(string), string DocuSignLandingUrl = default(string), Dictionary<string, string> DssValues = default(Dictionary<string, string>), string EnvelopeSendingBlocked = default(string), string EnvelopeUnitPrice = default(string), string ExternalAccountId = default(string), string ForgottenPasswordQuestionsCount = default(string), string IsDowngrade = default(string), string PaymentMethod = default(string), string PlanClassification = default(string), string PlanEndDate = default(string), string PlanName = default(string), string PlanStartDate = default(string), List<RecipientDomain> RecipientDomains = default(List<RecipientDomain>), string SeatsAllowed = default(string), string SeatsInUse = default(string), string Status21CFRPart11 = default(string), string SuspensionDate = default(string), string SuspensionStatus = default(string), bool? UseDisplayAppliance = default(bool?))
        {
            this.AccountIdGuid = AccountIdGuid;
            this.AccountName = AccountName;
            this.AccountSettings = AccountSettings;
            this.AllowTransactionRooms = AllowTransactionRooms;
            this.BillingPeriodDaysRemaining = BillingPeriodDaysRemaining;
            this.BillingPeriodEndDate = BillingPeriodEndDate;
            this.BillingPeriodEnvelopesAllowed = BillingPeriodEnvelopesAllowed;
            this.BillingPeriodEnvelopesSent = BillingPeriodEnvelopesSent;
            this.BillingPeriodStartDate = BillingPeriodStartDate;
            this.BillingProfile = BillingProfile;
            this.Brands = Brands;
            this.CanUpgrade = CanUpgrade;
            this.ConnectPermission = ConnectPermission;
            this.CreatedDate = CreatedDate;
            this.CurrencyCode = CurrencyCode;
            this.CurrentPlanId = CurrentPlanId;
            this.DisplayApplianceStartUrl = DisplayApplianceStartUrl;
            this.DisplayApplianceUrl = DisplayApplianceUrl;
            this.DistributorCode = DistributorCode;
            this.DocuSignLandingUrl = DocuSignLandingUrl;
            this.DssValues = DssValues;
            this.EnvelopeSendingBlocked = EnvelopeSendingBlocked;
            this.EnvelopeUnitPrice = EnvelopeUnitPrice;
            this.ExternalAccountId = ExternalAccountId;
            this.ForgottenPasswordQuestionsCount = ForgottenPasswordQuestionsCount;
            this.IsDowngrade = IsDowngrade;
            this.PaymentMethod = PaymentMethod;
            this.PlanClassification = PlanClassification;
            this.PlanEndDate = PlanEndDate;
            this.PlanName = PlanName;
            this.PlanStartDate = PlanStartDate;
            this.RecipientDomains = RecipientDomains;
            this.SeatsAllowed = SeatsAllowed;
            this.SeatsInUse = SeatsInUse;
            this.Status21CFRPart11 = Status21CFRPart11;
            this.SuspensionDate = SuspensionDate;
            this.SuspensionStatus = SuspensionStatus;
            this.UseDisplayAppliance = UseDisplayAppliance;
        }
        
        /// <summary>
        /// The GUID associated with the account ID.
        /// </summary>
        /// <value>The GUID associated with the account ID.</value>
        [DataMember(Name="accountIdGuid", EmitDefaultValue=false)]
        public string AccountIdGuid { get; set; }
        /// <summary>
        /// The name of the current account.
        /// </summary>
        /// <value>The name of the current account.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.
        /// </summary>
        /// <value>The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.</value>
        [DataMember(Name="accountSettings", EmitDefaultValue=false)]
        public AccountSettingsInformation AccountSettings { get; set; }
        /// <summary>
        /// When set to **true**, the transaction rooms feature exposed through the Workspaces API is enabled.
        /// </summary>
        /// <value>When set to **true**, the transaction rooms feature exposed through the Workspaces API is enabled.</value>
        [DataMember(Name="allowTransactionRooms", EmitDefaultValue=false)]
        public string AllowTransactionRooms { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodDaysRemaining", EmitDefaultValue=false)]
        public string BillingPeriodDaysRemaining { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEndDate", EmitDefaultValue=false)]
        public string BillingPeriodEndDate { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEnvelopesAllowed", EmitDefaultValue=false)]
        public string BillingPeriodEnvelopesAllowed { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodEnvelopesSent", EmitDefaultValue=false)]
        public string BillingPeriodEnvelopesSent { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingPeriodStartDate", EmitDefaultValue=false)]
        public string BillingPeriodStartDate { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="billingProfile", EmitDefaultValue=false)]
        public string BillingProfile { get; set; }
        /// <summary>
        /// Gets or Sets Brands
        /// </summary>
        [DataMember(Name="brands", EmitDefaultValue=false)]
        public BrandsResponse Brands { get; set; }
        /// <summary>
        /// When set to **true**, specifies that you can upgrade the account through the API.
        /// </summary>
        /// <value>When set to **true**, specifies that you can upgrade the account through the API.</value>
        [DataMember(Name="canUpgrade", EmitDefaultValue=false)]
        public string CanUpgrade { get; set; }
        /// <summary>
        /// Gets or Sets ConnectPermission
        /// </summary>
        [DataMember(Name="connectPermission", EmitDefaultValue=false)]
        public string ConnectPermission { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Identifies the plan that was used create this account.
        /// </summary>
        /// <value>Identifies the plan that was used create this account.</value>
        [DataMember(Name="currentPlanId", EmitDefaultValue=false)]
        public string CurrentPlanId { get; set; }
        /// <summary>
        /// Gets or Sets DisplayApplianceStartUrl
        /// </summary>
        [DataMember(Name="displayApplianceStartUrl", EmitDefaultValue=false)]
        public string DisplayApplianceStartUrl { get; set; }
        /// <summary>
        /// Gets or Sets DisplayApplianceUrl
        /// </summary>
        [DataMember(Name="displayApplianceUrl", EmitDefaultValue=false)]
        public string DisplayApplianceUrl { get; set; }
        /// <summary>
        /// The code that identifies the billing plan groups and plans for the new account.
        /// </summary>
        /// <value>The code that identifies the billing plan groups and plans for the new account.</value>
        [DataMember(Name="distributorCode", EmitDefaultValue=false)]
        public string DistributorCode { get; set; }
        /// <summary>
        /// Gets or Sets DocuSignLandingUrl
        /// </summary>
        [DataMember(Name="docuSignLandingUrl", EmitDefaultValue=false)]
        public string DocuSignLandingUrl { get; set; }
        /// <summary>
        /// Gets or Sets DssValues
        /// </summary>
        [DataMember(Name="dssValues", EmitDefaultValue=false)]
        public Dictionary<string, string> DssValues { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeSendingBlocked
        /// </summary>
        [DataMember(Name="envelopeSendingBlocked", EmitDefaultValue=false)]
        public string EnvelopeSendingBlocked { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeUnitPrice
        /// </summary>
        [DataMember(Name="envelopeUnitPrice", EmitDefaultValue=false)]
        public string EnvelopeUnitPrice { get; set; }
        /// <summary>
        /// Gets or Sets ExternalAccountId
        /// </summary>
        [DataMember(Name="externalAccountId", EmitDefaultValue=false)]
        public string ExternalAccountId { get; set; }
        /// <summary>
        ///  A complex element that contains up to four Question/Answer pairs for forgotten password information for a user.
        /// </summary>
        /// <value> A complex element that contains up to four Question/Answer pairs for forgotten password information for a user.</value>
        [DataMember(Name="forgottenPasswordQuestionsCount", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestionsCount { get; set; }
        /// <summary>
        /// Gets or Sets IsDowngrade
        /// </summary>
        [DataMember(Name="isDowngrade", EmitDefaultValue=false)]
        public string IsDowngrade { get; set; }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.
        /// </summary>
        /// <value>Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free.</value>
        [DataMember(Name="planClassification", EmitDefaultValue=false)]
        public string PlanClassification { get; set; }
        /// <summary>
        /// The date that the current plan will end.
        /// </summary>
        /// <value>The date that the current plan will end.</value>
        [DataMember(Name="planEndDate", EmitDefaultValue=false)]
        public string PlanEndDate { get; set; }
        /// <summary>
        /// The name of the Billing Plan.
        /// </summary>
        /// <value>The name of the Billing Plan.</value>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }
        /// <summary>
        /// The date that the Account started using the current plan.
        /// </summary>
        /// <value>The date that the Account started using the current plan.</value>
        [DataMember(Name="planStartDate", EmitDefaultValue=false)]
        public string PlanStartDate { get; set; }
        /// <summary>
        /// Gets or Sets RecipientDomains
        /// </summary>
        [DataMember(Name="recipientDomains", EmitDefaultValue=false)]
        public List<RecipientDomain> RecipientDomains { get; set; }
        /// <summary>
        /// Gets or Sets SeatsAllowed
        /// </summary>
        [DataMember(Name="seatsAllowed", EmitDefaultValue=false)]
        public string SeatsAllowed { get; set; }
        /// <summary>
        /// Gets or Sets SeatsInUse
        /// </summary>
        [DataMember(Name="seatsInUse", EmitDefaultValue=false)]
        public string SeatsInUse { get; set; }
        /// <summary>
        /// Gets or Sets Status21CFRPart11
        /// </summary>
        [DataMember(Name="status21CFRPart11", EmitDefaultValue=false)]
        public string Status21CFRPart11 { get; set; }
        /// <summary>
        /// Gets or Sets SuspensionDate
        /// </summary>
        [DataMember(Name="suspensionDate", EmitDefaultValue=false)]
        public string SuspensionDate { get; set; }
        /// <summary>
        /// Gets or Sets SuspensionStatus
        /// </summary>
        [DataMember(Name="suspensionStatus", EmitDefaultValue=false)]
        public string SuspensionStatus { get; set; }
        /// <summary>
        /// Gets or Sets UseDisplayAppliance
        /// </summary>
        [DataMember(Name="useDisplayAppliance", EmitDefaultValue=false)]
        public bool? UseDisplayAppliance { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInformation {\n");
            sb.Append("  AccountIdGuid: ").Append(AccountIdGuid).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountSettings: ").Append(AccountSettings).Append("\n");
            sb.Append("  AllowTransactionRooms: ").Append(AllowTransactionRooms).Append("\n");
            sb.Append("  BillingPeriodDaysRemaining: ").Append(BillingPeriodDaysRemaining).Append("\n");
            sb.Append("  BillingPeriodEndDate: ").Append(BillingPeriodEndDate).Append("\n");
            sb.Append("  BillingPeriodEnvelopesAllowed: ").Append(BillingPeriodEnvelopesAllowed).Append("\n");
            sb.Append("  BillingPeriodEnvelopesSent: ").Append(BillingPeriodEnvelopesSent).Append("\n");
            sb.Append("  BillingPeriodStartDate: ").Append(BillingPeriodStartDate).Append("\n");
            sb.Append("  BillingProfile: ").Append(BillingProfile).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  CanUpgrade: ").Append(CanUpgrade).Append("\n");
            sb.Append("  ConnectPermission: ").Append(ConnectPermission).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrentPlanId: ").Append(CurrentPlanId).Append("\n");
            sb.Append("  DisplayApplianceStartUrl: ").Append(DisplayApplianceStartUrl).Append("\n");
            sb.Append("  DisplayApplianceUrl: ").Append(DisplayApplianceUrl).Append("\n");
            sb.Append("  DistributorCode: ").Append(DistributorCode).Append("\n");
            sb.Append("  DocuSignLandingUrl: ").Append(DocuSignLandingUrl).Append("\n");
            sb.Append("  DssValues: ").Append(DssValues).Append("\n");
            sb.Append("  EnvelopeSendingBlocked: ").Append(EnvelopeSendingBlocked).Append("\n");
            sb.Append("  EnvelopeUnitPrice: ").Append(EnvelopeUnitPrice).Append("\n");
            sb.Append("  ExternalAccountId: ").Append(ExternalAccountId).Append("\n");
            sb.Append("  ForgottenPasswordQuestionsCount: ").Append(ForgottenPasswordQuestionsCount).Append("\n");
            sb.Append("  IsDowngrade: ").Append(IsDowngrade).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PlanClassification: ").Append(PlanClassification).Append("\n");
            sb.Append("  PlanEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  RecipientDomains: ").Append(RecipientDomains).Append("\n");
            sb.Append("  SeatsAllowed: ").Append(SeatsAllowed).Append("\n");
            sb.Append("  SeatsInUse: ").Append(SeatsInUse).Append("\n");
            sb.Append("  Status21CFRPart11: ").Append(Status21CFRPart11).Append("\n");
            sb.Append("  SuspensionDate: ").Append(SuspensionDate).Append("\n");
            sb.Append("  SuspensionStatus: ").Append(SuspensionStatus).Append("\n");
            sb.Append("  UseDisplayAppliance: ").Append(UseDisplayAppliance).Append("\n");
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
            return this.Equals(obj as AccountInformation);
        }

        /// <summary>
        /// Returns true if AccountInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountIdGuid == other.AccountIdGuid ||
                    this.AccountIdGuid != null &&
                    this.AccountIdGuid.Equals(other.AccountIdGuid)
                ) && 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.AccountSettings == other.AccountSettings ||
                    this.AccountSettings != null &&
                    this.AccountSettings.Equals(other.AccountSettings)
                ) && 
                (
                    this.AllowTransactionRooms == other.AllowTransactionRooms ||
                    this.AllowTransactionRooms != null &&
                    this.AllowTransactionRooms.Equals(other.AllowTransactionRooms)
                ) && 
                (
                    this.BillingPeriodDaysRemaining == other.BillingPeriodDaysRemaining ||
                    this.BillingPeriodDaysRemaining != null &&
                    this.BillingPeriodDaysRemaining.Equals(other.BillingPeriodDaysRemaining)
                ) && 
                (
                    this.BillingPeriodEndDate == other.BillingPeriodEndDate ||
                    this.BillingPeriodEndDate != null &&
                    this.BillingPeriodEndDate.Equals(other.BillingPeriodEndDate)
                ) && 
                (
                    this.BillingPeriodEnvelopesAllowed == other.BillingPeriodEnvelopesAllowed ||
                    this.BillingPeriodEnvelopesAllowed != null &&
                    this.BillingPeriodEnvelopesAllowed.Equals(other.BillingPeriodEnvelopesAllowed)
                ) && 
                (
                    this.BillingPeriodEnvelopesSent == other.BillingPeriodEnvelopesSent ||
                    this.BillingPeriodEnvelopesSent != null &&
                    this.BillingPeriodEnvelopesSent.Equals(other.BillingPeriodEnvelopesSent)
                ) && 
                (
                    this.BillingPeriodStartDate == other.BillingPeriodStartDate ||
                    this.BillingPeriodStartDate != null &&
                    this.BillingPeriodStartDate.Equals(other.BillingPeriodStartDate)
                ) && 
                (
                    this.BillingProfile == other.BillingProfile ||
                    this.BillingProfile != null &&
                    this.BillingProfile.Equals(other.BillingProfile)
                ) && 
                (
                    this.Brands == other.Brands ||
                    this.Brands != null &&
                    this.Brands.Equals(other.Brands)
                ) && 
                (
                    this.CanUpgrade == other.CanUpgrade ||
                    this.CanUpgrade != null &&
                    this.CanUpgrade.Equals(other.CanUpgrade)
                ) && 
                (
                    this.ConnectPermission == other.ConnectPermission ||
                    this.ConnectPermission != null &&
                    this.ConnectPermission.Equals(other.ConnectPermission)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.CurrentPlanId == other.CurrentPlanId ||
                    this.CurrentPlanId != null &&
                    this.CurrentPlanId.Equals(other.CurrentPlanId)
                ) && 
                (
                    this.DisplayApplianceStartUrl == other.DisplayApplianceStartUrl ||
                    this.DisplayApplianceStartUrl != null &&
                    this.DisplayApplianceStartUrl.Equals(other.DisplayApplianceStartUrl)
                ) && 
                (
                    this.DisplayApplianceUrl == other.DisplayApplianceUrl ||
                    this.DisplayApplianceUrl != null &&
                    this.DisplayApplianceUrl.Equals(other.DisplayApplianceUrl)
                ) && 
                (
                    this.DistributorCode == other.DistributorCode ||
                    this.DistributorCode != null &&
                    this.DistributorCode.Equals(other.DistributorCode)
                ) && 
                (
                    this.DocuSignLandingUrl == other.DocuSignLandingUrl ||
                    this.DocuSignLandingUrl != null &&
                    this.DocuSignLandingUrl.Equals(other.DocuSignLandingUrl)
                ) && 
                (
                    this.DssValues == other.DssValues ||
                    this.DssValues != null &&
                    this.DssValues.SequenceEqual(other.DssValues)
                ) && 
                (
                    this.EnvelopeSendingBlocked == other.EnvelopeSendingBlocked ||
                    this.EnvelopeSendingBlocked != null &&
                    this.EnvelopeSendingBlocked.Equals(other.EnvelopeSendingBlocked)
                ) && 
                (
                    this.EnvelopeUnitPrice == other.EnvelopeUnitPrice ||
                    this.EnvelopeUnitPrice != null &&
                    this.EnvelopeUnitPrice.Equals(other.EnvelopeUnitPrice)
                ) && 
                (
                    this.ExternalAccountId == other.ExternalAccountId ||
                    this.ExternalAccountId != null &&
                    this.ExternalAccountId.Equals(other.ExternalAccountId)
                ) && 
                (
                    this.ForgottenPasswordQuestionsCount == other.ForgottenPasswordQuestionsCount ||
                    this.ForgottenPasswordQuestionsCount != null &&
                    this.ForgottenPasswordQuestionsCount.Equals(other.ForgottenPasswordQuestionsCount)
                ) && 
                (
                    this.IsDowngrade == other.IsDowngrade ||
                    this.IsDowngrade != null &&
                    this.IsDowngrade.Equals(other.IsDowngrade)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PlanClassification == other.PlanClassification ||
                    this.PlanClassification != null &&
                    this.PlanClassification.Equals(other.PlanClassification)
                ) && 
                (
                    this.PlanEndDate == other.PlanEndDate ||
                    this.PlanEndDate != null &&
                    this.PlanEndDate.Equals(other.PlanEndDate)
                ) && 
                (
                    this.PlanName == other.PlanName ||
                    this.PlanName != null &&
                    this.PlanName.Equals(other.PlanName)
                ) && 
                (
                    this.PlanStartDate == other.PlanStartDate ||
                    this.PlanStartDate != null &&
                    this.PlanStartDate.Equals(other.PlanStartDate)
                ) && 
                (
                    this.RecipientDomains == other.RecipientDomains ||
                    this.RecipientDomains != null &&
                    this.RecipientDomains.SequenceEqual(other.RecipientDomains)
                ) && 
                (
                    this.SeatsAllowed == other.SeatsAllowed ||
                    this.SeatsAllowed != null &&
                    this.SeatsAllowed.Equals(other.SeatsAllowed)
                ) && 
                (
                    this.SeatsInUse == other.SeatsInUse ||
                    this.SeatsInUse != null &&
                    this.SeatsInUse.Equals(other.SeatsInUse)
                ) && 
                (
                    this.Status21CFRPart11 == other.Status21CFRPart11 ||
                    this.Status21CFRPart11 != null &&
                    this.Status21CFRPart11.Equals(other.Status21CFRPart11)
                ) && 
                (
                    this.SuspensionDate == other.SuspensionDate ||
                    this.SuspensionDate != null &&
                    this.SuspensionDate.Equals(other.SuspensionDate)
                ) && 
                (
                    this.SuspensionStatus == other.SuspensionStatus ||
                    this.SuspensionStatus != null &&
                    this.SuspensionStatus.Equals(other.SuspensionStatus)
                ) && 
                (
                    this.UseDisplayAppliance == other.UseDisplayAppliance ||
                    this.UseDisplayAppliance != null &&
                    this.UseDisplayAppliance.Equals(other.UseDisplayAppliance)
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
                if (this.AccountIdGuid != null)
                    hash = hash * 59 + this.AccountIdGuid.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.AccountSettings != null)
                    hash = hash * 59 + this.AccountSettings.GetHashCode();
                if (this.AllowTransactionRooms != null)
                    hash = hash * 59 + this.AllowTransactionRooms.GetHashCode();
                if (this.BillingPeriodDaysRemaining != null)
                    hash = hash * 59 + this.BillingPeriodDaysRemaining.GetHashCode();
                if (this.BillingPeriodEndDate != null)
                    hash = hash * 59 + this.BillingPeriodEndDate.GetHashCode();
                if (this.BillingPeriodEnvelopesAllowed != null)
                    hash = hash * 59 + this.BillingPeriodEnvelopesAllowed.GetHashCode();
                if (this.BillingPeriodEnvelopesSent != null)
                    hash = hash * 59 + this.BillingPeriodEnvelopesSent.GetHashCode();
                if (this.BillingPeriodStartDate != null)
                    hash = hash * 59 + this.BillingPeriodStartDate.GetHashCode();
                if (this.BillingProfile != null)
                    hash = hash * 59 + this.BillingProfile.GetHashCode();
                if (this.Brands != null)
                    hash = hash * 59 + this.Brands.GetHashCode();
                if (this.CanUpgrade != null)
                    hash = hash * 59 + this.CanUpgrade.GetHashCode();
                if (this.ConnectPermission != null)
                    hash = hash * 59 + this.ConnectPermission.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrentPlanId != null)
                    hash = hash * 59 + this.CurrentPlanId.GetHashCode();
                if (this.DisplayApplianceStartUrl != null)
                    hash = hash * 59 + this.DisplayApplianceStartUrl.GetHashCode();
                if (this.DisplayApplianceUrl != null)
                    hash = hash * 59 + this.DisplayApplianceUrl.GetHashCode();
                if (this.DistributorCode != null)
                    hash = hash * 59 + this.DistributorCode.GetHashCode();
                if (this.DocuSignLandingUrl != null)
                    hash = hash * 59 + this.DocuSignLandingUrl.GetHashCode();
                if (this.DssValues != null)
                    hash = hash * 59 + this.DssValues.GetHashCode();
                if (this.EnvelopeSendingBlocked != null)
                    hash = hash * 59 + this.EnvelopeSendingBlocked.GetHashCode();
                if (this.EnvelopeUnitPrice != null)
                    hash = hash * 59 + this.EnvelopeUnitPrice.GetHashCode();
                if (this.ExternalAccountId != null)
                    hash = hash * 59 + this.ExternalAccountId.GetHashCode();
                if (this.ForgottenPasswordQuestionsCount != null)
                    hash = hash * 59 + this.ForgottenPasswordQuestionsCount.GetHashCode();
                if (this.IsDowngrade != null)
                    hash = hash * 59 + this.IsDowngrade.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.PlanClassification != null)
                    hash = hash * 59 + this.PlanClassification.GetHashCode();
                if (this.PlanEndDate != null)
                    hash = hash * 59 + this.PlanEndDate.GetHashCode();
                if (this.PlanName != null)
                    hash = hash * 59 + this.PlanName.GetHashCode();
                if (this.PlanStartDate != null)
                    hash = hash * 59 + this.PlanStartDate.GetHashCode();
                if (this.RecipientDomains != null)
                    hash = hash * 59 + this.RecipientDomains.GetHashCode();
                if (this.SeatsAllowed != null)
                    hash = hash * 59 + this.SeatsAllowed.GetHashCode();
                if (this.SeatsInUse != null)
                    hash = hash * 59 + this.SeatsInUse.GetHashCode();
                if (this.Status21CFRPart11 != null)
                    hash = hash * 59 + this.Status21CFRPart11.GetHashCode();
                if (this.SuspensionDate != null)
                    hash = hash * 59 + this.SuspensionDate.GetHashCode();
                if (this.SuspensionStatus != null)
                    hash = hash * 59 + this.SuspensionStatus.GetHashCode();
                if (this.UseDisplayAppliance != null)
                    hash = hash * 59 + this.UseDisplayAppliance.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
