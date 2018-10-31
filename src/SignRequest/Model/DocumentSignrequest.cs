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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = SignRequest.Client.SwaggerDateConverter;

namespace SignRequest.Model
{
    /// <summary>
    /// DocumentSignrequest
    /// </summary>
    [DataContract]
    public partial class DocumentSignrequest :  IEquatable<DocumentSignrequest>, IValidatableObject
    {
        /// <summary>
        /// &#x60;m&#x60;: only me, &#x60;mo&#x60;: me and others, &#x60;o&#x60;: only others
        /// </summary>
        /// <value>&#x60;m&#x60;: only me, &#x60;mo&#x60;: me and others, &#x60;o&#x60;: only others</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WhoEnum
        {
            
            /// <summary>
            /// Enum M for value: m
            /// </summary>
            [EnumMember(Value = "m")]
            M = 1,
            
            /// <summary>
            /// Enum Mo for value: mo
            /// </summary>
            [EnumMember(Value = "mo")]
            Mo = 2,
            
            /// <summary>
            /// Enum O for value: o
            /// </summary>
            [EnumMember(Value = "o")]
            O = 3
        }

        /// <summary>
        /// &#x60;m&#x60;: only me, &#x60;mo&#x60;: me and others, &#x60;o&#x60;: only others
        /// </summary>
        /// <value>&#x60;m&#x60;: only me, &#x60;mo&#x60;: me and others, &#x60;o&#x60;: only others</value>
        [DataMember(Name="who", EmitDefaultValue=false)]
        public WhoEnum? Who { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSignrequest" /> class.
        /// </summary>
        /// <param name="RequiredAttachments">RequiredAttachments.</param>
        /// <param name="Signers">Signers.</param>
        public DocumentSignrequest(List<RequiredAttachment> RequiredAttachments = default(List<RequiredAttachment>), List<Signer> Signers = default(List<Signer>))
        {
            this.RequiredAttachments = RequiredAttachments;
            this.Signers = Signers;
        }
        
        /// <summary>
        /// Email of user sending the SignRequest (must be a validated email)
        /// </summary>
        /// <value>Email of user sending the SignRequest (must be a validated email)</value>
        [DataMember(Name="from_email", EmitDefaultValue=false)]
        public string FromEmail { get; private set; }

        /// <summary>
        /// Name to be used in the &#x60;From&#x60; email header, e.g. &#x60;{from_email_name} &lt;no-reply@signrequest.com&gt;&#x60;
        /// </summary>
        /// <value>Name to be used in the &#x60;From&#x60; email header, e.g. &#x60;{from_email_name} &lt;no-reply@signrequest.com&gt;&#x60;</value>
        [DataMember(Name="from_email_name", EmitDefaultValue=false)]
        public string FromEmailName { get; private set; }

        /// <summary>
        /// Have the sender of a SignRequest prepare the document before sending the request out, see: [prepare using the web interface](#section/Preparing-a-document/Prepare-using-the-web-interface)
        /// </summary>
        /// <value>Have the sender of a SignRequest prepare the document before sending the request out, see: [prepare using the web interface](#section/Preparing-a-document/Prepare-using-the-web-interface)</value>
        [DataMember(Name="is_being_prepared", EmitDefaultValue=false)]
        public bool? IsBeingPrepared { get; private set; }

        /// <summary>
        /// Gets or Sets PrepareUrl
        /// </summary>
        [DataMember(Name="prepare_url", EmitDefaultValue=false)]
        public string PrepareUrl { get; private set; }

        /// <summary>
        /// URL at which SignRequest will redirect to when a document is signed
        /// </summary>
        /// <value>URL at which SignRequest will redirect to when a document is signed</value>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; private set; }

        /// <summary>
        /// Gets or Sets RequiredAttachments
        /// </summary>
        [DataMember(Name="required_attachments", EmitDefaultValue=false)]
        public List<RequiredAttachment> RequiredAttachments { get; set; }

        /// <summary>
        /// Disable uploading/adding of attachments
        /// </summary>
        /// <value>Disable uploading/adding of attachments</value>
        [DataMember(Name="disable_attachments", EmitDefaultValue=false)]
        public bool? DisableAttachments { get; private set; }

        /// <summary>
        /// Disable usage of signatures generated by typing (text)
        /// </summary>
        /// <value>Disable usage of signatures generated by typing (text)</value>
        [DataMember(Name="disable_text_signatures", EmitDefaultValue=false)]
        public bool? DisableTextSignatures { get; private set; }

        /// <summary>
        /// Disable adding of text
        /// </summary>
        /// <value>Disable adding of text</value>
        [DataMember(Name="disable_text", EmitDefaultValue=false)]
        public bool? DisableText { get; private set; }

        /// <summary>
        /// Disable adding of dates
        /// </summary>
        /// <value>Disable adding of dates</value>
        [DataMember(Name="disable_date", EmitDefaultValue=false)]
        public bool? DisableDate { get; private set; }

        /// <summary>
        /// Disable all SignRequest status emails as well as the email that contains the signed documents
        /// </summary>
        /// <value>Disable all SignRequest status emails as well as the email that contains the signed documents</value>
        [DataMember(Name="disable_emails", EmitDefaultValue=false)]
        public bool? DisableEmails { get; private set; }

        /// <summary>
        /// Disable usage of uploaded signatures (images)
        /// </summary>
        /// <value>Disable usage of uploaded signatures (images)</value>
        [DataMember(Name="disable_upload_signatures", EmitDefaultValue=false)]
        public bool? DisableUploadSignatures { get; private set; }

        /// <summary>
        /// Subject of SignRequest email
        /// </summary>
        /// <value>Subject of SignRequest email</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; private set; }

        /// <summary>
        /// Message to include in SignRequest email, may contain the following html tags: &#x60;a&#x60;, &#x60;abbr&#x60;, &#x60;acronym&#x60;, &#x60;b&#x60;, &#x60;blockquote&#x60;, &#x60;code&#x60;, &#x60;em&#x60;, &#x60;i&#x60;, &#x60;ul&#x60;, &#x60;li&#x60;, &#x60;ol&#x60;, and &#x60;strong&#x60;
        /// </summary>
        /// <value>Message to include in SignRequest email, may contain the following html tags: &#x60;a&#x60;, &#x60;abbr&#x60;, &#x60;acronym&#x60;, &#x60;b&#x60;, &#x60;blockquote&#x60;, &#x60;code&#x60;, &#x60;em&#x60;, &#x60;i&#x60;, &#x60;ul&#x60;, &#x60;li&#x60;, &#x60;ol&#x60;, and &#x60;strong&#x60;</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }


        /// <summary>
        /// Automatically remind signers to sign a document
        /// </summary>
        /// <value>Automatically remind signers to sign a document</value>
        [DataMember(Name="send_reminders", EmitDefaultValue=false)]
        public bool? SendReminders { get; private set; }

        /// <summary>
        /// Gets or Sets Signers
        /// </summary>
        [DataMember(Name="signers", EmitDefaultValue=false)]
        public List<Signer> Signers { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSignrequest {\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
            sb.Append("  FromEmailName: ").Append(FromEmailName).Append("\n");
            sb.Append("  IsBeingPrepared: ").Append(IsBeingPrepared).Append("\n");
            sb.Append("  PrepareUrl: ").Append(PrepareUrl).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  RequiredAttachments: ").Append(RequiredAttachments).Append("\n");
            sb.Append("  DisableAttachments: ").Append(DisableAttachments).Append("\n");
            sb.Append("  DisableTextSignatures: ").Append(DisableTextSignatures).Append("\n");
            sb.Append("  DisableText: ").Append(DisableText).Append("\n");
            sb.Append("  DisableDate: ").Append(DisableDate).Append("\n");
            sb.Append("  DisableEmails: ").Append(DisableEmails).Append("\n");
            sb.Append("  DisableUploadSignatures: ").Append(DisableUploadSignatures).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Who: ").Append(Who).Append("\n");
            sb.Append("  SendReminders: ").Append(SendReminders).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentSignrequest);
        }

        /// <summary>
        /// Returns true if DocumentSignrequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentSignrequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSignrequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
                ) && 
                (
                    this.FromEmailName == input.FromEmailName ||
                    (this.FromEmailName != null &&
                    this.FromEmailName.Equals(input.FromEmailName))
                ) && 
                (
                    this.IsBeingPrepared == input.IsBeingPrepared ||
                    (this.IsBeingPrepared != null &&
                    this.IsBeingPrepared.Equals(input.IsBeingPrepared))
                ) && 
                (
                    this.PrepareUrl == input.PrepareUrl ||
                    (this.PrepareUrl != null &&
                    this.PrepareUrl.Equals(input.PrepareUrl))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.RequiredAttachments == input.RequiredAttachments ||
                    this.RequiredAttachments != null &&
                    this.RequiredAttachments.SequenceEqual(input.RequiredAttachments)
                ) && 
                (
                    this.DisableAttachments == input.DisableAttachments ||
                    (this.DisableAttachments != null &&
                    this.DisableAttachments.Equals(input.DisableAttachments))
                ) && 
                (
                    this.DisableTextSignatures == input.DisableTextSignatures ||
                    (this.DisableTextSignatures != null &&
                    this.DisableTextSignatures.Equals(input.DisableTextSignatures))
                ) && 
                (
                    this.DisableText == input.DisableText ||
                    (this.DisableText != null &&
                    this.DisableText.Equals(input.DisableText))
                ) && 
                (
                    this.DisableDate == input.DisableDate ||
                    (this.DisableDate != null &&
                    this.DisableDate.Equals(input.DisableDate))
                ) && 
                (
                    this.DisableEmails == input.DisableEmails ||
                    (this.DisableEmails != null &&
                    this.DisableEmails.Equals(input.DisableEmails))
                ) && 
                (
                    this.DisableUploadSignatures == input.DisableUploadSignatures ||
                    (this.DisableUploadSignatures != null &&
                    this.DisableUploadSignatures.Equals(input.DisableUploadSignatures))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Who == input.Who ||
                    (this.Who != null &&
                    this.Who.Equals(input.Who))
                ) && 
                (
                    this.SendReminders == input.SendReminders ||
                    (this.SendReminders != null &&
                    this.SendReminders.Equals(input.SendReminders))
                ) && 
                (
                    this.Signers == input.Signers ||
                    this.Signers != null &&
                    this.Signers.SequenceEqual(input.Signers)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.FromEmail != null)
                    hashCode = hashCode * 59 + this.FromEmail.GetHashCode();
                if (this.FromEmailName != null)
                    hashCode = hashCode * 59 + this.FromEmailName.GetHashCode();
                if (this.IsBeingPrepared != null)
                    hashCode = hashCode * 59 + this.IsBeingPrepared.GetHashCode();
                if (this.PrepareUrl != null)
                    hashCode = hashCode * 59 + this.PrepareUrl.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.RequiredAttachments != null)
                    hashCode = hashCode * 59 + this.RequiredAttachments.GetHashCode();
                if (this.DisableAttachments != null)
                    hashCode = hashCode * 59 + this.DisableAttachments.GetHashCode();
                if (this.DisableTextSignatures != null)
                    hashCode = hashCode * 59 + this.DisableTextSignatures.GetHashCode();
                if (this.DisableText != null)
                    hashCode = hashCode * 59 + this.DisableText.GetHashCode();
                if (this.DisableDate != null)
                    hashCode = hashCode * 59 + this.DisableDate.GetHashCode();
                if (this.DisableEmails != null)
                    hashCode = hashCode * 59 + this.DisableEmails.GetHashCode();
                if (this.DisableUploadSignatures != null)
                    hashCode = hashCode * 59 + this.DisableUploadSignatures.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Who != null)
                    hashCode = hashCode * 59 + this.Who.GetHashCode();
                if (this.SendReminders != null)
                    hashCode = hashCode * 59 + this.SendReminders.GetHashCode();
                if (this.Signers != null)
                    hashCode = hashCode * 59 + this.Signers.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // FromEmail (string) minLength
            if(this.FromEmail != null && this.FromEmail.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromEmail, length must be greater than 1.", new [] { "FromEmail" });
            }

            // FromEmailName (string) minLength
            if(this.FromEmailName != null && this.FromEmailName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromEmailName, length must be greater than 1.", new [] { "FromEmailName" });
            }

            // PrepareUrl (string) minLength
            if(this.PrepareUrl != null && this.PrepareUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrepareUrl, length must be greater than 1.", new [] { "PrepareUrl" });
            }

            // RedirectUrl (string) minLength
            if(this.RedirectUrl != null && this.RedirectUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RedirectUrl, length must be greater than 1.", new [] { "RedirectUrl" });
            }

            // Subject (string) minLength
            if(this.Subject != null && this.Subject.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be greater than 1.", new [] { "Subject" });
            }

            // Message (string) minLength
            if(this.Message != null && this.Message.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 1.", new [] { "Message" });
            }

            // Uuid (string) minLength
            if(this.Uuid != null && this.Uuid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uuid, length must be greater than 1.", new [] { "Uuid" });
            }

            yield break;
        }
    }

}
