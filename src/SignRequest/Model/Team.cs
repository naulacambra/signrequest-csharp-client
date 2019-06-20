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
    /// Team
    /// </summary>
    [DataContract]
    public partial class Team :  IEquatable<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Team() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="subdomain">subdomain (required).</param>
        /// <param name="phone">phone.</param>
        /// <param name="primaryColor">primaryColor.</param>
        /// <param name="eventsCallbackUrl">eventsCallbackUrl.</param>
        public Team(string name = default(string), string subdomain = default(string), string phone = default(string), string primaryColor = default(string), string eventsCallbackUrl = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Team and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "subdomain" is required (not null)
            if (subdomain == null)
            {
                throw new InvalidDataException("subdomain is a required property for Team and cannot be null");
            }
            else
            {
                this.Subdomain = subdomain;
            }
            this.Phone = phone;
            this.PrimaryColor = primaryColor;
            this.EventsCallbackUrl = eventsCallbackUrl;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Subdomain
        /// </summary>
        [DataMember(Name="subdomain", EmitDefaultValue=false)]
        public string Subdomain { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; private set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryColor
        /// </summary>
        [DataMember(Name="primary_color", EmitDefaultValue=false)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Gets or Sets EventsCallbackUrl
        /// </summary>
        [DataMember(Name="events_callback_url", EmitDefaultValue=false)]
        public string EventsCallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<InlineTeamMember> Members { get; private set; }

        /// <summary>
        /// When filled this team will be deleted after this date
        /// </summary>
        /// <value>When filled this team will be deleted after this date</value>
        [DataMember(Name="delete_after", EmitDefaultValue=false)]
        public DateTime? DeleteAfter { get; private set; }

        /// <summary>
        /// Indicates whether team is in Sandbox mode
        /// </summary>
        /// <value>Indicates whether team is in Sandbox mode</value>
        [DataMember(Name="sandbox", EmitDefaultValue=false)]
        public bool? Sandbox { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subdomain: ").Append(Subdomain).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  EventsCallbackUrl: ").Append(EventsCallbackUrl).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  Sandbox: ").Append(Sandbox).Append("\n");
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
            return this.Equals(input as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="input">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Subdomain == input.Subdomain ||
                    (this.Subdomain != null &&
                    this.Subdomain.Equals(input.Subdomain))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PrimaryColor == input.PrimaryColor ||
                    (this.PrimaryColor != null &&
                    this.PrimaryColor.Equals(input.PrimaryColor))
                ) && 
                (
                    this.EventsCallbackUrl == input.EventsCallbackUrl ||
                    (this.EventsCallbackUrl != null &&
                    this.EventsCallbackUrl.Equals(input.EventsCallbackUrl))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.DeleteAfter == input.DeleteAfter ||
                    (this.DeleteAfter != null &&
                    this.DeleteAfter.Equals(input.DeleteAfter))
                ) && 
                (
                    this.Sandbox == input.Sandbox ||
                    (this.Sandbox != null &&
                    this.Sandbox.Equals(input.Sandbox))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subdomain != null)
                    hashCode = hashCode * 59 + this.Subdomain.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PrimaryColor != null)
                    hashCode = hashCode * 59 + this.PrimaryColor.GetHashCode();
                if (this.EventsCallbackUrl != null)
                    hashCode = hashCode * 59 + this.EventsCallbackUrl.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.DeleteAfter != null)
                    hashCode = hashCode * 59 + this.DeleteAfter.GetHashCode();
                if (this.Sandbox != null)
                    hashCode = hashCode * 59 + this.Sandbox.GetHashCode();
                return hashCode;
            }
        }
    }

}
