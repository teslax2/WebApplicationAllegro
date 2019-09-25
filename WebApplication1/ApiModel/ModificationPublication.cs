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
    /// Allows you to change duration of offers. You can include only property in a request \&quot;duration\&quot; or \&quot;durationUnlimited\&quot;.
    /// </summary>
    [DataContract]
        public partial class ModificationPublication :  IEquatable<ModificationPublication>, IValidatableObject
    {
        /// <summary>
        /// Offer duration time provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Offer duration time provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DurationEnum
        {
            /// <summary>
            /// Enum PT72H for value: PT72H
            /// </summary>
            [EnumMember(Value = "PT72H")]
            PT72H = 0,
            /// <summary>
            /// Enum PT120H for value: PT120H
            /// </summary>
            [EnumMember(Value = "PT120H")]
            PT120H = 1,
            /// <summary>
            /// Enum PT168H for value: PT168H
            /// </summary>
            [EnumMember(Value = "PT168H")]
            PT168H = 2,
            /// <summary>
            /// Enum PT240H for value: PT240H
            /// </summary>
            [EnumMember(Value = "PT240H")]
            PT240H = 3,
            /// <summary>
            /// Enum PT480H for value: PT480H
            /// </summary>
            [EnumMember(Value = "PT480H")]
            PT480H = 4,
            /// <summary>
            /// Enum PT720H for value: PT720H
            /// </summary>
            [EnumMember(Value = "PT720H")]
            PT720H = 5,
            /// <summary>
            /// Enum P3D for value: P3D
            /// </summary>
            [EnumMember(Value = "P3D")]
            P3D = 6,
            /// <summary>
            /// Enum P5D for value: P5D
            /// </summary>
            [EnumMember(Value = "P5D")]
            P5D = 7,
            /// <summary>
            /// Enum P7D for value: P7D
            /// </summary>
            [EnumMember(Value = "P7D")]
            P7D = 8,
            /// <summary>
            /// Enum P10D for value: P10D
            /// </summary>
            [EnumMember(Value = "P10D")]
            P10D = 9,
            /// <summary>
            /// Enum P20D for value: P20D
            /// </summary>
            [EnumMember(Value = "P20D")]
            P20D = 10,
            /// <summary>
            /// Enum P30D for value: P30D
            /// </summary>
            [EnumMember(Value = "P30D")]
            P30D = 11        }
        /// <summary>
        /// Offer duration time provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Offer duration time provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public DurationEnum? Duration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationPublication" /> class.
        /// </summary>
        /// <param name="duration">Offer duration time provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format..</param>
        /// <param name="durationUnlimited">Unlimited duration time..</param>
        public ModificationPublication(DurationEnum? duration = default(DurationEnum?), bool? durationUnlimited = default(bool?))
        {
            this.Duration = duration;
            this.DurationUnlimited = durationUnlimited;
        }
        

        /// <summary>
        /// Unlimited duration time.
        /// </summary>
        /// <value>Unlimited duration time.</value>
        [DataMember(Name="durationUnlimited", EmitDefaultValue=false)]
        public bool? DurationUnlimited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModificationPublication {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationUnlimited: ").Append(DurationUnlimited).Append("\n");
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
            return this.Equals(input as ModificationPublication);
        }

        /// <summary>
        /// Returns true if ModificationPublication instances are equal
        /// </summary>
        /// <param name="input">Instance of ModificationPublication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModificationPublication input)
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
                    this.DurationUnlimited == input.DurationUnlimited ||
                    (this.DurationUnlimited != null &&
                    this.DurationUnlimited.Equals(input.DurationUnlimited))
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
                if (this.DurationUnlimited != null)
                    hashCode = hashCode * 59 + this.DurationUnlimited.GetHashCode();
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