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
    /// PublicTableDto
    /// </summary>
    [DataContract]
        public partial class PublicTableDto :  IEquatable<PublicTableDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OrientationEnum
        {
            /// <summary>
            /// Enum HORIZONTAL for value: HORIZONTAL
            /// </summary>
            [EnumMember(Value = "HORIZONTAL")]
            HORIZONTAL = 0,
            /// <summary>
            /// Enum VERTICAL for value: VERTICAL
            /// </summary>
            [EnumMember(Value = "VERTICAL")]
            VERTICAL = 1        }
        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OrientationEnum Orientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicTableDto" /> class.
        /// </summary>
        /// <param name="headers">headers (required).</param>
        /// <param name="id">id.</param>
        /// <param name="image">image.</param>
        /// <param name="name">name (required).</param>
        /// <param name="orientation">orientation (required).</param>
        /// <param name="values">values (required).</param>
        public PublicTableDto(List<Header> headers = default(List<Header>), string id = default(string), PublicTableImageDto image = default(PublicTableImageDto), string name = default(string), OrientationEnum orientation = default(OrientationEnum), List<Cells> values = default(List<Cells>))
        {
            // to ensure "headers" is required (not null)
            if (headers == null)
            {
                throw new InvalidDataException("headers is a required property for PublicTableDto and cannot be null");
            }
            else
            {
                this.Headers = headers;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PublicTableDto and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "orientation" is required (not null)
            if (orientation == null)
            {
                throw new InvalidDataException("orientation is a required property for PublicTableDto and cannot be null");
            }
            else
            {
                this.Orientation = orientation;
            }
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for PublicTableDto and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            this.Id = id;
            this.Image = image;
        }
        
        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<Header> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public PublicTableImageDto Image { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<Cells> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicTableDto {\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as PublicTableDto);
        }

        /// <summary>
        /// Returns true if PublicTableDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicTableDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicTableDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
