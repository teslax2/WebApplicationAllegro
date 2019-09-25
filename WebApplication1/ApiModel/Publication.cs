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
    /// Publication
    /// </summary>
    [DataContract]
        public partial class Publication :  IEquatable<Publication>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public OfferStatus? Status { get; set; }
        /// <summary>
        /// Indicates the reason for ending the offer:  - &#x60;USER&#x60; - offer ended by the seller.  - &#x60;ADMIN&#x60; - offer ended by an admin.  - &#x60;EXPIRATION&#x60; - offer ended because all available items had been sold out or offer duration had expired (valid for    offers with specified duration).  - &#x60;ERROR&#x60; - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.
        /// </summary>
        /// <value>Indicates the reason for ending the offer:  - &#x60;USER&#x60; - offer ended by the seller.  - &#x60;ADMIN&#x60; - offer ended by an admin.  - &#x60;EXPIRATION&#x60; - offer ended because all available items had been sold out or offer duration had expired (valid for    offers with specified duration).  - &#x60;ERROR&#x60; - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EndedByEnum
        {
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            [EnumMember(Value = "USER")]
            USER = 0,
            /// <summary>
            /// Enum ADMIN for value: ADMIN
            /// </summary>
            [EnumMember(Value = "ADMIN")]
            ADMIN = 1,
            /// <summary>
            /// Enum EXPIRATION for value: EXPIRATION
            /// </summary>
            [EnumMember(Value = "EXPIRATION")]
            EXPIRATION = 2,
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3        }
        /// <summary>
        /// Indicates the reason for ending the offer:  - &#x60;USER&#x60; - offer ended by the seller.  - &#x60;ADMIN&#x60; - offer ended by an admin.  - &#x60;EXPIRATION&#x60; - offer ended because all available items had been sold out or offer duration had expired (valid for    offers with specified duration).  - &#x60;ERROR&#x60; - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.
        /// </summary>
        /// <value>Indicates the reason for ending the offer:  - &#x60;USER&#x60; - offer ended by the seller.  - &#x60;ADMIN&#x60; - offer ended by an admin.  - &#x60;EXPIRATION&#x60; - offer ended because all available items had been sold out or offer duration had expired (valid for    offers with specified duration).  - &#x60;ERROR&#x60; - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed.</value>
        [DataMember(Name="endedBy", EmitDefaultValue=false)]
        public EndedByEnum? EndedBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Publication" /> class.
        /// </summary>
        /// <param name="duration">Publication duration, ISO 8601 duration format.</param>
        /// <param name="endingAt">Publication ending date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified.</param>
        /// <param name="startingAt">Publication starting date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified.</param>
        /// <param name="status">status.</param>
        /// <param name="endedBy">Indicates the reason for ending the offer:  - &#x60;USER&#x60; - offer ended by the seller.  - &#x60;ADMIN&#x60; - offer ended by an admin.  - &#x60;EXPIRATION&#x60; - offer ended because all available items had been sold out or offer duration had expired (valid for    offers with specified duration).  - &#x60;ERROR&#x60; - offer ended due to internal problem with offer publication. The publication command responded with    success status, but further processing failed..</param>
        /// <param name="republish">Whether to republish an offer after ending. Automatically republish offers or auctions:&lt;/br&gt; - &#x60;BUY_NOW&#x60; offer type are republished with initial stock, regardless of how many items you have sold.&lt;/br&gt; - &#x60;AUCTION&#x60; offer type are republished only if they were not concluded with purchase.&lt;/br&gt; - &#x60;ADVERTISEMENT&#x60; offer type cannot be republished..</param>
        public Publication(string duration = default(string), DateTime? endingAt = default(DateTime?), DateTime? startingAt = default(DateTime?), OfferStatus? status = default(OfferStatus?), EndedByEnum? endedBy = default(EndedByEnum?), bool? republish = default(bool?))
        {
            this.Duration = duration;
            this.EndingAt = endingAt;
            this.StartingAt = startingAt;
            this.Status = status;
            this.EndedBy = endedBy;
            this.Republish = republish;
        }
        
        /// <summary>
        /// Publication duration, ISO 8601 duration format
        /// </summary>
        /// <value>Publication duration, ISO 8601 duration format</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Publication ending date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified
        /// </summary>
        /// <value>Publication ending date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified</value>
        [DataMember(Name="endingAt", EmitDefaultValue=false)]
        public DateTime? EndingAt { get; set; }

        /// <summary>
        /// Publication starting date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified
        /// </summary>
        /// <value>Publication starting date: Format (ISO 8601) - yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ. Cannot be modified</value>
        [DataMember(Name="startingAt", EmitDefaultValue=false)]
        public DateTime? StartingAt { get; set; }



        /// <summary>
        /// Whether to republish an offer after ending. Automatically republish offers or auctions:&lt;/br&gt; - &#x60;BUY_NOW&#x60; offer type are republished with initial stock, regardless of how many items you have sold.&lt;/br&gt; - &#x60;AUCTION&#x60; offer type are republished only if they were not concluded with purchase.&lt;/br&gt; - &#x60;ADVERTISEMENT&#x60; offer type cannot be republished.
        /// </summary>
        /// <value>Whether to republish an offer after ending. Automatically republish offers or auctions:&lt;/br&gt; - &#x60;BUY_NOW&#x60; offer type are republished with initial stock, regardless of how many items you have sold.&lt;/br&gt; - &#x60;AUCTION&#x60; offer type are republished only if they were not concluded with purchase.&lt;/br&gt; - &#x60;ADVERTISEMENT&#x60; offer type cannot be republished.</value>
        [DataMember(Name="republish", EmitDefaultValue=false)]
        public bool? Republish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Publication {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  EndingAt: ").Append(EndingAt).Append("\n");
            sb.Append("  StartingAt: ").Append(StartingAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EndedBy: ").Append(EndedBy).Append("\n");
            sb.Append("  Republish: ").Append(Republish).Append("\n");
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
            return this.Equals(input as Publication);
        }

        /// <summary>
        /// Returns true if Publication instances are equal
        /// </summary>
        /// <param name="input">Instance of Publication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Publication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.EndingAt == input.EndingAt ||
                    (this.EndingAt != null &&
                    this.EndingAt.Equals(input.EndingAt))
                ) && 
                (
                    this.StartingAt == input.StartingAt ||
                    (this.StartingAt != null &&
                    this.StartingAt.Equals(input.StartingAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EndedBy == input.EndedBy ||
                    (this.EndedBy != null &&
                    this.EndedBy.Equals(input.EndedBy))
                ) && 
                (
                    this.Republish == input.Republish ||
                    (this.Republish != null &&
                    this.Republish.Equals(input.Republish))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.EndingAt != null)
                    hashCode = hashCode * 59 + this.EndingAt.GetHashCode();
                if (this.StartingAt != null)
                    hashCode = hashCode * 59 + this.StartingAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EndedBy != null)
                    hashCode = hashCode * 59 + this.EndedBy.GetHashCode();
                if (this.Republish != null)
                    hashCode = hashCode * 59 + this.Republish.GetHashCode();
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