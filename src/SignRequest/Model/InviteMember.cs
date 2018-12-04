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
    /// InviteMember
    /// </summary>
    [DataContract]
    public partial class InviteMember :  IEquatable<InviteMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteMember() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteMember" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="isAdmin">isAdmin (default to false).</param>
        /// <param name="isOwner">isOwner (default to false).</param>
        public InviteMember(string email = default(string), bool? isAdmin = false, bool? isOwner = false)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for InviteMember and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // use default value if no "isAdmin" provided
            if (isAdmin == null)
            {
                this.IsAdmin = false;
            }
            else
            {
                this.IsAdmin = isAdmin;
            }
            // use default value if no "isOwner" provided
            if (isOwner == null)
            {
                this.IsOwner = false;
            }
            else
            {
                this.IsOwner = isOwner;
            }
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="is_admin", EmitDefaultValue=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="is_owner", EmitDefaultValue=false)]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteMember {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
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
            return this.Equals(input as InviteMember);
        }

        /// <summary>
        /// Returns true if InviteMember instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteMember input)
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
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.IsOwner == input.IsOwner ||
                    (this.IsOwner != null &&
                    this.IsOwner.Equals(input.IsOwner))
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
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.IsOwner != null)
                    hashCode = hashCode * 59 + this.IsOwner.GetHashCode();
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
            // Email (string) minLength
            if(this.Email != null && this.Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            yield break;
        }
    }

}
