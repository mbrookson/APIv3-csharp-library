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
    /// GetCampaignRecipients
    /// </summary>
    [DataContract]
    public partial class GetCampaignRecipients :  IEquatable<GetCampaignRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCampaignRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignRecipients" /> class.
        /// </summary>
        /// <param name="lists">lists (required).</param>
        /// <param name="exclusionLists">exclusionLists (required).</param>
        public GetCampaignRecipients(List<long?> lists = default(List<long?>), List<long?> exclusionLists = default(List<long?>))
        {
            // to ensure "lists" is required (not null)
            if (lists == null)
            {
                throw new InvalidDataException("lists is a required property for GetCampaignRecipients and cannot be null");
            }
            else
            {
                this.Lists = lists;
            }
            // to ensure "exclusionLists" is required (not null)
            if (exclusionLists == null)
            {
                throw new InvalidDataException("exclusionLists is a required property for GetCampaignRecipients and cannot be null");
            }
            else
            {
                this.ExclusionLists = exclusionLists;
            }
        }
        
        /// <summary>
        /// Gets or Sets Lists
        /// </summary>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public List<long?> Lists { get; set; }

        /// <summary>
        /// Gets or Sets ExclusionLists
        /// </summary>
        [DataMember(Name="exclusionLists", EmitDefaultValue=false)]
        public List<long?> ExclusionLists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCampaignRecipients {\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  ExclusionLists: ").Append(ExclusionLists).Append("\n");
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
            return this.Equals(input as GetCampaignRecipients);
        }

        /// <summary>
        /// Returns true if GetCampaignRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCampaignRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCampaignRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lists == input.Lists ||
                    this.Lists != null &&
                    this.Lists.SequenceEqual(input.Lists)
                ) && 
                (
                    this.ExclusionLists == input.ExclusionLists ||
                    this.ExclusionLists != null &&
                    this.ExclusionLists.SequenceEqual(input.ExclusionLists)
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
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.ExclusionLists != null)
                    hashCode = hashCode * 59 + this.ExclusionLists.GetHashCode();
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
