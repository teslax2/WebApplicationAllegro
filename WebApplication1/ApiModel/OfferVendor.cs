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
    /// This section is available only for the charity offers.
    /// </summary>
    [DataContract]
        public partial class OfferVendor :  IEquatable<OfferVendor>, IValidatableObject
    {
        /// <summary>
        /// Identifier of the external service.
        /// </summary>
        /// <value>Identifier of the external service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum IdEnum
        {
            /// <summary>
            /// Enum ALLEGRO for value: CHARYTATYWNI_ALLEGRO
            /// </summary>
            [EnumMember(Value = "CHARYTATYWNI_ALLEGRO")]
            ALLEGRO = 0        }
        /// <summary>
        /// Identifier of the external service.
        /// </summary>
        /// <value>Identifier of the external service.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public IdEnum? Id { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferVendor" /> class.
        /// </summary>
        /// <param name="id">Identifier of the external service..</param>
        /// <param name="url">URL to the web page of the offer..</param>
        public OfferVendor(IdEnum? id = default(IdEnum?), string url = default(string))
        {
            this.Id = id;
            this.Url = url;
        }
        

        /// <summary>
        /// URL to the web page of the offer.
        /// </summary>
        /// <value>URL to the web page of the offer.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferVendor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as OfferVendor);
        }

        /// <summary>
        /// Returns true if OfferVendor instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferVendor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferVendor input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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