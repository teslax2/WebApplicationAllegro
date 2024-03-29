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
    /// CategoryProductParameter
    /// </summary>
    [DataContract]
        public partial class CategoryProductParameter :  IEquatable<CategoryProductParameter>, IValidatableObject
    {
        /// <summary>
        /// The type of the product parameter. Other fields in this structure may appear based on the type of the parameter.
        /// </summary>
        /// <value>The type of the product parameter. Other fields in this structure may appear based on the type of the parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 0,
            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 1,
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 2,
            /// <summary>
            /// Enum Dictionary for value: dictionary
            /// </summary>
            [EnumMember(Value = "dictionary")]
            Dictionary = 3        }
        /// <summary>
        /// The type of the product parameter. Other fields in this structure may appear based on the type of the parameter.
        /// </summary>
        /// <value>The type of the product parameter. Other fields in this structure may appear based on the type of the parameter.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryProductParameter" /> class.
        /// </summary>
        /// <param name="id">The ID of the parameter..</param>
        /// <param name="name">The name of the parameter in Polish..</param>
        /// <param name="type">The type of the product parameter. Other fields in this structure may appear based on the type of the parameter. (required).</param>
        /// <param name="required">Indicates whether the value of this parameter must be set in a product. Product without required parameters set cannot be created..</param>
        /// <param name="unit">The unit in which values of the parameter are used. May be &#x60;null&#x60;..</param>
        public CategoryProductParameter(string id = default(string), string name = default(string), TypeEnum type = default(TypeEnum), bool? required = default(bool?), string unit = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CategoryProductParameter and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Id = id;
            this.Name = name;
            this.Required = required;
            this.Unit = unit;
        }
        
        /// <summary>
        /// The ID of the parameter.
        /// </summary>
        /// <value>The ID of the parameter.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the parameter in Polish.
        /// </summary>
        /// <value>The name of the parameter in Polish.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Indicates whether the value of this parameter must be set in a product. Product without required parameters set cannot be created.
        /// </summary>
        /// <value>Indicates whether the value of this parameter must be set in a product. Product without required parameters set cannot be created.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// The unit in which values of the parameter are used. May be &#x60;null&#x60;.
        /// </summary>
        /// <value>The unit in which values of the parameter are used. May be &#x60;null&#x60;.</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryProductParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as CategoryProductParameter);
        }

        /// <summary>
        /// Returns true if CategoryProductParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryProductParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryProductParameter input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
