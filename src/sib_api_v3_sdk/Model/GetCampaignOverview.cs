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
    /// GetCampaignOverview
    /// </summary>
    [DataContract]
    public partial class GetCampaignOverview :  IEquatable<GetCampaignOverview>, IValidatableObject
    {
        /// <summary>
        /// Type of campaign
        /// </summary>
        /// <value>Type of campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Classic for value: classic
            /// </summary>
            [EnumMember(Value = "classic")]
            Classic = 1,
            
            /// <summary>
            /// Enum Trigger for value: trigger
            /// </summary>
            [EnumMember(Value = "trigger")]
            Trigger = 2
        }

        /// <summary>
        /// Type of campaign
        /// </summary>
        /// <value>Type of campaign</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Status of the campaign
        /// </summary>
        /// <value>Status of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 2,
            
            /// <summary>
            /// Enum Archive for value: archive
            /// </summary>
            [EnumMember(Value = "archive")]
            Archive = 3,
            
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 4,
            
            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 5,
            
            /// <summary>
            /// Enum Inprocess for value: in_process
            /// </summary>
            [EnumMember(Value = "in_process")]
            Inprocess = 6
        }

        /// <summary>
        /// Status of the campaign
        /// </summary>
        /// <value>Status of the campaign</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignOverview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCampaignOverview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignOverview" /> class.
        /// </summary>
        /// <param name="id">ID of the campaign (required).</param>
        /// <param name="name">Name of the campaign (required).</param>
        /// <param name="subject">Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;.</param>
        /// <param name="type">Type of campaign (required).</param>
        /// <param name="status">Status of the campaign (required).</param>
        /// <param name="scheduledAt">UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ).</param>
        /// <param name="abTesting">Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled..</param>
        /// <param name="subjectA">Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="subjectB">Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="splitRule">The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="winnerCriteria">Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="winnerDelay">The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="sendAtBestTime">It is true if you have chosen to send your campaign at best time, otherwise it is false.</param>
        public GetCampaignOverview(long? id = default(long?), string name = default(string), string subject = default(string), TypeEnum type = default(TypeEnum), StatusEnum status = default(StatusEnum), DateTime? scheduledAt = default(DateTime?), bool? abTesting = default(bool?), string subjectA = default(string), string subjectB = default(string), int? splitRule = default(int?), string winnerCriteria = default(string), int? winnerDelay = default(int?), bool? sendAtBestTime = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetCampaignOverview and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCampaignOverview and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GetCampaignOverview and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetCampaignOverview and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Subject = subject;
            this.ScheduledAt = scheduledAt;
            this.AbTesting = abTesting;
            this.SubjectA = subjectA;
            this.SubjectB = subjectB;
            this.SplitRule = splitRule;
            this.WinnerCriteria = winnerCriteria;
            this.WinnerDelay = winnerDelay;
            this.SendAtBestTime = sendAtBestTime;
        }
        
        /// <summary>
        /// ID of the campaign
        /// </summary>
        /// <value>ID of the campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the campaign
        /// </summary>
        /// <value>Name of the campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;
        /// </summary>
        /// <value>Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled.
        /// </summary>
        /// <value>Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled.</value>
        [DataMember(Name="abTesting", EmitDefaultValue=false)]
        public bool? AbTesting { get; set; }

        /// <summary>
        /// Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="subjectA", EmitDefaultValue=false)]
        public string SubjectA { get; set; }

        /// <summary>
        /// Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="subjectB", EmitDefaultValue=false)]
        public string SubjectB { get; set; }

        /// <summary>
        /// The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="splitRule", EmitDefaultValue=false)]
        public int? SplitRule { get; set; }

        /// <summary>
        /// Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="winnerCriteria", EmitDefaultValue=false)]
        public string WinnerCriteria { get; set; }

        /// <summary>
        /// The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="winnerDelay", EmitDefaultValue=false)]
        public int? WinnerDelay { get; set; }

        /// <summary>
        /// It is true if you have chosen to send your campaign at best time, otherwise it is false
        /// </summary>
        /// <value>It is true if you have chosen to send your campaign at best time, otherwise it is false</value>
        [DataMember(Name="sendAtBestTime", EmitDefaultValue=false)]
        public bool? SendAtBestTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCampaignOverview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  AbTesting: ").Append(AbTesting).Append("\n");
            sb.Append("  SubjectA: ").Append(SubjectA).Append("\n");
            sb.Append("  SubjectB: ").Append(SubjectB).Append("\n");
            sb.Append("  SplitRule: ").Append(SplitRule).Append("\n");
            sb.Append("  WinnerCriteria: ").Append(WinnerCriteria).Append("\n");
            sb.Append("  WinnerDelay: ").Append(WinnerDelay).Append("\n");
            sb.Append("  SendAtBestTime: ").Append(SendAtBestTime).Append("\n");
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
            return this.Equals(input as GetCampaignOverview);
        }

        /// <summary>
        /// Returns true if GetCampaignOverview instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCampaignOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCampaignOverview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.AbTesting == input.AbTesting ||
                    (this.AbTesting != null &&
                    this.AbTesting.Equals(input.AbTesting))
                ) && 
                (
                    this.SubjectA == input.SubjectA ||
                    (this.SubjectA != null &&
                    this.SubjectA.Equals(input.SubjectA))
                ) && 
                (
                    this.SubjectB == input.SubjectB ||
                    (this.SubjectB != null &&
                    this.SubjectB.Equals(input.SubjectB))
                ) && 
                (
                    this.SplitRule == input.SplitRule ||
                    (this.SplitRule != null &&
                    this.SplitRule.Equals(input.SplitRule))
                ) && 
                (
                    this.WinnerCriteria == input.WinnerCriteria ||
                    (this.WinnerCriteria != null &&
                    this.WinnerCriteria.Equals(input.WinnerCriteria))
                ) && 
                (
                    this.WinnerDelay == input.WinnerDelay ||
                    (this.WinnerDelay != null &&
                    this.WinnerDelay.Equals(input.WinnerDelay))
                ) && 
                (
                    this.SendAtBestTime == input.SendAtBestTime ||
                    (this.SendAtBestTime != null &&
                    this.SendAtBestTime.Equals(input.SendAtBestTime))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.AbTesting != null)
                    hashCode = hashCode * 59 + this.AbTesting.GetHashCode();
                if (this.SubjectA != null)
                    hashCode = hashCode * 59 + this.SubjectA.GetHashCode();
                if (this.SubjectB != null)
                    hashCode = hashCode * 59 + this.SubjectB.GetHashCode();
                if (this.SplitRule != null)
                    hashCode = hashCode * 59 + this.SplitRule.GetHashCode();
                if (this.WinnerCriteria != null)
                    hashCode = hashCode * 59 + this.WinnerCriteria.GetHashCode();
                if (this.WinnerDelay != null)
                    hashCode = hashCode * 59 + this.WinnerDelay.GetHashCode();
                if (this.SendAtBestTime != null)
                    hashCode = hashCode * 59 + this.SendAtBestTime.GetHashCode();
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