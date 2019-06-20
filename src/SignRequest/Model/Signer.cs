/* 
 * SignRequest API
 *
 * API for SignRequest.com
 *
 * OpenAPI spec version: v1
 * Contact: tech-support@signrequest.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = SignRequest.Client.SwaggerDateConverter;

namespace SignRequest.Model
{
    /// <summary>
    /// Signer
    /// </summary>
    [DataContract]
    public partial class Signer :  IEquatable<Signer>
    {
        /// <summary>
        /// Defines Language
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageEnum
        {
            
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 1,
            
            /// <summary>
            /// Enum EnGb for value: en-gb
            /// </summary>
            [EnumMember(Value = "en-gb")]
            EnGb = 2,
            
            /// <summary>
            /// Enum Nl for value: nl
            /// </summary>
            [EnumMember(Value = "nl")]
            Nl = 3,
            
            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 4,
            
            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 5,
            
            /// <summary>
            /// Enum He for value: he
            /// </summary>
            [EnumMember(Value = "he")]
            He = 6,
            
            /// <summary>
            /// Enum Da for value: da
            /// </summary>
            [EnumMember(Value = "da")]
            Da = 7,
            
            /// <summary>
            /// Enum Fi for value: fi
            /// </summary>
            [EnumMember(Value = "fi")]
            Fi = 8,
            
            /// <summary>
            /// Enum Hu for value: hu
            /// </summary>
            [EnumMember(Value = "hu")]
            Hu = 9,
            
            /// <summary>
            /// Enum It for value: it
            /// </summary>
            [EnumMember(Value = "it")]
            It = 10,
            
            /// <summary>
            /// Enum No for value: no
            /// </summary>
            [EnumMember(Value = "no")]
            No = 11,
            
            /// <summary>
            /// Enum Pl for value: pl
            /// </summary>
            [EnumMember(Value = "pl")]
            Pl = 12,
            
            /// <summary>
            /// Enum Pt for value: pt
            /// </summary>
            [EnumMember(Value = "pt")]
            Pt = 13,
            
            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 14,
            
            /// <summary>
            /// Enum Sv for value: sv
            /// </summary>
            [EnumMember(Value = "sv")]
            Sv = 15,
            
            /// <summary>
            /// Enum Ru for value: ru
            /// </summary>
            [EnumMember(Value = "ru")]
            Ru = 16
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Signer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="needsToSign">needsToSign (default to true).</param>
        /// <param name="approveOnly">approveOnly.</param>
        /// <param name="notifyOnly">notifyOnly.</param>
        /// <param name="inPerson">inPerson.</param>
        /// <param name="order">order.</param>
        /// <param name="language">language.</param>
        /// <param name="forceLanguage">forceLanguage.</param>
        /// <param name="verifyPhoneNumber">verifyPhoneNumber.</param>
        /// <param name="verifyBankAccount">verifyBankAccount.</param>
        /// <param name="embedUrlUserId">embedUrlUserId.</param>
        /// <param name="useStampForApproveOnly">Place an approval stamp on a document when a signer approves a document.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="afterDocument">afterDocument.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="password">Require the signer to enter this password before signing a document. This field is write only..</param>
        public Signer(string email = default(string), string firstName = default(string), string lastName = default(string), bool? needsToSign = true, bool? approveOnly = default(bool?), bool? notifyOnly = default(bool?), bool? inPerson = default(bool?), int? order = default(int?), LanguageEnum? language = default(LanguageEnum?), bool? forceLanguage = default(bool?), string verifyPhoneNumber = default(string), string verifyBankAccount = default(string), string embedUrlUserId = default(string), bool? useStampForApproveOnly = default(bool?), string redirectUrl = default(string), string afterDocument = default(string), List<InlineDocumentSignerIntegrationData> integrations = default(List<InlineDocumentSignerIntegrationData>), string password = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for Signer and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            // use default value if no "needsToSign" provided
            if (needsToSign == null)
            {
                this.NeedsToSign = true;
            }
            else
            {
                this.NeedsToSign = needsToSign;
            }
            this.ApproveOnly = approveOnly;
            this.NotifyOnly = notifyOnly;
            this.InPerson = inPerson;
            this.Order = order;
            this.Language = language;
            this.ForceLanguage = forceLanguage;
            this.VerifyPhoneNumber = verifyPhoneNumber;
            this.VerifyBankAccount = verifyBankAccount;
            this.EmbedUrlUserId = embedUrlUserId;
            this.UseStampForApproveOnly = useStampForApproveOnly;
            this.RedirectUrl = redirectUrl;
            this.AfterDocument = afterDocument;
            this.Integrations = integrations;
            this.Password = password;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets EmailViewed
        /// </summary>
        [DataMember(Name="email_viewed", EmitDefaultValue=false)]
        public bool? EmailViewed { get; private set; }

        /// <summary>
        /// Gets or Sets Viewed
        /// </summary>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public bool? Viewed { get; private set; }

        /// <summary>
        /// Gets or Sets Signed
        /// </summary>
        [DataMember(Name="signed", EmitDefaultValue=false)]
        public bool? Signed { get; private set; }

        /// <summary>
        /// Gets or Sets Downloaded
        /// </summary>
        [DataMember(Name="downloaded", EmitDefaultValue=false)]
        public bool? Downloaded { get; private set; }

        /// <summary>
        /// Gets or Sets SignedOn
        /// </summary>
        [DataMember(Name="signed_on", EmitDefaultValue=false)]
        public DateTime? SignedOn { get; private set; }

        /// <summary>
        /// Gets or Sets NeedsToSign
        /// </summary>
        [DataMember(Name="needs_to_sign", EmitDefaultValue=false)]
        public bool? NeedsToSign { get; set; }

        /// <summary>
        /// Gets or Sets ApproveOnly
        /// </summary>
        [DataMember(Name="approve_only", EmitDefaultValue=false)]
        public bool? ApproveOnly { get; set; }

        /// <summary>
        /// Gets or Sets NotifyOnly
        /// </summary>
        [DataMember(Name="notify_only", EmitDefaultValue=false)]
        public bool? NotifyOnly { get; set; }

        /// <summary>
        /// Gets or Sets InPerson
        /// </summary>
        [DataMember(Name="in_person", EmitDefaultValue=false)]
        public bool? InPerson { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }


        /// <summary>
        /// Gets or Sets ForceLanguage
        /// </summary>
        [DataMember(Name="force_language", EmitDefaultValue=false)]
        public bool? ForceLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Emailed
        /// </summary>
        [DataMember(Name="emailed", EmitDefaultValue=false)]
        public bool? Emailed { get; private set; }

        /// <summary>
        /// Gets or Sets VerifyPhoneNumber
        /// </summary>
        [DataMember(Name="verify_phone_number", EmitDefaultValue=false)]
        public string VerifyPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets VerifyBankAccount
        /// </summary>
        [DataMember(Name="verify_bank_account", EmitDefaultValue=false)]
        public string VerifyBankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Declined
        /// </summary>
        [DataMember(Name="declined", EmitDefaultValue=false)]
        public bool? Declined { get; private set; }

        /// <summary>
        /// Gets or Sets DeclinedOn
        /// </summary>
        [DataMember(Name="declined_on", EmitDefaultValue=false)]
        public DateTime? DeclinedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Forwarded
        /// </summary>
        [DataMember(Name="forwarded", EmitDefaultValue=false)]
        public string Forwarded { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedOn
        /// </summary>
        [DataMember(Name="forwarded_on", EmitDefaultValue=false)]
        public DateTime? ForwardedOn { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedToEmail
        /// </summary>
        [DataMember(Name="forwarded_to_email", EmitDefaultValue=false)]
        public string ForwardedToEmail { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedReason
        /// </summary>
        [DataMember(Name="forwarded_reason", EmitDefaultValue=false)]
        public string ForwardedReason { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or Sets EmbedUrlUserId
        /// </summary>
        [DataMember(Name="embed_url_user_id", EmitDefaultValue=false)]
        public string EmbedUrlUserId { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<SignerInputs> Inputs { get; private set; }

        /// <summary>
        /// Place an approval stamp on a document when a signer approves a document
        /// </summary>
        /// <value>Place an approval stamp on a document when a signer approves a document</value>
        [DataMember(Name="use_stamp_for_approve_only", EmitDefaultValue=false)]
        public bool? UseStampForApproveOnly { get; set; }

        /// <summary>
        /// Gets or Sets EmbedUrl
        /// </summary>
        [DataMember(Name="embed_url", EmitDefaultValue=false)]
        public string EmbedUrl { get; private set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<SignerAttachment> Attachments { get; private set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets AfterDocument
        /// </summary>
        [DataMember(Name="after_document", EmitDefaultValue=false)]
        public string AfterDocument { get; set; }

        /// <summary>
        /// Gets or Sets Integrations
        /// </summary>
        [DataMember(Name="integrations", EmitDefaultValue=false)]
        public List<InlineDocumentSignerIntegrationData> Integrations { get; set; }

        /// <summary>
        /// Require the signer to enter this password before signing a document. This field is write only.
        /// </summary>
        /// <value>Require the signer to enter this password before signing a document. This field is write only.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signer {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailViewed: ").Append(EmailViewed).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  Signed: ").Append(Signed).Append("\n");
            sb.Append("  Downloaded: ").Append(Downloaded).Append("\n");
            sb.Append("  SignedOn: ").Append(SignedOn).Append("\n");
            sb.Append("  NeedsToSign: ").Append(NeedsToSign).Append("\n");
            sb.Append("  ApproveOnly: ").Append(ApproveOnly).Append("\n");
            sb.Append("  NotifyOnly: ").Append(NotifyOnly).Append("\n");
            sb.Append("  InPerson: ").Append(InPerson).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ForceLanguage: ").Append(ForceLanguage).Append("\n");
            sb.Append("  Emailed: ").Append(Emailed).Append("\n");
            sb.Append("  VerifyPhoneNumber: ").Append(VerifyPhoneNumber).Append("\n");
            sb.Append("  VerifyBankAccount: ").Append(VerifyBankAccount).Append("\n");
            sb.Append("  Declined: ").Append(Declined).Append("\n");
            sb.Append("  DeclinedOn: ").Append(DeclinedOn).Append("\n");
            sb.Append("  Forwarded: ").Append(Forwarded).Append("\n");
            sb.Append("  ForwardedOn: ").Append(ForwardedOn).Append("\n");
            sb.Append("  ForwardedToEmail: ").Append(ForwardedToEmail).Append("\n");
            sb.Append("  ForwardedReason: ").Append(ForwardedReason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  EmbedUrlUserId: ").Append(EmbedUrlUserId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  UseStampForApproveOnly: ").Append(UseStampForApproveOnly).Append("\n");
            sb.Append("  EmbedUrl: ").Append(EmbedUrl).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  AfterDocument: ").Append(AfterDocument).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Signer);
        }

        /// <summary>
        /// Returns true if Signer instances are equal
        /// </summary>
        /// <param name="input">Instance of Signer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailViewed == input.EmailViewed ||
                    (this.EmailViewed != null &&
                    this.EmailViewed.Equals(input.EmailViewed))
                ) && 
                (
                    this.Viewed == input.Viewed ||
                    (this.Viewed != null &&
                    this.Viewed.Equals(input.Viewed))
                ) && 
                (
                    this.Signed == input.Signed ||
                    (this.Signed != null &&
                    this.Signed.Equals(input.Signed))
                ) && 
                (
                    this.Downloaded == input.Downloaded ||
                    (this.Downloaded != null &&
                    this.Downloaded.Equals(input.Downloaded))
                ) && 
                (
                    this.SignedOn == input.SignedOn ||
                    (this.SignedOn != null &&
                    this.SignedOn.Equals(input.SignedOn))
                ) && 
                (
                    this.NeedsToSign == input.NeedsToSign ||
                    (this.NeedsToSign != null &&
                    this.NeedsToSign.Equals(input.NeedsToSign))
                ) && 
                (
                    this.ApproveOnly == input.ApproveOnly ||
                    (this.ApproveOnly != null &&
                    this.ApproveOnly.Equals(input.ApproveOnly))
                ) && 
                (
                    this.NotifyOnly == input.NotifyOnly ||
                    (this.NotifyOnly != null &&
                    this.NotifyOnly.Equals(input.NotifyOnly))
                ) && 
                (
                    this.InPerson == input.InPerson ||
                    (this.InPerson != null &&
                    this.InPerson.Equals(input.InPerson))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ForceLanguage == input.ForceLanguage ||
                    (this.ForceLanguage != null &&
                    this.ForceLanguage.Equals(input.ForceLanguage))
                ) && 
                (
                    this.Emailed == input.Emailed ||
                    (this.Emailed != null &&
                    this.Emailed.Equals(input.Emailed))
                ) && 
                (
                    this.VerifyPhoneNumber == input.VerifyPhoneNumber ||
                    (this.VerifyPhoneNumber != null &&
                    this.VerifyPhoneNumber.Equals(input.VerifyPhoneNumber))
                ) && 
                (
                    this.VerifyBankAccount == input.VerifyBankAccount ||
                    (this.VerifyBankAccount != null &&
                    this.VerifyBankAccount.Equals(input.VerifyBankAccount))
                ) && 
                (
                    this.Declined == input.Declined ||
                    (this.Declined != null &&
                    this.Declined.Equals(input.Declined))
                ) && 
                (
                    this.DeclinedOn == input.DeclinedOn ||
                    (this.DeclinedOn != null &&
                    this.DeclinedOn.Equals(input.DeclinedOn))
                ) && 
                (
                    this.Forwarded == input.Forwarded ||
                    (this.Forwarded != null &&
                    this.Forwarded.Equals(input.Forwarded))
                ) && 
                (
                    this.ForwardedOn == input.ForwardedOn ||
                    (this.ForwardedOn != null &&
                    this.ForwardedOn.Equals(input.ForwardedOn))
                ) && 
                (
                    this.ForwardedToEmail == input.ForwardedToEmail ||
                    (this.ForwardedToEmail != null &&
                    this.ForwardedToEmail.Equals(input.ForwardedToEmail))
                ) && 
                (
                    this.ForwardedReason == input.ForwardedReason ||
                    (this.ForwardedReason != null &&
                    this.ForwardedReason.Equals(input.ForwardedReason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.EmbedUrlUserId == input.EmbedUrlUserId ||
                    (this.EmbedUrlUserId != null &&
                    this.EmbedUrlUserId.Equals(input.EmbedUrlUserId))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.UseStampForApproveOnly == input.UseStampForApproveOnly ||
                    (this.UseStampForApproveOnly != null &&
                    this.UseStampForApproveOnly.Equals(input.UseStampForApproveOnly))
                ) && 
                (
                    this.EmbedUrl == input.EmbedUrl ||
                    (this.EmbedUrl != null &&
                    this.EmbedUrl.Equals(input.EmbedUrl))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.AfterDocument == input.AfterDocument ||
                    (this.AfterDocument != null &&
                    this.AfterDocument.Equals(input.AfterDocument))
                ) && 
                (
                    this.Integrations == input.Integrations ||
                    this.Integrations != null &&
                    this.Integrations.SequenceEqual(input.Integrations)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailViewed != null)
                    hashCode = hashCode * 59 + this.EmailViewed.GetHashCode();
                if (this.Viewed != null)
                    hashCode = hashCode * 59 + this.Viewed.GetHashCode();
                if (this.Signed != null)
                    hashCode = hashCode * 59 + this.Signed.GetHashCode();
                if (this.Downloaded != null)
                    hashCode = hashCode * 59 + this.Downloaded.GetHashCode();
                if (this.SignedOn != null)
                    hashCode = hashCode * 59 + this.SignedOn.GetHashCode();
                if (this.NeedsToSign != null)
                    hashCode = hashCode * 59 + this.NeedsToSign.GetHashCode();
                if (this.ApproveOnly != null)
                    hashCode = hashCode * 59 + this.ApproveOnly.GetHashCode();
                if (this.NotifyOnly != null)
                    hashCode = hashCode * 59 + this.NotifyOnly.GetHashCode();
                if (this.InPerson != null)
                    hashCode = hashCode * 59 + this.InPerson.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ForceLanguage != null)
                    hashCode = hashCode * 59 + this.ForceLanguage.GetHashCode();
                if (this.Emailed != null)
                    hashCode = hashCode * 59 + this.Emailed.GetHashCode();
                if (this.VerifyPhoneNumber != null)
                    hashCode = hashCode * 59 + this.VerifyPhoneNumber.GetHashCode();
                if (this.VerifyBankAccount != null)
                    hashCode = hashCode * 59 + this.VerifyBankAccount.GetHashCode();
                if (this.Declined != null)
                    hashCode = hashCode * 59 + this.Declined.GetHashCode();
                if (this.DeclinedOn != null)
                    hashCode = hashCode * 59 + this.DeclinedOn.GetHashCode();
                if (this.Forwarded != null)
                    hashCode = hashCode * 59 + this.Forwarded.GetHashCode();
                if (this.ForwardedOn != null)
                    hashCode = hashCode * 59 + this.ForwardedOn.GetHashCode();
                if (this.ForwardedToEmail != null)
                    hashCode = hashCode * 59 + this.ForwardedToEmail.GetHashCode();
                if (this.ForwardedReason != null)
                    hashCode = hashCode * 59 + this.ForwardedReason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.EmbedUrlUserId != null)
                    hashCode = hashCode * 59 + this.EmbedUrlUserId.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.UseStampForApproveOnly != null)
                    hashCode = hashCode * 59 + this.UseStampForApproveOnly.GetHashCode();
                if (this.EmbedUrl != null)
                    hashCode = hashCode * 59 + this.EmbedUrl.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.AfterDocument != null)
                    hashCode = hashCode * 59 + this.AfterDocument.GetHashCode();
                if (this.Integrations != null)
                    hashCode = hashCode * 59 + this.Integrations.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }

}
