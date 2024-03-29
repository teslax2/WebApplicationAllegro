/* 
 * Allegro REST API
 *
 * https://developer.allegro.pl/about
 *
 * OpenAPI spec version: latest
 * 
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


namespace WebApplication1.ApiModel
{
    /// <summary>
    /// SellerRebateDto
    /// </summary>
    [DataContract]
        public partial class SellerRebateDto :  IEquatable<SellerRebateDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 0,
            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE = 1,
            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            [EnumMember(Value = "SUSPENDED")]
            SUSPENDED = 2        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerRebateDto" /> class.
        /// </summary>
        /// <param name="benefits">What kind of rebate will be given (required).</param>
        /// <param name="createdAt">when was this rebate created.</param>
        /// <param name="id">Rebate identifier (required).</param>
        /// <param name="offerCriteria">What offers will be included (required).</param>
        /// <param name="status">status (required).</param>
        public SellerRebateDto(List<Benefit> benefits = default(List<Benefit>), DateTime? createdAt = default(DateTime?), string id = default(string), List<SellerRebateOfferCriterion> offerCriteria = default(List<SellerRebateOfferCriterion>), StatusEnum status = default(StatusEnum))
        {
            // to ensure "benefits" is required (not null)
            if (benefits == null)
            {
                throw new InvalidDataException("benefits is a required property for SellerRebateDto and cannot be null");
            }
            else
            {
                this.Benefits = benefits;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SellerRebateDto and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "offerCriteria" is required (not null)
            if (offerCriteria == null)
            {
                throw new InvalidDataException("offerCriteria is a required property for SellerRebateDto and cannot be null");
            }
            else
            {
                this.OfferCriteria = offerCriteria;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SellerRebateDto and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.CreatedAt = createdAt;
        }
        
        /// <summary>
        /// What kind of rebate will be given
        /// </summary>
        /// <value>What kind of rebate will be given</value>
        [DataMember(Name="benefits", EmitDefaultValue=false)]
        public List<Benefit> Benefits { get; set; }

        /// <summary>
        /// when was this rebate created
        /// </summary>
        /// <value>when was this rebate created</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Rebate identifier
        /// </summary>
        /// <value>Rebate identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// What offers will be included
        /// </summary>
        /// <value>What offers will be included</value>
        [DataMember(Name="offerCriteria", EmitDefaultValue=false)]
        public List<SellerRebateOfferCriterion> OfferCriteria { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SellerRebateDto {\n");
            sb.Append("  Benefits: ").Append(Benefits).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OfferCriteria: ").Append(OfferCriteria).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SellerRebateDto);
        }

        /// <summary>
        /// Returns true if SellerRebateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerRebateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerRebateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Benefits == input.Benefits ||
                    this.Benefits != null &&
                    input.Benefits != null &&
                    this.Benefits.SequenceEqual(input.Benefits)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OfferCriteria == input.OfferCriteria ||
                    this.OfferCriteria != null &&
                    input.OfferCriteria != null &&
                    this.OfferCriteria.SequenceEqual(input.OfferCriteria)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Benefits != null)
                    hashCode = hashCode * 59 + this.Benefits.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OfferCriteria != null)
                    hashCode = hashCode * 59 + this.OfferCriteria.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
