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
    /// Rates
    /// </summary>
    [DataContract]
        public partial class Rates :  IEquatable<Rates>, IValidatableObject
    {
        /// <summary>
        /// Delivery rate value
        /// </summary>
        /// <value>Delivery rate value</value>
                public enum DeliveryEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5        }
        /// <summary>
        /// Delivery rate value
        /// </summary>
        /// <value>Delivery rate value</value>
        [DataMember(Name="delivery", EmitDefaultValue=false)]
        public DeliveryEnum? Delivery { get; set; }
        /// <summary>
        /// Delivery cost rate value
        /// </summary>
        /// <value>Delivery cost rate value</value>
                public enum DeliveryCostEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5        }
        /// <summary>
        /// Delivery cost rate value
        /// </summary>
        /// <value>Delivery cost rate value</value>
        [DataMember(Name="deliveryCost", EmitDefaultValue=false)]
        public DeliveryCostEnum? DeliveryCost { get; set; }
        /// <summary>
        /// Description rate value
        /// </summary>
        /// <value>Description rate value</value>
                public enum DescriptionEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5        }
        /// <summary>
        /// Description rate value
        /// </summary>
        /// <value>Description rate value</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DescriptionEnum? Description { get; set; }
        /// <summary>
        /// Service rate value
        /// </summary>
        /// <value>Service rate value</value>
                public enum ServiceEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5        }
        /// <summary>
        /// Service rate value
        /// </summary>
        /// <value>Service rate value</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public ServiceEnum? Service { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rates" /> class.
        /// </summary>
        /// <param name="delivery">Delivery rate value.</param>
        /// <param name="deliveryCost">Delivery cost rate value.</param>
        /// <param name="description">Description rate value.</param>
        /// <param name="service">Service rate value.</param>
        public Rates(DeliveryEnum? delivery = default(DeliveryEnum?), DeliveryCostEnum? deliveryCost = default(DeliveryCostEnum?), DescriptionEnum? description = default(DescriptionEnum?), ServiceEnum? service = default(ServiceEnum?))
        {
            this.Delivery = delivery;
            this.DeliveryCost = deliveryCost;
            this.Description = description;
            this.Service = service;
        }
        




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rates {\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
            sb.Append("  DeliveryCost: ").Append(DeliveryCost).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
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
            return this.Equals(input as Rates);
        }

        /// <summary>
        /// Returns true if Rates instances are equal
        /// </summary>
        /// <param name="input">Instance of Rates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Delivery == input.Delivery ||
                    (this.Delivery != null &&
                    this.Delivery.Equals(input.Delivery))
                ) && 
                (
                    this.DeliveryCost == input.DeliveryCost ||
                    (this.DeliveryCost != null &&
                    this.DeliveryCost.Equals(input.DeliveryCost))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.Delivery != null)
                    hashCode = hashCode * 59 + this.Delivery.GetHashCode();
                if (this.DeliveryCost != null)
                    hashCode = hashCode * 59 + this.DeliveryCost.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
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