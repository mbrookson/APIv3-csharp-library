/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
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
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetExtendedContactDetails
    /// </summary>
    [DataContract]
    public partial class GetExtendedContactDetails :  IEquatable<GetExtendedContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedContactDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetails" /> class.
        /// </summary>
        /// <param name="email">Email address of the contact for which you requested the details (required).</param>
        /// <param name="id">ID of the contact for which you requested the details (required).</param>
        /// <param name="emailBlacklisted">Blacklist status for email campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted) (required).</param>
        /// <param name="smsBlacklisted">Blacklist status for SMS campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted) (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">Last modification UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="listIds">listIds (required).</param>
        /// <param name="listUnsubscribed">listUnsubscribed.</param>
        /// <param name="attributes">Set of attributes of the contact (required).</param>
        /// <param name="statistics">statistics (required).</param>
        public GetExtendedContactDetails(string email = default(string), long? id = default(long?), bool? emailBlacklisted = default(bool?), bool? smsBlacklisted = default(bool?), DateTime? createdAt = default(DateTime?), DateTime? modifiedAt = default(DateTime?), List<long?> listIds = default(List<long?>), List<long?> listUnsubscribed = default(List<long?>), Object attributes = default(Object), GetExtendedContactDetailsStatistics statistics = default(GetExtendedContactDetailsStatistics))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "emailBlacklisted" is required (not null)
            if (emailBlacklisted == null)
            {
                throw new InvalidDataException("emailBlacklisted is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.EmailBlacklisted = emailBlacklisted;
            }
            // to ensure "smsBlacklisted" is required (not null)
            if (smsBlacklisted == null)
            {
                throw new InvalidDataException("smsBlacklisted is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.SmsBlacklisted = smsBlacklisted;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            // to ensure "listIds" is required (not null)
            if (listIds == null)
            {
                throw new InvalidDataException("listIds is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.ListIds = listIds;
            }
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new InvalidDataException("attributes is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.Attributes = attributes;
            }
            // to ensure "statistics" is required (not null)
            if (statistics == null)
            {
                throw new InvalidDataException("statistics is a required property for GetExtendedContactDetails and cannot be null");
            }
            else
            {
                this.Statistics = statistics;
            }
            this.ListUnsubscribed = listUnsubscribed;
        }
        
        /// <summary>
        /// Email address of the contact for which you requested the details
        /// </summary>
        /// <value>Email address of the contact for which you requested the details</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// ID of the contact for which you requested the details
        /// </summary>
        /// <value>ID of the contact for which you requested the details</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Blacklist status for email campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted)
        /// </summary>
        /// <value>Blacklist status for email campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted)</value>
        [DataMember(Name="emailBlacklisted", EmitDefaultValue=false)]
        public bool? EmailBlacklisted { get; set; }

        /// <summary>
        /// Blacklist status for SMS campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted)
        /// </summary>
        /// <value>Blacklist status for SMS campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted)</value>
        [DataMember(Name="smsBlacklisted", EmitDefaultValue=false)]
        public bool? SmsBlacklisted { get; set; }

        /// <summary>
        /// Creation UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last modification UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Last modification UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets ListIds
        /// </summary>
        [DataMember(Name="listIds", EmitDefaultValue=false)]
        public List<long?> ListIds { get; set; }

        /// <summary>
        /// Gets or Sets ListUnsubscribed
        /// </summary>
        [DataMember(Name="listUnsubscribed", EmitDefaultValue=false)]
        public List<long?> ListUnsubscribed { get; set; }

        /// <summary>
        /// Set of attributes of the contact
        /// </summary>
        /// <value>Set of attributes of the contact</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public GetExtendedContactDetailsStatistics Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedContactDetails {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailBlacklisted: ").Append(EmailBlacklisted).Append("\n");
            sb.Append("  SmsBlacklisted: ").Append(SmsBlacklisted).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  ListUnsubscribed: ").Append(ListUnsubscribed).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(input as GetExtendedContactDetails);
        }

        /// <summary>
        /// Returns true if GetExtendedContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedContactDetails input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EmailBlacklisted == input.EmailBlacklisted ||
                    (this.EmailBlacklisted != null &&
                    this.EmailBlacklisted.Equals(input.EmailBlacklisted))
                ) && 
                (
                    this.SmsBlacklisted == input.SmsBlacklisted ||
                    (this.SmsBlacklisted != null &&
                    this.SmsBlacklisted.Equals(input.SmsBlacklisted))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.ListIds == input.ListIds ||
                    this.ListIds != null &&
                    this.ListIds.SequenceEqual(input.ListIds)
                ) && 
                (
                    this.ListUnsubscribed == input.ListUnsubscribed ||
                    this.ListUnsubscribed != null &&
                    this.ListUnsubscribed.SequenceEqual(input.ListUnsubscribed)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Statistics == input.Statistics ||
                    (this.Statistics != null &&
                    this.Statistics.Equals(input.Statistics))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EmailBlacklisted != null)
                    hashCode = hashCode * 59 + this.EmailBlacklisted.GetHashCode();
                if (this.SmsBlacklisted != null)
                    hashCode = hashCode * 59 + this.SmsBlacklisted.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.ListIds != null)
                    hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                if (this.ListUnsubscribed != null)
                    hashCode = hashCode * 59 + this.ListUnsubscribed.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
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
            yield break;
        }
    }

}
