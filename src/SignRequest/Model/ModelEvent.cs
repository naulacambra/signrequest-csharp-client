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
    /// ModelEvent
    /// </summary>
    [DataContract]
    public partial class ModelEvent :  IEquatable<ModelEvent>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Ok for value: ok
            /// </summary>
            [EnumMember(Value = "ok")]
            Ok = 1,
            
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 2
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum Converterror for value: convert_error
            /// </summary>
            [EnumMember(Value = "convert_error")]
            Converterror = 1,
            
            /// <summary>
            /// Enum Converted for value: converted
            /// </summary>
            [EnumMember(Value = "converted")]
            Converted = 2,
            
            /// <summary>
            /// Enum Sendingerror for value: sending_error
            /// </summary>
            [EnumMember(Value = "sending_error")]
            Sendingerror = 3,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 4,
            
            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 5,
            
            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 6,
            
            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 7,
            
            /// <summary>
            /// Enum Signed for value: signed
            /// </summary>
            [EnumMember(Value = "signed")]
            Signed = 8,
            
            /// <summary>
            /// Enum Viewed for value: viewed
            /// </summary>
            [EnumMember(Value = "viewed")]
            Viewed = 9,
            
            /// <summary>
            /// Enum Downloaded for value: downloaded
            /// </summary>
            [EnumMember(Value = "downloaded")]
            Downloaded = 10,
            
            /// <summary>
            /// Enum Signersigned for value: signer_signed
            /// </summary>
            [EnumMember(Value = "signer_signed")]
            Signersigned = 11,
            
            /// <summary>
            /// Enum Signeremailbounced for value: signer_email_bounced
            /// </summary>
            [EnumMember(Value = "signer_email_bounced")]
            Signeremailbounced = 12,
            
            /// <summary>
            /// Enum Signerviewedemail for value: signer_viewed_email
            /// </summary>
            [EnumMember(Value = "signer_viewed_email")]
            Signerviewedemail = 13,
            
            /// <summary>
            /// Enum Signerviewed for value: signer_viewed
            /// </summary>
            [EnumMember(Value = "signer_viewed")]
            Signerviewed = 14,
            
            /// <summary>
            /// Enum Signerforwarded for value: signer_forwarded
            /// </summary>
            [EnumMember(Value = "signer_forwarded")]
            Signerforwarded = 15,
            
            /// <summary>
            /// Enum Signerdownloaded for value: signer_downloaded
            /// </summary>
            [EnumMember(Value = "signer_downloaded")]
            Signerdownloaded = 16,
            
            /// <summary>
            /// Enum Signrequestreceived for value: signrequest_received
            /// </summary>
            [EnumMember(Value = "signrequest_received")]
            Signrequestreceived = 17
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEvent" /> class.
        /// </summary>
        /// <param name="Team">Team.</param>
        /// <param name="Document">Document.</param>
        /// <param name="Signer">Signer.</param>
        public ModelEvent(DocumentTeam Team = default(DocumentTeam), Document Document = default(Document), Signer Signer = default(Signer))
        {
            this.Team = Team;
            this.Document = Document;
            this.Signer = Signer;
        }
        
        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }



        /// <summary>
        /// Gets or Sets Delivered
        /// </summary>
        [DataMember(Name="delivered", EmitDefaultValue=false)]
        public bool? Delivered { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveredOn
        /// </summary>
        [DataMember(Name="delivered_on", EmitDefaultValue=false)]
        public DateTime? DeliveredOn { get; private set; }

        /// <summary>
        /// Gets or Sets CallbackStatusCode
        /// </summary>
        [DataMember(Name="callback_status_code", EmitDefaultValue=false)]
        public int? CallbackStatusCode { get; private set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; private set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public DocumentTeam Team { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }

        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name="signer", EmitDefaultValue=false)]
        public Signer Signer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelEvent {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  DeliveredOn: ").Append(DeliveredOn).Append("\n");
            sb.Append("  CallbackStatusCode: ").Append(CallbackStatusCode).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
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
            return this.Equals(input as ModelEvent);
        }

        /// <summary>
        /// Returns true if ModelEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    (this.Delivered != null &&
                    this.Delivered.Equals(input.Delivered))
                ) && 
                (
                    this.DeliveredOn == input.DeliveredOn ||
                    (this.DeliveredOn != null &&
                    this.DeliveredOn.Equals(input.DeliveredOn))
                ) && 
                (
                    this.CallbackStatusCode == input.CallbackStatusCode ||
                    (this.CallbackStatusCode != null &&
                    this.CallbackStatusCode.Equals(input.CallbackStatusCode))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Signer == input.Signer ||
                    (this.Signer != null &&
                    this.Signer.Equals(input.Signer))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Delivered != null)
                    hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                if (this.DeliveredOn != null)
                    hashCode = hashCode * 59 + this.DeliveredOn.GetHashCode();
                if (this.CallbackStatusCode != null)
                    hashCode = hashCode * 59 + this.CallbackStatusCode.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Signer != null)
                    hashCode = hashCode * 59 + this.Signer.GetHashCode();
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
            // Uuid (string) minLength
            if(this.Uuid != null && this.Uuid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uuid, length must be greater than 1.", new [] { "Uuid" });
            }

            yield break;
        }
    }

}
